﻿namespace RSMods
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
            this.Songlist = new System.Windows.Forms.ListBox();
            this.ModList = new System.Windows.Forms.ListBox();
            this.ToggleLoftCheckbox = new System.Windows.Forms.CheckBox();
            this.AddVolumeCheckbox = new System.Windows.Forms.CheckBox();
            this.DecreaseVolumeCheckbox = new System.Windows.Forms.CheckBox();
            this.SongTimerCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveAndQuit = new System.Windows.Forms.Button();
            this.ToggleLoftKey = new System.Windows.Forms.Label();
            this.AddVolumeKey = new System.Windows.Forms.Label();
            this.DecreaseVolumeKey = new System.Windows.Forms.Label();
            this.SongTimerKey = new System.Windows.Forms.Label();
            this.ReEnumerationKey = new System.Windows.Forms.Label();
            this.NewAssignmentTxtBox = new System.Windows.Forms.TextBox();
            this.NewAssignment = new System.Windows.Forms.Label();
            this.NewSonglistName = new System.Windows.Forms.Label();
            this.NewSongListNameTxtbox = new System.Windows.Forms.TextBox();
            this.RainbowStringsEnabled = new System.Windows.Forms.CheckBox();
            this.ExtendedRangeEnabled = new System.Windows.Forms.CheckBox();
            this.RainbowStringsAssignment = new System.Windows.Forms.Label();
            this.ExtendedRangeTunings = new System.Windows.Forms.ListBox();
            this.ForceEnumerationCheckbox = new System.Windows.Forms.CheckBox();
            this.DiscoModeCheckbox = new System.Windows.Forms.CheckBox();
            this.HeadstockCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveSkylineCheckbox = new System.Windows.Forms.CheckBox();
            this.GreenScreenWallCheckbox = new System.Windows.Forms.CheckBox();
            this.AutoLoadProfileCheckbox = new System.Windows.Forms.CheckBox();
            this.FretlessModeCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveInlaysCheckbox = new System.Windows.Forms.CheckBox();
            this.ToggleLoftWhenStartupRadio = new System.Windows.Forms.RadioButton();
            this.ToggleLoftWhenManualRadio = new System.Windows.Forms.RadioButton();
            this.ToggleLoftWhenSongRadio = new System.Windows.Forms.RadioButton();
            this.ForceEnumerationManualRadio = new System.Windows.Forms.RadioButton();
            this.ForceEnumerationAutomaticRadio = new System.Windows.Forms.RadioButton();
            this.HowToEnumerateBox = new System.Windows.Forms.GroupBox();
            this.ToggleLoftOffWhenBox = new System.Windows.Forms.GroupBox();
            this.ExtendedRangeTuningBox = new System.Windows.Forms.GroupBox();
            this.EnabledModsBox = new System.Windows.Forms.GroupBox();
            this.RemoveLineMarkersCheckBox = new System.Windows.Forms.CheckBox();
            this.SongListBox = new System.Windows.Forms.GroupBox();
            this.KeybindingsBox = new System.Windows.Forms.GroupBox();
            this.ResetToDefaultButton = new System.Windows.Forms.Button();
            this.HowToEnumerateBox.SuspendLayout();
            this.ToggleLoftOffWhenBox.SuspendLayout();
            this.ExtendedRangeTuningBox.SuspendLayout();
            this.EnabledModsBox.SuspendLayout();
            this.SongListBox.SuspendLayout();
            this.KeybindingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Songlist
            // 
            this.Songlist.FormattingEnabled = true;
            this.Songlist.Location = new System.Drawing.Point(21, 26);
            this.Songlist.Name = "Songlist";
            this.Songlist.Size = new System.Drawing.Size(185, 147);
            this.Songlist.TabIndex = 2;
            this.Songlist.SelectedIndexChanged += new System.EventHandler(this.Songlist_SelectedIndexChanged);
            // 
            // ModList
            // 
            this.ModList.FormattingEnabled = true;
            this.ModList.Location = new System.Drawing.Point(22, 29);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(185, 134);
            this.ModList.TabIndex = 5;
            this.ModList.SelectedIndexChanged += new System.EventHandler(this.ModList_SelectedIndexChanged);
            // 
            // ToggleLoftCheckbox
            // 
            this.ToggleLoftCheckbox.AutoSize = true;
            this.ToggleLoftCheckbox.Location = new System.Drawing.Point(11, 22);
            this.ToggleLoftCheckbox.Name = "ToggleLoftCheckbox";
            this.ToggleLoftCheckbox.Size = new System.Drawing.Size(80, 17);
            this.ToggleLoftCheckbox.TabIndex = 6;
            this.ToggleLoftCheckbox.Text = "Toggle Loft";
            this.ToggleLoftCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddVolumeCheckbox
            // 
            this.AddVolumeCheckbox.AutoSize = true;
            this.AddVolumeCheckbox.Location = new System.Drawing.Point(11, 45);
            this.AddVolumeCheckbox.Name = "AddVolumeCheckbox";
            this.AddVolumeCheckbox.Size = new System.Drawing.Size(83, 17);
            this.AddVolumeCheckbox.TabIndex = 8;
            this.AddVolumeCheckbox.Text = "Add Volume";
            this.AddVolumeCheckbox.UseVisualStyleBackColor = true;
            // 
            // DecreaseVolumeCheckbox
            // 
            this.DecreaseVolumeCheckbox.AutoSize = true;
            this.DecreaseVolumeCheckbox.Location = new System.Drawing.Point(166, 45);
            this.DecreaseVolumeCheckbox.Name = "DecreaseVolumeCheckbox";
            this.DecreaseVolumeCheckbox.Size = new System.Drawing.Size(110, 17);
            this.DecreaseVolumeCheckbox.TabIndex = 9;
            this.DecreaseVolumeCheckbox.Text = "Decrease Volume";
            this.DecreaseVolumeCheckbox.UseVisualStyleBackColor = true;
            // 
            // SongTimerCheckbox
            // 
            this.SongTimerCheckbox.AutoSize = true;
            this.SongTimerCheckbox.Location = new System.Drawing.Point(166, 22);
            this.SongTimerCheckbox.Name = "SongTimerCheckbox";
            this.SongTimerCheckbox.Size = new System.Drawing.Size(110, 17);
            this.SongTimerCheckbox.TabIndex = 10;
            this.SongTimerCheckbox.Text = "Show Song Timer";
            this.SongTimerCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveAndQuit
            // 
            this.SaveAndQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndQuit.Location = new System.Drawing.Point(1329, 452);
            this.SaveAndQuit.Name = "SaveAndQuit";
            this.SaveAndQuit.Size = new System.Drawing.Size(228, 45);
            this.SaveAndQuit.TabIndex = 13;
            this.SaveAndQuit.Text = "Save And Quit";
            this.SaveAndQuit.UseVisualStyleBackColor = true;
            this.SaveAndQuit.Click += new System.EventHandler(this.SaveAndQuitFunction);
            // 
            // ToggleLoftKey
            // 
            this.ToggleLoftKey.AutoSize = true;
            this.ToggleLoftKey.Location = new System.Drawing.Point(488, 38);
            this.ToggleLoftKey.Name = "ToggleLoftKey";
            this.ToggleLoftKey.Size = new System.Drawing.Size(0, 13);
            this.ToggleLoftKey.TabIndex = 14;
            // 
            // AddVolumeKey
            // 
            this.AddVolumeKey.AutoSize = true;
            this.AddVolumeKey.Location = new System.Drawing.Point(488, 61);
            this.AddVolumeKey.Name = "AddVolumeKey";
            this.AddVolumeKey.Size = new System.Drawing.Size(0, 13);
            this.AddVolumeKey.TabIndex = 15;
            // 
            // DecreaseVolumeKey
            // 
            this.DecreaseVolumeKey.AutoSize = true;
            this.DecreaseVolumeKey.Location = new System.Drawing.Point(488, 84);
            this.DecreaseVolumeKey.Name = "DecreaseVolumeKey";
            this.DecreaseVolumeKey.Size = new System.Drawing.Size(0, 13);
            this.DecreaseVolumeKey.TabIndex = 16;
            // 
            // SongTimerKey
            // 
            this.SongTimerKey.AutoSize = true;
            this.SongTimerKey.Location = new System.Drawing.Point(488, 107);
            this.SongTimerKey.Name = "SongTimerKey";
            this.SongTimerKey.Size = new System.Drawing.Size(0, 13);
            this.SongTimerKey.TabIndex = 17;
            // 
            // ReEnumerationKey
            // 
            this.ReEnumerationKey.AutoSize = true;
            this.ReEnumerationKey.Location = new System.Drawing.Point(488, 130);
            this.ReEnumerationKey.Name = "ReEnumerationKey";
            this.ReEnumerationKey.Size = new System.Drawing.Size(0, 13);
            this.ReEnumerationKey.TabIndex = 18;
            // 
            // NewAssignmentTxtBox
            // 
            this.NewAssignmentTxtBox.Location = new System.Drawing.Point(222, 93);
            this.NewAssignmentTxtBox.Name = "NewAssignmentTxtBox";
            this.NewAssignmentTxtBox.Size = new System.Drawing.Size(188, 20);
            this.NewAssignmentTxtBox.TabIndex = 20;
            this.NewAssignmentTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewAssignmentTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEnter);
            // 
            // NewAssignment
            // 
            this.NewAssignment.AutoSize = true;
            this.NewAssignment.Location = new System.Drawing.Point(219, 59);
            this.NewAssignment.Name = "NewAssignment";
            this.NewAssignment.Size = new System.Drawing.Size(196, 13);
            this.NewAssignment.TabIndex = 21;
            this.NewAssignment.Text = "New Assignment (Press Enter To Save):";
            // 
            // NewSonglistName
            // 
            this.NewSonglistName.AutoSize = true;
            this.NewSonglistName.Location = new System.Drawing.Point(218, 44);
            this.NewSonglistName.Name = "NewSonglistName";
            this.NewSonglistName.Size = new System.Drawing.Size(225, 13);
            this.NewSonglistName.TabIndex = 22;
            this.NewSonglistName.Text = "Change Songlist Name (Press Enter To Save):";
            // 
            // NewSongListNameTxtbox
            // 
            this.NewSongListNameTxtbox.Location = new System.Drawing.Point(221, 83);
            this.NewSongListNameTxtbox.Name = "NewSongListNameTxtbox";
            this.NewSongListNameTxtbox.Size = new System.Drawing.Size(222, 20);
            this.NewSongListNameTxtbox.TabIndex = 23;
            this.NewSongListNameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewSongListNameTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEnter);
            // 
            // RainbowStringsEnabled
            // 
            this.RainbowStringsEnabled.AutoSize = true;
            this.RainbowStringsEnabled.Location = new System.Drawing.Point(11, 68);
            this.RainbowStringsEnabled.Name = "RainbowStringsEnabled";
            this.RainbowStringsEnabled.Size = new System.Drawing.Size(103, 17);
            this.RainbowStringsEnabled.TabIndex = 26;
            this.RainbowStringsEnabled.Text = "Rainbow Strings";
            this.RainbowStringsEnabled.UseVisualStyleBackColor = true;
            // 
            // ExtendedRangeEnabled
            // 
            this.ExtendedRangeEnabled.AutoSize = true;
            this.ExtendedRangeEnabled.Location = new System.Drawing.Point(166, 68);
            this.ExtendedRangeEnabled.Name = "ExtendedRangeEnabled";
            this.ExtendedRangeEnabled.Size = new System.Drawing.Size(146, 17);
            this.ExtendedRangeEnabled.TabIndex = 27;
            this.ExtendedRangeEnabled.Text = "Extended Range Support";
            this.ExtendedRangeEnabled.UseVisualStyleBackColor = true;
            // 
            // RainbowStringsAssignment
            // 
            this.RainbowStringsAssignment.AutoSize = true;
            this.RainbowStringsAssignment.Location = new System.Drawing.Point(544, 130);
            this.RainbowStringsAssignment.Name = "RainbowStringsAssignment";
            this.RainbowStringsAssignment.Size = new System.Drawing.Size(0, 13);
            this.RainbowStringsAssignment.TabIndex = 28;
            // 
            // ExtendedRangeTunings
            // 
            this.ExtendedRangeTunings.FormattingEnabled = true;
            this.ExtendedRangeTunings.Items.AddRange(new object[] {
            "D",
            "C#",
            "C",
            "B",
            "A#",
            "A",
            "G#",
            "G",
            "F#",
            "F",
            "Octave Down"});
            this.ExtendedRangeTunings.Location = new System.Drawing.Point(63, 21);
            this.ExtendedRangeTunings.Name = "ExtendedRangeTunings";
            this.ExtendedRangeTunings.Size = new System.Drawing.Size(79, 147);
            this.ExtendedRangeTunings.TabIndex = 29;
            this.ExtendedRangeTunings.Visible = false;
            // 
            // ForceEnumerationCheckbox
            // 
            this.ForceEnumerationCheckbox.AutoSize = true;
            this.ForceEnumerationCheckbox.Location = new System.Drawing.Point(11, 137);
            this.ForceEnumerationCheckbox.Name = "ForceEnumerationCheckbox";
            this.ForceEnumerationCheckbox.Size = new System.Drawing.Size(115, 17);
            this.ForceEnumerationCheckbox.TabIndex = 31;
            this.ForceEnumerationCheckbox.Text = "Force Enumeration";
            this.ForceEnumerationCheckbox.UseVisualStyleBackColor = true;
            // 
            // DiscoModeCheckbox
            // 
            this.DiscoModeCheckbox.AutoSize = true;
            this.DiscoModeCheckbox.Location = new System.Drawing.Point(166, 114);
            this.DiscoModeCheckbox.Name = "DiscoModeCheckbox";
            this.DiscoModeCheckbox.Size = new System.Drawing.Size(83, 17);
            this.DiscoModeCheckbox.TabIndex = 33;
            this.DiscoModeCheckbox.Text = "Disco Mode";
            this.DiscoModeCheckbox.UseVisualStyleBackColor = true;
            // 
            // HeadstockCheckbox
            // 
            this.HeadstockCheckbox.AutoSize = true;
            this.HeadstockCheckbox.Location = new System.Drawing.Point(11, 91);
            this.HeadstockCheckbox.Name = "HeadstockCheckbox";
            this.HeadstockCheckbox.Size = new System.Drawing.Size(121, 17);
            this.HeadstockCheckbox.TabIndex = 34;
            this.HeadstockCheckbox.Text = "Remove Headstock";
            this.HeadstockCheckbox.UseVisualStyleBackColor = true;
            // 
            // RemoveSkylineCheckbox
            // 
            this.RemoveSkylineCheckbox.AutoSize = true;
            this.RemoveSkylineCheckbox.Location = new System.Drawing.Point(166, 91);
            this.RemoveSkylineCheckbox.Name = "RemoveSkylineCheckbox";
            this.RemoveSkylineCheckbox.Size = new System.Drawing.Size(103, 17);
            this.RemoveSkylineCheckbox.TabIndex = 36;
            this.RemoveSkylineCheckbox.Text = "Remove Skyline";
            this.RemoveSkylineCheckbox.UseVisualStyleBackColor = true;
            // 
            // GreenScreenWallCheckbox
            // 
            this.GreenScreenWallCheckbox.AutoSize = true;
            this.GreenScreenWallCheckbox.Location = new System.Drawing.Point(11, 114);
            this.GreenScreenWallCheckbox.Name = "GreenScreenWallCheckbox";
            this.GreenScreenWallCheckbox.Size = new System.Drawing.Size(111, 17);
            this.GreenScreenWallCheckbox.TabIndex = 37;
            this.GreenScreenWallCheckbox.Text = "Greenscreen Wall";
            this.GreenScreenWallCheckbox.UseVisualStyleBackColor = true;
            // 
            // AutoLoadProfileCheckbox
            // 
            this.AutoLoadProfileCheckbox.AutoSize = true;
            this.AutoLoadProfileCheckbox.Location = new System.Drawing.Point(166, 137);
            this.AutoLoadProfileCheckbox.Name = "AutoLoadProfileCheckbox";
            this.AutoLoadProfileCheckbox.Size = new System.Drawing.Size(151, 17);
            this.AutoLoadProfileCheckbox.TabIndex = 38;
            this.AutoLoadProfileCheckbox.Text = "Autoload Last Used Profile";
            this.AutoLoadProfileCheckbox.UseVisualStyleBackColor = true;
            // 
            // FretlessModeCheckbox
            // 
            this.FretlessModeCheckbox.AutoSize = true;
            this.FretlessModeCheckbox.Location = new System.Drawing.Point(11, 160);
            this.FretlessModeCheckbox.Name = "FretlessModeCheckbox";
            this.FretlessModeCheckbox.Size = new System.Drawing.Size(92, 17);
            this.FretlessModeCheckbox.TabIndex = 41;
            this.FretlessModeCheckbox.Text = "Fretless Mode";
            this.FretlessModeCheckbox.UseVisualStyleBackColor = true;
            // 
            // RemoveInlaysCheckbox
            // 
            this.RemoveInlaysCheckbox.AutoSize = true;
            this.RemoveInlaysCheckbox.Location = new System.Drawing.Point(166, 161);
            this.RemoveInlaysCheckbox.Name = "RemoveInlaysCheckbox";
            this.RemoveInlaysCheckbox.Size = new System.Drawing.Size(96, 17);
            this.RemoveInlaysCheckbox.TabIndex = 42;
            this.RemoveInlaysCheckbox.Text = "Remove Inlays";
            this.RemoveInlaysCheckbox.UseVisualStyleBackColor = true;
            // 
            // ToggleLoftWhenStartupRadio
            // 
            this.ToggleLoftWhenStartupRadio.AutoSize = true;
            this.ToggleLoftWhenStartupRadio.Location = new System.Drawing.Point(16, 14);
            this.ToggleLoftWhenStartupRadio.Name = "ToggleLoftWhenStartupRadio";
            this.ToggleLoftWhenStartupRadio.Size = new System.Drawing.Size(180, 17);
            this.ToggleLoftWhenStartupRadio.TabIndex = 44;
            this.ToggleLoftWhenStartupRadio.TabStop = true;
            this.ToggleLoftWhenStartupRadio.Text = "As Soon As The Game Starts Up";
            this.ToggleLoftWhenStartupRadio.UseVisualStyleBackColor = true;
            this.ToggleLoftWhenStartupRadio.Visible = false;
            // 
            // ToggleLoftWhenManualRadio
            // 
            this.ToggleLoftWhenManualRadio.AutoSize = true;
            this.ToggleLoftWhenManualRadio.Location = new System.Drawing.Point(17, 37);
            this.ToggleLoftWhenManualRadio.Name = "ToggleLoftWhenManualRadio";
            this.ToggleLoftWhenManualRadio.Size = new System.Drawing.Size(220, 17);
            this.ToggleLoftWhenManualRadio.TabIndex = 45;
            this.ToggleLoftWhenManualRadio.TabStop = true;
            this.ToggleLoftWhenManualRadio.Text = "Only When I Manually Trigger Via Hotkey";
            this.ToggleLoftWhenManualRadio.UseVisualStyleBackColor = true;
            this.ToggleLoftWhenManualRadio.Visible = false;
            // 
            // ToggleLoftWhenSongRadio
            // 
            this.ToggleLoftWhenSongRadio.AutoSize = true;
            this.ToggleLoftWhenSongRadio.Location = new System.Drawing.Point(17, 60);
            this.ToggleLoftWhenSongRadio.Name = "ToggleLoftWhenSongRadio";
            this.ToggleLoftWhenSongRadio.Size = new System.Drawing.Size(128, 17);
            this.ToggleLoftWhenSongRadio.TabIndex = 46;
            this.ToggleLoftWhenSongRadio.TabStop = true;
            this.ToggleLoftWhenSongRadio.Text = "Only When In A Song";
            this.ToggleLoftWhenSongRadio.UseVisualStyleBackColor = true;
            this.ToggleLoftWhenSongRadio.Visible = false;
            // 
            // ForceEnumerationManualRadio
            // 
            this.ForceEnumerationManualRadio.AutoSize = true;
            this.ForceEnumerationManualRadio.Location = new System.Drawing.Point(14, 23);
            this.ForceEnumerationManualRadio.Name = "ForceEnumerationManualRadio";
            this.ForceEnumerationManualRadio.Size = new System.Drawing.Size(112, 17);
            this.ForceEnumerationManualRadio.TabIndex = 24;
            this.ForceEnumerationManualRadio.TabStop = true;
            this.ForceEnumerationManualRadio.Text = "Manual (Keypress)";
            this.ForceEnumerationManualRadio.UseVisualStyleBackColor = true;
            this.ForceEnumerationManualRadio.Visible = false;
            // 
            // ForceEnumerationAutomaticRadio
            // 
            this.ForceEnumerationAutomaticRadio.AutoSize = true;
            this.ForceEnumerationAutomaticRadio.Location = new System.Drawing.Point(14, 48);
            this.ForceEnumerationAutomaticRadio.Name = "ForceEnumerationAutomaticRadio";
            this.ForceEnumerationAutomaticRadio.Size = new System.Drawing.Size(180, 17);
            this.ForceEnumerationAutomaticRadio.TabIndex = 25;
            this.ForceEnumerationAutomaticRadio.TabStop = true;
            this.ForceEnumerationAutomaticRadio.Text = "Automatic (Scan For New CDLC)";
            this.ForceEnumerationAutomaticRadio.UseVisualStyleBackColor = true;
            this.ForceEnumerationAutomaticRadio.Visible = false;
            // 
            // HowToEnumerateBox
            // 
            this.HowToEnumerateBox.Controls.Add(this.ForceEnumerationAutomaticRadio);
            this.HowToEnumerateBox.Controls.Add(this.ForceEnumerationManualRadio);
            this.HowToEnumerateBox.Location = new System.Drawing.Point(1015, 111);
            this.HowToEnumerateBox.Name = "HowToEnumerateBox";
            this.HowToEnumerateBox.Size = new System.Drawing.Size(206, 96);
            this.HowToEnumerateBox.TabIndex = 47;
            this.HowToEnumerateBox.TabStop = false;
            this.HowToEnumerateBox.Text = "How Do You Want To Enumerate?";
            this.HowToEnumerateBox.Visible = false;
            // 
            // ToggleLoftOffWhenBox
            // 
            this.ToggleLoftOffWhenBox.Controls.Add(this.ToggleLoftWhenSongRadio);
            this.ToggleLoftOffWhenBox.Controls.Add(this.ToggleLoftWhenManualRadio);
            this.ToggleLoftOffWhenBox.Controls.Add(this.ToggleLoftWhenStartupRadio);
            this.ToggleLoftOffWhenBox.Location = new System.Drawing.Point(1015, 20);
            this.ToggleLoftOffWhenBox.Name = "ToggleLoftOffWhenBox";
            this.ToggleLoftOffWhenBox.Size = new System.Drawing.Size(243, 86);
            this.ToggleLoftOffWhenBox.TabIndex = 48;
            this.ToggleLoftOffWhenBox.TabStop = false;
            this.ToggleLoftOffWhenBox.Text = "Toggle Loft Off When:";
            this.ToggleLoftOffWhenBox.Visible = false;
            // 
            // ExtendedRangeTuningBox
            // 
            this.ExtendedRangeTuningBox.Controls.Add(this.ExtendedRangeTunings);
            this.ExtendedRangeTuningBox.Location = new System.Drawing.Point(1380, 20);
            this.ExtendedRangeTuningBox.Name = "ExtendedRangeTuningBox";
            this.ExtendedRangeTuningBox.Size = new System.Drawing.Size(215, 188);
            this.ExtendedRangeTuningBox.TabIndex = 49;
            this.ExtendedRangeTuningBox.TabStop = false;
            this.ExtendedRangeTuningBox.Text = "Enable Extended Range When Low E Is";
            this.ExtendedRangeTuningBox.Visible = false;
            // 
            // EnabledModsBox
            // 
            this.EnabledModsBox.Controls.Add(this.RemoveLineMarkersCheckBox);
            this.EnabledModsBox.Controls.Add(this.RemoveInlaysCheckbox);
            this.EnabledModsBox.Controls.Add(this.SongTimerCheckbox);
            this.EnabledModsBox.Controls.Add(this.ToggleLoftCheckbox);
            this.EnabledModsBox.Controls.Add(this.FretlessModeCheckbox);
            this.EnabledModsBox.Controls.Add(this.AddVolumeCheckbox);
            this.EnabledModsBox.Controls.Add(this.DecreaseVolumeCheckbox);
            this.EnabledModsBox.Controls.Add(this.AutoLoadProfileCheckbox);
            this.EnabledModsBox.Controls.Add(this.RainbowStringsEnabled);
            this.EnabledModsBox.Controls.Add(this.ExtendedRangeEnabled);
            this.EnabledModsBox.Controls.Add(this.GreenScreenWallCheckbox);
            this.EnabledModsBox.Controls.Add(this.ForceEnumerationCheckbox);
            this.EnabledModsBox.Controls.Add(this.DiscoModeCheckbox);
            this.EnabledModsBox.Controls.Add(this.RemoveSkylineCheckbox);
            this.EnabledModsBox.Controls.Add(this.HeadstockCheckbox);
            this.EnabledModsBox.Location = new System.Drawing.Point(502, 20);
            this.EnabledModsBox.Name = "EnabledModsBox";
            this.EnabledModsBox.Size = new System.Drawing.Size(486, 182);
            this.EnabledModsBox.TabIndex = 50;
            this.EnabledModsBox.TabStop = false;
            this.EnabledModsBox.Text = "Enabled Mods";
            // 
            // RemoveLineMarkersCheckBox
            // 
            this.RemoveLineMarkersCheckBox.AutoSize = true;
            this.RemoveLineMarkersCheckBox.Location = new System.Drawing.Point(320, 22);
            this.RemoveLineMarkersCheckBox.Name = "RemoveLineMarkersCheckBox";
            this.RemoveLineMarkersCheckBox.Size = new System.Drawing.Size(130, 17);
            this.RemoveLineMarkersCheckBox.TabIndex = 43;
            this.RemoveLineMarkersCheckBox.Text = "Remove Line Markers";
            this.RemoveLineMarkersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SongListBox
            // 
            this.SongListBox.Controls.Add(this.NewSongListNameTxtbox);
            this.SongListBox.Controls.Add(this.NewSonglistName);
            this.SongListBox.Controls.Add(this.Songlist);
            this.SongListBox.Location = new System.Drawing.Point(12, 20);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(459, 182);
            this.SongListBox.TabIndex = 51;
            this.SongListBox.TabStop = false;
            this.SongListBox.Text = "Song Lists";
            // 
            // KeybindingsBox
            // 
            this.KeybindingsBox.Controls.Add(this.NewAssignment);
            this.KeybindingsBox.Controls.Add(this.NewAssignmentTxtBox);
            this.KeybindingsBox.Controls.Add(this.ReEnumerationKey);
            this.KeybindingsBox.Controls.Add(this.SongTimerKey);
            this.KeybindingsBox.Controls.Add(this.DecreaseVolumeKey);
            this.KeybindingsBox.Controls.Add(this.AddVolumeKey);
            this.KeybindingsBox.Controls.Add(this.ToggleLoftKey);
            this.KeybindingsBox.Controls.Add(this.RainbowStringsAssignment);
            this.KeybindingsBox.Controls.Add(this.ModList);
            this.KeybindingsBox.Location = new System.Drawing.Point(33, 242);
            this.KeybindingsBox.Name = "KeybindingsBox";
            this.KeybindingsBox.Size = new System.Drawing.Size(654, 176);
            this.KeybindingsBox.TabIndex = 52;
            this.KeybindingsBox.TabStop = false;
            this.KeybindingsBox.Text = "Key Bindings";
            // 
            // ResetToDefaultButton
            // 
            this.ResetToDefaultButton.Location = new System.Drawing.Point(12, 475);
            this.ResetToDefaultButton.Name = "ResetToDefaultButton";
            this.ResetToDefaultButton.Size = new System.Drawing.Size(109, 22);
            this.ResetToDefaultButton.TabIndex = 32;
            this.ResetToDefaultButton.Text = "Reset To Default";
            this.ResetToDefaultButton.UseVisualStyleBackColor = true;
            this.ResetToDefaultButton.Click += new System.EventHandler(this.ResetToDefaultSettings);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1616, 509);
            this.Controls.Add(this.KeybindingsBox);
            this.Controls.Add(this.SongListBox);
            this.Controls.Add(this.EnabledModsBox);
            this.Controls.Add(this.ExtendedRangeTuningBox);
            this.Controls.Add(this.ToggleLoftOffWhenBox);
            this.Controls.Add(this.HowToEnumerateBox);
            this.Controls.Add(this.ResetToDefaultButton);
            this.Controls.Add(this.SaveAndQuit);
            this.Name = "MainForm";
            this.Text = "Rocksmith 2014 DLL Modifier";
            this.HowToEnumerateBox.ResumeLayout(false);
            this.HowToEnumerateBox.PerformLayout();
            this.ToggleLoftOffWhenBox.ResumeLayout(false);
            this.ToggleLoftOffWhenBox.PerformLayout();
            this.ExtendedRangeTuningBox.ResumeLayout(false);
            this.EnabledModsBox.ResumeLayout(false);
            this.EnabledModsBox.PerformLayout();
            this.SongListBox.ResumeLayout(false);
            this.SongListBox.PerformLayout();
            this.KeybindingsBox.ResumeLayout(false);
            this.KeybindingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.ListBox Songlist;
        private System.Windows.Forms.ListBox ModList;
        private System.Windows.Forms.CheckBox ToggleLoftCheckbox;
        private System.Windows.Forms.CheckBox AddVolumeCheckbox;
        private System.Windows.Forms.CheckBox DecreaseVolumeCheckbox;
        private System.Windows.Forms.CheckBox SongTimerCheckbox;
        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Label ToggleLoftKey;
        private System.Windows.Forms.Label AddVolumeKey;
        private System.Windows.Forms.Label DecreaseVolumeKey;
        private System.Windows.Forms.Label SongTimerKey;
        private System.Windows.Forms.Label ReEnumerationKey;
        private System.Windows.Forms.TextBox NewAssignmentTxtBox;
        private System.Windows.Forms.Label NewAssignment;
        private System.Windows.Forms.Label NewSonglistName;
        private System.Windows.Forms.TextBox NewSongListNameTxtbox;
        private System.Windows.Forms.CheckBox RainbowStringsEnabled;
        private System.Windows.Forms.CheckBox ExtendedRangeEnabled;
        private System.Windows.Forms.Label RainbowStringsAssignment;
        private System.Windows.Forms.ListBox ExtendedRangeTunings;
        private System.Windows.Forms.CheckBox ForceEnumerationCheckbox;
        private System.Windows.Forms.CheckBox DiscoModeCheckbox;
        private System.Windows.Forms.CheckBox HeadstockCheckbox;
        private System.Windows.Forms.CheckBox RemoveSkylineCheckbox;
        private System.Windows.Forms.CheckBox GreenScreenWallCheckbox;
        private System.Windows.Forms.CheckBox AutoLoadProfileCheckbox;
        private System.Windows.Forms.CheckBox FretlessModeCheckbox;
        private System.Windows.Forms.CheckBox RemoveInlaysCheckbox;
        private System.Windows.Forms.RadioButton ToggleLoftWhenStartupRadio;
        private System.Windows.Forms.RadioButton ToggleLoftWhenManualRadio;
        private System.Windows.Forms.RadioButton ToggleLoftWhenSongRadio;
        private System.Windows.Forms.RadioButton ForceEnumerationManualRadio;
        private System.Windows.Forms.RadioButton ForceEnumerationAutomaticRadio;
        private System.Windows.Forms.GroupBox HowToEnumerateBox;
        private System.Windows.Forms.GroupBox ToggleLoftOffWhenBox;
        private System.Windows.Forms.GroupBox ExtendedRangeTuningBox;
        private System.Windows.Forms.GroupBox EnabledModsBox;
        private System.Windows.Forms.CheckBox RemoveLineMarkersCheckBox;
        private System.Windows.Forms.GroupBox SongListBox;
        private System.Windows.Forms.GroupBox KeybindingsBox;
        private System.Windows.Forms.Button ResetToDefaultButton;
    }
}
