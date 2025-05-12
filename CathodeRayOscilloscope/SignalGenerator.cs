using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;

namespace CathodeRayOscilloscope
{
    public static class SignalGenerator
    {
        public static List<double> GenerateSignal(OscilloscopeModel model, double timeOffset)
        {
            if (model == null)
                return new List<double>();
            var signal = new List<double>();
            int samples = 1000;
            double period = model.Frequency > 0 ? 1.0 / model.Frequency : 1.0; 
            double timeStep = period / samples;
            double triggerTime = 0;
            /// Find trigger point
            for (int i = 0; i < samples; i++)
            {
                double t = timeOffset + i * timeStep;
                double currentValue = CalculateWaveValue(model.WaveType, model.Frequency, t, model.Amplitude);
                double prevValue = CalculateWaveValue(model.WaveType, model.Frequency, t - timeStep, model.Amplitude);
                bool triggered = model.TriggerEdge == "Rising"
                    ? (i > 0 && currentValue >= model.TriggerLevel && prevValue < model.TriggerLevel)
                    : (i > 0 && currentValue <= model.TriggerLevel && prevValue > model.TriggerLevel);
                if (triggered)
                {
                    triggerTime = t;
                    break;
                }
            }
            /// Generate signal
            for (int i = 0; i < samples; i++)
            {
                double t = triggerTime + i * timeStep;
                double value = CalculateWaveValue(model.WaveType, model.Frequency, t, model.Amplitude);
                signal.Add(value);
            }
            /// Update readouts
            model.MeasuredFrequency = model.Frequency;
            model.PeakToPeakVoltage = signal.Any() ? signal.Max() - signal.Min() : 0.0;
            /// Compute FFT if needed
            if (model.ShowFFT)
            {
                var signalArray = signal.ToArray();
                var complex = signalArray.Select(x => new MathNet.Numerics.Complex32((float)x, 0)).ToArray();
                Fourier.Forward(complex, FourierOptions.Default);
                model.FrequencySpectrum = complex.Take(complex.Length / 2).Select(c => (double)c.Magnitude).ToList();
                model.SamplingRate = samples / period; // Hz
            }
            else
            {
                model.FrequencySpectrum.Clear();
            }
            return signal;
        }

        private static double CalculateWaveValue(string waveType, double frequency, double t, double amplitude)
        {
            double value;
            switch (waveType)
            {
                case "Sine":
                    value = Math.Sin(2 * Math.PI * frequency * t);
                    break;
                case "Square":
                    value = Math.Sign(Math.Sin(2 * Math.PI * frequency * t));
                    break;
                case "Triangle":
                    value = 2 * Math.Abs(2 * (t * frequency - Math.Floor(t * frequency + 0.5))) - 1;
                    break;
                case "Sawtooth":
                    value = 2 * (t * frequency - Math.Floor(t * frequency)) - 1;
                    break;
                default:
                    value = 0.0;
                    break;
            }
            return value * amplitude;
        }
    }
}