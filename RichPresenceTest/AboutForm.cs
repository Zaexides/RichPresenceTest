using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RichPresenceTest
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            versionLabel.Text = UpdateChecker.CURRENT_VERSION;
            latestLabel.Text = UpdateChecker.LatestVersion;
            stableLabel.Text = UpdateChecker.LatestStableVersion;

            updateAvailableLabel.Visible = !UpdateChecker.IsUpToDate;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UpdateChecker.DOWNLOAD_URL);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
