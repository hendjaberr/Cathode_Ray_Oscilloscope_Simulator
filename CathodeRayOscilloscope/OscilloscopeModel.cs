using System.Collections.Generic;

namespace CathodeRayOscilloscope
{
    public class OscilloscopeModel
    {
        public double VoltagePerDivision { get; set; } = 1.0;
        public double TimePerDivision { get; set; } = 1.0;
        public double Frequency { get; set; } = 10.0;
        public string WaveType { get; set; } = "Sine";
        public double VerticalPosition { get; set; } = 0.0;
        public double HorizontalPosition { get; set; } = 0.0;
        public double TriggerLevel { get; set; } = 0.0;
        public string TriggerEdge { get; set; } = "Rising";
        public double Amplitude { get; set; } = 1.0; // Amplitude control
        public List<double> SignalData { get; set; } = new List<double>();
        public List<List<double>> PreviousSignals { get; set; } = new List<List<double>>();
        /// Measurement cursors
        public double CursorTime1 { get; set; } // ms
        public double CursorTime2 { get; set; } // ms
        public double CursorVoltage1 { get; set; } // V
        public double CursorVoltage2 { get; set; } // V
        public double DeltaTime => System.Math.Abs(CursorTime2 - CursorTime1);
        public double DeltaVoltage => System.Math.Abs(CursorVoltage2 - CursorVoltage1);
        /// Frequency and voltage readouts
        public double MeasuredFrequency { get; set; }
        public double PeakToPeakVoltage { get; set; }
        /// FFT display
        public bool ShowFFT { get; set; }
        public List<double> FrequencySpectrum { get; set; } = new List<double>();
        public double SamplingRate { get; set; } = 1000.0; // Hz
    }
}