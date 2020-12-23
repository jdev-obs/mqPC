using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace mqtt_play
{
    public partial class ControlGroupSet : UserControl
    {
        #region controlGroupSet Variables
        public int controlID;
        public string type;
        public string displayName;
        public string path;

        public bool collapsed;
        public bool enabled;
        public bool fullStack;

        public KeyCommand keyControl;
        public MediaCommand mediaControl;
        public MouseCommand mouseControl;
        public string macro = "";
        public string batch = "";
        #endregion
        
        #region Error Lists
        // Error 1: No path
        // Error 2: Key Control with no key selected
        // Error 3: Can't use same modifier key twice
        // Error 4: No command selected
        public string[] validationErrorList = new string[]
        {
            "Success",
            "You must enter a path.",
            "You must select a keyboard key.",
            "You cannot use the same key modifier twice",
            "You must select a command.",
            "You must have exactly one * in your path when using a full stack. The * will be replaced by the command string for each individual command option."
        };

        public string[] enableErrorList = new string[]
        {
            "Success",
            "This path is already in use. To activate multiple commands with the same path, please use a Macro command type.",

        };
        #endregion

        #region Dropdown Dictionaries
        private readonly Dictionary<string, string> mouseDropDownList = new Dictionary<string, string>()
        {
            { "full-stack", "Full Stack" },
            { "move-all", "Move (All)" },
            {"move-to","Move (X,Y)" },
            {"lclick","Click" },
            {"dblclick","Double Click" },
            {"rclick","Right Click" },
            {"mclick","Middle Click" },
        };

        private readonly Dictionary<string, string> mediaDropDownList = new Dictionary<string, string>()
        {
            {"full-stack", "Full Stack" },
            {"mute", "Mute" },
            {"vol-up", "Vol Up" },
            {"vol-dwn", "Vol Dwn" },
            {"play" , "Play/Pause" },
            {"stop", "Stop" },
            {"track-prev","Track Prev" },
            {"track-next","Track Next" },
        };

        #endregion

        #region Initializers
        public ControlGroupSet(int PControlID)
        {
            controlID = PControlID;
            type = "Key Control";
            displayName = "";
            path = "";
            collapsed = false;
            enabled = false;
            fullStack = false;
            keyControl = new KeyCommand();
            mediaControl = new MediaCommand();
            mouseControl = new MouseCommand();

            InitializeComponent();
            UICustomInitialization();
            //set save button image
            controlCollapse.BackgroundImage = mqtt_play.Properties.Resources.minus_light_grey;

            controlType.SelectedIndex = controlType.FindStringExact(type);

            controlKeyModifierCount.SelectedIndex = 0;

            this.ShowKeyControlUI();
            this.KeyControlUIUpdate();
        }

        public ControlGroupSet(int PControlID, string PType, string PName, string PPath, bool PCollapsed, bool PEnabled, bool PFullStack, string PCommand)
        {
            controlID = PControlID;
            type = PType;
            displayName = PName;
            path = PPath;
            fullStack = PFullStack;
            collapsed = PCollapsed;

            InitializeComponent();
            UICustomInitialization();

            //set save button image
            controlCollapse.BackgroundImage = mqtt_play.Properties.Resources.minus_light_grey;

            //apply stored values if applicable
            if (displayName != "") this.controlName.Text = displayName;
            if (path != "") this.controlPath.Text = path;

            controlType.SelectedIndex = controlType.FindStringExact(type);

            this.ShowCurrentUI();
            

            switch (type)
            {
                case "Key Control":
                    keyControl = new KeyCommand(PCommand);
                    this.KeyControlUIUpdate();
                    break;
                case "Media Control":
                    mediaControl = new MediaCommand(PCommand);
                    this.MediaControlUIUpdate();
                    break;
                case "Mouse Control":
                    mouseControl = new MouseCommand(PCommand);
                    this.MouseControlUIUpdate();
                    break;
                case "Macro":
                    macro = PCommand;
                    break;
                case "Batch Script":
                    batch = PCommand;
                    break;
            }

            if (keyControl == null) keyControl = new KeyCommand();
            if (mediaControl == null) mediaControl = new MediaCommand();
            if (mouseControl == null) mouseControl = new MouseCommand();

            

            //if collapsed 
            if (collapsed)
            {
                collapsed = false;
                this.Collapse();
            }

            if (PEnabled) this.Enable(true);


        }
        
        public void UICustomInitialization()
        {
            controlMouseCommand.DisplayMember = "Value";
            controlMouseCommand.ValueMember = "Key";
            controlMouseCommand.DataSource = new BindingSource(mouseDropDownList, null);
            controlMouseCommand.SelectedIndex = -1;
            controlMouseCommand.SelectedIndexChanged += new System.EventHandler(this.ControlMouseCommand_SelectedIndexChanged);

            controlMediaCommand.DisplayMember = "Value";
            controlMediaCommand.ValueMember = "Key";
            controlMediaCommand.DataSource = new BindingSource(mediaDropDownList, null);
            controlMediaCommand.SelectedIndex = -1;
            controlMediaCommand.SelectedIndexChanged += new System.EventHandler(this.ControlMediaCommand_SelectedIndexChanged);
        }
        #endregion

        #region UI Button Event Functions
        private void ControlCollapse_Click(object sender, EventArgs e)
        {
            this.Collapse();
        }

        private void ControlDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.OnControlGroupDeleted(EventArgs.Empty);
            this.Dispose();
        }


        private void ControlEnable_Click(object sender, EventArgs e)
        {
            if (this.enabled) this.Disable();
            else this.Enable();
            this.OnControlGroupUpdated(EventArgs.Empty);
        }

        private void ControlSortUp_Click(object sender, EventArgs e)
        {
            if (this.Parent is FlowLayoutPanel)
            {
                int currentIndex = this.Parent.Controls.GetChildIndex(this);
                if (currentIndex > 0)
                {

                    ControlGroupSet movedItem = (ControlGroupSet)this.Parent.Controls[currentIndex - 1];
                    movedItem.TabIndex++;
                    movedItem.OnControlGroupOrderUpdated(EventArgs.Empty);


                    this.Parent.Controls.SetChildIndex(this, currentIndex - 1);
                    this.TabIndex--;

                }
                this.OnControlGroupOrderUpdated(EventArgs.Empty);
            }
        }

        private void ControlSortDown_Click(object sender, EventArgs e)
        {
            if (this.Parent is FlowLayoutPanel)
            {

                int currentIndex = this.Parent.Controls.GetChildIndex(this);

                if (currentIndex < this.Parent.Controls.Count - 1)
                {

                    ControlGroupSet movedItem = (ControlGroupSet)this.Parent.Controls[currentIndex + 1];
                    movedItem.TabIndex--;
                    movedItem.OnControlGroupOrderUpdated(EventArgs.Empty);

                    this.Parent.Controls.SetChildIndex(this, currentIndex + 1);
                    this.TabIndex++;

                    this.OnControlGroupOrderUpdated(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region UI Change Event Functions
        private void ControlPath_TextChanged(object sender, EventArgs e)
        {
            this.path = controlPath.Text;
            this.ControlsUpdated();
        }

        private void ControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == controlType.SelectedItem.ToString()) return;

            this.ShowCurrentUI(false);
            this.type = controlType.SelectedItem.ToString();
            
            switch (type)
            {
                case "Key Control":
                    this.ShowKeyControlUI();
                    this.KeyControlUIUpdate();
                    fullStack = false;
                    break;
                case "Media Control":
                    this.ShowMediaControlUI();
                    this.MediaControlUIUpdate();
                    break;
                case "Mouse Control":
                    this.ShowMouseControlUI();
                    this.MouseControlUIUpdate();
                    break;
                case "Macro":
                    this.ShowMacroUI();
                    fullStack = false;
                    break;
                case "Batch Script":
                    this.ShowBatchUI();
                    fullStack = false;
                    break;
            }
            this.ControlsUpdated();
        }

        private void ControlName_TextChanged(object sender, EventArgs e)
        {
            this.displayName = controlName.Text;
            this.OnControlGroupUpdated(EventArgs.Empty);
        }
        #endregion

        #region UI Display Functions
        public void LockUI(bool canEdit = false)
        {
            controlType.Enabled = canEdit;
            controlPath.Enabled = canEdit;

            switch (type)
            {
                case "Key Control":
                    controlKeyCommand.Enabled = canEdit;
                    controlKeyModifierCount.Enabled = canEdit;
                    controlKeyModifier1.Enabled = canEdit;
                    controlKeyModifier2.Enabled = canEdit;
                    controlKeyModifier3.Enabled = canEdit;
                    break;
                case "Media Control":
                    controlMediaCommand.Enabled = canEdit;
                    controlMediaOSD.AutoCheck = canEdit;
                    break;
                case "Mouse Control":
                    controlMouseCommand.Enabled = canEdit;
                    break;
            }
        }

        private void ShowCurrentUI(bool show = true)
        {
            switch (type)
            {
                case "Key Control":
                    ShowKeyControlUI(show);
                    break;
                case "Media Control":
                    ShowMediaControlUI(show);
                    break;
                case "Mouse Control":
                    ShowMouseControlUI(show);
                    break;
                case "Macro":
                    ShowMacroUI(show);
                    break;
                case "Batch Script":
                    ShowBatchUI(show);
                    break;
            }
        }

        private void ShowKeyControlUI(bool show=true)
        {
            controlKeyModifierCountLabel.Visible = show;
            controlKeyLabel.Visible = show;
            controlKeyModifierCount.Visible = show;
            controlKeyCommand.Visible = show;

            if(!show)
            {
                controlKeyModifier1.Visible = show;
                controlKeyModifier2.Visible = show;
                controlKeyModifier3.Visible = show;
            }
        }

        private void ShowMediaControlUI(bool show = true)
        {
            controlCommandLabel.Visible = show;
            controlMediaCommand.Visible = show;
            if (!show) controlMediaOSD.Visible = false;
        }

        private void ShowMouseControlUI(bool show = true)
        {
            controlCommandLabel.Visible = show;
            controlMouseCommand.Visible = show;
        }

        private void ShowMacroUI(bool show = true)
        {
            Console.WriteLine(show);
        }

        private void ShowBatchUI(bool show = true)
        {
            Console.WriteLine(show);
        }
        #endregion

        #region Main Functions

        public void Collapse()
        {
            if (collapsed)
            {
                controlCollapse.BackgroundImage = mqtt_play.Properties.Resources.minus_light_grey;
                collapsed = false;
                controlFrame.Height = 230;
                this.Height = 233;
            }
            else
            {
                controlCollapse.BackgroundImage = mqtt_play.Properties.Resources.plus_light_grey;
                collapsed = true;
                controlFrame.Height = 74;
                this.Height = 75;
            }
            this.OnControlGroupUpdated(EventArgs.Empty);
        }

        public int Enable(bool silent = false)
        {
            int validationCode = ValidateControls();

            if (validationCode == 0)
            {
                controlEnable.Text = "Disable";
                this.enabled = true;
                controlFrame.Text = "Enabled";
                controlFrame.ForeColor = Color.FromArgb(0, 163, 0);
                this.LockUI();
                this.OnControlGroupEnabled(EventArgs.Empty);
                return 0;
            }
            else if(!silent) MessageBox.Show(validationErrorList[validationCode]);
            return 1;
        }

        public int ValidateControls()
        {

            if (this.path == "") return 1;
            switch (type)
            {
                case "Key Control":
                    if (keyControl.key == null) return 2; // Check if key command present
                    keyControl.ConsolidateModifiers();
                    KeyControlUIUpdate();
                    if (keyControl.modCount == 3 && (keyControl.mod3 == keyControl.mod2 || keyControl.mod3 == keyControl.mod1)) return 3; //Check if mod3 matches mod1 or mod 2
                    if (keyControl.modCount > 1 && keyControl.mod2 == keyControl.mod1) return 3; // Check if mod 2 matches mod 1
                    break;
                case "Media Control":
                    if (mediaControl.command == null) return 4; // Check if media command present
                    if (mediaControl.command == "full-stack" && this.path.Length - this.path.Replace("*", "").Length != 1) return 5; // Verify full stack and that path contains exactly one *
                    break;
                case "Mouse Control":
                    if (mouseControl.command == null) return 4; // Check if mouse command present
                    if ((mouseControl.command == "full-stack" || mouseControl.command == "move-all") && this.path.Length - this.path.Replace("*", "").Length != 1) return 5; // Verify full stack and that path contains exactly one *
                    break;
            }

            return 0;
        }

        public void EnableError(int errorCode)
        {
            this.Disable();
            MessageBox.Show(enableErrorList[errorCode]);
        }

        public void Disable()
        {
            controlEnable.Text = "Enable";
            this.enabled = false;
            controlFrame.Text = "Disabled";
            controlFrame.ForeColor = Color.FromArgb(255, 140, 0);
            this.OnControlGroupDisabled(EventArgs.Empty);
            this.LockUI(true);
        }
        #endregion

        #region Command Controls
        #region Key Control UI
        public void KeyControlUIUpdate()
        {
            controlKeyModifierCount.SelectedIndex = keyControl.modCount;
            controlKeyCommand.SelectedIndex = (keyControl.key != null) ? controlKeyCommand.FindStringExact(keyControl.key) : -1;

            controlKeyModifier1.SelectedIndex = (keyControl.modCount > 0) ? controlKeyModifier1.FindStringExact(keyControl.mod1) : -1;
            controlKeyModifier2.SelectedIndex = (keyControl.modCount > 1) ? controlKeyModifier2.FindStringExact(keyControl.mod2) : -1;
            controlKeyModifier3.SelectedIndex = (keyControl.modCount == 3) ? controlKeyModifier3.FindStringExact(keyControl.mod3) : -1;

            switch (this.keyControl.modCount)
            {
                case 0:
                    controlKeyModifier1.Visible = false;
                    controlKeyModifier2.Visible = false;
                    controlKeyModifier3.Visible = false;
                    controlKeyLabel.Location = new System.Drawing.Point(493, 143);
                    controlKeyLabel.Text = "Key:";
                    break;
                case 1:
                    controlKeyModifier1.Visible = true;
                    controlKeyModifier2.Visible = false;
                    controlKeyModifier3.Visible = false;
                    controlKeyLabel.Location = new System.Drawing.Point(372, 143);
                    controlKeyLabel.Text = "Keys:";
                    break;
                case 2:
                    controlKeyModifier1.Visible = true;
                    controlKeyModifier2.Visible = true;
                    controlKeyModifier3.Visible = false;
                    controlKeyLabel.Location = new System.Drawing.Point(262, 143);
                    controlKeyLabel.Text = "Keys:";
                    break;
                case 3:
                    controlKeyModifier1.Visible = true;
                    controlKeyModifier2.Visible = true;
                    controlKeyModifier3.Visible = true;
                    controlKeyLabel.Location = new System.Drawing.Point(152, 143);
                    controlKeyLabel.Text = "Keys:";
                    break;
            }
        }

        private void ControlKeyCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyControl.key = controlKeyCommand.SelectedItem.ToString();
            this.ControlsUpdated();
        }

        private void ControlKeyModifier3_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyControl.mod3 = (controlKeyModifier3.SelectedIndex != -1) ? controlKeyModifier3.SelectedItem.ToString() : null;
            this.ControlsUpdated();
        }

        private void ControlKeyModifier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyControl.mod2 = (controlKeyModifier2.SelectedIndex != -1) ? controlKeyModifier2.SelectedItem.ToString() : null;
            this.ControlsUpdated();
        }

        private void ControlKeyModifier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyControl.mod1 = (controlKeyModifier1.SelectedIndex != -1) ? controlKeyModifier1.SelectedItem.ToString() : null;
            this.ControlsUpdated();
        }

        private void ControlKeyModifierCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.keyControl.modCount = this.controlKeyModifierCount.SelectedIndex;
            this.KeyControlUIUpdate();
            this.ControlsUpdated();
        }

        #endregion

        #region Media Control UI

        public void MediaControlUIUpdate()
        {
            if (mediaControl.command != null) controlMediaCommand.SelectedValue = mediaControl.command;
            controlMediaOSD.Checked = mediaControl.osd;

            if (mediaControl.command == "full-stack" || mediaControl.command == "vol-up" || mediaControl.command == "vol-dwn" || mediaControl.command == "mute") controlMediaOSD.Visible = true;
            else controlMediaOSD.Visible = false;

            this.fullStack = (mediaControl.command == "full-stack");
        }

        private void ControlMediaCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mediaControl.command = controlMediaCommand.SelectedValue?.ToString();
            this.MediaControlUIUpdate();
            this.ControlsUpdated();
        }

        private void ControlMediaOSD_CheckedChanged(object sender, EventArgs e)
        {
            this.mediaControl.osd = controlMediaOSD.Checked;
            this.ControlsUpdated();
        }
        #endregion

        #region Mouse Control UI

        public void MouseControlUIUpdate()
        {
            if (mouseControl.command != null) controlMouseCommand.SelectedValue = mouseControl.command;

            this.fullStack = (mouseControl.command == "full-stack" || mouseControl.command == "move-all");
        }

        private void ControlMouseCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mouseControl.command = controlMouseCommand.SelectedValue?.ToString();
            this.MouseControlUIUpdate();
            this.ControlsUpdated();
        }
        #endregion

        #endregion

        #region Events
        public void ControlsUpdated()
        {
            if (this.enabled) this.Disable();
            this.OnControlGroupUpdated(EventArgs.Empty);
        }

        protected virtual void OnControlGroupUpdated(EventArgs e)
        {
            ControlGroupUpdated?.Invoke(this, e);
        }

        protected virtual void OnControlGroupOrderUpdated(EventArgs e)
        {
            ControlGroupOrderUpdated?.Invoke(this, e);
        }

        protected virtual void OnControlGroupDeleted(EventArgs e)
        {
            ControlGroupDeleted?.Invoke(this, e);
        }

        protected virtual void OnControlGroupEnabled(EventArgs e)
        {
            ControlGroupEnabled?.Invoke(this, e);
        }

        protected virtual void OnControlGroupDisabled(EventArgs e)
        {
            ControlGroupDisabled?.Invoke(this, e);
        }
        
        public event EventHandler ControlGroupUpdated;
        public event EventHandler ControlGroupOrderUpdated;
        public event EventHandler ControlGroupDeleted;
        public event EventHandler ControlGroupEnabled;
        public event EventHandler ControlGroupDisabled;

        #endregion


    }

    public class KeyCommand
    {
        public string key;
        public int modCount;
        public string mod1;
        public string mod2;
        public string mod3;

        public KeyCommand()
        {
            key = null;
            modCount = 0;
            mod1 = null;
            mod2 = null;
            mod3 = null;
        }

        public KeyCommand(string Serialization)
        {
            string[] serialVals = Serialization.Split(new[] { ":::" }, StringSplitOptions.None);

            key = (serialVals[0] != "") ? serialVals[0] : null;
            modCount = Int32.Parse(serialVals[1]);
            mod1 = (modCount > 0) ? serialVals[2] : null;
            mod2 = (modCount > 1) ? serialVals[3] : null;
            mod3 = (modCount == 3) ? serialVals[4] : null;
        }

        public string Serialize()
        {
            return key + ":::" + modCount + ":::" + mod1 + ":::" + mod2 + ":::" + mod3;
        }

        public void ConsolidateModifiers()
        {
            if (this.modCount == 3)
            {
                if (this.mod3 == null) this.modCount = 2;
                else
                {
                    if (this.mod2 == null)
                    {
                        this.mod2 = this.mod3;
                        this.mod3 = null;
                        this.modCount = 2;
                    }
                    else
                    {
                        if (this.mod1 == null)
                        {
                            this.mod1 = this.mod2;
                            this.mod2 = this.mod3;
                            this.mod3 = null;
                            this.modCount = 2;
                        }
                    }
                }
            }

            if (this.modCount == 2)
            {
                if (this.mod2 == null) this.modCount = 1;
                else
                {
                    if (this.mod1 == null)
                    {
                        this.mod1 = this.mod2;
                        this.mod2 = null;
                        this.modCount = 1;
                    }
                }
            }

            if (this.modCount == 1 && this.mod1 == null) this.modCount = 0; 
        }
    }

    public class MediaCommand
    {
        public string command;
        public bool osd;

        public string[] fullStackCommands = new string[]
        {
            "mute",
            "vol-up",
            "vol-dwn",
            "play",
            "stop",
            "track-prev",
            "track-next"
        };

        public string[] OSDStackCommands = new string[]
        {
            "mute-osd",
            "vol-up-osd",
            "vol-dwn-osd",
            "mute",
            "vol-up",
            "vol-dwn",
            "play",
            "stop",
            "track-prev",
            "track-next"
        };

        public MediaCommand()
        {
            this.command = null;
            this.osd = false;
        }

        public MediaCommand(string Serialization)
        {
            string[] serialVals = Serialization.Split(new[] { ":::" }, StringSplitOptions.None);
            this.command = (serialVals[0] != "") ? serialVals[0] : null;
            this.osd = (serialVals[1] == "True" || serialVals[1] == "False") && bool.Parse(serialVals[1]);
        }

        public string Serialize()
        {
            return this.command + ":::" + this.osd;
        }

    }

    public class MouseCommand
    {
        public string command;

        public string[] fullStackCommands = new string[]
        {
            "move-left",
            "move-right",
            "move-up",
            "move-down",
            "move-to",
            "click",
            "dbl-click",
            "rclick",
            "mclick"
        };

        public string[] moveCommands = new string[]
        {
            "move-left",
            "move-right",
            "move-up",
            "move-down",
            "move-to",
        };

        public MouseCommand()
        {
            this.command = null;
        }

        public MouseCommand(string Serialization)
        {
            string[] serialVals = Serialization.Split(new[] { ":::" }, StringSplitOptions.None);
            this.command = (serialVals[0] != "") ? serialVals[0] : null;
        }

        public string Serialize()
        {
            return this.command;
        }
    }
}
