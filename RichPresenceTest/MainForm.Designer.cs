namespace RichPresenceTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.applicationBox = new System.Windows.Forms.GroupBox();
            this.newAppGroup = new System.Windows.Forms.GroupBox();
            this.addAppButton = new System.Windows.Forms.Button();
            this.appIdLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.appIdTextBox = new System.Windows.Forms.TextBox();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.newAppLabel = new System.Windows.Forms.Label();
            this.curAppGroup = new System.Windows.Forms.GroupBox();
            this.currentAppIdLabel = new System.Windows.Forms.Label();
            this.removeAppButton = new System.Windows.Forms.Button();
            this.appBox = new System.Windows.Forms.ComboBox();
            this.curAppLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.GroupBox();
            this.removeSmallIconButton = new System.Windows.Forms.Button();
            this.removeLargeIconButton = new System.Windows.Forms.Button();
            this.smallIconBox = new System.Windows.Forms.ComboBox();
            this.smallIconLabel = new System.Windows.Forms.Label();
            this.largeIconBox = new System.Windows.Forms.ComboBox();
            this.largeIconLabel = new System.Windows.Forms.Label();
            this.addIconBox = new System.Windows.Forms.GroupBox();
            this.addIconButton = new System.Windows.Forms.Button();
            this.largeIconRadioButton = new System.Windows.Forms.RadioButton();
            this.smallIconRadioButton = new System.Windows.Forms.RadioButton();
            this.iconNameTextBox = new System.Windows.Forms.TextBox();
            this.iconNameLabel = new System.Windows.Forms.Label();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.smallIconTextLabel = new System.Windows.Forms.Label();
            this.smallIconTextBox = new System.Windows.Forms.TextBox();
            this.largeIconTextBox = new System.Windows.Forms.TextBox();
            this.largeIconTextLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.partyBox = new System.Windows.Forms.GroupBox();
            this.partyMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.partyMaxLabel = new System.Windows.Forms.Label();
            this.partySizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.partySizeLabel = new System.Windows.Forms.Label();
            this.partyCheckBox = new System.Windows.Forms.CheckBox();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.endTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.currentDateTimeEndButton = new System.Windows.Forms.Button();
            this.dateTimeEndPicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.currentDateTimeButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.applicationBox.SuspendLayout();
            this.newAppGroup.SuspendLayout();
            this.curAppGroup.SuspendLayout();
            this.iconBox.SuspendLayout();
            this.addIconBox.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.partyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySizeNumeric)).BeginInit();
            this.timeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationBox
            // 
            this.applicationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationBox.Controls.Add(this.newAppGroup);
            this.applicationBox.Controls.Add(this.curAppGroup);
            this.applicationBox.Location = new System.Drawing.Point(13, 13);
            this.applicationBox.Name = "applicationBox";
            this.applicationBox.Size = new System.Drawing.Size(431, 141);
            this.applicationBox.TabIndex = 0;
            this.applicationBox.TabStop = false;
            this.applicationBox.Text = "Application";
            // 
            // newAppGroup
            // 
            this.newAppGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newAppGroup.Controls.Add(this.addAppButton);
            this.newAppGroup.Controls.Add(this.appIdLabel);
            this.newAppGroup.Controls.Add(this.appNameLabel);
            this.newAppGroup.Controls.Add(this.appIdTextBox);
            this.newAppGroup.Controls.Add(this.appNameTextBox);
            this.newAppGroup.Controls.Add(this.newAppLabel);
            this.newAppGroup.Location = new System.Drawing.Point(188, 20);
            this.newAppGroup.Name = "newAppGroup";
            this.newAppGroup.Size = new System.Drawing.Size(237, 115);
            this.newAppGroup.TabIndex = 1;
            this.newAppGroup.TabStop = false;
            // 
            // addAppButton
            // 
            this.addAppButton.Enabled = false;
            this.addAppButton.Location = new System.Drawing.Point(7, 86);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(224, 23);
            this.addAppButton.TabIndex = 7;
            this.addAppButton.Text = "Add";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // appIdLabel
            // 
            this.appIdLabel.AutoSize = true;
            this.appIdLabel.Location = new System.Drawing.Point(6, 53);
            this.appIdLabel.Name = "appIdLabel";
            this.appIdLabel.Size = new System.Drawing.Size(43, 13);
            this.appIdLabel.TabIndex = 6;
            this.appIdLabel.Text = "App ID:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Location = new System.Drawing.Point(6, 23);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(60, 13);
            this.appNameLabel.TabIndex = 5;
            this.appNameLabel.Text = "App Name:";
            // 
            // appIdTextBox
            // 
            this.appIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appIdTextBox.Location = new System.Drawing.Point(82, 46);
            this.appIdTextBox.Name = "appIdTextBox";
            this.appIdTextBox.Size = new System.Drawing.Size(149, 20);
            this.appIdTextBox.TabIndex = 4;
            this.appIdTextBox.TextChanged += new System.EventHandler(this.appIdTextBox_TextChanged);
            this.appIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appIdTextBox_KeyPress);
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameTextBox.Location = new System.Drawing.Point(82, 20);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.appNameTextBox.TabIndex = 3;
            this.appNameTextBox.TextChanged += new System.EventHandler(this.appNameTextBox_TextChanged);
            // 
            // newAppLabel
            // 
            this.newAppLabel.AutoSize = true;
            this.newAppLabel.Location = new System.Drawing.Point(6, 0);
            this.newAppLabel.Name = "newAppLabel";
            this.newAppLabel.Size = new System.Drawing.Size(87, 13);
            this.newAppLabel.TabIndex = 2;
            this.newAppLabel.Text = "New Application:";
            // 
            // curAppGroup
            // 
            this.curAppGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.curAppGroup.Controls.Add(this.currentAppIdLabel);
            this.curAppGroup.Controls.Add(this.removeAppButton);
            this.curAppGroup.Controls.Add(this.appBox);
            this.curAppGroup.Controls.Add(this.curAppLabel);
            this.curAppGroup.Location = new System.Drawing.Point(7, 20);
            this.curAppGroup.Name = "curAppGroup";
            this.curAppGroup.Size = new System.Drawing.Size(177, 115);
            this.curAppGroup.TabIndex = 0;
            this.curAppGroup.TabStop = false;
            // 
            // currentAppIdLabel
            // 
            this.currentAppIdLabel.AutoSize = true;
            this.currentAppIdLabel.Location = new System.Drawing.Point(6, 46);
            this.currentAppIdLabel.Name = "currentAppIdLabel";
            this.currentAppIdLabel.Size = new System.Drawing.Size(27, 13);
            this.currentAppIdLabel.TabIndex = 3;
            this.currentAppIdLabel.Text = "N/A";
            // 
            // removeAppButton
            // 
            this.removeAppButton.Enabled = false;
            this.removeAppButton.Location = new System.Drawing.Point(6, 86);
            this.removeAppButton.Name = "removeAppButton";
            this.removeAppButton.Size = new System.Drawing.Size(164, 23);
            this.removeAppButton.TabIndex = 2;
            this.removeAppButton.Text = "Remove";
            this.removeAppButton.UseVisualStyleBackColor = true;
            this.removeAppButton.Click += new System.EventHandler(this.removeAppButton_Click);
            // 
            // appBox
            // 
            this.appBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appBox.FormattingEnabled = true;
            this.appBox.Location = new System.Drawing.Point(6, 19);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(164, 21);
            this.appBox.TabIndex = 1;
            this.appBox.SelectedIndexChanged += new System.EventHandler(this.appBox_SelectedIndexChanged);
            // 
            // curAppLabel
            // 
            this.curAppLabel.AutoSize = true;
            this.curAppLabel.Location = new System.Drawing.Point(6, 0);
            this.curAppLabel.Name = "curAppLabel";
            this.curAppLabel.Size = new System.Drawing.Size(99, 13);
            this.curAppLabel.TabIndex = 0;
            this.curAppLabel.Text = "Current Application:";
            // 
            // iconBox
            // 
            this.iconBox.Controls.Add(this.removeSmallIconButton);
            this.iconBox.Controls.Add(this.removeLargeIconButton);
            this.iconBox.Controls.Add(this.smallIconBox);
            this.iconBox.Controls.Add(this.smallIconLabel);
            this.iconBox.Controls.Add(this.largeIconBox);
            this.iconBox.Controls.Add(this.largeIconLabel);
            this.iconBox.Controls.Add(this.addIconBox);
            this.iconBox.Enabled = false;
            this.iconBox.Location = new System.Drawing.Point(13, 155);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(431, 140);
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            this.iconBox.Text = "Icons";
            // 
            // removeSmallIconButton
            // 
            this.removeSmallIconButton.Enabled = false;
            this.removeSmallIconButton.Location = new System.Drawing.Point(158, 78);
            this.removeSmallIconButton.Name = "removeSmallIconButton";
            this.removeSmallIconButton.Size = new System.Drawing.Size(24, 23);
            this.removeSmallIconButton.TabIndex = 6;
            this.removeSmallIconButton.Text = "X";
            this.removeSmallIconButton.UseVisualStyleBackColor = true;
            this.removeSmallIconButton.Click += new System.EventHandler(this.removeSmallIconButton_Click);
            // 
            // removeLargeIconButton
            // 
            this.removeLargeIconButton.Enabled = false;
            this.removeLargeIconButton.Location = new System.Drawing.Point(158, 34);
            this.removeLargeIconButton.Name = "removeLargeIconButton";
            this.removeLargeIconButton.Size = new System.Drawing.Size(24, 23);
            this.removeLargeIconButton.TabIndex = 5;
            this.removeLargeIconButton.Text = "X";
            this.removeLargeIconButton.UseVisualStyleBackColor = true;
            this.removeLargeIconButton.Click += new System.EventHandler(this.removeLargeIconButton_Click);
            // 
            // smallIconBox
            // 
            this.smallIconBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smallIconBox.FormattingEnabled = true;
            this.smallIconBox.Location = new System.Drawing.Point(13, 79);
            this.smallIconBox.Name = "smallIconBox";
            this.smallIconBox.Size = new System.Drawing.Size(139, 21);
            this.smallIconBox.TabIndex = 4;
            this.smallIconBox.SelectedIndexChanged += new System.EventHandler(this.smallIconBox_SelectedIndexChanged);
            // 
            // smallIconLabel
            // 
            this.smallIconLabel.AutoSize = true;
            this.smallIconLabel.Location = new System.Drawing.Point(13, 62);
            this.smallIconLabel.Name = "smallIconLabel";
            this.smallIconLabel.Size = new System.Drawing.Size(56, 13);
            this.smallIconLabel.TabIndex = 3;
            this.smallIconLabel.Text = "Small Icon";
            // 
            // largeIconBox
            // 
            this.largeIconBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.largeIconBox.FormattingEnabled = true;
            this.largeIconBox.Location = new System.Drawing.Point(13, 35);
            this.largeIconBox.Name = "largeIconBox";
            this.largeIconBox.Size = new System.Drawing.Size(139, 21);
            this.largeIconBox.TabIndex = 2;
            this.largeIconBox.SelectedIndexChanged += new System.EventHandler(this.largeIconBox_SelectedIndexChanged);
            // 
            // largeIconLabel
            // 
            this.largeIconLabel.AutoSize = true;
            this.largeIconLabel.Location = new System.Drawing.Point(13, 19);
            this.largeIconLabel.Name = "largeIconLabel";
            this.largeIconLabel.Size = new System.Drawing.Size(61, 13);
            this.largeIconLabel.TabIndex = 1;
            this.largeIconLabel.Text = "Large Icon:";
            // 
            // addIconBox
            // 
            this.addIconBox.Controls.Add(this.addIconButton);
            this.addIconBox.Controls.Add(this.largeIconRadioButton);
            this.addIconBox.Controls.Add(this.smallIconRadioButton);
            this.addIconBox.Controls.Add(this.iconNameTextBox);
            this.addIconBox.Controls.Add(this.iconNameLabel);
            this.addIconBox.Location = new System.Drawing.Point(188, 19);
            this.addIconBox.Name = "addIconBox";
            this.addIconBox.Size = new System.Drawing.Size(237, 115);
            this.addIconBox.TabIndex = 0;
            this.addIconBox.TabStop = false;
            this.addIconBox.Text = "New Icon";
            // 
            // addIconButton
            // 
            this.addIconButton.Enabled = false;
            this.addIconButton.Location = new System.Drawing.Point(7, 86);
            this.addIconButton.Name = "addIconButton";
            this.addIconButton.Size = new System.Drawing.Size(224, 23);
            this.addIconButton.TabIndex = 4;
            this.addIconButton.Text = "Add";
            this.addIconButton.UseVisualStyleBackColor = true;
            this.addIconButton.Click += new System.EventHandler(this.addIconButton_Click);
            // 
            // largeIconRadioButton
            // 
            this.largeIconRadioButton.AutoSize = true;
            this.largeIconRadioButton.Location = new System.Drawing.Point(9, 66);
            this.largeIconRadioButton.Name = "largeIconRadioButton";
            this.largeIconRadioButton.Size = new System.Drawing.Size(76, 17);
            this.largeIconRadioButton.TabIndex = 3;
            this.largeIconRadioButton.TabStop = true;
            this.largeIconRadioButton.Text = "Large Icon";
            this.largeIconRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallIconRadioButton
            // 
            this.smallIconRadioButton.AutoSize = true;
            this.smallIconRadioButton.Checked = true;
            this.smallIconRadioButton.Location = new System.Drawing.Point(9, 43);
            this.smallIconRadioButton.Name = "smallIconRadioButton";
            this.smallIconRadioButton.Size = new System.Drawing.Size(74, 17);
            this.smallIconRadioButton.TabIndex = 2;
            this.smallIconRadioButton.TabStop = true;
            this.smallIconRadioButton.Text = "Small Icon";
            this.smallIconRadioButton.UseVisualStyleBackColor = true;
            // 
            // iconNameTextBox
            // 
            this.iconNameTextBox.Location = new System.Drawing.Point(82, 17);
            this.iconNameTextBox.MaxLength = 32;
            this.iconNameTextBox.Name = "iconNameTextBox";
            this.iconNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.iconNameTextBox.TabIndex = 1;
            this.iconNameTextBox.TextChanged += new System.EventHandler(this.iconNameTextBox_TextChanged);
            // 
            // iconNameLabel
            // 
            this.iconNameLabel.AutoSize = true;
            this.iconNameLabel.Location = new System.Drawing.Point(9, 20);
            this.iconNameLabel.Name = "iconNameLabel";
            this.iconNameLabel.Size = new System.Drawing.Size(62, 13);
            this.iconNameLabel.TabIndex = 0;
            this.iconNameLabel.Text = "Icon Name:";
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.smallIconTextLabel);
            this.textGroupBox.Controls.Add(this.smallIconTextBox);
            this.textGroupBox.Controls.Add(this.largeIconTextBox);
            this.textGroupBox.Controls.Add(this.largeIconTextLabel);
            this.textGroupBox.Controls.Add(this.stateTextBox);
            this.textGroupBox.Controls.Add(this.stateLabel);
            this.textGroupBox.Controls.Add(this.detailsTextBox);
            this.textGroupBox.Controls.Add(this.detailsLabel);
            this.textGroupBox.Enabled = false;
            this.textGroupBox.Location = new System.Drawing.Point(13, 302);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(431, 121);
            this.textGroupBox.TabIndex = 2;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Text";
            // 
            // smallIconTextLabel
            // 
            this.smallIconTextLabel.AutoSize = true;
            this.smallIconTextLabel.Location = new System.Drawing.Point(13, 97);
            this.smallIconTextLabel.Name = "smallIconTextLabel";
            this.smallIconTextLabel.Size = new System.Drawing.Size(83, 13);
            this.smallIconTextLabel.TabIndex = 7;
            this.smallIconTextLabel.Text = "Small Icon Text:";
            // 
            // smallIconTextBox
            // 
            this.smallIconTextBox.Enabled = false;
            this.smallIconTextBox.Location = new System.Drawing.Point(104, 94);
            this.smallIconTextBox.MaxLength = 128;
            this.smallIconTextBox.Name = "smallIconTextBox";
            this.smallIconTextBox.Size = new System.Drawing.Size(321, 20);
            this.smallIconTextBox.TabIndex = 6;
            this.smallIconTextBox.TextChanged += new System.EventHandler(this.smallIconTextBox_TextChanged);
            // 
            // largeIconTextBox
            // 
            this.largeIconTextBox.Enabled = false;
            this.largeIconTextBox.Location = new System.Drawing.Point(104, 67);
            this.largeIconTextBox.MaxLength = 128;
            this.largeIconTextBox.Name = "largeIconTextBox";
            this.largeIconTextBox.Size = new System.Drawing.Size(321, 20);
            this.largeIconTextBox.TabIndex = 5;
            this.largeIconTextBox.TextChanged += new System.EventHandler(this.largeIconTextBox_TextChanged);
            // 
            // largeIconTextLabel
            // 
            this.largeIconTextLabel.AutoSize = true;
            this.largeIconTextLabel.Location = new System.Drawing.Point(13, 70);
            this.largeIconTextLabel.Name = "largeIconTextLabel";
            this.largeIconTextLabel.Size = new System.Drawing.Size(85, 13);
            this.largeIconTextLabel.TabIndex = 4;
            this.largeIconTextLabel.Text = "Large Icon Text:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(104, 40);
            this.stateTextBox.MaxLength = 128;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(321, 20);
            this.stateTextBox.TabIndex = 3;
            this.stateTextBox.TextChanged += new System.EventHandler(this.stateTextBox_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(13, 43);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(104, 13);
            this.detailsTextBox.MaxLength = 128;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(321, 20);
            this.detailsTextBox.TabIndex = 1;
            this.detailsTextBox.TextChanged += new System.EventHandler(this.detailsTextBox_TextChanged);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(13, 16);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(42, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Details:";
            // 
            // partyBox
            // 
            this.partyBox.Controls.Add(this.partyMaxNumeric);
            this.partyBox.Controls.Add(this.partyMaxLabel);
            this.partyBox.Controls.Add(this.partySizeNumeric);
            this.partyBox.Controls.Add(this.partySizeLabel);
            this.partyBox.Controls.Add(this.partyCheckBox);
            this.partyBox.Enabled = false;
            this.partyBox.Location = new System.Drawing.Point(13, 430);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(98, 94);
            this.partyBox.TabIndex = 3;
            this.partyBox.TabStop = false;
            // 
            // partyMaxNumeric
            // 
            this.partyMaxNumeric.Location = new System.Drawing.Point(47, 45);
            this.partyMaxNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.partyMaxNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyMaxNumeric.Name = "partyMaxNumeric";
            this.partyMaxNumeric.Size = new System.Drawing.Size(44, 20);
            this.partyMaxNumeric.TabIndex = 4;
            this.partyMaxNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyMaxNumeric.ValueChanged += new System.EventHandler(this.partyMaxNumeric_ValueChanged);
            // 
            // partyMaxLabel
            // 
            this.partyMaxLabel.AutoSize = true;
            this.partyMaxLabel.Location = new System.Drawing.Point(16, 47);
            this.partyMaxLabel.Name = "partyMaxLabel";
            this.partyMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.partyMaxLabel.TabIndex = 3;
            this.partyMaxLabel.Text = "Max:";
            // 
            // partySizeNumeric
            // 
            this.partySizeNumeric.Location = new System.Drawing.Point(47, 22);
            this.partySizeNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.partySizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partySizeNumeric.Name = "partySizeNumeric";
            this.partySizeNumeric.Size = new System.Drawing.Size(44, 20);
            this.partySizeNumeric.TabIndex = 2;
            this.partySizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // partySizeLabel
            // 
            this.partySizeLabel.AutoSize = true;
            this.partySizeLabel.Location = new System.Drawing.Point(16, 25);
            this.partySizeLabel.Name = "partySizeLabel";
            this.partySizeLabel.Size = new System.Drawing.Size(30, 13);
            this.partySizeLabel.TabIndex = 1;
            this.partySizeLabel.Text = "Size:";
            // 
            // partyCheckBox
            // 
            this.partyCheckBox.AutoSize = true;
            this.partyCheckBox.Location = new System.Drawing.Point(7, 1);
            this.partyCheckBox.Name = "partyCheckBox";
            this.partyCheckBox.Size = new System.Drawing.Size(50, 17);
            this.partyCheckBox.TabIndex = 0;
            this.partyCheckBox.Text = "Party";
            this.partyCheckBox.UseVisualStyleBackColor = true;
            this.partyCheckBox.CheckedChanged += new System.EventHandler(this.partyCheckBox_CheckedChanged);
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.endTimeCheckBox);
            this.timeBox.Controls.Add(this.currentDateTimeEndButton);
            this.timeBox.Controls.Add(this.dateTimeEndPicker);
            this.timeBox.Controls.Add(this.startTimeCheckBox);
            this.timeBox.Controls.Add(this.currentDateTimeButton);
            this.timeBox.Controls.Add(this.dateTimePicker);
            this.timeBox.Location = new System.Drawing.Point(118, 431);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(326, 93);
            this.timeBox.TabIndex = 4;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Time";
            // 
            // endTimeCheckBox
            // 
            this.endTimeCheckBox.AutoSize = true;
            this.endTimeCheckBox.Location = new System.Drawing.Point(165, 20);
            this.endTimeCheckBox.Name = "endTimeCheckBox";
            this.endTimeCheckBox.Size = new System.Drawing.Size(71, 17);
            this.endTimeCheckBox.TabIndex = 6;
            this.endTimeCheckBox.Text = "End Time";
            this.endTimeCheckBox.UseVisualStyleBackColor = true;
            this.endTimeCheckBox.CheckedChanged += new System.EventHandler(this.endTimeCheckBox_CheckedChanged);
            // 
            // currentDateTimeEndButton
            // 
            this.currentDateTimeEndButton.Enabled = false;
            this.currentDateTimeEndButton.Location = new System.Drawing.Point(165, 62);
            this.currentDateTimeEndButton.Name = "currentDateTimeEndButton";
            this.currentDateTimeEndButton.Size = new System.Drawing.Size(153, 25);
            this.currentDateTimeEndButton.TabIndex = 5;
            this.currentDateTimeEndButton.Text = "Reset";
            this.currentDateTimeEndButton.UseVisualStyleBackColor = true;
            this.currentDateTimeEndButton.Click += new System.EventHandler(this.currentDateTimeEndButton_Click);
            // 
            // dateTimeEndPicker
            // 
            this.dateTimeEndPicker.Checked = false;
            this.dateTimeEndPicker.CustomFormat = "MMM dd yyyy HH:mm:ss";
            this.dateTimeEndPicker.Enabled = false;
            this.dateTimeEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEndPicker.Location = new System.Drawing.Point(165, 39);
            this.dateTimeEndPicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimeEndPicker.Name = "dateTimeEndPicker";
            this.dateTimeEndPicker.Size = new System.Drawing.Size(155, 20);
            this.dateTimeEndPicker.TabIndex = 4;
            // 
            // startTimeCheckBox
            // 
            this.startTimeCheckBox.AutoSize = true;
            this.startTimeCheckBox.Location = new System.Drawing.Point(6, 20);
            this.startTimeCheckBox.Name = "startTimeCheckBox";
            this.startTimeCheckBox.Size = new System.Drawing.Size(74, 17);
            this.startTimeCheckBox.TabIndex = 3;
            this.startTimeCheckBox.Text = "Start Time";
            this.startTimeCheckBox.UseVisualStyleBackColor = true;
            this.startTimeCheckBox.CheckedChanged += new System.EventHandler(this.startTimeCheckBox_CheckedChanged);
            // 
            // currentDateTimeButton
            // 
            this.currentDateTimeButton.Enabled = false;
            this.currentDateTimeButton.Location = new System.Drawing.Point(6, 62);
            this.currentDateTimeButton.Name = "currentDateTimeButton";
            this.currentDateTimeButton.Size = new System.Drawing.Size(153, 25);
            this.currentDateTimeButton.TabIndex = 2;
            this.currentDateTimeButton.Text = "Reset";
            this.currentDateTimeButton.UseVisualStyleBackColor = true;
            this.currentDateTimeButton.Click += new System.EventHandler(this.currentDateTimeButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "MMM dd yyyy HH:mm:ss";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 39);
            this.dateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(13, 530);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(212, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update Status";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(231, 530);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(213, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 565);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.partyBox);
            this.Controls.Add(this.textGroupBox);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.applicationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Rich Presence Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.applicationBox.ResumeLayout(false);
            this.newAppGroup.ResumeLayout(false);
            this.newAppGroup.PerformLayout();
            this.curAppGroup.ResumeLayout(false);
            this.curAppGroup.PerformLayout();
            this.iconBox.ResumeLayout(false);
            this.iconBox.PerformLayout();
            this.addIconBox.ResumeLayout(false);
            this.addIconBox.PerformLayout();
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.partyBox.ResumeLayout(false);
            this.partyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySizeNumeric)).EndInit();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox applicationBox;
        private System.Windows.Forms.Label curAppLabel;
        private System.Windows.Forms.ComboBox appBox;
        private System.Windows.Forms.GroupBox newAppGroup;
        private System.Windows.Forms.GroupBox curAppGroup;
        private System.Windows.Forms.Label newAppLabel;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.TextBox appIdTextBox;
        private System.Windows.Forms.Label appIdLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button removeAppButton;
        private System.Windows.Forms.Label currentAppIdLabel;
        private System.Windows.Forms.GroupBox iconBox;
        private System.Windows.Forms.GroupBox addIconBox;
        private System.Windows.Forms.Label iconNameLabel;
        private System.Windows.Forms.TextBox iconNameTextBox;
        private System.Windows.Forms.RadioButton largeIconRadioButton;
        private System.Windows.Forms.RadioButton smallIconRadioButton;
        private System.Windows.Forms.Button addIconButton;
        private System.Windows.Forms.Label largeIconLabel;
        private System.Windows.Forms.ComboBox largeIconBox;
        private System.Windows.Forms.Label smallIconLabel;
        private System.Windows.Forms.ComboBox smallIconBox;
        private System.Windows.Forms.Button removeSmallIconButton;
        private System.Windows.Forms.Button removeLargeIconButton;
        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox largeIconTextBox;
        private System.Windows.Forms.Label largeIconTextLabel;
        private System.Windows.Forms.TextBox smallIconTextBox;
        private System.Windows.Forms.Label smallIconTextLabel;
        private System.Windows.Forms.GroupBox partyBox;
        private System.Windows.Forms.CheckBox partyCheckBox;
        private System.Windows.Forms.Label partySizeLabel;
        private System.Windows.Forms.NumericUpDown partySizeNumeric;
        private System.Windows.Forms.NumericUpDown partyMaxNumeric;
        private System.Windows.Forms.Label partyMaxLabel;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button currentDateTimeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.DateTimePicker dateTimeEndPicker;
        private System.Windows.Forms.CheckBox startTimeCheckBox;
        private System.Windows.Forms.CheckBox endTimeCheckBox;
        private System.Windows.Forms.Button currentDateTimeEndButton;
    }
}