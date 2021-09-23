using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboardHeatMap
{
    public partial class FrmMain : Form
    {
        private bool allowFormClosing = false;
        public bool Hidden { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            notifyIcon.Visible = true;
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
            //TODO: stop capturing
            AllowFormClosing();
            this.Close();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ActivateForm();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowFormClosing) return;
            allowFormClosing = false;
            e.Cancel = true;
            HideForm();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = "Keyboard Heatmap is running ...";
            notifyIcon.ShowBalloonTip(300);
        }
    }
}