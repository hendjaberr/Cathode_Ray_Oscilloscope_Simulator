using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace CathodeRayOscilloscope
{
    public class WaveformRenderer
    {
        private readonly PictureBox _pictureBox;
        private readonly Pen _gridPenMajor = new Pen(Color.FromArgb(80, 100, 100, 100), 1); 
        private readonly Pen _gridPenMinor = new Pen(Color.FromArgb(40, 100, 100, 100), 1); 
        private readonly Pen _waveformPen = new Pen(Color.FromArgb(0, 255, 0), 2); 
        private readonly Pen _waveformGlowPen = new Pen(Color.FromArgb(50, 0, 255, 0), 4); 
        private readonly Pen _persistencePen = new Pen(Color.FromArgb(50, 0, 255, 0), 1); 
        private readonly Pen _cursorPen = new Pen(Color.Yellow, 1) { DashStyle = DashStyle.Dash };
        private readonly Pen _fftPen = new Pen(Color.FromArgb(0, 255, 0), 2); 
        private readonly Brush _fftBrush = new SolidBrush(Color.FromArgb(100, 0, 255, 0)); 

        public WaveformRenderer(PictureBox pictureBox)
        {
            _pictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox));
            _pictureBox.BackColor = Color.Black; 
        }

        public void Render(OscilloscopeModel model)
        {
            if (model == null || _pictureBox.Width <= 0 || _pictureBox.Height <= 0)
                return;

            using (var bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height))
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(_pictureBox.BackColor);
                float width = _pictureBox.Width;
                float height = _pictureBox.Height;
                float centerY = height / 2;
                float waveformPixelsPerVolt = height / (float)(model.VoltagePerDivision * 10);
                float waveformPixelsPerMs = width / (float)(model.TimePerDivision * 10);
                DrawGraticule(graphics, width, height, waveformPixelsPerVolt, waveformPixelsPerMs);
                if (model.ShowFFT)
                {
                    DrawFFT(graphics, model, width, height);
                }
                else
                {
                    if (model.PreviousSignals != null)
                    {
                        for (int i = 0; i < model.PreviousSignals.Count; i++)
                        {
                            int alpha = (int)(50 * (1.0 - (double)i / model.PreviousSignals.Count));
                            using (var pen = new Pen(Color.FromArgb(alpha, 0, 255, 0), 1))
                            {
                                DrawWaveform(graphics, model, model.PreviousSignals[i], width, height, centerY,
                                    waveformPixelsPerVolt, waveformPixelsPerMs, pen);
                            }
                        }
                    }
                    if (model.SignalData != null && model.SignalData.Any())
                    {
                        DrawWaveform(graphics, model, model.SignalData, width, height, centerY,
                            waveformPixelsPerVolt, waveformPixelsPerMs, _waveformGlowPen);
                        DrawWaveform(graphics, model, model.SignalData, width, height, centerY,
                            waveformPixelsPerVolt, waveformPixelsPerMs, _waveformPen);
                    }
                }
                DrawCursors(graphics, model, width, height, centerY, waveformPixelsPerVolt, waveformPixelsPerMs);
                if (_pictureBox.Image != null)
                    _pictureBox.Image.Dispose();
                _pictureBox.Image = (Bitmap)bitmap.Clone();
            }
        }

        private void DrawGraticule(Graphics graphics, float width, float height, float pixelsPerVolt, float pixelsPerMs)
        {
            int majorDivisionsX = 10;
            int majorDivisionsY = 8;
            float divWidth = width / majorDivisionsX;
            float divHeight = height / majorDivisionsY;
            for (int i = 0; i <= majorDivisionsX; i++)
            {
                float x = i * divWidth;
                graphics.DrawLine(_gridPenMajor, x, 0, x, height);
            }
            for (int i = 0; i <= majorDivisionsY; i++)
            {
                float y = i * divHeight;
                graphics.DrawLine(_gridPenMajor, 0, y, width, y);
            }
            int minorDivisions = 5;
            float minorDivWidth = divWidth / minorDivisions;
            float minorDivHeight = divHeight / minorDivisions;
            for (int i = 0; i <= majorDivisionsX * minorDivisions; i++)
            {
                float x = i * minorDivWidth;
                graphics.DrawLine(_gridPenMinor, x, 0, x, height);
            }
            for (int i = 0; i <= majorDivisionsY * minorDivisions; i++)
            {
                float y = i * minorDivHeight;
                graphics.DrawLine(_gridPenMinor, 0, y, width, y);
            }
        }

        private void DrawWaveform(Graphics graphics, OscilloscopeModel model, List<double> signal,
            float width, float height, float centerY, float pixelsPerVolt, float pixelsPerMs, Pen pen)
        {
            if (signal == null || !signal.Any())
                return;
            var points = new PointF[signal.Count];
            for (int i = 0; i < signal.Count; i++)
            {
                float x = i * (width / (signal.Count - 1)) + (float)model.HorizontalPosition * pixelsPerMs;
                float y = centerY - ((float)signal[i] + (float)model.VerticalPosition) * pixelsPerVolt;
                points[i] = new PointF(x, y);
            }
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Y = Math.Max(0, Math.Min(height, points[i].Y));
                points[i].X = Math.Max(0, Math.Min(width, points[i].X));
            }
            graphics.DrawLines(pen, points);
        }

        private void DrawFFT(Graphics graphics, OscilloscopeModel model, float width, float height)
        {
            if (model.FrequencySpectrum == null || !model.FrequencySpectrum.Any())
                return;
            float barWidth = width / model.FrequencySpectrum.Count;
            float maxAmplitude = (float)model.FrequencySpectrum.Max();
            if (maxAmplitude == 0)
                maxAmplitude = 1; 
            for (int i = 0; i < model.FrequencySpectrum.Count; i++)
            {
                float x = i * barWidth;
                float barHeight = (float)(model.FrequencySpectrum[i] / maxAmplitude) * (height * 0.8f);
                float y = height - barHeight;
                graphics.FillRectangle(_fftBrush, x, y, barWidth, barHeight);
                graphics.DrawRectangle(_fftPen, x, y, barWidth, barHeight);
            }
            using (var font = new Font("Arial", 8))
            using (var brush = new SolidBrush(Color.FromArgb(0, 255, 0)))
            {
                float maxFreq = (float)(model.SamplingRate / 2);
                for (int i = 0; i <= 5; i++)
                {
                    float x = i * (width / 5);
                    float freq = i * (maxFreq / 5);
                    graphics.DrawString($"{freq:F0} Hz", font, brush, x, height - 20);
                }
            }
        }

        private void DrawCursors(Graphics graphics, OscilloscopeModel model, float width, float height,
            float centerY, float pixelsPerVolt, float pixelsPerMs)
        {
            if (model.ShowFFT)
                return;

            /// Time Cursor 1
            float x1 = (float)model.CursorTime1 * pixelsPerMs + (float)model.HorizontalPosition * pixelsPerMs;
            if (x1 >= 0 && x1 <= width)
                graphics.DrawLine(_cursorPen, x1, 0, x1, height);
            /// Time Cursor 2
            float x2 = (float)model.CursorTime2 * pixelsPerMs + (float)model.HorizontalPosition * pixelsPerMs;
            if (x2 >= 0 && x2 <= width)
                graphics.DrawLine(_cursorPen, x2, 0, x2, height);
            /// Voltage Cursor 1
            float y1 = centerY - (float)(model.CursorVoltage1 + model.VerticalPosition) * pixelsPerVolt;
            if (y1 >= 0 && y1 <= height)
                graphics.DrawLine(_cursorPen, 0, y1, width, y1);
            /// Voltage Cursor 2
            float y2 = centerY - (float)(model.CursorVoltage2 + model.VerticalPosition) * pixelsPerVolt;
            if (y2 >= 0 && y2 <= height)
                graphics.DrawLine(_cursorPen, 0, y2, width, y2);
        }
    }
}