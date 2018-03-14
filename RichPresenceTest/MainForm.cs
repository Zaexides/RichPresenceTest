using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichPresenceTest
{
    public partial class MainForm : Form
    {
        DiscordRpc.EventHandlers handlers;
        private readonly DateTime unixDateTimeStart = new DateTime(1970, 1, 1).AddHours(1); //???!!?!?!

        private Settings.Application CurrentApplication
        {
            get
            {
                if (Settings.ApplicationCount == 0)
                    return null;
                else
                    return Settings.GetApplication(appBox.SelectedIndex);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnGroupCheckBox(partyCheckBox, partyBox);
            Settings.Load();
            SetupApplicationList();
            handlers = new DiscordRpc.EventHandlers();
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
                if (Settings.ContainsApplicationWithID(appIdTextBox.Text))
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
                    if (!Settings.ContainsApplicationWithName(appNameTextBox.Text))
                        return true;
                }
            }
            return false;
        }

        private void SetupApplicationList()
        {
            appBox.Items.Clear();
            appBox.Items.AddRange(Settings.GetApplicationArray());
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

            if (appBox.SelectedIndex == -1)
                currentAppIdLabel.Text = "N/A";
            else
                currentAppIdLabel.Text = Settings.GetApplication(appBox.SelectedIndex).appId;

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
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            if (Settings.ContainsApplicationWithID(appIdTextBox.Text))
                Settings.RenameApplication(appIdTextBox.Text, appNameTextBox.Text);
            else
                Settings.AddApplication(new Settings.Application(appNameTextBox.Text, appIdTextBox.Text));
            appNameTextBox.Text = string.Empty;
            appIdTextBox.Text = string.Empty;
            ValidateIfAddAppButtonShouldBeActivated();
            SetupApplicationList();
            appBox.SelectedIndex = appBox.Items.Count - 1;
        }

        private void removeAppButton_Click(object sender, EventArgs e)
        {
            Settings.RemoveApplication(appBox.SelectedIndex);
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
        private void partyCheckBox_CheckedChanged(object sender, EventArgs e) => partyBox.Enabled = partyCheckBox.Checked;

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
        }

        private void currentDateTimeButton_Click(object sender, EventArgs e) => dateTimePicker.Value = DateTime.Now;
        private void currentDateTimeEndButton_Click(object sender, EventArgs e) => dateTimeEndPicker.Value = DateTime.Now;

        private void stopButton_Click(object sender, EventArgs e) => DiscordRpc.Shutdown();

        private void updateButton_Click(object sender, EventArgs e)
        {
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

            if(startTimeCheckBox.Checked)
                richPresence.startTimestamp = (long)dateTimePicker.Value.Subtract(unixDateTimeStart).TotalSeconds;
            if (endTimeCheckBox.Checked)
                richPresence.endTimestamp = (long)dateTimeEndPicker.Value.Subtract(unixDateTimeStart).TotalSeconds;

            DiscordRpc.UpdatePresence(richPresence);
        }

        private void startTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = startTimeCheckBox.Checked;
            currentDateTimeButton.Enabled = startTimeCheckBox.Checked;
        }

        private void endTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeEndPicker.Enabled = endTimeCheckBox.Checked;
            currentDateTimeEndButton.Enabled = endTimeCheckBox.Checked;
        }
    }
}
