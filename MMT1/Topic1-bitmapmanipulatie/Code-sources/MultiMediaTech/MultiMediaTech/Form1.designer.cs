namespace MultiMediaTech {
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
            this.picBoxBitmap = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnToepassen = new System.Windows.Forms.Button();
            this.trackBarBlauw = new System.Windows.Forms.TrackBar();
            this.lblBlauwWaarde = new System.Windows.Forms.Label();
            this.lblBlauw = new System.Windows.Forms.Label();
            this.trackBarGroen = new System.Windows.Forms.TrackBar();
            this.lblGroenWaarde = new System.Windows.Forms.Label();
            this.lblGroen = new System.Windows.Forms.Label();
            this.trackBarRood = new System.Windows.Forms.TrackBar();
            this.lblRoodWaarde = new System.Windows.Forms.Label();
            this.lblRood = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBitmap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlauw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRood)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBitmap
            // 
            this.picBoxBitmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBitmap.Location = new System.Drawing.Point(5, 5);
            this.picBoxBitmap.Name = "picBoxBitmap";
            this.picBoxBitmap.Size = new System.Drawing.Size(464, 259);
            this.picBoxBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBitmap.TabIndex = 0;
            this.picBoxBitmap.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openenToolStripMenuItem,
            this.opslaanToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "bestand";
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.openenToolStripMenuItem.Text = "openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.opslaanToolStripMenuItem.Text = "opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.opslaanToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.filterToolStripMenuItem.Text = "filter";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.invertToolStripMenuItem.Text = "invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInvert);
            this.splitContainer1.Panel1.Controls.Add(this.btnToepassen);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarBlauw);
            this.splitContainer1.Panel1.Controls.Add(this.lblBlauwWaarde);
            this.splitContainer1.Panel1.Controls.Add(this.lblBlauw);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarGroen);
            this.splitContainer1.Panel1.Controls.Add(this.lblGroenWaarde);
            this.splitContainer1.Panel1.Controls.Add(this.lblGroen);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarRood);
            this.splitContainer1.Panel1.Controls.Add(this.lblRoodWaarde);
            this.splitContainer1.Panel1.Controls.Add(this.lblRood);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picBoxBitmap);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(728, 269);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnInvert
            // 
            this.btnInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvert.Location = new System.Drawing.Point(197, 139);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(50, 23);
            this.btnInvert.TabIndex = 9;
            this.btnInvert.Text = "invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnToepassen
            // 
            this.btnToepassen.Location = new System.Drawing.Point(12, 139);
            this.btnToepassen.Name = "btnToepassen";
            this.btnToepassen.Size = new System.Drawing.Size(75, 23);
            this.btnToepassen.TabIndex = 8;
            this.btnToepassen.Text = "toepassen";
            this.btnToepassen.UseVisualStyleBackColor = true;
            this.btnToepassen.Click += new System.EventHandler(this.btnToepassen_Click);
            // 
            // trackBarBlauw
            // 
            this.trackBarBlauw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBlauw.LargeChange = 1;
            this.trackBarBlauw.Location = new System.Drawing.Point(3, 107);
            this.trackBarBlauw.Maximum = 5;
            this.trackBarBlauw.Minimum = -5;
            this.trackBarBlauw.Name = "trackBarBlauw";
            this.trackBarBlauw.Size = new System.Drawing.Size(244, 45);
            this.trackBarBlauw.TabIndex = 6;
            this.trackBarBlauw.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlauw.ValueChanged += new System.EventHandler(this.trackBarBlauw_ValueChanged);
            // 
            // lblBlauwWaarde
            // 
            this.lblBlauwWaarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlauwWaarde.AutoSize = true;
            this.lblBlauwWaarde.Location = new System.Drawing.Point(201, 91);
            this.lblBlauwWaarde.Name = "lblBlauwWaarde";
            this.lblBlauwWaarde.Size = new System.Drawing.Size(13, 13);
            this.lblBlauwWaarde.TabIndex = 7;
            this.lblBlauwWaarde.Text = "0";
            // 
            // lblBlauw
            // 
            this.lblBlauw.AutoSize = true;
            this.lblBlauw.Location = new System.Drawing.Point(12, 91);
            this.lblBlauw.Name = "lblBlauw";
            this.lblBlauw.Size = new System.Drawing.Size(35, 13);
            this.lblBlauw.TabIndex = 5;
            this.lblBlauw.Text = "blauw";
            // 
            // trackBarGroen
            // 
            this.trackBarGroen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGroen.LargeChange = 1;
            this.trackBarGroen.Location = new System.Drawing.Point(3, 66);
            this.trackBarGroen.Maximum = 5;
            this.trackBarGroen.Minimum = -5;
            this.trackBarGroen.Name = "trackBarGroen";
            this.trackBarGroen.Size = new System.Drawing.Size(244, 45);
            this.trackBarGroen.TabIndex = 3;
            this.trackBarGroen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGroen.ValueChanged += new System.EventHandler(this.trackBarGroen_ValueChanged);
            // 
            // lblGroenWaarde
            // 
            this.lblGroenWaarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroenWaarde.AutoSize = true;
            this.lblGroenWaarde.Location = new System.Drawing.Point(201, 50);
            this.lblGroenWaarde.Name = "lblGroenWaarde";
            this.lblGroenWaarde.Size = new System.Drawing.Size(13, 13);
            this.lblGroenWaarde.TabIndex = 4;
            this.lblGroenWaarde.Text = "0";
            // 
            // lblGroen
            // 
            this.lblGroen.AutoSize = true;
            this.lblGroen.Location = new System.Drawing.Point(12, 50);
            this.lblGroen.Name = "lblGroen";
            this.lblGroen.Size = new System.Drawing.Size(34, 13);
            this.lblGroen.TabIndex = 2;
            this.lblGroen.Text = "groen";
            // 
            // trackBarRood
            // 
            this.trackBarRood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRood.LargeChange = 1;
            this.trackBarRood.Location = new System.Drawing.Point(3, 26);
            this.trackBarRood.Maximum = 5;
            this.trackBarRood.Minimum = -5;
            this.trackBarRood.Name = "trackBarRood";
            this.trackBarRood.Size = new System.Drawing.Size(244, 45);
            this.trackBarRood.TabIndex = 1;
            this.trackBarRood.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRood.ValueChanged += new System.EventHandler(this.trackBarRood_ValueChanged);
            // 
            // lblRoodWaarde
            // 
            this.lblRoodWaarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoodWaarde.AutoSize = true;
            this.lblRoodWaarde.Location = new System.Drawing.Point(201, 10);
            this.lblRoodWaarde.Name = "lblRoodWaarde";
            this.lblRoodWaarde.Size = new System.Drawing.Size(13, 13);
            this.lblRoodWaarde.TabIndex = 1;
            this.lblRoodWaarde.Text = "0";
            // 
            // lblRood
            // 
            this.lblRood.AutoSize = true;
            this.lblRood.Location = new System.Drawing.Point(12, 10);
            this.lblRood.Name = "lblRood";
            this.lblRood.Size = new System.Drawing.Size(28, 13);
            this.lblRood.TabIndex = 0;
            this.lblRood.Text = "rood";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 299);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(728, 23);
            this.progressBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 322);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multimedia technieken       Bitmap-manipulatie";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBitmap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlauw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBitmap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblRood;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
        private System.Windows.Forms.Label lblRoodWaarde;
        private System.Windows.Forms.TrackBar trackBarRood;
        private System.Windows.Forms.TrackBar trackBarBlauw;
        private System.Windows.Forms.Label lblBlauwWaarde;
        private System.Windows.Forms.Label lblBlauw;
        private System.Windows.Forms.TrackBar trackBarGroen;
        private System.Windows.Forms.Label lblGroenWaarde;
        private System.Windows.Forms.Label lblGroen;
        private System.Windows.Forms.Button btnToepassen;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
    }
}

