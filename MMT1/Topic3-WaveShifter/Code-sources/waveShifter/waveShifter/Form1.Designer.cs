namespace waveShifter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainerWaveShifter = new System.Windows.Forms.SplitContainer();
            this.btnStopPlayer1 = new System.Windows.Forms.Button();
            this.btnStartPlayer1 = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblOrigineel = new System.Windows.Forms.Label();
            this.btnStopPlayer2 = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnStartPlayer2 = new System.Windows.Forms.Button();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblChanged = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.numericUpDownShiftedSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblShiftedSeconds = new System.Windows.Forms.Label();
            this.btnMakeChanged = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWaveShifter)).BeginInit();
            this.splitContainerWaveShifter.Panel1.SuspendLayout();
            this.splitContainerWaveShifter.Panel2.SuspendLayout();
            this.splitContainerWaveShifter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftedSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerWaveShifter
            // 
            this.splitContainerWaveShifter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainerWaveShifter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerWaveShifter.Location = new System.Drawing.Point(12, 12);
            this.splitContainerWaveShifter.Name = "splitContainerWaveShifter";
            this.splitContainerWaveShifter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWaveShifter.Panel1
            // 
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.btnMakeChanged);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.lblShiftedSeconds);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.numericUpDownShiftedSeconds);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.btnStopPlayer1);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.btnStartPlayer1);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.lblPlayer1);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.btnOpen);
            this.splitContainerWaveShifter.Panel1.Controls.Add(this.lblOrigineel);
            // 
            // splitContainerWaveShifter.Panel2
            // 
            this.splitContainerWaveShifter.Panel2.Controls.Add(this.btnStopPlayer2);
            this.splitContainerWaveShifter.Panel2.Controls.Add(this.btnOpslaan);
            this.splitContainerWaveShifter.Panel2.Controls.Add(this.btnStartPlayer2);
            this.splitContainerWaveShifter.Panel2.Controls.Add(this.lblPlayer2);
            this.splitContainerWaveShifter.Panel2.Controls.Add(this.lblChanged);
            this.splitContainerWaveShifter.Size = new System.Drawing.Size(281, 444);
            this.splitContainerWaveShifter.SplitterDistance = 235;
            this.splitContainerWaveShifter.TabIndex = 0;
            // 
            // btnStopPlayer1
            // 
            this.btnStopPlayer1.Location = new System.Drawing.Point(61, 87);
            this.btnStopPlayer1.Name = "btnStopPlayer1";
            this.btnStopPlayer1.Size = new System.Drawing.Size(45, 23);
            this.btnStopPlayer1.TabIndex = 4;
            this.btnStopPlayer1.Text = "Stop";
            this.btnStopPlayer1.UseVisualStyleBackColor = true;
            this.btnStopPlayer1.Click += new System.EventHandler(this.btnStopPlayer1_Click);
            // 
            // btnStartPlayer1
            // 
            this.btnStartPlayer1.Location = new System.Drawing.Point(13, 87);
            this.btnStartPlayer1.Name = "btnStartPlayer1";
            this.btnStartPlayer1.Size = new System.Drawing.Size(42, 23);
            this.btnStartPlayer1.TabIndex = 3;
            this.btnStartPlayer1.Text = "Start";
            this.btnStartPlayer1.UseVisualStyleBackColor = true;
            this.btnStartPlayer1.Click += new System.EventHandler(this.btnStartPlayer1_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 60);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(116, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblOrigineel
            // 
            this.lblOrigineel.AutoSize = true;
            this.lblOrigineel.Location = new System.Drawing.Point(12, 17);
            this.lblOrigineel.Name = "lblOrigineel";
            this.lblOrigineel.Size = new System.Drawing.Size(48, 13);
            this.lblOrigineel.TabIndex = 0;
            this.lblOrigineel.Text = "Origineel";
            // 
            // btnStopPlayer2
            // 
            this.btnStopPlayer2.Location = new System.Drawing.Point(61, 76);
            this.btnStopPlayer2.Name = "btnStopPlayer2";
            this.btnStopPlayer2.Size = new System.Drawing.Size(45, 23);
            this.btnStopPlayer2.TabIndex = 7;
            this.btnStopPlayer2.Text = "Stop";
            this.btnStopPlayer2.UseVisualStyleBackColor = true;
            this.btnStopPlayer2.Click += new System.EventHandler(this.btnStopPlayer2_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(116, 12);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 2;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnStartPlayer2
            // 
            this.btnStartPlayer2.Location = new System.Drawing.Point(13, 76);
            this.btnStartPlayer2.Name = "btnStartPlayer2";
            this.btnStartPlayer2.Size = new System.Drawing.Size(42, 23);
            this.btnStartPlayer2.TabIndex = 6;
            this.btnStartPlayer2.Text = "Start";
            this.btnStartPlayer2.UseVisualStyleBackColor = true;
            this.btnStartPlayer2.Click += new System.EventHandler(this.btnStartPlayer2_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(12, 50);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player";
            // 
            // lblChanged
            // 
            this.lblChanged.AutoSize = true;
            this.lblChanged.Location = new System.Drawing.Point(12, 17);
            this.lblChanged.Name = "lblChanged";
            this.lblChanged.Size = new System.Drawing.Size(56, 13);
            this.lblChanged.TabIndex = 1;
            this.lblChanged.Text = "Veranderd";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 472);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 23);
            this.progressBar.TabIndex = 1;
            // 
            // numericUpDownShiftedSeconds
            // 
            this.numericUpDownShiftedSeconds.DecimalPlaces = 2;
            this.numericUpDownShiftedSeconds.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownShiftedSeconds.Location = new System.Drawing.Point(11, 135);
            this.numericUpDownShiftedSeconds.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShiftedSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownShiftedSeconds.Name = "numericUpDownShiftedSeconds";
            this.numericUpDownShiftedSeconds.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownShiftedSeconds.TabIndex = 50;
            // 
            // lblShiftedSeconds
            // 
            this.lblShiftedSeconds.AutoSize = true;
            this.lblShiftedSeconds.Location = new System.Drawing.Point(74, 137);
            this.lblShiftedSeconds.Name = "lblShiftedSeconds";
            this.lblShiftedSeconds.Size = new System.Drawing.Size(129, 13);
            this.lblShiftedSeconds.TabIndex = 51;
            this.lblShiftedSeconds.Text = "Verschuiving in seconden";
            // 
            // btnMakeChanged
            // 
            this.btnMakeChanged.Location = new System.Drawing.Point(11, 172);
            this.btnMakeChanged.Name = "btnMakeChanged";
            this.btnMakeChanged.Size = new System.Drawing.Size(155, 23);
            this.btnMakeChanged.TabIndex = 52;
            this.btnMakeChanged.Text = "Maak veranderde wav file";
            this.btnMakeChanged.UseVisualStyleBackColor = true;
            this.btnMakeChanged.Click += new System.EventHandler(this.btnMakeChanged_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 495);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.splitContainerWaveShifter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerWaveShifter.Panel1.ResumeLayout(false);
            this.splitContainerWaveShifter.Panel1.PerformLayout();
            this.splitContainerWaveShifter.Panel2.ResumeLayout(false);
            this.splitContainerWaveShifter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWaveShifter)).EndInit();
            this.splitContainerWaveShifter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftedSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerWaveShifter;
        private System.Windows.Forms.Label lblOrigineel;
        private System.Windows.Forms.Label lblChanged;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnStopPlayer1;
        private System.Windows.Forms.Button btnStartPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnStopPlayer2;
        private System.Windows.Forms.Button btnStartPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown numericUpDownShiftedSeconds;
        private System.Windows.Forms.Label lblShiftedSeconds;
        private System.Windows.Forms.Button btnMakeChanged;
    }
}

