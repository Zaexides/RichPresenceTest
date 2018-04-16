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
            latestLabel.Text = UpdateChecker.IsConnected ? UpdateChecker.LatestVersion : "???";
            stableLabel.Text = UpdateChecker.IsConnected ? UpdateChecker.LatestStableVersion : "???";

            updateAvailableLabel.Visible = !UpdateChecker.IsUpToDate;
            if(UpdateChecker.IsConnected)
                WriteChangelog(UpdateChecker.Changelogs);
            else
            {
                changelog.Clear();
                changelog.AppendText("Could not connect to the internet.");
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UpdateChecker.DOWNLOAD_URL);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteChangelog(UpdateChecker.UpdateData.Changelog[] changelogs)
        {
            changelog.Clear();

            changelog.AppendText("Changelog:");

            if (changelogs == null)
                return;

            foreach(var cl in changelogs)
            {
                changelog.AppendText($"\r\n\r\n");

                changelog.AppendText($"Version {cl.version}:\r\n");
                if (cl.changes != null)
                {
                    foreach (string change in cl.changes)
                    {
                        changelog.AppendText($" - {change}\r\n");
                    }
                }
            }
        }
    }
}
