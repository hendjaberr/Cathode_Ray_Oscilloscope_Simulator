using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CathodeRayOscilloscope
{
    public partial class Form1 : Form
    {
        private OscilloscopeModel _model;
        private WaveformRenderer _renderer;
        private Timer _timer;
        private double _timeOffset;
        private bool _isDraggingCursor;
        private string _draggingCursor = "";

        public Form1()
        {
            InitializeComponent();
            _model = new OscilloscopeModel();
            _renderer = waveformPictureBox != null ? new WaveformRenderer(waveformPictureBox) : null;
            if (_renderer == null)
            {
                MessageBox.Show("Failed to initialize WaveformRenderer. Please check waveformPictureBox.", "Initialization Error");
                return;
            }
            if (waveTypeComboBox != null)
            {
                waveTypeComboBox.Items.AddRange(new[] { "Sine", "Square", "Triangle", "Sawtooth" });
                waveTypeComboBox.SelectedIndex = 0;
            }
            if (triggerEdgeComboBox != null)
            {
                triggerEdgeComboBox.Items.AddRange(new[] { "Rising", "Falling" });
                triggerEdgeComboBox.SelectedIndex = 0;
            }
            _timer = new Timer { Interval = 20 };
            _timer.Tick += (s, e) =>
            {
                if (_model != null)
                {
                    _timeOffset += _timer.Interval / 1000.0 * _model.TimePerDivision / 10;
                    UpdateWaveform();
                }
            };
            if (waveformPictureBox != null)
            {
                waveformPictureBox.MouseDown += WaveformPictureBox_MouseDown;
                waveformPictureBox.MouseMove += WaveformPictureBox_MouseMove;
                waveformPictureBox.MouseUp += WaveformPictureBox_MouseUp;
            }
            _timer.Start();
            UpdateWaveform();
        }

        private void UpdateWaveform()
        {
            if (_model == null || _renderer == null || waveformPictureBox == null || _timer == null)
                return;
            _model.SignalData = SignalGenerator.GenerateSignal(_model, _timeOffset) ?? new List<double>();
            if (_model.PreviousSignals.Count >= 5)
                _model.PreviousSignals.RemoveAt(0);
            if (!_model.ShowFFT && _timer.Enabled)
                _model.PreviousSignals.Add(new List<double>(_model.SignalData));
            waveformPictureBox.Tag = _model;
            _renderer.Render(_model);
            if (frequencyReadoutLabel != null)
                frequencyReadoutLabel.Text = $"Freq: {_model.MeasuredFrequency:F1} Hz";
            if (vppReadoutLabel != null)
                vppReadoutLabel.Text = $"Vpp: {_model.PeakToPeakVoltage:F1} V";
        }

        private void WaveformPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_model == null || _model.ShowFFT || waveformPictureBox == null)
                return;
            float width = waveformPictureBox.Width;
            float height = waveformPictureBox.Height;
            float waveformPixelsPerVolt = height / (float)(_model.VoltagePerDivision * 10);
            float waveformPixelsPerMs = width / (float)(_model.TimePerDivision * 10);
            float centerY = height / 2;
            float mouseXMs = (e.X - (float)_model.HorizontalPosition * waveformPixelsPerMs) / waveformPixelsPerMs;
            float mouseYV = -(e.Y - centerY) / waveformPixelsPerVolt - (float)_model.VerticalPosition;
            double[] distances = new double[]
            {
                Math.Abs(mouseXMs - _model.CursorTime1),
                Math.Abs(mouseXMs - _model.CursorTime2),
                Math.Abs(mouseYV - _model.CursorVoltage1),
                Math.Abs(mouseYV - _model.CursorVoltage2)
            };
            int minIndex = Array.IndexOf(distances, distances.Min());
            if (distances[minIndex] < 0.5)
            {
                _isDraggingCursor = true;
                if (minIndex == 0)
                    _draggingCursor = "Time1";
                else if (minIndex == 1)
                    _draggingCursor = "Time2";
                else if (minIndex == 2)
                    _draggingCursor = "Voltage1";
                else if (minIndex == 3)
                    _draggingCursor = "Voltage2";
            }
        }

        private void WaveformPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDraggingCursor || _model == null || waveformPictureBox == null)
                return;
            float width = waveformPictureBox.Width;
            float height = waveformPictureBox.Height;
            float waveformPixelsPerVolt = height / (float)(_model.VoltagePerDivision * 10);
            float waveformPixelsPerMs = width / (float)(_model.TimePerDivision * 10);
            float centerY = height / 2;
            float mouseXMs = (e.X - (float)_model.HorizontalPosition * waveformPixelsPerMs) / waveformPixelsPerMs;
            float mouseYV = -(e.Y - centerY) / waveformPixelsPerVolt - (float)_model.VerticalPosition;
            if (_draggingCursor == "Time1")
                _model.CursorTime1 = Math.Max(0, Math.Min(mouseXMs, _model.TimePerDivision * 10));
            else if (_draggingCursor == "Time2")
                _model.CursorTime2 = Math.Max(0, Math.Min(mouseXMs, _model.TimePerDivision * 10));
            else if (_draggingCursor == "Voltage1")
                _model.CursorVoltage1 = Math.Max(-_model.VoltagePerDivision * 5, Math.Min(mouseYV, _model.VoltagePerDivision * 5));
            else if (_draggingCursor == "Voltage2")
                _model.CursorVoltage2 = Math.Max(-_model.VoltagePerDivision * 5, Math.Min(mouseYV, _model.VoltagePerDivision * 5));
            UpdateWaveform();
        }

        private void WaveformPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isDraggingCursor = false;
            _draggingCursor = "";
        }

        private void voltagePerDivNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && voltagePerDivNumeric != null)
            {
                _model.VoltagePerDivision = (double)voltagePerDivNumeric.Value;
                UpdateWaveform();
            }
        }

        private void timePerDivNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && timePerDivNumeric != null)
            {
                _model.TimePerDivision = (double)timePerDivNumeric.Value;
                UpdateWaveform();
            }
        }

        private void frequencyNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && frequencyNumeric != null)
            {
                _model.Frequency = (double)frequencyNumeric.Value;
                UpdateWaveform();
            }
        }

        private void verticalPositionNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && verticalPositionNumeric != null)
            {
                _model.VerticalPosition = (double)verticalPositionNumeric.Value;
                UpdateWaveform();
            }
        }

        private void horizontalPositionNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && horizontalPositionNumeric != null)
            {
                _model.HorizontalPosition = (double)horizontalPositionNumeric.Value;
                UpdateWaveform();
            }
        }

        private void triggerLevelNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && triggerLevelNumeric != null)
            {
                _model.TriggerLevel = (double)triggerLevelNumeric.Value;
                UpdateWaveform();
            }
        }

        private void waveTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_model != null && waveTypeComboBox != null && waveTypeComboBox.SelectedItem != null)
            {
                _model.WaveType = waveTypeComboBox.SelectedItem.ToString();
                UpdateWaveform();
            }
        }

        private void triggerEdgeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_model != null && triggerEdgeComboBox != null && triggerEdgeComboBox.SelectedItem != null)
            {
                _model.TriggerEdge = triggerEdgeComboBox.SelectedItem.ToString();
                UpdateWaveform();
            }
        }

        private void amplitudeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_model != null && amplitudeNumeric != null)
            {
                _model.Amplitude = (double)amplitudeNumeric.Value;
                UpdateWaveform();
            }
        }

        private void toggleFFTButton_Click(object sender, EventArgs e)
        {
            if (_model != null && toggleFFTButton != null)
            {
                _model.ShowFFT = !_model.ShowFFT;
                toggleFFTButton.Text = _model.ShowFFT ? "Time Domain" : "FFT";
                if (_model.ShowFFT)
                    _model.PreviousSignals.Clear();
                UpdateWaveform();
            }
        }

        private void pauseResumeButton_Click(object sender, EventArgs e)
        {
            if (_timer != null && pauseResumeButton != null)
            {
                if (_timer.Enabled)
                {
                    _timer.Stop();
                    pauseResumeButton.Text = "Resume";
                }
                else
                {
                    _timer.Start();
                    pauseResumeButton.Text = "Pause";
                }
            }
        }

        private void saveCsvButton_Click(object sender, EventArgs e)
        {
            if (_model == null || _model.SignalData == null || !_model.SignalData.Any())
            {
                MessageBox.Show("No waveform data available to save.", "Error");
                return;
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Save Waveform as CSV";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine("Time (ms),Voltage (V)");
                            double period = _model.Frequency > 0 ? 1000.0 / _model.Frequency : 1000.0; 
                            double timeStep = period / _model.SignalData.Count;
                            for (int i = 0; i < _model.SignalData.Count; i++)
                            {
                                double time = i * timeStep;
                                double voltage = _model.SignalData[i];
                                writer.WriteLine($"{time:F6},{voltage:F6}");
                            }
                        }
                        MessageBox.Show("Waveform saved successfully as CSV.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save CSV: {ex.Message}", "Error");
                    }
                }
            }
        }

        private void savePngButton_Click(object sender, EventArgs e)
        {
            if (waveformPictureBox == null || waveformPictureBox.Image == null)
            {
                MessageBox.Show("No waveform image available to save.", "Error");
                return;
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                saveFileDialog.Title = "Save Waveform as PNG";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        waveformPictureBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Waveform image saved successfully as PNG.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save PNG: {ex.Message}", "Error");
                    }
                }
            }
        }
    }
}