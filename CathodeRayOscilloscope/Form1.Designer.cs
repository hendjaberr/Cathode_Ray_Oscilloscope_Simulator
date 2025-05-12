namespace CathodeRayOscilloscope
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.waveformPictureBox = new System.Windows.Forms.PictureBox();
            this.controlPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.savePngButton = new System.Windows.Forms.Button();
            this.saveCsvButton = new System.Windows.Forms.Button();
            this.voltagePerDivNumeric = new System.Windows.Forms.NumericUpDown();
            this.timePerDivNumeric = new System.Windows.Forms.NumericUpDown();
            this.frequencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.verticalPositionNumeric = new System.Windows.Forms.NumericUpDown();
            this.horizontalPositionNumeric = new System.Windows.Forms.NumericUpDown();
            this.triggerLevelNumeric = new System.Windows.Forms.NumericUpDown();
            this.waveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.triggerEdgeComboBox = new System.Windows.Forms.ComboBox();
            this.amplitudeNumeric = new System.Windows.Forms.NumericUpDown();
            this.toggleFFTButton = new System.Windows.Forms.Button();
            this.pauseResumeButton = new System.Windows.Forms.Button();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.verticalPositionLabel = new System.Windows.Forms.Label();
            this.horizontalPositionLabel = new System.Windows.Forms.Label();
            this.triggerLevelLabel = new System.Windows.Forms.Label();
            this.waveTypeLabel = new System.Windows.Forms.Label();
            this.triggerEdgeLabel = new System.Windows.Forms.Label();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.readoutPanel = new System.Windows.Forms.Panel();
            this.frequencyReadoutLabel = new System.Windows.Forms.Label();
            this.vppReadoutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waveformPictureBox)).BeginInit();
            this.controlPanelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltagePerDivNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePerDivNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPositionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPositionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevelNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumeric)).BeginInit();
            this.readoutPanel.SuspendLayout();
            this.SuspendLayout();
            /// waveform picture box 
            this.waveformPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.waveformPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.waveformPictureBox.Location = new System.Drawing.Point(12, 12);
            this.waveformPictureBox.Name = "waveformPictureBox";
            this.waveformPictureBox.Size = new System.Drawing.Size(760, 400);
            this.waveformPictureBox.TabIndex = 0;
            this.waveformPictureBox.TabStop = false;
            /// control panel group box
            this.controlPanelGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.controlPanelGroupBox.Controls.Add(this.savePngButton);
            this.controlPanelGroupBox.Controls.Add(this.saveCsvButton);
            this.controlPanelGroupBox.Controls.Add(this.readoutPanel);
            this.controlPanelGroupBox.Controls.Add(this.amplitudeLabel);
            this.controlPanelGroupBox.Controls.Add(this.triggerEdgeLabel);
            this.controlPanelGroupBox.Controls.Add(this.waveTypeLabel);
            this.controlPanelGroupBox.Controls.Add(this.triggerLevelLabel);
            this.controlPanelGroupBox.Controls.Add(this.horizontalPositionLabel);
            this.controlPanelGroupBox.Controls.Add(this.verticalPositionLabel);
            this.controlPanelGroupBox.Controls.Add(this.frequencyLabel);
            this.controlPanelGroupBox.Controls.Add(this.timeLabel);
            this.controlPanelGroupBox.Controls.Add(this.voltageLabel);
            this.controlPanelGroupBox.Controls.Add(this.toggleFFTButton);
            this.controlPanelGroupBox.Controls.Add(this.pauseResumeButton);
            this.controlPanelGroupBox.Controls.Add(this.amplitudeNumeric);
            this.controlPanelGroupBox.Controls.Add(this.triggerEdgeComboBox);
            this.controlPanelGroupBox.Controls.Add(this.waveTypeComboBox);
            this.controlPanelGroupBox.Controls.Add(this.triggerLevelNumeric);
            this.controlPanelGroupBox.Controls.Add(this.horizontalPositionNumeric);
            this.controlPanelGroupBox.Controls.Add(this.verticalPositionNumeric);
            this.controlPanelGroupBox.Controls.Add(this.frequencyNumeric);
            this.controlPanelGroupBox.Controls.Add(this.timePerDivNumeric);
            this.controlPanelGroupBox.Controls.Add(this.voltagePerDivNumeric);
            this.controlPanelGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.controlPanelGroupBox.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 418);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Size = new System.Drawing.Size(760, 280);
            this.controlPanelGroupBox.TabIndex = 1;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            /// save PNG 
            this.savePngButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.savePngButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savePngButton.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePngButton.Location = new System.Drawing.Point(400, 220);
            this.savePngButton.Name = "savePngButton";
            this.savePngButton.Size = new System.Drawing.Size(120, 30);
            this.savePngButton.TabIndex = 21;
            this.savePngButton.Text = "Save PNG";
            this.savePngButton.UseVisualStyleBackColor = false;
            this.savePngButton.Click += new System.EventHandler(this.savePngButton_Click);
            /// save CSV
            this.saveCsvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveCsvButton.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCsvButton.Location = new System.Drawing.Point(400, 190);
            this.saveCsvButton.Name = "saveCsvButton";
            this.saveCsvButton.Size = new System.Drawing.Size(120, 30);
            this.saveCsvButton.TabIndex = 20;
            this.saveCsvButton.Text = "Save CSV";
            this.saveCsvButton.UseVisualStyleBackColor = false;
            this.saveCsvButton.Click += new System.EventHandler(this.saveCsvButton_Click);
            /// voltage/div 
            this.voltagePerDivNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voltagePerDivNumeric.DecimalPlaces = 1;
            this.voltagePerDivNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltagePerDivNumeric.Location = new System.Drawing.Point(120, 30);
            this.voltagePerDivNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.voltagePerDivNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.voltagePerDivNumeric.Name = "voltagePerDivNumeric";
            this.voltagePerDivNumeric.Size = new System.Drawing.Size(120, 26);
            this.voltagePerDivNumeric.TabIndex = 0;
            this.voltagePerDivNumeric.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            this.voltagePerDivNumeric.ValueChanged += new System.EventHandler(this.voltagePerDivNumeric_ValueChanged);
            /// time/div 
            this.timePerDivNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.timePerDivNumeric.DecimalPlaces = 1;
            this.timePerDivNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePerDivNumeric.Location = new System.Drawing.Point(120, 60);
            this.timePerDivNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.timePerDivNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.timePerDivNumeric.Name = "timePerDivNumeric";
            this.timePerDivNumeric.Size = new System.Drawing.Size(120, 26);
            this.timePerDivNumeric.TabIndex = 1;
            this.timePerDivNumeric.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            this.timePerDivNumeric.ValueChanged += new System.EventHandler(this.timePerDivNumeric_ValueChanged);
            /// frequency
            this.frequencyNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.frequencyNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyNumeric.Location = new System.Drawing.Point(120, 90);
            this.frequencyNumeric.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.frequencyNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.frequencyNumeric.Name = "frequencyNumeric";
            this.frequencyNumeric.Size = new System.Drawing.Size(120, 26);
            this.frequencyNumeric.TabIndex = 2;
            this.frequencyNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.frequencyNumeric.ValueChanged += new System.EventHandler(this.frequencyNumeric_ValueChanged);
            /// vertical position
            this.verticalPositionNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.verticalPositionNumeric.DecimalPlaces = 1;
            this.verticalPositionNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalPositionNumeric.Location = new System.Drawing.Point(120, 120);
            this.verticalPositionNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.verticalPositionNumeric.Minimum = new decimal(new int[] { 5, 0, 0, -2147483648 });
            this.verticalPositionNumeric.Name = "verticalPositionNumeric";
            this.verticalPositionNumeric.Size = new System.Drawing.Size(120, 26);
            this.verticalPositionNumeric.TabIndex = 3;
            this.verticalPositionNumeric.ValueChanged += new System.EventHandler(this.verticalPositionNumeric_ValueChanged);
            /// horizontal position
            this.horizontalPositionNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.horizontalPositionNumeric.DecimalPlaces = 1;
            this.horizontalPositionNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalPositionNumeric.Location = new System.Drawing.Point(120, 150);
            this.horizontalPositionNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.horizontalPositionNumeric.Minimum = new decimal(new int[] { 10, 0, 0, -2147483648 });
            this.horizontalPositionNumeric.Name = "horizontalPositionNumeric";
            this.horizontalPositionNumeric.Size = new System.Drawing.Size(120, 26);
            this.horizontalPositionNumeric.TabIndex = 4;
            this.horizontalPositionNumeric.ValueChanged += new System.EventHandler(this.horizontalPositionNumeric_ValueChanged);
            /// ampltiude 
            this.amplitudeNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.amplitudeNumeric.DecimalPlaces = 1;
            this.amplitudeNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitudeNumeric.Location = new System.Drawing.Point(120, 180);
            this.amplitudeNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.amplitudeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.amplitudeNumeric.Name = "amplitudeNumeric";
            this.amplitudeNumeric.Size = new System.Drawing.Size(120, 26);
            this.amplitudeNumeric.TabIndex = 5;
            this.amplitudeNumeric.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            this.amplitudeNumeric.ValueChanged += new System.EventHandler(this.amplitudeNumeric_ValueChanged);
            /// trigger level
            this.triggerLevelNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.triggerLevelNumeric.DecimalPlaces = 1;
            this.triggerLevelNumeric.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerLevelNumeric.Location = new System.Drawing.Point(400, 30);
            this.triggerLevelNumeric.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            this.triggerLevelNumeric.Minimum = new decimal(new int[] { 2, 0, 0, -2147483648 });
            this.triggerLevelNumeric.Name = "triggerLevelNumeric";
            this.triggerLevelNumeric.Size = new System.Drawing.Size(120, 26);
            this.triggerLevelNumeric.TabIndex = 6;
            this.triggerLevelNumeric.ValueChanged += new System.EventHandler(this.triggerLevelNumeric_ValueChanged);
            /// wave type
            this.waveTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.waveTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waveTypeComboBox.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveTypeComboBox.Location = new System.Drawing.Point(400, 60);
            this.waveTypeComboBox.Name = "waveTypeComboBox";
            this.waveTypeComboBox.Size = new System.Drawing.Size(120, 24);
            this.waveTypeComboBox.TabIndex = 7;
            this.waveTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.waveTypeComboBox_SelectedIndexChanged);
            /// trigger edge
            this.triggerEdgeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.triggerEdgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triggerEdgeComboBox.Font = new System.Drawing.Font("Fixedsys", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerEdgeComboBox.Location = new System.Drawing.Point(400, 90);
            this.triggerEdgeComboBox.Name = "triggerEdgeComboBox";
            this.triggerEdgeComboBox.Size = new System.Drawing.Size(120, 24);
            this.triggerEdgeComboBox.TabIndex = 8;
            this.triggerEdgeComboBox.SelectedIndexChanged += new System.EventHandler(this.triggerEdgeComboBox_SelectedIndexChanged);
            /// toggle FFT button
            this.toggleFFTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toggleFFTButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toggleFFTButton.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleFFTButton.Location = new System.Drawing.Point(400, 120);
            this.toggleFFTButton.Name = "toggleFFTButton";
            this.toggleFFTButton.Size = new System.Drawing.Size(120, 30);
            this.toggleFFTButton.TabIndex = 9;
            this.toggleFFTButton.Text = "FFT";
            this.toggleFFTButton.UseVisualStyleBackColor = false;
            this.toggleFFTButton.Click += new System.EventHandler(this.toggleFFTButton_Click);
            /// pause & resume button
            this.pauseResumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pauseResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pauseResumeButton.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseResumeButton.Location = new System.Drawing.Point(400, 160);
            this.pauseResumeButton.Name = "pauseResumeButton";
            this.pauseResumeButton.Size = new System.Drawing.Size(120, 30);
            this.pauseResumeButton.TabIndex = 10;
            this.pauseResumeButton.Text = "Pause";
            this.pauseResumeButton.UseVisualStyleBackColor = false;
            this.pauseResumeButton.Click += new System.EventHandler(this.pauseResumeButton_Click);
            /// voltage label
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.Location = new System.Drawing.Point(20, 32);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(94, 13);
            this.voltageLabel.TabIndex = 11;
            this.voltageLabel.Text = "Voltage/Div (V):";
            /// time label
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(20, 62);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 13);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "Time/Div (ms):";
            /// frequency label
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.Location = new System.Drawing.Point(20, 92);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(78, 13);
            this.frequencyLabel.TabIndex = 13;
            this.frequencyLabel.Text = "Frequency (Hz):";
            /// vertical position label 
            this.verticalPositionLabel.AutoSize = true;
            this.verticalPositionLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalPositionLabel.Location = new System.Drawing.Point(20, 122);
            this.verticalPositionLabel.Name = "verticalPositionLabel";
            this.verticalPositionLabel.Size = new System.Drawing.Size(89, 13);
            this.verticalPositionLabel.TabIndex = 14;
            this.verticalPositionLabel.Text = "Vertical Pos (V):";
            /// horizontal position label
            this.horizontalPositionLabel.AutoSize = true;
            this.horizontalPositionLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalPositionLabel.Location = new System.Drawing.Point(20, 152);
            this.horizontalPositionLabel.Name = "horizontalPositionLabel";
            this.horizontalPositionLabel.Size = new System.Drawing.Size(99, 13);
            this.horizontalPositionLabel.TabIndex = 15;
            this.horizontalPositionLabel.Text = "Horizontal Pos (ms):";
            /// amplitude label
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitudeLabel.Location = new System.Drawing.Point(20, 182);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(73, 13);
            this.amplitudeLabel.TabIndex = 16;
            this.amplitudeLabel.Text = "Amplitude (V):";
            /// trigger level label
            this.triggerLevelLabel.AutoSize = true;
            this.triggerLevelLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerLevelLabel.Location = new System.Drawing.Point(300, 32);
            this.triggerLevelLabel.Name = "triggerLevelLabel";
            this.triggerLevelLabel.Size = new System.Drawing.Size(73, 13);
            this.triggerLevelLabel.TabIndex = 17;
            this.triggerLevelLabel.Text = "Trigger Level:";
            /// wave type label
            this.waveTypeLabel.AutoSize = true;
            this.waveTypeLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveTypeLabel.Location = new System.Drawing.Point(300, 62);
            this.waveTypeLabel.Name = "waveTypeLabel";
            this.waveTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.waveTypeLabel.TabIndex = 18;
            this.waveTypeLabel.Text = "Wave Type:";
            /// trigger edge label
            this.triggerEdgeLabel.AutoSize = true;
            this.triggerEdgeLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerEdgeLabel.Location = new System.Drawing.Point(300, 92);
            this.triggerEdgeLabel.Name = "triggerEdgeLabel";
            this.triggerEdgeLabel.Size = new System.Drawing.Size(67, 13);
            this.triggerEdgeLabel.TabIndex = 19;
            this.triggerEdgeLabel.Text = "Trigger Edge:";
            /// readout panel
            this.readoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.readoutPanel.Controls.Add(this.vppReadoutLabel);
            this.readoutPanel.Controls.Add(this.frequencyReadoutLabel);
            this.readoutPanel.Location = new System.Drawing.Point(20, 210);
            this.readoutPanel.Name = "readoutPanel";
            this.readoutPanel.Size = new System.Drawing.Size(500, 50);
            this.readoutPanel.TabIndex = 20;
            /// frequency readout label
            this.frequencyReadoutLabel.AutoSize = true;
            this.frequencyReadoutLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyReadoutLabel.Location = new System.Drawing.Point(10, 10);
            this.frequencyReadoutLabel.Name = "frequencyReadoutLabel";
            this.frequencyReadoutLabel.Size = new System.Drawing.Size(80, 13);
            this.frequencyReadoutLabel.TabIndex = 0;
            this.frequencyReadoutLabel.Text = "Freq: 0.0 Hz";
            /// Vpp readout label 
            this.vppReadoutLabel.AutoSize = true;
            this.vppReadoutLabel.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vppReadoutLabel.Location = new System.Drawing.Point(10, 30);
            this.vppReadoutLabel.Name = "vppReadoutLabel";
            this.vppReadoutLabel.Size = new System.Drawing.Size(60, 13);
            this.vppReadoutLabel.TabIndex = 1;
            this.vppReadoutLabel.Text = "Vpp: 0.0 V";
            /// Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Controls.Add(this.waveformPictureBox);
            this.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cathode Ray Oscilloscope";
            ((System.ComponentModel.ISupportInitialize)(this.waveformPictureBox)).EndInit();
            this.controlPanelGroupBox.ResumeLayout(false);
            this.controlPanelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltagePerDivNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePerDivNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPositionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPositionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevelNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumeric)).EndInit();
            this.readoutPanel.ResumeLayout(false);
            this.readoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox waveformPictureBox;
        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.NumericUpDown voltagePerDivNumeric;
        private System.Windows.Forms.NumericUpDown timePerDivNumeric;
        private System.Windows.Forms.NumericUpDown frequencyNumeric;
        private System.Windows.Forms.NumericUpDown verticalPositionNumeric;
        private System.Windows.Forms.NumericUpDown horizontalPositionNumeric;
        private System.Windows.Forms.NumericUpDown triggerLevelNumeric;
        private System.Windows.Forms.NumericUpDown amplitudeNumeric;
        private System.Windows.Forms.ComboBox waveTypeComboBox;
        private System.Windows.Forms.ComboBox triggerEdgeComboBox;
        private System.Windows.Forms.Button toggleFFTButton;
        private System.Windows.Forms.Button pauseResumeButton;
        private System.Windows.Forms.Button saveCsvButton;
        private System.Windows.Forms.Button savePngButton;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label verticalPositionLabel;
        private System.Windows.Forms.Label horizontalPositionLabel;
        private System.Windows.Forms.Label triggerLevelLabel;
        private System.Windows.Forms.Label waveTypeLabel;
        private System.Windows.Forms.Label triggerEdgeLabel;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Panel readoutPanel;
        private System.Windows.Forms.Label frequencyReadoutLabel;
        private System.Windows.Forms.Label vppReadoutLabel;
    }
}