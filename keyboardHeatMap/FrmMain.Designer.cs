namespace keyboardHeatMap
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCapture = new System.Windows.Forms.Button();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.keyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "KeyboardHeatmap";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Location = new System.Drawing.Point(514, 419);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(88, 27);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.Text = "Start";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // grdResults
            // 
            this.grdResults.AllowUserToAddRows = false;
            this.grdResults.AllowUserToDeleteRows = false;
            this.grdResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyCode,
            this.Column1});
            this.grdResults.Location = new System.Drawing.Point(14, 14);
            this.grdResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdResults.Name = "grdResults";
            this.grdResults.Size = new System.Drawing.Size(588, 398);
            this.grdResults.TabIndex = 3;
            // 
            // keyCode
            // 
            this.keyCode.HeaderText = "Key";
            this.keyCode.Name = "keyCode";
            this.keyCode.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Count";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Enabled = false;
            this.btnSaveToFile.Location = new System.Drawing.Point(420, 419);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(88, 27);
            this.btnSaveToFile.TabIndex = 4;
            this.btnSaveToFile.Text = "SaveResults";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(14, 419);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(399, 27);
            this.lblStatus.TabIndex = 5;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "CSV files|*.csv";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 459);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.btnCapture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(632, 498);
            this.Name = "FrmMain";
            this.Text = "KeyboardHeatmap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.DataGridViewTextBoxColumn keyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

        private System.Windows.Forms.DataGridView grdResults;

        private System.Windows.Forms.Button btnCapture;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.NotifyIcon notifyIcon;

        #endregion
    }
}