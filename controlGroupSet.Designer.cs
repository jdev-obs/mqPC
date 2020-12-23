using System.Collections.Generic;

namespace mqtt_play
{
    partial class ControlGroupSet
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
                this.controlKeyModifierCount.SelectedIndexChanged -= this.ControlKeyModifierCount_SelectedIndexChanged;
                this.controlSortUp.Click -= this.ControlSortUp_Click;
                this.controlSortDown.Click -= this.ControlSortDown_Click;
                this.controlDelete.Click -= this.ControlDelete_Click;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlNameLabel = new System.Windows.Forms.Label();
            this.controlName = new System.Windows.Forms.TextBox();
            this.controlPathLabel = new System.Windows.Forms.Label();
            this.controlPath = new System.Windows.Forms.TextBox();
            this.commandTypeLabel = new System.Windows.Forms.Label();
            this.controlType = new System.Windows.Forms.ComboBox();
            this.controlKeyModifierCount = new System.Windows.Forms.ComboBox();
            this.controlKeyModifier3 = new System.Windows.Forms.ComboBox();
            this.controlKeyModifier2 = new System.Windows.Forms.ComboBox();
            this.controlKeyModifier1 = new System.Windows.Forms.ComboBox();
            this.controlKeyCommand = new System.Windows.Forms.ComboBox();
            this.controlDelete = new System.Windows.Forms.Button();
            this.controlFrame = new System.Windows.Forms.GroupBox();
            this.controlMouseCommand = new System.Windows.Forms.ComboBox();
            this.controlMediaOSD = new System.Windows.Forms.CheckBox();
            this.controlMediaCommand = new System.Windows.Forms.ComboBox();
            this.controlCommandLabel = new System.Windows.Forms.Label();
            this.controlCollapse = new System.Windows.Forms.Button();
            this.controlSortDown = new System.Windows.Forms.Button();
            this.controlSortUp = new System.Windows.Forms.Button();
            this.controlKeyLabel = new System.Windows.Forms.Label();
            this.controlKeyModifierCountLabel = new System.Windows.Forms.Label();
            this.controlEnable = new System.Windows.Forms.Button();
            this.controlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlNameLabel
            // 
            this.controlNameLabel.AutoSize = true;
            this.controlNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlNameLabel.Location = new System.Drawing.Point(393, 37);
            this.controlNameLabel.Name = "controlNameLabel";
            this.controlNameLabel.Size = new System.Drawing.Size(63, 25);
            this.controlNameLabel.TabIndex = 5;
            this.controlNameLabel.Text = "Name:";
            // 
            // controlName
            // 
            this.controlName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlName.Location = new System.Drawing.Point(457, 35);
            this.controlName.Name = "controlName";
            this.controlName.Size = new System.Drawing.Size(198, 31);
            this.controlName.TabIndex = 6;
            this.controlName.TextChanged += new System.EventHandler(this.ControlName_TextChanged);
            // 
            // controlPathLabel
            // 
            this.controlPathLabel.AutoSize = true;
            this.controlPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlPathLabel.Location = new System.Drawing.Point(277, 90);
            this.controlPathLabel.Name = "controlPathLabel";
            this.controlPathLabel.Size = new System.Drawing.Size(102, 25);
            this.controlPathLabel.TabIndex = 7;
            this.controlPathLabel.Text = "MQTT Path:";
            // 
            // controlPath
            // 
            this.controlPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlPath.Location = new System.Drawing.Point(381, 89);
            this.controlPath.Name = "controlPath";
            this.controlPath.Size = new System.Drawing.Size(274, 31);
            this.controlPath.TabIndex = 8;
            this.controlPath.TextChanged += new System.EventHandler(this.ControlPath_TextChanged);
            // 
            // commandTypeLabel
            // 
            this.commandTypeLabel.AutoSize = true;
            this.commandTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.commandTypeLabel.Location = new System.Drawing.Point(150, 35);
            this.commandTypeLabel.Name = "commandTypeLabel";
            this.commandTypeLabel.Size = new System.Drawing.Size(53, 25);
            this.commandTypeLabel.TabIndex = 6;
            this.commandTypeLabel.Text = "Type:";
            // 
            // controlType
            // 
            this.controlType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlType.FormattingEnabled = true;
            this.controlType.Items.AddRange(new object[] {
            "Key Control",
            "Media Control",
            "Mouse Control",
            "Macro",
            "Batch Script"});
            this.controlType.Location = new System.Drawing.Point(205, 33);
            this.controlType.Name = "controlType";
            this.controlType.Size = new System.Drawing.Size(182, 33);
            this.controlType.TabIndex = 3;
            this.controlType.SelectedIndexChanged += new System.EventHandler(this.ControlType_SelectedIndexChanged);
            // 
            // controlKeyModifierCount
            // 
            this.controlKeyModifierCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlKeyModifierCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlKeyModifierCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlKeyModifierCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyModifierCount.FormattingEnabled = true;
            this.controlKeyModifierCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.controlKeyModifierCount.Location = new System.Drawing.Point(81, 141);
            this.controlKeyModifierCount.Name = "controlKeyModifierCount";
            this.controlKeyModifierCount.Size = new System.Drawing.Size(58, 33);
            this.controlKeyModifierCount.TabIndex = 10;
            this.controlKeyModifierCount.Visible = false;
            this.controlKeyModifierCount.SelectedIndexChanged += new System.EventHandler(this.ControlKeyModifierCount_SelectedIndexChanged);
            // 
            // controlKeyModifier3
            // 
            this.controlKeyModifier3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlKeyModifier3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlKeyModifier3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlKeyModifier3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyModifier3.FormattingEnabled = true;
            this.controlKeyModifier3.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift",
            "Windows"});
            this.controlKeyModifier3.Location = new System.Drawing.Point(205, 140);
            this.controlKeyModifier3.Name = "controlKeyModifier3";
            this.controlKeyModifier3.Size = new System.Drawing.Size(110, 33);
            this.controlKeyModifier3.TabIndex = 12;
            this.controlKeyModifier3.Visible = false;
            this.controlKeyModifier3.SelectedIndexChanged += new System.EventHandler(this.ControlKeyModifier3_SelectedIndexChanged);
            // 
            // controlKeyModifier2
            // 
            this.controlKeyModifier2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlKeyModifier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlKeyModifier2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlKeyModifier2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyModifier2.FormattingEnabled = true;
            this.controlKeyModifier2.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift",
            "Windows"});
            this.controlKeyModifier2.Location = new System.Drawing.Point(317, 140);
            this.controlKeyModifier2.Name = "controlKeyModifier2";
            this.controlKeyModifier2.Size = new System.Drawing.Size(110, 33);
            this.controlKeyModifier2.TabIndex = 13;
            this.controlKeyModifier2.Visible = false;
            this.controlKeyModifier2.SelectedIndexChanged += new System.EventHandler(this.ControlKeyModifier2_SelectedIndexChanged);
            // 
            // controlKeyModifier1
            // 
            this.controlKeyModifier1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlKeyModifier1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlKeyModifier1.DropDownWidth = 108;
            this.controlKeyModifier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlKeyModifier1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyModifier1.FormattingEnabled = true;
            this.controlKeyModifier1.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift",
            "Windows"});
            this.controlKeyModifier1.Location = new System.Drawing.Point(429, 140);
            this.controlKeyModifier1.Name = "controlKeyModifier1";
            this.controlKeyModifier1.Size = new System.Drawing.Size(110, 33);
            this.controlKeyModifier1.TabIndex = 14;
            this.controlKeyModifier1.Visible = false;
            this.controlKeyModifier1.SelectedIndexChanged += new System.EventHandler(this.ControlKeyModifier1_SelectedIndexChanged);
            // 
            // controlKeyCommand
            // 
            this.controlKeyCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlKeyCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlKeyCommand.DropDownWidth = 108;
            this.controlKeyCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlKeyCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyCommand.FormattingEnabled = true;
            this.controlKeyCommand.Items.AddRange(new object[] {
            "Escape",
            "Enter",
            "Space",
            "Tab",
            "Delete",
            "Left",
            "Up",
            "Right",
            "Down",
            "PrintScreen",
            "Home",
            "End",
            "PageUp",
            "PageDown",
            "Insert",
            "Apps",
            "Windows",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "NumPad1",
            "NumPad2",
            "NumPad3",
            "NumPad4",
            "NumPad5",
            "NumPad6",
            "NumPad7",
            "NumPad8",
            "NumPad9",
            "NumPad0",
            "-",
            "=",
            "[",
            "]",
            "\\",
            "`",
            ";",
            "\'",
            ",",
            ".",
            "/"});
            this.controlKeyCommand.Location = new System.Drawing.Point(541, 140);
            this.controlKeyCommand.Name = "controlKeyCommand";
            this.controlKeyCommand.Size = new System.Drawing.Size(118, 33);
            this.controlKeyCommand.TabIndex = 15;
            this.controlKeyCommand.Visible = false;
            this.controlKeyCommand.SelectedIndexChanged += new System.EventHandler(this.ControlKeyCommand_SelectedIndexChanged);
            // 
            // controlDelete
            // 
            this.controlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.controlDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlDelete.Location = new System.Drawing.Point(584, 185);
            this.controlDelete.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.controlDelete.Name = "controlDelete";
            this.controlDelete.Size = new System.Drawing.Size(72, 37);
            this.controlDelete.TabIndex = 103;
            this.controlDelete.Text = "Delete";
            this.controlDelete.UseVisualStyleBackColor = false;
            this.controlDelete.Click += new System.EventHandler(this.ControlDelete_Click);
            // 
            // controlFrame
            // 
            this.controlFrame.Controls.Add(this.controlMouseCommand);
            this.controlFrame.Controls.Add(this.controlMediaOSD);
            this.controlFrame.Controls.Add(this.controlMediaCommand);
            this.controlFrame.Controls.Add(this.controlCommandLabel);
            this.controlFrame.Controls.Add(this.controlCollapse);
            this.controlFrame.Controls.Add(this.controlSortDown);
            this.controlFrame.Controls.Add(this.controlSortUp);
            this.controlFrame.Controls.Add(this.controlKeyLabel);
            this.controlFrame.Controls.Add(this.controlKeyModifierCountLabel);
            this.controlFrame.Controls.Add(this.controlEnable);
            this.controlFrame.Controls.Add(this.controlNameLabel);
            this.controlFrame.Controls.Add(this.controlName);
            this.controlFrame.Controls.Add(this.controlPathLabel);
            this.controlFrame.Controls.Add(this.controlPath);
            this.controlFrame.Controls.Add(this.commandTypeLabel);
            this.controlFrame.Controls.Add(this.controlType);
            this.controlFrame.Controls.Add(this.controlKeyModifierCount);
            this.controlFrame.Controls.Add(this.controlKeyModifier3);
            this.controlFrame.Controls.Add(this.controlKeyModifier2);
            this.controlFrame.Controls.Add(this.controlKeyModifier1);
            this.controlFrame.Controls.Add(this.controlKeyCommand);
            this.controlFrame.Controls.Add(this.controlDelete);
            this.controlFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlFrame.ForeColor = System.Drawing.Color.DarkOrange;
            this.controlFrame.Location = new System.Drawing.Point(6, -3);
            this.controlFrame.Margin = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.controlFrame.Name = "controlFrame";
            this.controlFrame.Padding = new System.Windows.Forms.Padding(0);
            this.controlFrame.Size = new System.Drawing.Size(664, 230);
            this.controlFrame.TabIndex = 0;
            this.controlFrame.TabStop = false;
            this.controlFrame.Text = "Disabled";
            // 
            // controlMouseCommand
            // 
            this.controlMouseCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlMouseCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlMouseCommand.DropDownWidth = 108;
            this.controlMouseCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlMouseCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlMouseCommand.FormattingEnabled = true;
            this.controlMouseCommand.Location = new System.Drawing.Point(105, 140);
            this.controlMouseCommand.Name = "controlMouseCommand";
            this.controlMouseCommand.Size = new System.Drawing.Size(132, 33);
            this.controlMouseCommand.TabIndex = 10;
            this.controlMouseCommand.Visible = false;
            // 
            // controlMediaOSD
            // 
            this.controlMediaOSD.AutoSize = true;
            this.controlMediaOSD.BackColor = System.Drawing.Color.Black;
            this.controlMediaOSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlMediaOSD.Location = new System.Drawing.Point(255, 142);
            this.controlMediaOSD.Name = "controlMediaOSD";
            this.controlMediaOSD.Size = new System.Drawing.Size(124, 29);
            this.controlMediaOSD.TabIndex = 13;
            this.controlMediaOSD.Text = "Show OSD";
            this.controlMediaOSD.UseVisualStyleBackColor = false;
            this.controlMediaOSD.Visible = false;
            this.controlMediaOSD.CheckedChanged += new System.EventHandler(this.ControlMediaOSD_CheckedChanged);
            // 
            // controlMediaCommand
            // 
            this.controlMediaCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlMediaCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlMediaCommand.DropDownWidth = 108;
            this.controlMediaCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlMediaCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlMediaCommand.FormattingEnabled = true;
            this.controlMediaCommand.Location = new System.Drawing.Point(105, 140);
            this.controlMediaCommand.Name = "controlMediaCommand";
            this.controlMediaCommand.Size = new System.Drawing.Size(132, 33);
            this.controlMediaCommand.TabIndex = 10;
            this.controlMediaCommand.Visible = false;
            // 
            // controlCommandLabel
            // 
            this.controlCommandLabel.AutoSize = true;
            this.controlCommandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlCommandLabel.Location = new System.Drawing.Point(2, 143);
            this.controlCommandLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.controlCommandLabel.Name = "controlCommandLabel";
            this.controlCommandLabel.Size = new System.Drawing.Size(100, 25);
            this.controlCommandLabel.TabIndex = 9;
            this.controlCommandLabel.Text = "Command:";
            this.controlCommandLabel.Visible = false;
            // 
            // controlCollapse
            // 
            this.controlCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.controlCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.controlCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.controlCollapse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlCollapse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.controlCollapse.Location = new System.Drawing.Point(9, 31);
            this.controlCollapse.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.controlCollapse.Name = "controlCollapse";
            this.controlCollapse.Padding = new System.Windows.Forms.Padding(4);
            this.controlCollapse.Size = new System.Drawing.Size(36, 36);
            this.controlCollapse.TabIndex = 1;
            this.controlCollapse.UseVisualStyleBackColor = false;
            this.controlCollapse.Click += new System.EventHandler(this.ControlCollapse_Click);
            // 
            // controlSortDown
            // 
            this.controlSortDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlSortDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlSortDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.controlSortDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlSortDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlSortDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlSortDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlSortDown.Location = new System.Drawing.Point(89, 31);
            this.controlSortDown.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.controlSortDown.Name = "controlSortDown";
            this.controlSortDown.Size = new System.Drawing.Size(36, 36);
            this.controlSortDown.TabIndex = 2;
            this.controlSortDown.Text = "▼";
            this.controlSortDown.UseVisualStyleBackColor = false;
            this.controlSortDown.Click += new System.EventHandler(this.ControlSortDown_Click);
            // 
            // controlSortUp
            // 
            this.controlSortUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlSortUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlSortUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.controlSortUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlSortUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlSortUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlSortUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlSortUp.Location = new System.Drawing.Point(49, 31);
            this.controlSortUp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.controlSortUp.Name = "controlSortUp";
            this.controlSortUp.Size = new System.Drawing.Size(36, 36);
            this.controlSortUp.TabIndex = 1;
            this.controlSortUp.Text = "▲";
            this.controlSortUp.UseVisualStyleBackColor = false;
            this.controlSortUp.Click += new System.EventHandler(this.ControlSortUp_Click);
            // 
            // controlKeyLabel
            // 
            this.controlKeyLabel.AutoSize = true;
            this.controlKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyLabel.Location = new System.Drawing.Point(152, 143);
            this.controlKeyLabel.Name = "controlKeyLabel";
            this.controlKeyLabel.Size = new System.Drawing.Size(52, 25);
            this.controlKeyLabel.TabIndex = 11;
            this.controlKeyLabel.Text = "Keys:";
            this.controlKeyLabel.Visible = false;
            // 
            // controlKeyModifierCountLabel
            // 
            this.controlKeyModifierCountLabel.AutoSize = true;
            this.controlKeyModifierCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlKeyModifierCountLabel.Location = new System.Drawing.Point(3, 143);
            this.controlKeyModifierCountLabel.Name = "controlKeyModifierCountLabel";
            this.controlKeyModifierCountLabel.Size = new System.Drawing.Size(78, 25);
            this.controlKeyModifierCountLabel.TabIndex = 9;
            this.controlKeyModifierCountLabel.Text = "# Mods:";
            this.controlKeyModifierCountLabel.Visible = false;
            // 
            // controlEnable
            // 
            this.controlEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlEnable.Location = new System.Drawing.Point(9, 185);
            this.controlEnable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.controlEnable.Name = "controlEnable";
            this.controlEnable.Size = new System.Drawing.Size(82, 37);
            this.controlEnable.TabIndex = 102;
            this.controlEnable.Text = "Enable";
            this.controlEnable.UseVisualStyleBackColor = false;
            this.controlEnable.Click += new System.EventHandler(this.ControlEnable_Click);
            // 
            // controlGroupSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.controlFrame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.Name = "controlGroupSet";
            this.Padding = new System.Windows.Forms.Padding(1, 2, 4, 4);
            this.Size = new System.Drawing.Size(677, 233);
            this.controlFrame.ResumeLayout(false);
            this.controlFrame.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Label controlNameLabel;
        private System.Windows.Forms.TextBox controlName;
        private System.Windows.Forms.Label controlPathLabel;
        private System.Windows.Forms.TextBox controlPath;
        private System.Windows.Forms.Label commandTypeLabel;
        private System.Windows.Forms.ComboBox controlType;
        private System.Windows.Forms.ComboBox controlKeyModifierCount;
        private System.Windows.Forms.ComboBox controlKeyModifier3;
        private System.Windows.Forms.ComboBox controlKeyModifier2;
        private System.Windows.Forms.ComboBox controlKeyModifier1;
        private System.Windows.Forms.ComboBox controlKeyCommand;
        private System.Windows.Forms.Button controlDelete;
        private System.Windows.Forms.GroupBox controlFrame;
        private System.Windows.Forms.Button controlEnable;
        private System.Windows.Forms.Label controlKeyModifierCountLabel;
        private System.Windows.Forms.Label controlKeyLabel;
        private System.Windows.Forms.Button controlSortDown;
        private System.Windows.Forms.Button controlSortUp;

        public List<string> ModKeys = new List<string>() {
            "Ctrl",
            "Alt",
            "Shift",
            "Windows"
        };
        private System.Windows.Forms.Button controlCollapse;
        private System.Windows.Forms.Label controlCommandLabel;
        private System.Windows.Forms.ComboBox controlMediaCommand;
        private System.Windows.Forms.CheckBox controlMediaOSD;
        private System.Windows.Forms.ComboBox controlMouseCommand;
    }




}
