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
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            autoStartCheckBox.Checked = ShortcutProvider.ShortcutExists();
            autoUpdateCheckBox.Checked = Settings.Main.UpdateOnStartup;
            rememberTimeStampCheckBox.Checked = Settings.Main.SaveTimestamp;
            timeDifferenceCheckBox.Enabled = rememberTimeStampCheckBox.Checked;
            timeDifferenceCheckBox.Checked = Settings.Main.SaveDifference;
        }

        private void autoStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStartCheckBox.Checked)
                ShortcutProvider.CreateShortcut();
            else
                ShortcutProvider.DeleteShortcut();
        }
        
        private void autoUpdateCheckBox_CheckedChanged(object sender, EventArgs e) => Settings.Main.UpdateOnStartup = autoUpdateCheckBox.Checked;

        private void rememberTimeStampCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Main.SaveTimestamp = rememberTimeStampCheckBox.Checked;
            timeDifferenceCheckBox.Enabled = rememberTimeStampCheckBox.Checked;
            if (Application.OpenForms[0] is MainForm)
                (Application.OpenForms[0] as MainForm).SaveTimestamp();
        }

        private void timeDifferenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Main.SaveDifference = timeDifferenceCheckBox.Checked;
            if (Application.OpenForms[0] is MainForm)
                (Application.OpenForms[0] as MainForm).SaveTimestamp();
        }
    }
}
