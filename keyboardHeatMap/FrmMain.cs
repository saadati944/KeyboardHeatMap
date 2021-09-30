using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using keyboardHeatMap.Capture;
using keyboardHeatMap.IO;
using WindowsInput.Events;

namespace keyboardHeatMap
{
    public partial class FrmMain : Form
    {
        private bool allowFormClosing = false;
        private IKHCore core;
        public bool Hidden { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            notifyIcon.Visible = true;
            core = new Core();
        }

        private void ActivateForm()
        {
            if (Hidden) ShowForm();
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        
        private void ShowForm()
        {
            Hidden = false;
            this.Show();
        }

        private void HideForm()
        {
            Hidden = true;
            this.Hide();
        }

        private void AllowFormClosing()
        {
            allowFormClosing = true;
        }
        
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActivateForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllowFormClosing();
            this.Close();
            Process.GetCurrentProcess().Kill();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ActivateForm();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowFormClosing)
            {
                if(core.IsCapturing())
                    btnCapture_Click(null, null);
                return;
            }
            allowFormClosing = false;
            e.Cancel = true;
            HideForm();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = "Keyboard Heatmap is running ...";
            notifyIcon.ShowBalloonTip(300);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!core.IsCapturing())
            {
                lblStatus.Text = "Capturing ...";
                btnCapture.Text = "Stop";
                btnSaveToFile.Enabled = false;
                grdResults.Rows.Clear();
                core.StartCapture();
            }
            else
            {
                lblStatus.Text = "Results";
                btnCapture.Text = "Start";
                btnSaveToFile.Enabled = true;
                SuspendLayout();
                grdResults.Rows.Add("TotalClicks", core.TotalClicks());
                foreach (var res in core.Results())
                    grdResults.Rows.Add(res.Key, res.Value);
                grdResults.Sort(grdResults.Columns[1], ListSortDirection.Descending);
                core.StopCapture();
                ResumeLayout();
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                SaveFormat format;
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName)?.ToLower();
                format = SaveFormat.TXT;
                if (ext == ".csv")
                    format = SaveFormat.CSV;
                
                core.SaveToFile(saveFileDialog.FileName, format, true, false);

                MessageBox.Show("Successful !!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch{
                MessageBox.Show("ERROR !!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}