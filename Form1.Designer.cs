namespace UTT_Verifier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcListBoxes = new System.Windows.Forms.SplitContainer();
            this.spcFilePaths = new System.Windows.Forms.SplitContainer();
            this.lblQuartzPath = new System.Windows.Forms.Label();
            this.edtQuartzPath = new System.Windows.Forms.TextBox();
            this.gbQuartzDates = new System.Windows.Forms.GroupBox();
            this.lbQuartzDates = new System.Windows.Forms.ListBox();
            this.btnQuartzPath = new System.Windows.Forms.Button();
            this.gbVShapeDates = new System.Windows.Forms.GroupBox();
            this.lbVShapeDates = new System.Windows.Forms.ListBox();
            this.btnVShapePath = new System.Windows.Forms.Button();
            this.edtVShapePath = new System.Windows.Forms.TextBox();
            this.lblVShapePath = new System.Windows.Forms.Label();
            this.dlgGetPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.pbDates = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcListBoxes)).BeginInit();
            this.spcListBoxes.Panel1.SuspendLayout();
            this.spcListBoxes.Panel2.SuspendLayout();
            this.spcListBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcFilePaths)).BeginInit();
            this.spcFilePaths.Panel1.SuspendLayout();
            this.spcFilePaths.Panel2.SuspendLayout();
            this.spcFilePaths.SuspendLayout();
            this.gbQuartzDates.SuspendLayout();
            this.gbVShapeDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcFilePaths);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcListBoxes);
            this.spcMain.Size = new System.Drawing.Size(871, 526);
            this.spcMain.SplitterDistance = 263;
            this.spcMain.TabIndex = 13;
            // 
            // spcListBoxes
            // 
            this.spcListBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcListBoxes.Location = new System.Drawing.Point(0, 0);
            this.spcListBoxes.Name = "spcListBoxes";
            // 
            // spcListBoxes.Panel1
            // 
            this.spcListBoxes.Panel1.Controls.Add(this.gbQuartzDates);
            // 
            // spcListBoxes.Panel2
            // 
            this.spcListBoxes.Panel2.Controls.Add(this.gbVShapeDates);
            this.spcListBoxes.Size = new System.Drawing.Size(871, 259);
            this.spcListBoxes.SplitterDistance = 435;
            this.spcListBoxes.TabIndex = 0;
            // 
            // spcFilePaths
            // 
            this.spcFilePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcFilePaths.Location = new System.Drawing.Point(0, 0);
            this.spcFilePaths.Name = "spcFilePaths";
            this.spcFilePaths.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcFilePaths.Panel1
            // 
            this.spcFilePaths.Panel1.Controls.Add(this.btnVShapePath);
            this.spcFilePaths.Panel1.Controls.Add(this.edtVShapePath);
            this.spcFilePaths.Panel1.Controls.Add(this.lblVShapePath);
            this.spcFilePaths.Panel1.Controls.Add(this.btnQuartzPath);
            this.spcFilePaths.Panel1.Controls.Add(this.edtQuartzPath);
            this.spcFilePaths.Panel1.Controls.Add(this.lblQuartzPath);
            // 
            // spcFilePaths.Panel2
            // 
            this.spcFilePaths.Panel2.Controls.Add(this.pbDates);
            this.spcFilePaths.Panel2.Controls.Add(this.btnGetDates);
            this.spcFilePaths.Size = new System.Drawing.Size(871, 263);
            this.spcFilePaths.SplitterDistance = 122;
            this.spcFilePaths.TabIndex = 0;
            // 
            // lblQuartzPath
            // 
            this.lblQuartzPath.AutoSize = true;
            this.lblQuartzPath.Location = new System.Drawing.Point(12, 18);
            this.lblQuartzPath.Name = "lblQuartzPath";
            this.lblQuartzPath.Size = new System.Drawing.Size(85, 13);
            this.lblQuartzPath.TabIndex = 0;
            this.lblQuartzPath.Text = "Quartz File Path:";
            // 
            // edtQuartzPath
            // 
            this.edtQuartzPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtQuartzPath.Location = new System.Drawing.Point(117, 15);
            this.edtQuartzPath.Name = "edtQuartzPath";
            this.edtQuartzPath.Size = new System.Drawing.Size(709, 20);
            this.edtQuartzPath.TabIndex = 1;
            // 
            // gbQuartzDates
            // 
            this.gbQuartzDates.Controls.Add(this.lbQuartzDates);
            this.gbQuartzDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuartzDates.Location = new System.Drawing.Point(0, 0);
            this.gbQuartzDates.Name = "gbQuartzDates";
            this.gbQuartzDates.Size = new System.Drawing.Size(435, 259);
            this.gbQuartzDates.TabIndex = 0;
            this.gbQuartzDates.TabStop = false;
            this.gbQuartzDates.Text = "Quartz";
            // 
            // lbQuartzDates
            // 
            this.lbQuartzDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuartzDates.FormattingEnabled = true;
            this.lbQuartzDates.Location = new System.Drawing.Point(3, 16);
            this.lbQuartzDates.Name = "lbQuartzDates";
            this.lbQuartzDates.Size = new System.Drawing.Size(429, 240);
            this.lbQuartzDates.TabIndex = 0;
            // 
            // btnQuartzPath
            // 
            this.btnQuartzPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuartzPath.Location = new System.Drawing.Point(832, 13);
            this.btnQuartzPath.Name = "btnQuartzPath";
            this.btnQuartzPath.Size = new System.Drawing.Size(27, 23);
            this.btnQuartzPath.TabIndex = 2;
            this.btnQuartzPath.Text = "...";
            this.btnQuartzPath.UseVisualStyleBackColor = true;
            this.btnQuartzPath.Click += new System.EventHandler(this.btnQuartzPath_Click);
            // 
            // gbVShapeDates
            // 
            this.gbVShapeDates.Controls.Add(this.lbVShapeDates);
            this.gbVShapeDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVShapeDates.Location = new System.Drawing.Point(0, 0);
            this.gbVShapeDates.Name = "gbVShapeDates";
            this.gbVShapeDates.Size = new System.Drawing.Size(432, 259);
            this.gbVShapeDates.TabIndex = 0;
            this.gbVShapeDates.TabStop = false;
            this.gbVShapeDates.Text = "V-Shape";
            // 
            // lbVShapeDates
            // 
            this.lbVShapeDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVShapeDates.FormattingEnabled = true;
            this.lbVShapeDates.Location = new System.Drawing.Point(3, 16);
            this.lbVShapeDates.Name = "lbVShapeDates";
            this.lbVShapeDates.Size = new System.Drawing.Size(426, 240);
            this.lbVShapeDates.TabIndex = 0;
            // 
            // btnVShapePath
            // 
            this.btnVShapePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVShapePath.Location = new System.Drawing.Point(832, 41);
            this.btnVShapePath.Name = "btnVShapePath";
            this.btnVShapePath.Size = new System.Drawing.Size(27, 23);
            this.btnVShapePath.TabIndex = 5;
            this.btnVShapePath.Text = "...";
            this.btnVShapePath.UseVisualStyleBackColor = true;
            this.btnVShapePath.Click += new System.EventHandler(this.btnVShapePath_Click);
            // 
            // edtVShapePath
            // 
            this.edtVShapePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtVShapePath.Location = new System.Drawing.Point(117, 43);
            this.edtVShapePath.Name = "edtVShapePath";
            this.edtVShapePath.Size = new System.Drawing.Size(709, 20);
            this.edtVShapePath.TabIndex = 4;
            // 
            // lblVShapePath
            // 
            this.lblVShapePath.AutoSize = true;
            this.lblVShapePath.Location = new System.Drawing.Point(12, 46);
            this.lblVShapePath.Name = "lblVShapePath";
            this.lblVShapePath.Size = new System.Drawing.Size(95, 13);
            this.lblVShapePath.TabIndex = 3;
            this.lblVShapePath.Text = "V-Shape File Path:";
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(12, 13);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(99, 23);
            this.btnGetDates.TabIndex = 0;
            this.btnGetDates.Text = "get dates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // pbDates
            // 
            this.pbDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDates.Location = new System.Drawing.Point(117, 13);
            this.pbDates.Name = "pbDates";
            this.pbDates.Size = new System.Drawing.Size(742, 23);
            this.pbDates.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 526);
            this.Controls.Add(this.spcMain);
            this.Name = "Form1";
            this.Text = "UTT Verifier";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcListBoxes.Panel1.ResumeLayout(false);
            this.spcListBoxes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcListBoxes)).EndInit();
            this.spcListBoxes.ResumeLayout(false);
            this.spcFilePaths.Panel1.ResumeLayout(false);
            this.spcFilePaths.Panel1.PerformLayout();
            this.spcFilePaths.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcFilePaths)).EndInit();
            this.spcFilePaths.ResumeLayout(false);
            this.gbQuartzDates.ResumeLayout(false);
            this.gbVShapeDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcFilePaths;
        private System.Windows.Forms.TextBox edtQuartzPath;
        private System.Windows.Forms.Label lblQuartzPath;
        private System.Windows.Forms.SplitContainer spcListBoxes;
        private System.Windows.Forms.Button btnQuartzPath;
        private System.Windows.Forms.GroupBox gbQuartzDates;
        private System.Windows.Forms.ListBox lbQuartzDates;
        private System.Windows.Forms.GroupBox gbVShapeDates;
        private System.Windows.Forms.ListBox lbVShapeDates;
        private System.Windows.Forms.Button btnVShapePath;
        private System.Windows.Forms.TextBox edtVShapePath;
        private System.Windows.Forms.Label lblVShapePath;
        private System.Windows.Forms.FolderBrowserDialog dlgGetPath;
        private System.Windows.Forms.ProgressBar pbDates;
        private System.Windows.Forms.Button btnGetDates;
    }
}

