﻿namespace RichPresenceTest
{
    partial class PreferencesForm
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
            this.components = new System.ComponentModel.Container();
            this.startupSettingsBox = new System.Windows.Forms.GroupBox();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.timeSettingsBox = new System.Windows.Forms.GroupBox();
            this.timeDifferenceCheckBox = new System.Windows.Forms.CheckBox();
            this.rememberTimeStampCheckBox = new System.Windows.Forms.CheckBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.startupSettingsBox.SuspendLayout();
            this.timeSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startupSettingsBox
            // 
            this.startupSettingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startupSettingsBox.Controls.Add(this.autoUpdateCheckBox);
            this.startupSettingsBox.Controls.Add(this.autoStartCheckBox);
            this.startupSettingsBox.Location = new System.Drawing.Point(13, 13);
            this.startupSettingsBox.Name = "startupSettingsBox";
            this.startupSettingsBox.Size = new System.Drawing.Size(445, 66);
            this.startupSettingsBox.TabIndex = 0;
            this.startupSettingsBox.TabStop = false;
            this.startupSettingsBox.Text = "Startup Settings";
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(6, 42);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(215, 17);
            this.autoUpdateCheckBox.TabIndex = 1;
            this.autoUpdateCheckBox.Text = "Update Rich Presence status on startup";
            this.tooltip.SetToolTip(this.autoUpdateCheckBox, "Updates your rich presence status whenever the application starts.");
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.autoUpdateCheckBox_CheckedChanged);
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(6, 19);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(179, 17);
            this.autoStartCheckBox.TabIndex = 0;
            this.autoStartCheckBox.Text = "Startup when Windows starts up";
            this.tooltip.SetToolTip(this.autoStartCheckBox, "Creates a shortcut in the Windows startup folder.");
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            this.autoStartCheckBox.CheckedChanged += new System.EventHandler(this.autoStartCheckBox_CheckedChanged);
            // 
            // timeSettingsBox
            // 
            this.timeSettingsBox.Controls.Add(this.timeDifferenceCheckBox);
            this.timeSettingsBox.Controls.Add(this.rememberTimeStampCheckBox);
            this.timeSettingsBox.Location = new System.Drawing.Point(13, 86);
            this.timeSettingsBox.Name = "timeSettingsBox";
            this.timeSettingsBox.Size = new System.Drawing.Size(445, 64);
            this.timeSettingsBox.TabIndex = 1;
            this.timeSettingsBox.TabStop = false;
            this.timeSettingsBox.Text = "Time Settings";
            // 
            // timeDifferenceCheckBox
            // 
            this.timeDifferenceCheckBox.AutoSize = true;
            this.timeDifferenceCheckBox.Location = new System.Drawing.Point(6, 42);
            this.timeDifferenceCheckBox.Name = "timeDifferenceCheckBox";
            this.timeDifferenceCheckBox.Size = new System.Drawing.Size(101, 17);
            this.timeDifferenceCheckBox.TabIndex = 1;
            this.timeDifferenceCheckBox.Text = "Save difference";
            this.tooltip.SetToolTip(this.timeDifferenceCheckBox, "Causes the time difference to be saved rather than the actual time.\r\ni.e. it\'s cu" +
        "rrently 3:20 PM and you set the time to 3:40 PM, it\'ll save it as a 20 minute di" +
        "fference rather than the exact time.");
            this.timeDifferenceCheckBox.UseVisualStyleBackColor = true;
            this.timeDifferenceCheckBox.CheckedChanged += new System.EventHandler(this.timeDifferenceCheckBox_CheckedChanged);
            // 
            // rememberTimeStampCheckBox
            // 
            this.rememberTimeStampCheckBox.AutoSize = true;
            this.rememberTimeStampCheckBox.Location = new System.Drawing.Point(6, 19);
            this.rememberTimeStampCheckBox.Name = "rememberTimeStampCheckBox";
            this.rememberTimeStampCheckBox.Size = new System.Drawing.Size(131, 17);
            this.rememberTimeStampCheckBox.TabIndex = 0;
            this.rememberTimeStampCheckBox.Text = "Remember Timestamp";
            this.tooltip.SetToolTip(this.rememberTimeStampCheckBox, "Causes the set time to be remembered.");
            this.rememberTimeStampCheckBox.UseVisualStyleBackColor = true;
            this.rememberTimeStampCheckBox.CheckedChanged += new System.EventHandler(this.rememberTimeStampCheckBox_CheckedChanged);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 232);
            this.Controls.Add(this.timeSettingsBox);
            this.Controls.Add(this.startupSettingsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.ShowIcon = false;
            this.Text = "PreferencesForm";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this.startupSettingsBox.ResumeLayout(false);
            this.startupSettingsBox.PerformLayout();
            this.timeSettingsBox.ResumeLayout(false);
            this.timeSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox startupSettingsBox;
        private System.Windows.Forms.CheckBox autoStartCheckBox;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.GroupBox timeSettingsBox;
        private System.Windows.Forms.CheckBox rememberTimeStampCheckBox;
        private System.Windows.Forms.CheckBox timeDifferenceCheckBox;
        private System.Windows.Forms.ToolTip tooltip;
    }
}