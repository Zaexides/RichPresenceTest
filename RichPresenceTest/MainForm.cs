using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RichPresenceTest
{
    public partial class MainForm : Form
    {
        DiscordRpc.EventHandlers handlers;
        public static readonly DateTime unixDateTimeStart = new DateTime(1970, 1, 1).AddHours(1); //???!!?!?!
        private readonly bool autoStart = false;

        private Settings.Application CurrentApplication
        {
            get
            {
                if (Settings.Main.ApplicationCount == 0)
                    return null;
                else
                    return Settings.Main.GetApplication(appBox.SelectedIndex);
            }
        }

        public MainForm(bool fromAutoStartup)
        {
            UpdateChecker.CheckForUpdates();
            InitializeComponent();
            autoStart = fromAutoStartup;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnGroupCheckBox(partyCheckBox, partyBox);
            UnGroupCheckBox(timeCheckBox, timeBox);
            Settings.Load();
            int lastSelectedApplication = Settings.Main.LastSelectedApplication;
            SetupApplicationList();
            if(lastSelectedApplication != -1 && lastSelectedApplication < appBox.Items.Count)
                appBox.SelectedIndex = lastSelectedApplication;
            handlers = new DiscordRpc.EventHandlers();

            if (Settings.Main.UpdateOnStartup)
                updateButton_Click(this, new EventArgs());

            if (!UpdateChecker.IsUpToDate)
            {
                Font f = new Font(updatesToolStripMenuItem.Font, FontStyle.Bold);
                updatesToolStripMenuItem.Font = f;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DiscordRpc.Shutdown();
        }

        private void appIdTextBox_TextChanged(object sender, EventArgs e)
        {
            appIdTextBox.Text = new string(appIdTextBox.Text.Where(c => char.IsNumber(c)).ToArray());
            ValidateIfAddAppButtonShouldBeActivated();
        }

        private void appNameTextBox_TextChanged(object sender, EventArgs e) => ValidateIfAddAppButtonShouldBeActivated();

        private void ValidateIfAddAppButtonShouldBeActivated()
        {
            addAppButton.Enabled = ShouldButtonBeActive();
            if(addAppButton.Enabled)
            {
                if (Settings.Main.ContainsApplicationWithID(appIdTextBox.Text))
                    addAppButton.Text = "Rename";
                else
                    addAppButton.Text = "Add";
            }
        }

        private bool ShouldButtonBeActive()
        {
            if (appIdTextBox.Text != string.Empty)
            {
                if (appNameTextBox.Text != string.Empty)
                {
                    if (!Settings.Main.ContainsApplicationWithName(appNameTextBox.Text))
                        return true;
                }
            }
            return false;
        }

        private void SetupApplicationList()
        {
            appBox.Items.Clear();
            appBox.Items.AddRange(Settings.Main.GetApplicationArray());
            if (appBox.Items.Count > 0)
                appBox.SelectedIndex = 0;
            else
                appBox.SelectedIndex = -1;
            appBox_SelectedIndexChanged(null, null);
        }

        private void appIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void appBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeAppButton.Enabled = appBox.SelectedIndex != -1;
            iconBox.Enabled = appBox.SelectedIndex != -1;
            textGroupBox.Enabled = appBox.SelectedIndex != -1;
            updateButton.Enabled = appBox.SelectedIndex != -1;
            timeCheckBox.Enabled = appBox.SelectedIndex != -1;
            partyCheckBox.Enabled = appBox.SelectedIndex != -1;

            if (appBox.SelectedIndex == -1)
            {
                timeCheckBox.Checked = false;
                partyCheckBox.Checked = false;
            }

            Settings.Main.LastSelectedApplication = appBox.SelectedIndex;

            if (appBox.SelectedIndex == -1)
                currentAppIdLabel.Text = "N/A";
            else
                currentAppIdLabel.Text = Settings.Main.GetApplication(appBox.SelectedIndex).appId;

            int smallIconIndex = 0;
            int largeIconIndex = 0;
            if(CurrentApplication != null)
            {
                smallIconIndex = CurrentApplication.SmallIconIndex;
                largeIconIndex = CurrentApplication.LargeIconIndex;
            }

            SetupIconLists();

            if (CurrentApplication == null)
                return;
            smallIconBox.SelectedIndex = smallIconIndex;
            largeIconBox.SelectedIndex = largeIconIndex;
            stateTextBox.Text = CurrentApplication.StateText;
            detailsTextBox.Text = CurrentApplication.DetailsText;
            timeCheckBox.Checked = CurrentApplication.UseTime;
            endTimeRadioButton.Checked = CurrentApplication.UseEndTime;
            partyCheckBox.Checked = CurrentApplication.UseParty;
            partySizeNumeric.Value = CurrentApplication.PartySize;
            partyMaxNumeric.Value = CurrentApplication.PartyMax;

            if (Settings.Main.SaveTimestamp && CurrentApplication.TimeSetting != null)
                dateTimePicker.Value = CurrentApplication.TimeSetting.DateTime;
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            if (Settings.Main.ContainsApplicationWithID(appIdTextBox.Text))
                Settings.Main.RenameApplication(appIdTextBox.Text, appNameTextBox.Text);
            else
                Settings.Main.AddApplication(new Settings.Application(appNameTextBox.Text, appIdTextBox.Text));
            appNameTextBox.Text = string.Empty;
            appIdTextBox.Text = string.Empty;
            ValidateIfAddAppButtonShouldBeActivated();
            SetupApplicationList();
            appBox.SelectedIndex = appBox.Items.Count - 1;
        }

        private void removeAppButton_Click(object sender, EventArgs e)
        {
            Settings.Main.RemoveApplication(appBox.SelectedIndex);
            SetupApplicationList();
        }

        private void iconNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addIconButton.Enabled = iconNameTextBox.Text != string.Empty && !CurrentApplication.ContainsIconName(iconNameTextBox.Text);
        }

        private void addIconButton_Click(object sender, EventArgs e)
        {
            if (largeIconRadioButton.Checked)
                CurrentApplication.AddLargeIcon(iconNameTextBox.Text);
            else
                CurrentApplication.AddSmallIcon(iconNameTextBox.Text);
            iconNameTextBox.Text = string.Empty;
            SetupIconLists();

            if (largeIconRadioButton.Checked)
                largeIconBox.SelectedIndex = largeIconBox.Items.Count - 1;
            else
                smallIconBox.SelectedIndex = smallIconBox.Items.Count - 1;
        }

        private void SetupIconLists()
        {
            smallIconBox.Items.Clear();
            largeIconBox.Items.Clear();
            if (CurrentApplication == null)
                return;
            smallIconBox.Items.AddRange(CurrentApplication.SmallIconArray);
            largeIconBox.Items.AddRange(CurrentApplication.LargeIconArray);
            smallIconBox.SelectedIndex = 0;
            largeIconBox.SelectedIndex = 0;
        }

        private void removeLargeIconButton_Click(object sender, EventArgs e)
        {
            CurrentApplication.RemoveLargeIcon(largeIconBox.SelectedIndex);
            SetupIconLists();
        }

        private void removeSmallIconButton_Click(object sender, EventArgs e)
        {
            CurrentApplication.RemoveSmallIcon(smallIconBox.SelectedIndex);
            SetupIconLists();
        }

        private void largeIconBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentApplication.LargeIconIndex = largeIconBox.SelectedIndex;
            removeLargeIconButton.Enabled = largeIconBox.SelectedIndex > 0;
            largeIconTextBox.Enabled = largeIconBox.SelectedIndex > 0;
            if (largeIconTextBox.Enabled)
                largeIconTextBox.Text = CurrentApplication.GetLargeIconText(largeIconBox.SelectedIndex);
        }

        private void smallIconBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentApplication.SmallIconIndex = smallIconBox.SelectedIndex;
            removeSmallIconButton.Enabled = smallIconBox.SelectedIndex > 0;
            smallIconTextBox.Enabled = smallIconBox.SelectedIndex > 0;
            if (smallIconTextBox.Enabled)
                smallIconTextBox.Text = CurrentApplication.GetSmallIconText(smallIconBox.SelectedIndex);
        }

        private void detailsTextBox_TextChanged(object sender, EventArgs e) => CurrentApplication.DetailsText = detailsTextBox.Text;
        private void stateTextBox_TextChanged(object sender, EventArgs e) => CurrentApplication.StateText = stateTextBox.Text;
        private void largeIconTextBox_TextChanged(object sender, EventArgs e) => CurrentApplication.SetLargeIconText(largeIconBox.SelectedIndex, largeIconTextBox.Text);
        private void smallIconTextBox_TextChanged(object sender, EventArgs e) => CurrentApplication.SetSmallIconText(smallIconBox.SelectedIndex, smallIconTextBox.Text);

        private void partyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            partyBox.Enabled = partyCheckBox.Checked;
            CurrentApplication.UseParty = partyCheckBox.Checked;
        }

        private void UnGroupCheckBox(CheckBox checkBox, GroupBox groupBox)
        {
            Point checkboxLocation = checkBox.Location;
            groupBox.Parent.Controls.Add(checkBox);
            checkBox.Location = new Point(
                checkboxLocation.X + groupBox.Location.X,
                checkboxLocation.Y + groupBox.Location.Y
                );
            checkBox.BringToFront();
        }

        private void partyMaxNumeric_ValueChanged(object sender, EventArgs e)
        {
            partySizeNumeric.Maximum = partyMaxNumeric.Value;
            SetPartySizeSettings();
        }

        private void partySizeNumeric_ValueChanged(object sender, EventArgs e) => SetPartySizeSettings();

        private void SetPartySizeSettings()
        {
            CurrentApplication.SetParty(
                (int)partySizeNumeric.Value,
                (int)partyMaxNumeric.Value
                );
        }

        private void currentDateTimeButton_Click(object sender, EventArgs e) => dateTimePicker.Value = DateTime.Now;

        private void stopButton_Click(object sender, EventArgs e) => DiscordRpc.Shutdown();

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (CurrentApplication == null)
                return;

            DiscordRpc.Shutdown();
            DiscordRpc.Initialize(CurrentApplication.appId, ref handlers, false, string.Empty);

            DiscordRpc.RichPresence richPresence = new DiscordRpc.RichPresence();
            richPresence.details = detailsTextBox.Text;
            richPresence.state = stateTextBox.Text;

            if(largeIconBox.SelectedIndex > 0)
            {
                richPresence.largeImageKey = (string)largeIconBox.SelectedItem;
                richPresence.largeImageText = CurrentApplication.GetLargeIconText(largeIconBox.SelectedIndex);
            }
            if (smallIconBox.SelectedIndex > 0)
            {
                richPresence.smallImageKey = (string)smallIconBox.SelectedItem;
                richPresence.smallImageText = CurrentApplication.GetSmallIconText(smallIconBox.SelectedIndex);
            }

            if(partyCheckBox.Checked)
            {
                richPresence.partySize = (int)partySizeNumeric.Value;
                richPresence.partyMax = (int)partyMaxNumeric.Value;
            }

            if (timeCheckBox.Checked)
            {
                if (startTimeRadioButton.Checked)
                    richPresence.startTimestamp = (long)dateTimePicker.Value.Subtract(unixDateTimeStart).TotalSeconds;
                else if (endTimeRadioButton.Checked)
                    richPresence.endTimestamp = (long)dateTimePicker.Value.Subtract(unixDateTimeStart).TotalSeconds;
            }

            DiscordRpc.UpdatePresence(richPresence);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                Hide();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon.Visible = false;
                Show();
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e) => showToolStripMenuItem_Click(sender, e);

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void timeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            timeBox.Enabled = timeCheckBox.Checked;
            resetTimestampToolStripMenuItem.Enabled = timeCheckBox.Checked;
            if(CurrentApplication != null)
                CurrentApplication.UseTime = timeCheckBox.Checked;
        }

        private void endTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentApplication != null)
                CurrentApplication.UseEndTime = endTimeRadioButton.Checked;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => Application.Exit();

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if(!UpdateChecker.IsUpToDate)
                updatesToolStripMenuItem_Click(sender, e);
            else if(autoStart)
                WindowState = FormWindowState.Minimized;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) => updateButton_Click(sender, e);

        private void resetTimestampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDateTimeButton_Click(sender, e);
            updateButton_Click(sender, e);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.ShowDialog();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) => SaveTimestamp();

        public void SaveTimestamp()
        {
            if (Settings.Main.SaveTimestamp && CurrentApplication != null)
            {
                ITimeSetting timeSetting;
                if (Settings.Main.SaveDifference)
                    timeSetting = new TimeDifference();
                else
                    timeSetting = new TimeStamp();

                timeSetting.DateTime = dateTimePicker.Value;
                CurrentApplication.TimeSetting = timeSetting;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Settings.Main.MinimizeInsteadOfClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
