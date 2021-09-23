using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private bool capturing => keyboardCapture.IsCapturing;
        private IKeyboardCapture keyboardCapture;
        public bool Hidden { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            notifyIcon.Visible = true;
            keyboardCapture = new KeyboardCapture();
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
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ActivateForm();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowFormClosing)
            {
                if(capturing)
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
            if (!capturing)
            {
                lblStatus.Text = "Capturing ...";
                btnCapture.Text = "Stop";
                btnSaveToFile.Enabled = false;
                grdResults.Rows.Clear();
                keyboardCapture.Start();
            }
            else
            {
                lblStatus.Text = "Results";
                btnCapture.Text = "Start";
                btnSaveToFile.Enabled = true;
                SuspendLayout();
                grdResults.Rows.Add("TotalClicks", keyboardCapture.Results().TotalClicks());
                foreach (var res in keyboardCapture.Results().Results())
                    grdResults.Rows.Add(res.Key, res.Value);
                grdResults.Sort(grdResults.Columns[1], ListSortDirection.Descending);
                ResumeLayout();
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                IWriter writer = new FileWriter(saveFileDialog.FileName);

                writer.AddLine("Key,Count");
                writer.AddLine($"TotalClicks,{keyboardCapture.Results().TotalClicks()}");

                var result = keyboardCapture.Results().Results();
                List<KeyValuePair<KeyCode, int>> lst = result.ToList();
                lst.Sort((a, b) => a.Value.CompareTo(b.Value));

                for(int i=lst.Count-1; i>=0; i--)
                    writer.AddLine($"{lst[i].Key},{lst[i].Value}");

                writer.WriteToDisk();

                MessageBox.Show("Successful !!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch{
                MessageBox.Show("ERROR !!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}