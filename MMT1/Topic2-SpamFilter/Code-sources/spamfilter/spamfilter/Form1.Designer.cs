namespace spamfilter {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTrainingData = new System.Windows.Forms.TabPage();
            this.tabPageDecisionTree = new System.Windows.Forms.TabPage();
            this.groupBoxTrainingData = new System.Windows.Forms.GroupBox();
            this.dataGridViewTrainingData = new System.Windows.Forms.DataGridView();
            this.decisionTreeViewDecisionTree = new Accord.Controls.DecisionTreeView();
            this.groupBoxDecisionTree = new System.Windows.Forms.GroupBox();
            this.groupBoxVisualizationData = new System.Windows.Forms.GroupBox();
            this.zedGraphControlData = new ZedGraph.ZedGraphControl();
            this.tabPageTesting = new System.Windows.Forms.TabPage();
            this.dgvPerformance = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.groupBoxTestFile = new System.Windows.Forms.GroupBox();
            this.testenEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTestedFile = new System.Windows.Forms.Label();
            this.lblPathTestedFile = new System.Windows.Forms.Label();
            this.lblPrediction = new System.Windows.Forms.Label();
            this.lblPredictionTestedEmail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTrainingData.SuspendLayout();
            this.tabPageDecisionTree.SuspendLayout();
            this.groupBoxTrainingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingData)).BeginInit();
            this.groupBoxDecisionTree.SuspendLayout();
            this.groupBoxVisualizationData.SuspendLayout();
            this.tabPageTesting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.groupBoxPerformance.SuspendLayout();
            this.groupBoxTestFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testenEmailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTrainingData);
            this.tabControl.Controls.Add(this.tabPageDecisionTree);
            this.tabControl.Controls.Add(this.tabPageTesting);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(907, 476);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageTrainingData
            // 
            this.tabPageTrainingData.Controls.Add(this.groupBoxVisualizationData);
            this.tabPageTrainingData.Controls.Add(this.groupBoxTrainingData);
            this.tabPageTrainingData.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrainingData.Name = "tabPageTrainingData";
            this.tabPageTrainingData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrainingData.Size = new System.Drawing.Size(899, 450);
            this.tabPageTrainingData.TabIndex = 0;
            this.tabPageTrainingData.Text = "Training Data";
            this.tabPageTrainingData.UseVisualStyleBackColor = true;
            // 
            // tabPageDecisionTree
            // 
            this.tabPageDecisionTree.Controls.Add(this.groupBoxDecisionTree);
            this.tabPageDecisionTree.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecisionTree.Name = "tabPageDecisionTree";
            this.tabPageDecisionTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecisionTree.Size = new System.Drawing.Size(855, 450);
            this.tabPageDecisionTree.TabIndex = 1;
            this.tabPageDecisionTree.Text = "Decision Tree";
            this.tabPageDecisionTree.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrainingData
            // 
            this.groupBoxTrainingData.Controls.Add(this.dataGridViewTrainingData);
            this.groupBoxTrainingData.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTrainingData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTrainingData.Name = "groupBoxTrainingData";
            this.groupBoxTrainingData.Size = new System.Drawing.Size(304, 444);
            this.groupBoxTrainingData.TabIndex = 0;
            this.groupBoxTrainingData.TabStop = false;
            this.groupBoxTrainingData.Text = "Training Data";
            // 
            // dataGridViewTrainingData
            // 
            this.dataGridViewTrainingData.AllowUserToAddRows = false;
            this.dataGridViewTrainingData.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewTrainingData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTrainingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrainingData.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTrainingData.Name = "dataGridViewTrainingData";
            this.dataGridViewTrainingData.ReadOnly = true;
            this.dataGridViewTrainingData.Size = new System.Drawing.Size(298, 425);
            this.dataGridViewTrainingData.TabIndex = 5;
            // 
            // decisionTreeViewDecisionTree
            // 
            this.decisionTreeViewDecisionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeViewDecisionTree.Location = new System.Drawing.Point(3, 16);
            this.decisionTreeViewDecisionTree.Name = "decisionTreeViewDecisionTree";
            this.decisionTreeViewDecisionTree.Size = new System.Drawing.Size(295, 424);
            this.decisionTreeViewDecisionTree.TabIndex = 0;
            this.decisionTreeViewDecisionTree.TreeSource = null;
            // 
            // groupBoxDecisionTree
            // 
            this.groupBoxDecisionTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDecisionTree.Controls.Add(this.decisionTreeViewDecisionTree);
            this.groupBoxDecisionTree.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDecisionTree.Name = "groupBoxDecisionTree";
            this.groupBoxDecisionTree.Size = new System.Drawing.Size(301, 443);
            this.groupBoxDecisionTree.TabIndex = 1;
            this.groupBoxDecisionTree.TabStop = false;
            this.groupBoxDecisionTree.Text = "Decision Tree";
            // 
            // groupBoxVisualizationData
            // 
            this.groupBoxVisualizationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVisualizationData.Controls.Add(this.zedGraphControlData);
            this.groupBoxVisualizationData.Location = new System.Drawing.Point(313, 3);
            this.groupBoxVisualizationData.Name = "groupBoxVisualizationData";
            this.groupBoxVisualizationData.Size = new System.Drawing.Size(580, 444);
            this.groupBoxVisualizationData.TabIndex = 1;
            this.groupBoxVisualizationData.TabStop = false;
            this.groupBoxVisualizationData.Text = "Visualization";
            // 
            // zedGraphControlData
            // 
            this.zedGraphControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlData.Enabled = false;
            this.zedGraphControlData.Location = new System.Drawing.Point(3, 16);
            this.zedGraphControlData.Name = "zedGraphControlData";
            this.zedGraphControlData.ScrollGrace = 0D;
            this.zedGraphControlData.ScrollMaxX = 0D;
            this.zedGraphControlData.ScrollMaxY = 0D;
            this.zedGraphControlData.ScrollMaxY2 = 0D;
            this.zedGraphControlData.ScrollMinX = 0D;
            this.zedGraphControlData.ScrollMinY = 0D;
            this.zedGraphControlData.ScrollMinY2 = 0D;
            this.zedGraphControlData.Size = new System.Drawing.Size(574, 425);
            this.zedGraphControlData.TabIndex = 0;
            // 
            // tabPageTesting
            // 
            this.tabPageTesting.Controls.Add(this.groupBoxTestFile);
            this.tabPageTesting.Controls.Add(this.groupBoxPerformance);
            this.tabPageTesting.Location = new System.Drawing.Point(4, 22);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Size = new System.Drawing.Size(899, 450);
            this.tabPageTesting.TabIndex = 2;
            this.tabPageTesting.Text = "Testing";
            this.tabPageTesting.UseVisualStyleBackColor = true;
            // 
            // dgvPerformance
            // 
            this.dgvPerformance.AllowUserToAddRows = false;
            this.dgvPerformance.AllowUserToDeleteRows = false;
            this.dgvPerformance.AllowUserToResizeRows = false;
            this.dgvPerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerformance.Location = new System.Drawing.Point(3, 16);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.ReadOnly = true;
            this.dgvPerformance.RowHeadersVisible = false;
            this.dgvPerformance.Size = new System.Drawing.Size(893, 60);
            this.dgvPerformance.TabIndex = 2;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Accuracy";
            this.Column10.HeaderText = "Accuracy";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Efficiency";
            this.Column9.HeaderText = "Efficiency";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Specificity";
            this.Column8.HeaderText = "Specificity";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sensitivity";
            this.Column7.HeaderText = "Sensitivity";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FalsePositives";
            this.Column6.HeaderText = "False Positives";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TrueNegatives";
            this.Column5.HeaderText = "True Negatives";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FalseNegatives";
            this.Column4.HeaderText = "False Negatives";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TruePositives";
            this.Column3.HeaderText = "True Positives";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Error";
            this.Column2.HeaderText = "Error sum-of-squares";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RSquared";
            this.Column1.HeaderText = "R² (r-squared)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.Controls.Add(this.dgvPerformance);
            this.groupBoxPerformance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPerformance.Location = new System.Drawing.Point(0, 371);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(899, 79);
            this.groupBoxPerformance.TabIndex = 3;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance Measures";
            // 
            // groupBoxTestFile
            // 
            this.groupBoxTestFile.Controls.Add(this.lblPredictionTestedEmail);
            this.groupBoxTestFile.Controls.Add(this.lblPrediction);
            this.groupBoxTestFile.Controls.Add(this.lblPathTestedFile);
            this.groupBoxTestFile.Controls.Add(this.lblTestedFile);
            this.groupBoxTestFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTestFile.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTestFile.Name = "groupBoxTestFile";
            this.groupBoxTestFile.Size = new System.Drawing.Size(899, 371);
            this.groupBoxTestFile.TabIndex = 4;
            this.groupBoxTestFile.TabStop = false;
            this.groupBoxTestFile.Text = "Test of Email";
            // 
            // testenEmailsToolStripMenuItem
            // 
            this.testenEmailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.testenEmailsToolStripMenuItem.Name = "testenEmailsToolStripMenuItem";
            this.testenEmailsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.testenEmailsToolStripMenuItem.Text = "Testen Emails";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // lblTestedFile
            // 
            this.lblTestedFile.AutoSize = true;
            this.lblTestedFile.Location = new System.Drawing.Point(7, 20);
            this.lblTestedFile.Name = "lblTestedFile";
            this.lblTestedFile.Size = new System.Drawing.Size(62, 13);
            this.lblTestedFile.TabIndex = 0;
            this.lblTestedFile.Text = "Tested file: ";
            // 
            // lblPathTestedFile
            // 
            this.lblPathTestedFile.AutoSize = true;
            this.lblPathTestedFile.Location = new System.Drawing.Point(75, 20);
            this.lblPathTestedFile.Name = "lblPathTestedFile";
            this.lblPathTestedFile.Size = new System.Drawing.Size(28, 13);
            this.lblPathTestedFile.TabIndex = 1;
            this.lblPathTestedFile.Text = "path";
            // 
            // lblPrediction
            // 
            this.lblPrediction.AutoSize = true;
            this.lblPrediction.Location = new System.Drawing.Point(10, 58);
            this.lblPrediction.Name = "lblPrediction";
            this.lblPrediction.Size = new System.Drawing.Size(60, 13);
            this.lblPrediction.TabIndex = 2;
            this.lblPrediction.Text = "Prediction: ";
            // 
            // lblPredictionTestedEmail
            // 
            this.lblPredictionTestedEmail.AutoSize = true;
            this.lblPredictionTestedEmail.Location = new System.Drawing.Point(75, 58);
            this.lblPredictionTestedEmail.Name = "lblPredictionTestedEmail";
            this.lblPredictionTestedEmail.Size = new System.Drawing.Size(17, 13);
            this.lblPredictionTestedEmail.TabIndex = 3;
            this.lblPredictionTestedEmail.Text = "lbl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 500);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageTrainingData.ResumeLayout(false);
            this.tabPageDecisionTree.ResumeLayout(false);
            this.groupBoxTrainingData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingData)).EndInit();
            this.groupBoxDecisionTree.ResumeLayout(false);
            this.groupBoxVisualizationData.ResumeLayout(false);
            this.tabPageTesting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.groupBoxPerformance.ResumeLayout(false);
            this.groupBoxTestFile.ResumeLayout(false);
            this.groupBoxTestFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTrainingData;
        private System.Windows.Forms.GroupBox groupBoxTrainingData;
        private System.Windows.Forms.TabPage tabPageDecisionTree;
        private System.Windows.Forms.DataGridView dataGridViewTrainingData;
        private System.Windows.Forms.GroupBox groupBoxDecisionTree;
        private Accord.Controls.DecisionTreeView decisionTreeViewDecisionTree;
        private System.Windows.Forms.GroupBox groupBoxVisualizationData;
        private ZedGraph.ZedGraphControl zedGraphControlData;
        private System.Windows.Forms.TabPage tabPageTesting;
        private System.Windows.Forms.DataGridView dgvPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBoxPerformance;
        private System.Windows.Forms.ToolStripMenuItem testenEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTestFile;
        private System.Windows.Forms.Label lblPredictionTestedEmail;
        private System.Windows.Forms.Label lblPrediction;
        private System.Windows.Forms.Label lblPathTestedFile;
        private System.Windows.Forms.Label lblTestedFile;

    }
}

