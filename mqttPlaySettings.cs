using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinControlCommander;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Xml.XPath;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace mqtt_play
{
    public partial class MQTTPlaySettings : Form
    {
        readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MQTTPlaySettings));

        #region Stored Values
        //UI Flags
        public bool mqttPlayCanClose = false;
        public bool saved = false;
        public bool ordered = true;
        public string activeTab = "status";


        //Tab Colors
        public Dictionary<string, Color> colorValues = new Dictionary<string, Color>(){
            {"mainBack", Color.FromArgb(34,34,34) },
            {"titleBack", Color.FromArgb(15,15,15) },
            {"titleFore", Color.FromArgb(255,140,0) },
            {"closeBack", Color.FromArgb(25,25,25) },
            {"closeFore", Color.FromArgb(255,140,0)},
            {"closeBackHover", Color.FromArgb(60,60,60) },

            {"tabBack", Color.FromArgb(25,25,25) },
            {"tabFore", Color.FromArgb(255,140,0) },
            {"tabBackHover", Color.FromArgb(60,60,60) },
            {"tabBackClick", Color.FromArgb(5,5,5) },
            {"tabActiveBack", Color.FromArgb(255,140,0) },
            {"tabActiveFore", Color.FromArgb(45,45,45) },
            {"tabActiveBackHover", Color.FromArgb(255,170,0) },
            {"tabActiveBackClick", Color.FromArgb(190,100,0) },

            {"buttonOtherBack", Color.FromArgb(25,25,25) },
            {"buttonOtherFore", Color.FromArgb(25,25,25) },
            {"buttonOtherBackHover", Color.FromArgb(25,25,25) },

            {"csBack", Color.FromArgb(25,25,25) },
            {"csFrame", Color.FromArgb(25,25,25) },
            {"csEnabledLabel", Color.FromArgb(25,25,25) },
            {"csDisabledLabel", Color.FromArgb(25,25,25) },
            {"csText", Color.FromArgb(25,25,25) },
            {"csTextboxBack", Color.FromArgb(25,25,25) },
            {"csButtonBack", Color.FromArgb(25,25,25) },
            {"csButtonFore", Color.FromArgb(25,25,25) },
            {"csButtonBackHover", Color.FromArgb(25,25,25) },

            {"labelColor", Color.FromArgb(25,25,25) },
            {"valueColor", Color.FromArgb(25,25,25) },
            {"textboxBack", Color.FromArgb(25,25,25) },
            {"textboxFore", Color.FromArgb(25,25,25) },
        };
        public bool colorSaves = false;

        //Custom Titlebar
        private readonly PictureBox titleBar = new PictureBox();
        private readonly Label titleClose = new Label();
        private bool titleDrag = false;
        private Point titlePoint = new Point(0, 0);
        private readonly Label titleText = new Label();
        private readonly Label titleIcon = new Label();

        //Control Group Stores
        public SortedDictionary<int, ControlGroupSet> controlInventory = new SortedDictionary<int, ControlGroupSet>() { }; //main control list sorted by controlID
        public HashSet<int> controlSaves = new HashSet<int>(); //to save
        public HashSet<int> controlDeletes = new HashSet<int>(); //to delete

        //XML
        public XDocument xConfig;
        public string xmlFile = "config.xml";


        //Mqtt
        public MqttClient client;

        public string mqttDeviceName;
        public string mqttIP;
        public string mqttPort;
        public string mqttUser;
        public string mqttPass;
        public bool mqttStartupConnect;


        public int mqttReconnect = 0;
        public bool mqttConnected = false;
        public bool mqttUserDisconnected = false;

        public Dictionary<string, int> mqttRegistry = new Dictionary<string, int>() { };

        //MQTT Connection Delegates
        public delegate void SafeMQTTConnectionButtonDelegate(bool connected, int button);
        public delegate void SafeMQTTBoxLockDelegate(TextBox box, bool ro, Color textBackColor, BorderStyle textBorder);
        public delegate void SafeMQTTCancelButtonDelegate(bool reconnecting, int button);
        public delegate void SafeMQTTCancelButtonUnlockDelegate(bool disabled);
        public delegate void SafeMQTTLabelUpdateDelegate(int type);

        //Status Update Delegates
        public delegate void SafeUpdateTextBox(TextBox box, string value);
        public delegate void SafeStatusLastCommCallDelegate(string topic, string message);



        #endregion
        public MQTTPlaySettings()
        {
            InitializeComponent();
            bool newConf = false;

            #region Custom Titlebar
            this.titleBar.Location = this.Location;
            this.titleBar.Width = this.Width;
            this.titleBar.Height = 30;
            this.titleBar.BackColor = colorValues["titleBack"];
            this.mainTableLayout.Controls.Add(this.titleBar, 0, 0);
            this.mainTableLayout.SetColumnSpan(titleBar, 2);

            this.titleText.Text = "mqPC";
            this.titleText.Font = new Font(this.titleClose.Font.FontFamily, 7, FontStyle.Regular);
            this.titleText.Location = new Point(29, 6);
            this.titleText.ForeColor = colorValues["tabFore"];
            this.titleText.BackColor = colorValues["titleBack"];
            
            this.Controls.Add(this.titleText);
            this.titleText.BringToFront();

            this.titleIcon.Location = new Point(4, 6);
            this.titleIcon.Image = mqtt_play.Properties.Resources.mqtt_play;
            this.titleIcon.Padding = new Padding(0,0,0,0);
            this.titleIcon.Width = 25;
            this.titleIcon.BackColor = colorValues["titleBack"];
            this.Controls.Add(this.titleIcon);
            this.titleIcon.BringToFront();

            this.titleClose.Text = "X";
            this.titleClose.Font = new Font(this.titleClose.Font.FontFamily, 7, FontStyle.Bold);
            this.titleClose.TextAlign = ContentAlignment.MiddleCenter;
            this.titleClose.Location = new Point(this.Width - 29, 5);
            this.titleClose.ForeColor = colorValues["tabFore"];
            this.titleClose.BackColor = colorValues["tabBack"];
            this.titleClose.Width = 24;
            this.Controls.Add(this.titleClose);
            this.titleClose.BringToFront();

            this.titleClose.MouseEnter += new EventHandler(TitleControl_MouseEnter);
            this.titleClose.MouseLeave += new EventHandler(TitleControl_MouseLeave);
            this.titleClose.MouseClick += new MouseEventHandler(TitleControl_MouseClick);

            this.titleBar.MouseDown += new MouseEventHandler(TitleBar_MouseDown);
            this.titleBar.MouseUp += new MouseEventHandler(TitleBar_MouseUp);
            this.titleBar.MouseMove += new MouseEventHandler(TitleBar_MouseMove);

            this.titleText.MouseDown += new MouseEventHandler(TitleBar_MouseDown);
            this.titleText.MouseUp += new MouseEventHandler(TitleBar_MouseUp);
            this.titleText.MouseMove += new MouseEventHandler(TitleBar_MouseMove);

            this.titleIcon.MouseDown += new MouseEventHandler(TitleBar_MouseDown);
            this.titleIcon.MouseUp += new MouseEventHandler(TitleBar_MouseUp);
            this.titleIcon.MouseMove += new MouseEventHandler(TitleBar_MouseMove);

            #endregion

            try
            {
                xConfig = XDocument.Load(xmlFile);
            }
            catch (FileNotFoundException)
            {
                string xmlConfBase = "<collection><mqttSettings><deviceName></deviceName><ip></ip><port></port><user></user><password></password><startupConnect>False</startupConnect></mqttSettings><controlGroupSets></controlGroupSets><uiColors></uiColors></collection>";
                File.WriteAllText(xmlFile, xmlConfBase);
                xConfig = XDocument.Parse(xmlConfBase);
                newConf = true;
                mqttStartupConnect = false;
            }

            buttonSave.BackgroundImage = mqtt_play.Properties.Resources.diskette_o_saved;

            if (!newConf)
            {
                mqttDeviceNameVal.Text = xConfig.Root.Element("mqttSettings").Element("deviceName").Value;
                mqttBrokerIPVal.Text = xConfig.Root.Element("mqttSettings").Element("ip").Value;
                mqttBrokerPortVal.Text = xConfig.Root.Element("mqttSettings").Element("port").Value;
                mqttUserVal.Text = xConfig.Root.Element("mqttSettings").Element("user").Value;
                mqttPasswordVal.Text = xConfig.Root.Element("mqttSettings").Element("password").Value;
                string startConnectString = xConfig.Root.Element("mqttSettings").Element("startupConnect").Value;
                mqttConnectOnStartup.Checked = (startConnectString == "True" || startConnectString == "False") && bool.Parse(startConnectString);
                RestoreUIColors();
            }

            RestoreControlGroupSets();

            if (mqttStartupConnect) MQTTConnect();

        }

        protected override void OnShown(EventArgs e) //Hide on start
        {
            base.OnShown(e);
            this.Hide();
        }

        private void MQTTPlaySettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !mqttPlayCanClose)
            {
                e.Cancel = true;
                Hide();
            }
        }

        #region Title Events
        private void TitleControl_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.titleClose)) this.titleClose.BackColor = colorValues["tabBackHover"];
        }

        private void TitleControl_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(this.titleClose)) this.titleClose.BackColor = colorValues["tabBack"];
        }

        private void TitleControl_MouseClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.titleDrag = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.titlePoint = e.Location;
            this.titleDrag = true;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.titleDrag)
            {
                Point p2 = this.PointToScreen(new Point(e.X, e.Y));
                p2 = new Point(p2.X - this.titlePoint.X, p2.Y - this.titlePoint.Y);
                this.Location = p2;
            }
        }

        #endregion

        #region Tray UI
        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void NotifyIconMenu_SettingsButton(object sender, EventArgs e)
        {
            this.Show();
        }

        private void NotifyIconMenu_CloseButton(object sender, EventArgs e)
        {
            this.mqttPlayCanClose = true;
            if (mqttConnected) MQTTDisconnect();
            this.Close();
        }

        #endregion

        #region Tab UI
        private void SwitchTab(string newTab)
        {

            if (this.activeTab == newTab) return;

            Button newButton;
            Button activeButton;
            Panel newPanel;
            Panel activePanel;

            switch (newTab)
            {
                case "status":
                    newButton = tabButtonStatus;
                    newPanel = statusPanel;
                    break;
                case "controls":
                    newButton = tabButtonControls;
                    newPanel = controlsPanel;
                    break;
                case "mqtt":
                    newButton = tabButtonMQTT;
                    newPanel = mqttPanel;
                    break;
                case "ui":
                    newButton = tabButtonUI;
                    newPanel = uiPanel;
                    break;
                default:
                    return;
            }

            switch (this.activeTab)
            {
                case "status":
                    activeButton = tabButtonStatus;
                    activePanel = statusPanel;
                    break;
                case "controls":
                    activeButton = tabButtonControls;
                    activePanel = controlsPanel;
                    break;
                case "mqtt":
                    activeButton = tabButtonMQTT;
                    activePanel = mqttPanel;
                    break;
                case "ui":
                    activeButton = tabButtonUI;
                    activePanel = uiPanel;
                    break;
                default:
                    return;
            }

            this.activeTab = newTab;

            activePanel.Hide();
            newPanel.Show();

            //Set Active Tab Button to Normal Style
            activeButton.BackColor = colorValues["tabBack"];
            activeButton.ForeColor = colorValues["tabFore"];
            activeButton.FlatAppearance.MouseDownBackColor = colorValues["tabBackClick"];
            activeButton.FlatAppearance.MouseOverBackColor = colorValues["tabBackHover"];
            activeButton.Font = new Font(activeButton.Font.FontFamily, activeButton.Font.Size, FontStyle.Regular);

            //Set New Tab to Active Tab Style
            newButton.BackColor = colorValues["tabActiveBack"];
            newButton.ForeColor = colorValues["tabActiveFore"];
            newButton.FlatAppearance.MouseDownBackColor = colorValues["tabActiveBackClick"];
            newButton.FlatAppearance.MouseOverBackColor = colorValues["tabActiveBackHover"];
            newButton.Font = new Font(newButton.Font.FontFamily, newButton.Font.Size, FontStyle.Bold);
        }

        private void TabButtonStatus_Click(object sender, EventArgs e)
        {
            SwitchTab("status");
        }

        private void TabButtonControls_Click(object sender, EventArgs e)
        {
            SwitchTab("controls");
        }

        private void TabButtonMQTT_Click(object sender, EventArgs e)
        {
            SwitchTab("mqtt");
        }

        private void TabButtonUI_Click(object sender, EventArgs e)
        {
            SwitchTab("ui");
        }

        #endregion

        #region Status UI
        private void UpdateStatus()
        {
            string connectStatus = (mqttConnected) ? "Connected" : "Disconnected"; 
            
            UpdateTextBox(statusCurrentVal, connectStatus);

            UpdateTextBox(statusDeviceNameVal, mqttDeviceName);
            UpdateTextBox(statusIPVal, mqttIP);
            UpdateTextBox(statusPortVal, mqttPort);    
        }

        private void UpdateTextBox(TextBox box, string value)
        {
            if (box.InvokeRequired)
            {
                var d = new SafeUpdateTextBox(UpdateTextBox);
                statusCurrentVal.Invoke(d, new object[] { box, value });
            }
            else
                box.Text = value;
        }

        private void UpdateStatusLastComm(string topic, string message)
        {
            string lastComm = "Topic: " + topic + " Message: " + message;

            if (statusLastCommVal.InvokeRequired)
            {
                var d = new SafeStatusLastCommCallDelegate(UpdateStatusLastComm);
                statusLastCommVal.Invoke(d, new object[] { topic, message });
            }
            else
                statusLastCommVal.Text = lastComm;

        }

        #endregion

        #region MQTT UI
        private void MQTTUILock(bool ro=true)
        {
            Color textBackColor;
            BorderStyle textBorder;
            List<TextBox> textBoxes = new List<TextBox>() {
                mqttDeviceNameVal,
                mqttBrokerIPVal,
                mqttBrokerPortVal,
                mqttUserVal,
                mqttPasswordVal
            };

            if (ro)
            {
                textBackColor = Color.FromArgb(34, 34, 34);
                textBorder = BorderStyle.None;
            }
            else
            {
                textBackColor = Color.FromArgb(25, 25, 25);
                textBorder = BorderStyle.Fixed3D;
            }

            foreach(TextBox box in textBoxes)
            {
                MQTTBoxLock(box, ro, textBackColor, textBorder);
            }

            //set connect and disconnect buttons
            MQTTConnectionButton(ro);
        }

        private void MQTTBoxLock(TextBox box, bool ro, Color textBackColor, BorderStyle textBorder)
        {
            if(box.InvokeRequired)
            {
                var d = new SafeMQTTBoxLockDelegate(MQTTBoxLock);
                box.Invoke(d, new object[] { box, ro, textBackColor, textBorder });
            } else
            {
                box.ReadOnly = ro;
                box.BackColor = textBackColor;
                box.BorderStyle = textBorder;
            }
        }

        private void MQTTConnectionButton(bool connected=true, int button=0)
        {
            if(button != 2)
            {
                if (mqttConnect.InvokeRequired)
                {
                    var d = new SafeMQTTConnectionButtonDelegate(MQTTConnectionButton);
                    mqttConnect.Invoke(d, new object[] { connected, 1 });
                } 
                else mqttConnect.Visible = !connected;

            }

            if(button != 1)
            {
                if (mqttDisconnect.InvokeRequired)
                {
                    var d = new SafeMQTTConnectionButtonDelegate(MQTTConnectionButton);
                    mqttDisconnect.Invoke(d, new object[] { connected, 2 });
                }
                else mqttDisconnect.Visible = connected;
            }
        }
        
        private void MQTTCancelButton(bool reconnecting, int button = 0)
        {
            if(button != 2)
            {
                if (mqttDisconnect.InvokeRequired)
                {
                    var d = new SafeMQTTCancelButtonDelegate(MQTTCancelButton);
                    mqttDisconnect.Invoke(d, new object[] { reconnecting, 1 });
                }
                else mqttDisconnect.Visible = !reconnecting;
            }
            
            if (button != 1)
            {
                if (mqttCancel.InvokeRequired)
                {
                    var d = new SafeMQTTCancelButtonDelegate(MQTTCancelButton);
                    mqttCancel.Invoke(d, new object[] { reconnecting, 2 });
                }
                else mqttCancel.Visible = reconnecting;
            }
        }

        private void MQTTCancelButtonLock(bool disabled = true)
        {
            if(mqttCancel.InvokeRequired)
            {
                var d = new SafeMQTTCancelButtonUnlockDelegate(MQTTCancelButtonLock);
                mqttCancel.Invoke(d, new object[] { disabled });
            }
            else mqttCancel.Enabled = !disabled;
        }

        private void MQTTLabelUpdate(int type)
        {
            //public delegate void SafeMQTTLabelUpdateDelegate(int status);
            string[] messages =
            {
                "",
                "Disconnected. Attempting to reconnect.",
                "Connection failed.",
                "Cancelling reconnection attempt."
            };

            if (mqttConnectionAttempt.InvokeRequired)
            {
                var d = new SafeMQTTLabelUpdateDelegate(MQTTLabelUpdate);
                mqttConnectionAttempt.Invoke(d, new object[] { type });
            }
            else
                mqttConnectionAttempt.Text = messages[type];
        }

        private void MQTTConnect_Click(object sender, EventArgs e)
        {
            mqttReconnect = 0;
            MQTTConnect();
        }

        private void MQTTDisconnect_Click(object sender, EventArgs e)
        {
            MQTTDisconnect();
        }

        private void MQTTCancel_Click(object sender, EventArgs e)
        {
            mqttReconnect = 0;
            MQTTLabelUpdate(3);
            MQTTCancelButtonLock();
        }

        private void MQTTDeviceNameVal_TextChanged(object sender, EventArgs e)
        {
            this.mqttDeviceName = mqttDeviceNameVal.Text;
            this.ContentUpdated();
        }

        private void MQTTBrokerIPVal_TextChanged(object sender, EventArgs e)
        {
            this.mqttIP = mqttBrokerIPVal.Text;
            this.ContentUpdated();
        }
        
        private void MQTTBrokerPortVal_TextChanged(object sender, EventArgs e)
        {
            this.mqttPort = mqttBrokerPortVal.Text;
            this.ContentUpdated();
        }

        private void MQTTUserVal_TextChanged(object sender, EventArgs e)
        {
            this.mqttUser = mqttUserVal.Text;
            this.ContentUpdated();
        }

        private void MQTTPasswordVal_TextChanged(object sender, EventArgs e)
        {
            this.mqttPass = mqttPasswordVal.Text;
            this.ContentUpdated();
        }

        private void MQTTConnectOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            this.mqttStartupConnect = mqttConnectOnStartup.Checked;
            this.ContentUpdated();
        }

        #endregion

        #region MQTT Client
        public void MQTTDisconnect()
        {
            mqttUserDisconnected = true;
            mqttReconnect = 0;
            if (client != null) client.Disconnect();
            MQTTUILock(false);
        }

        public async void MQTTConnect()
        {
            //validate 
            if (mqttIP == null || mqttIP == "")
            {
                MessageBox.Show("Please enter a valid IP address type");
                return;
            }
            if (IPAddress.TryParse(mqttIP, out IPAddress address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        //Valid IPv4 (continue)
                        break;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        // Valid IPv6 (unsure if these pass through to PAHO) (For now let's prompt user IPv6 is untested)
                        MessageBox.Show("Please note that IPv6 is untested.");
                        break;
                    default:
                        MessageBox.Show("Please enter a valid IP address type");
                        return;
                }
            }


            client = new MqttClient(this.mqttIP);

            //register to message received

            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            client.MqttMsgSubscribed += Client_MqttMsgSubscribed;
            client.MqttMsgUnsubscribed += Client_MqttMsgUnsubscribed;
            client.ConnectionClosed += Client_ConnectionClosed;

            
            MQTTUILock();

            while (mqttReconnect == 0 || mqttReconnect == 2)
            {
                try
                {
                    if (client.Connect(Guid.NewGuid().ToString(), mqttUser, mqttPass) == 0)
                    {
                        if(mqttReconnect == 2) MQTTCancelButton(false);
                        mqttConnected = true;
                        mqttReconnect = 1;
                        UpdateStatus();
                        MQTTLabelUpdate(0);
                        foreach (KeyValuePair<string, int> entry in mqttRegistry)
                            MQTTUpdateSubscription(entry.Key);
                        MQTTUILock();
                    } else
                    {
                        if (mqttReconnect == 0)
                        {
                            mqttReconnect = -1;
                            client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                            client.MqttMsgSubscribed -= Client_MqttMsgSubscribed;
                            client.MqttMsgUnsubscribed -= Client_MqttMsgUnsubscribed;
                            client.ConnectionClosed -= Client_ConnectionClosed;
                            if (!mqttCancel.Enabled)
                            {
                                MQTTCancelButtonLock(false);
                                MQTTCancelButton(false, 2);
                                MQTTLabelUpdate(0);
                            } 
                            else MQTTLabelUpdate(2);
                            MQTTUILock(false);
                        }
                        else MQTTCancelButton(true);
                    }
                }
                catch {
                    if (mqttReconnect == 0)
                    {
                        mqttReconnect = -1;
                        client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                        client.MqttMsgSubscribed -= Client_MqttMsgSubscribed;
                        client.MqttMsgUnsubscribed -= Client_MqttMsgUnsubscribed;
                        client.ConnectionClosed -= Client_ConnectionClosed;
                        if (!mqttCancel.Enabled)
                        {
                            MQTTCancelButtonLock(false);
                            MQTTCancelButton(false, 2);
                            MQTTLabelUpdate(0);
                        }
                        else MQTTLabelUpdate(2);
                        MQTTUILock(false);
                    }
                    else MQTTCancelButton(true);
                }
                if (mqttReconnect == 2)
                    await Task.Delay(10000);
            }
            
        }

        void MQTTUpdateSubscription(string topic, bool subscribe = true)
        {
            string[] topics = { topic };
            if (subscribe)
            {
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
                client.Subscribe(topics, qosLevels);
            } 
            else
                client.Unsubscribe(topics);
        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string payload = Encoding.UTF8.GetString(e.Message);
            if (mqttRegistry.ContainsKey(e.Topic))
            {
                int id = mqttRegistry[e.Topic];
                ControlGroupSet controlSet = controlInventory[id];
                if (controlSet.fullStack) PerformControlFunction(controlSet, payload, e.Topic);
                else PerformControlFunction(controlSet, payload);
            }

            UpdateStatusLastComm(e.Topic, payload);
        }

        void Client_ConnectionClosed(object sender, EventArgs e)
        {

            mqttConnected = false;
            //Don't update status if app is closing
            if (!mqttPlayCanClose) UpdateStatus(); // Dont update status if app is closing
            if (mqttReconnect == 1) mqttReconnect = 2;
            //Don't reconnect if the connection closed by user interactions
            if (mqttUserDisconnected || mqttReconnect == -1)
            {
                mqttUserDisconnected = false;
                return;
            }
            MQTTLabelUpdate(1);
            MQTTConnect();
        }

        void Client_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            //catch un-subscribes here
        }

        void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            //catch subscribes here
        }
        #endregion

        #region Control Tab
        #region Control UI

        private void ControlButtonAdd_Click(object sender, EventArgs e)
        {
            int newKey = (controlInventory.Count > 0)? controlInventory.Last().Key + 1 : 1;

            ControlGroupSet newControlGroupSet = new ControlGroupSet(newKey) {
                Name = "controlGroupSet" + newKey,
                TabIndex = this.controlItemFlowPanel.Controls.Count,
            };

            controlInventory.Add(newKey, newControlGroupSet);

            this.controlItemFlowPanel.Controls.Add(newControlGroupSet);

            newControlGroupSet.ControlGroupUpdated += ControlGroupInstance_Updated;
            newControlGroupSet.ControlGroupOrderUpdated += ControlGroupOrder_Updated;
            newControlGroupSet.ControlGroupEnabled += ControlGroup_Enabled;
            newControlGroupSet.ControlGroupDisabled += ControlGroup_Disabled;
            newControlGroupSet.ControlGroupDeleted += ControlGroupInstance_Deleted;

            controlSaves.Add(newKey);
            this.ContentUpdated();
        }

        private void ControlButtonCollapse_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, ControlGroupSet> control in controlInventory)
                if (!control.Value.collapsed) control.Value.Collapse();
        }

        private void ControlButtonExpand_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, ControlGroupSet> control in controlInventory)
                if (control.Value.collapsed) control.Value.Collapse();
        }
        #endregion

        #region Control Group Set Event Listeners
        void ControlGroupInstance_Deleted(object sender, EventArgs e)
        {
            if (sender is ControlGroupSet toDelete)
            {
                toDelete.ControlGroupUpdated -= ControlGroupInstance_Updated;
                toDelete.ControlGroupOrderUpdated -= ControlGroupOrder_Updated;
                toDelete.ControlGroupEnabled -= ControlGroup_Enabled;
                toDelete.ControlGroupDisabled -= ControlGroup_Disabled;
                toDelete.ControlGroupDeleted -= ControlGroupInstance_Deleted;

                controlSaves.Remove(toDelete.controlID);
                controlDeletes.Add(toDelete.controlID);
                this.controlInventory.Remove(toDelete.controlID);

                if (toDelete.Enabled)
                {
                    foreach (var item in mqttRegistry.Where(kvp => kvp.Value == toDelete.controlID).ToList())
                    {
                        mqttRegistry.Remove(item.Key);
                        if (mqttConnected) MQTTUpdateSubscription(item.Key, false);
                    }
                }
            }

            this.UpdateControlSortByIndex();
            this.ContentUpdated();
        }

        void ControlGroup_Enabled(object sender, EventArgs E)
        {
            if (sender is ControlGroupSet toSubscribe)
            {
                if (mqttRegistry.ContainsValue(toSubscribe.controlID))
                {
                    toSubscribe.EnableError(1);
                    return;
                }
                SubscribeControlGroup(toSubscribe);
            }
        }

        void ControlGroup_Disabled(object sender, EventArgs E)
        {
            if (sender is ControlGroupSet toDisable)
            {
                foreach (var item in mqttRegistry.Where(kvp => kvp.Value == toDisable.controlID).ToList())
                {
                    mqttRegistry.Remove(item.Key);
                    if (mqttConnected) MQTTUpdateSubscription(item.Key);
                }
            }
        }

        void ControlGroupInstance_Updated(object sender, EventArgs e)
        {
            if (sender is ControlGroupSet toSave) controlSaves.Add(toSave.controlID);
            this.ContentUpdated();
        }

        void ControlGroupOrder_Updated(object sender, EventArgs e)
        {
            if (sender is ControlGroupSet toSave) controlSaves.Add(toSave.controlID);
            if (ordered) ordered = false;
            this.ContentUpdated();
        }
        #endregion

        #region Control Group Functions
        void SubscribeControlGroup(ControlGroupSet toSubscribe)
        {
            if (!toSubscribe.fullStack)
            {
                mqttRegistry.Add(this.mqttDeviceName + "/" + toSubscribe.path, toSubscribe.controlID);
                if (mqttConnected) MQTTUpdateSubscription(this.mqttDeviceName + "/" + toSubscribe.path);
            }
            else
            {
                string[] commands = new string[] { };
                switch (toSubscribe.type)
                {
                    case "Media Control":
                        commands = (toSubscribe.mediaControl.osd) ? toSubscribe.mediaControl.OSDStackCommands : toSubscribe.mediaControl.fullStackCommands;
                        break;
                    case "Mouse Control":
                        if (toSubscribe.mouseControl.command == "full-stack") commands = toSubscribe.mouseControl.fullStackCommands;
                        else if (toSubscribe.mouseControl.command == "move-all") commands = toSubscribe.mouseControl.moveCommands;
                        break;
                }

                foreach (string command in commands)
                {
                    string path = this.mqttDeviceName + "/" + toSubscribe.path.Replace("*", command);
                    mqttRegistry.Add(path, toSubscribe.controlID);
                    if (mqttConnected) MQTTUpdateSubscription(path);
                }
            }
        }

        void UpdateControlSortByIndex()
        {
            foreach (ControlGroupSet control in this.controlItemFlowPanel.Controls)
            {
                control.TabIndex = control.Parent.Controls.GetChildIndex(control); //assign Tab Index to current control item flow panel index
                controlSaves.Add(control.controlID);
            }
        }

        void PerformControlFunction(ControlGroupSet controlSet, string payload, string fullStackCommand = "")
        {
            
            switch (controlSet.type)
            {
                case "Key Control":
                    PerformKeyControl(controlSet.keyControl);
                    break;
                case "Media Control":
                    PerformMediaControl(controlSet, payload, fullStackCommand);
                    break;
                case "Mouse Control":
                    PerformMouseControl(controlSet, payload, fullStackCommand);
                    break;
                case "Macro":
                    MessageBox.Show(controlSet.displayName);
                    break;
                case "Batch Script":
                    MessageBox.Show(controlSet.displayName);
                    break;

            }
        }

        void PerformKeyControl(KeyCommand keyControl)
        {
            List<string> mods = new List<string>();

            if (keyControl.modCount > 0) mods.Add(keyControl.mod1);
            if(keyControl.modCount > 1) mods.Add(keyControl.mod2);
            if (keyControl.modCount == 3) mods.Add(keyControl.mod3);

            KBControl.SendKeyCombo(keyControl.key, mods);
        }

        string FullStackToCommand(string path, string topic)
        {
            int commLen = topic.Length - path.Length;
            int marker = path.IndexOf("*") + 1 + commLen;
            int length = topic.Length;
            return topic.Remove(marker, length - marker).Remove(0, marker - commLen - 1);
        }

        void PerformMediaControl(ControlGroupSet controlGroup, string payload, string fullStackCommand)
        {
            int amount = (payload != "" && payload.All(c => c <= '9' && c >= '0')) ? int.Parse(payload) : 10;

            if (fullStackCommand != "")
            {
                string command = FullStackToCommand(controlGroup.path, fullStackCommand).Replace(this.mqttDeviceName + "/","");
                bool osd = command.Contains("-osd");
                command = command.Replace("-osd","");
                EventControl.MediaEvent(command, osd, amount);
            } 
            else EventControl.MediaEvent(controlGroup.mediaControl.command, controlGroup.mediaControl.osd, amount);
        }

        void PerformMouseControl(ControlGroupSet controlGroup, string payload, string fullStackCommand)
        {
            if (fullStackCommand != "")
            {
                string command = FullStackToCommand(controlGroup.path, fullStackCommand).Replace(this.mqttDeviceName + "/", "");
                EventControl.MouseEvent(command, payload);
            } EventControl.MouseEvent(controlGroup.mouseControl.command, payload);
        }

        #endregion
        #endregion

        #region UI Tab
        private void WinBGVal_Click(object sender, EventArgs e)
        {
            uiColorDialog.Color = winBGVal.BackColor;
            if (uiColorDialog.ShowDialog() == DialogResult.OK)
            {
                winBGVal.BackColor = uiColorDialog.Color;
                this.BackColor = uiColorDialog.Color;
                colorValues["mainBack"] = uiColorDialog.Color;
                colorSaves = true;
                ContentUpdated();
            }
        }

        private void TitleBGVal_Click(object sender, EventArgs e)
        {
            uiColorDialog.Color = titleBGVal.BackColor;
            if (uiColorDialog.ShowDialog() == DialogResult.OK)
            {
                titleBGVal.BackColor = uiColorDialog.Color;
                this.titleBar.BackColor = uiColorDialog.Color;
                this.titleText.BackColor = uiColorDialog.Color;
                this.titleIcon.BackColor = uiColorDialog.Color;
                colorValues["titleBack"] = uiColorDialog.Color;
                colorSaves = true;
                ContentUpdated();
            }
        }

        private void TitleFGVal_Click(object sender, EventArgs e)
        {
            uiColorDialog.Color = titleFGVal.BackColor;
            if (uiColorDialog.ShowDialog() == DialogResult.OK)
            {
                titleFGVal.BackColor = uiColorDialog.Color;
                this.titleText.ForeColor = uiColorDialog.Color;
                colorValues["titleFore"] = uiColorDialog.Color;
                colorSaves = true;
                ContentUpdated();
            }
        }

        private void SetUIColors()
        {
            winBGVal.BackColor = colorValues["mainBack"];
            this.BackColor = colorValues["mainBack"];

            titleBGVal.BackColor = colorValues["titleBack"];
            this.titleBar.BackColor = colorValues["titleBack"];
            this.titleText.BackColor = colorValues["titleBack"];
            this.titleIcon.BackColor = colorValues["titleBack"];

            titleFGVal.BackColor = colorValues["titleFore"];
            this.titleText.ForeColor = colorValues["titleFore"];

        }

        private void UiAppIconButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "png files (*.png)|*.png",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap ico = new Bitmap(openFileDialog.FileName);
                this.trayIcon.Icon = Icon.FromHandle(ico.GetHicon());
                ico = new Bitmap(ico, 24, 24);
                this.titleIcon.Image = ico;
            }
        }

        private void UiIconRevertButton_Click(object sender, EventArgs e)
        {
            this.trayIcon.Icon = ((Icon)(resources.GetObject("trayIcon.Icon")));
            this.titleIcon.Image = mqtt_play.Properties.Resources.mqtt_play;
        }

        private void saveIconButton_Click(object sender, EventArgs e)
        {

        }

        private void pendingSaveIconButton_Click(object sender, EventArgs e)
        {

        }

        private void saveRevertButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Save Functions
        //Convert color to comma separated string
        private string ColorToString(Color val)
        {
            return val.R + "," + val.G + "," + val.B;
        }
        //Convert comma separated stored string value to color
        private Color StringToColor(string val)
        {
            string[] vals = val.Split(new[] { "," }, StringSplitOptions.None);
            return Color.FromArgb(int.Parse(vals[0]), int.Parse(vals[1]), int.Parse(vals[2]));
        }

        public void ContentUpdated()
        {
            this.saved = false;
            buttonSave.BackgroundImage = mqtt_play.Properties.Resources.diskette_o_save;
        }

        public void SaveContent()
        {
            xConfig.Root.Element("mqttSettings").Element("deviceName").Value = this.mqttDeviceName ?? "";
            xConfig.Root.Element("mqttSettings").Element("ip").Value = this.mqttIP ?? "";
            xConfig.Root.Element("mqttSettings").Element("port").Value = this.mqttPort ?? "";
            xConfig.Root.Element("mqttSettings").Element("user").Value = this.mqttUser ?? "";
            xConfig.Root.Element("mqttSettings").Element("password").Value = this.mqttPass ?? "";
            xConfig.Root.Element("mqttSettings").Element("startupConnect").Value = this.mqttStartupConnect ? "True" : "False";

            xConfig.Save(xmlFile);

            if (controlSaves.Count > 0 || controlDeletes.Count > 0 || !ordered) SaveControlGroupSet();
            if (colorSaves) SaveUIColors();

            this.saved = true;
            this.ordered = true;
            buttonSave.BackgroundImage = mqtt_play.Properties.Resources.diskette_o_saved;
        }


        public void SaveControlGroupSet()
        {
            var controlGroupSets = xConfig.Root.Element("controlGroupSets");

            foreach (int id in controlSaves)
            {
                XElement extantNode = xConfig.XPathSelectElement("collection/controlGroupSets/controlGroupSet[id='" + id + "']");
                XElement idNode, typeNode, nameNode, pathNode, sortNode, collapsedNode, enabledNode, fsNode, commandNode;

                if (extantNode == null)
                {
                    XElement controlNode = new XElement("controlGroupSet");
                    controlGroupSets.Add(controlNode);

                    idNode = new XElement("id");
                    controlNode.Add(idNode);

                    typeNode = new XElement("type");
                    controlNode.Add(typeNode);

                    nameNode = new XElement("name");
                    controlNode.Add(nameNode);

                    pathNode = new XElement("path");
                    controlNode.Add(pathNode);

                    sortNode = new XElement("sort");
                    controlNode.Add(sortNode);

                    collapsedNode = new XElement("collapsed");
                    controlNode.Add(collapsedNode);

                    enabledNode = new XElement("enabled");
                    controlNode.Add(enabledNode);

                    fsNode = new XElement("fullstack");
                    controlNode.Add(fsNode);

                    commandNode = new XElement("command");
                    controlNode.Add(commandNode);
                } else
                {
                    idNode = extantNode.Element("id");
                    typeNode = extantNode.Element("type");
                    nameNode = extantNode.Element("name");
                    pathNode = extantNode.Element("path");
                    sortNode = extantNode.Element("sort");
                    collapsedNode = extantNode.Element("collapsed");
                    enabledNode = extantNode.Element("enabled");
                    fsNode = extantNode.Element("fullstack");
                    commandNode = extantNode.Element("command");
                }

                idNode.Value = id.ToString();
                typeNode.Value = controlInventory[id].type;
                nameNode.Value = controlInventory[id].displayName;
                pathNode.Value = controlInventory[id].path;
                int sort = controlInventory[id].TabIndex; //avoid contextual marshalling
                sortNode.Value = sort.ToString();
                collapsedNode.Value = controlInventory[id].collapsed ? "True" : "False";
                enabledNode.Value = controlInventory[id].enabled ? "True" : "False";
                fsNode.Value = controlInventory[id].fullStack ? "True" : "False";
                switch (controlInventory[id].type)
                {
                    case "Key Control":
                        commandNode.Value = controlInventory[id].keyControl.Serialize();
                        break;
                    case "Media Control":
                        commandNode.Value = controlInventory[id].mediaControl.Serialize();
                        break;
                    case "Mouse Control":
                        commandNode.Value = controlInventory[id].mouseControl.Serialize();
                        break;
                    case "Macro":
                        commandNode.Value = controlInventory[id].macro;
                        break;
                    case "Batch Script":
                        commandNode.Value = controlInventory[id].batch;
                        break;
                }
            }

            foreach (int id in controlDeletes)
            {
                XElement extantNode = xConfig.XPathSelectElement("collection/controlGroupSets/controlGroupSet[id='" + id + "']");

                if (extantNode != null) extantNode.Remove();
            }

            if (!ordered)
            {
                XElement[] sortedSets = xConfig.Root.Element("controlGroupSets").Elements("controlGroupSet").OrderBy(t => (int)t.Element("sort")).ToArray();
                xConfig.Root.Element("controlGroupSets").ReplaceAll(sortedSets);
            }

            controlDeletes.Clear();
            controlSaves.Clear();

            xConfig.Save(xmlFile);
        }

        public void RestoreControlGroupSets()
        {
            var controlNodes = xConfig.Root.Element("controlGroupSets").Elements("controlGroupSet");

            foreach (XElement controlNode in controlNodes)
            {
                XElement idNode = controlNode.Element("id");
                XElement typeNode = controlNode.Element("type");
                XElement nameNode = controlNode.Element("name");
                XElement pathNode = controlNode.Element("path");
                XElement sortNode = controlNode.Element("sort");
                XElement collapsedNode = controlNode.Element("collapsed");
                XElement enabledNode = controlNode.Element("enabled");
                XElement fsNode = controlNode.Element("fullstack");
                XElement commandNode = controlNode.Element("command");

                int id = int.Parse(idNode.Value);
                int sort = int.Parse(sortNode.Value);
                bool collapsed = bool.Parse(collapsedNode.Value);
                bool enabled = bool.Parse(enabledNode.Value);
                bool fullstack = bool.Parse(fsNode.Value);

                ControlGroupSet newControlGroupSet = new ControlGroupSet(id, typeNode.Value, nameNode.Value, pathNode.Value, collapsed, enabled, fullstack, commandNode.Value)
                {
                    Name = "controlGroupSet" + id,
                    TabIndex = sort,
                };

                controlInventory.Add(id, newControlGroupSet);

                this.controlItemFlowPanel.Controls.Add(newControlGroupSet);

                if (enabled) SubscribeControlGroup(newControlGroupSet);

                newControlGroupSet.ControlGroupDeleted += ControlGroupInstance_Deleted;
                newControlGroupSet.ControlGroupUpdated += ControlGroupInstance_Updated;
                newControlGroupSet.ControlGroupOrderUpdated += ControlGroupOrder_Updated;
                newControlGroupSet.ControlGroupEnabled += ControlGroup_Enabled;
                newControlGroupSet.ControlGroupDisabled += ControlGroup_Disabled;
            }
        }

        public void SaveUIColors()
        {
            var uiColors = xConfig.Root.Element("uiColors");
            foreach (var color in colorValues)
            {
                XElement extantNode = xConfig.XPathSelectElement("collection/uiColors/" + color.Key);
                if (extantNode == null)
                {
                    XElement colorNode = new XElement(color.Key);
                    uiColors.Add(colorNode);
                    extantNode = colorNode;
                }
                extantNode.Value = ColorToString(color.Value);
            }
            xConfig.Save(xmlFile);
        }

        public void RestoreUIColors()
        {
            var colorNodes = xConfig.Root.Element("uiColors").Elements();
            foreach (XElement colorNode in colorNodes) colorValues[colorNode.Name.LocalName] = StringToColor(colorNode.Value);
            SetUIColors();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!this.saved) this.SaveContent();
        }

        #endregion

    }

}

namespace WinControlCommander
{
    //WinControlCommander provides abstraction for keyboard events, audio events, and other Windows based interactions
    // Controls audio using the Windows CoreAudio API
    public static class AudioControl
    {
        #region Win Master Volume Controller

        // Get master volume level (0 - 100)
        public static float GetVol()
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return -1;
                //declare test
                winmVol.GetVolLevelScalar(out float volumeLevel);
                return volumeLevel * 100;
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }

        
        // Get mute state of master vol
        public static bool GetMute()
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return false;

                winmVol.GetMute(out bool isMuted);
                return isMuted;
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }

        
        // Set master volume level
        public static void SetVol(float newLevel)
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return;

                winmVol.SetVolLevelScalar(newLevel / 100, Guid.Empty);
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }

        // Increase master volume level (by 0 - 100)
        public static float StepMasterVol(float stepAmount)
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return -1;

                float stepAmountScaled = stepAmount / 100;

                // Get the level
                winmVol.GetVolLevelScalar(out float volumeLevel);

                // Calculate the new level
                float newLevel = volumeLevel + stepAmountScaled;
                newLevel = Math.Min(1, newLevel);
                newLevel = Math.Max(0, newLevel);

                winmVol.SetVolLevelScalar(newLevel, Guid.Empty);

                // Return the new volume level that was set
                return newLevel * 100;
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }

        // Set master volume mute status (t/f)
        public static void SetMasterMute(bool isMuted)
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return;

                winmVol.SetMute(isMuted, Guid.Empty);
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }

        // Toggle master volume mute status
        public static bool ToggleMasterMute()
        {
            IAudioEndpointVolume winmVol = null;
            try
            {
                winmVol = GetVolObj();
                if (winmVol == null) return false;

                winmVol.GetMute(out bool isMuted);
                winmVol.SetMute(!isMuted, Guid.Empty);

                return !isMuted;
            }
            finally
            {
                if (winmVol != null) Marshal.ReleaseComObject(winmVol);
            }
        }


        // Win Core Audio API volume object abstraction
        private static IAudioEndpointVolume GetVolObj()
        {
            IMMDeviceEnumerator deviceEnumerator = null;
            IMMDevice speakers = null;
            try
            {
                deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
                deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

                Guid IID_IAudioEndpointVolume = typeof(IAudioEndpointVolume).GUID;
                speakers.Activate(ref IID_IAudioEndpointVolume, 0, IntPtr.Zero, out object o);
                IAudioEndpointVolume winmVol = (IAudioEndpointVolume)o;

                return winmVol;
            }
            finally
            {
                if (speakers != null) Marshal.ReleaseComObject(speakers);
                if (deviceEnumerator != null) Marshal.ReleaseComObject(deviceEnumerator);
            }
        }

        #endregion

    }

    public static class KBControl
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void Keybd_event(Byte bVk, Byte bScan, int dwFlags, int dwExtraInfo);
        public static void SendMediaKey(string keyStr)
        {
            // not implemented

            switch (keyStr)
            {
                case "mute":
                    Keybd_event((byte)Keys.VolumeMute, 0, 0, 0);
                    Keybd_event((byte)Keys.VolumeMute, 0, 2, 0);
                    break;
                case "vol-up":
                    Keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
                    Keybd_event((byte)Keys.VolumeUp, 0, 2, 0);
                    break;
                case "vol-dwn":
                    Keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
                    Keybd_event((byte)Keys.VolumeDown, 0, 2, 0);
                    break;
                case "play":
                    Keybd_event((byte)Keys.MediaPlayPause, 0, 0, 0);
                    Keybd_event((byte)Keys.MediaPlayPause, 0, 2, 0);
                    break;
                case "stop":
                    Keybd_event((byte)Keys.MediaStop, 0, 0, 0);
                    Keybd_event((byte)Keys.MediaStop, 0, 2, 0);
                    break;
                case "track-next":
                    Keybd_event((byte)Keys.MediaNextTrack, 0, 0, 0);
                    Keybd_event((byte)Keys.MediaNextTrack, 0, 2, 0);
                    break;
                case "track-prev":
                    Keybd_event((byte)Keys.MediaPreviousTrack, 0, 0, 0);
                    Keybd_event((byte)Keys.MediaPreviousTrack, 0, 2, 0);
                    break;
                default:
                    break;

            }


        }

        public static void SendKeyCombo(string key, List<string> mods)
        {
            foreach (string mod in mods)
                Keybd_event((byte)KeyLookup(mod), 0, 0, 0);
            Keybd_event((byte)KeyLookup(key), 0, 0, 0);

            Keybd_event((byte)KeyLookup(key), 0, 2, 0);
            foreach (string mod in mods)
                Keybd_event((byte)KeyLookup(mod), 0, 2, 0);
        }

        public static void SendKey(string keyStr)
        {
            Keybd_event((byte)KeyLookup(keyStr), 0, 0, 0);
            Keybd_event((byte)KeyLookup(keyStr), 0, 2, 0);
        }

        public static Keys KeyLookup(string key)
        {
            string[] digitKeys = new string[] {"0","1","2","3","4","5","6","7","8","9"};
            if (key == "Ctrl")
                key = "ControlKey";
            if (key == "Shift")
                key = "ShiftKey";
            if (key == "Alt")
                key = "Menu";
            else if (key == "Windows")
                key = "LWin";
            else if (digitKeys.Contains(key))
                key = "D" + key;

            return (Keys)Keys.Parse(typeof(Keys), key);
        }
    }

    public static class MOUControl
    {

        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

        }


        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT cursorPoint);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void MouseEvent(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void MoveCursor(string direction, int qty)
        {
            GetCursorPos(out POINT mouPos);

            switch(direction)
            {
                case "up":
                    mouPos.Y += qty;
                    break;
                case "down":
                    mouPos.Y -= qty;
                    break;
                case "left":
                    mouPos.X -= qty;
                    break;
                case "right":
                    mouPos.X += qty;
                    break;
            }
            
            SetCursorPos(mouPos.X, mouPos.Y);
        }

        public static void MouseClick(string click, string type = "click")
        {
            GetCursorPos(out POINT mouPos);
            int mouseDown, mouseUp;

            switch(click)
            {
                case "left":
                    mouseDown = 0x02;
                    mouseUp = 0x04;
                    break;
                case "right":
                    mouseDown = 0x08;
                    mouseUp = 0x10;
                    break;
                case "middle":
                    mouseDown = 0x20;
                    mouseUp = 0x40;
                    break;
                default:
                    return;
            }

            switch(type)
            {
                case "click":
                    MouseEvent(mouseDown | mouseUp, mouPos.X, mouPos.Y, 0, 0);
                    break;
                case "double":
                    MouseEvent(mouseDown | mouseUp, mouPos.X, mouPos.Y, 0, 0);
                    MouseEvent(mouseDown | mouseUp, mouPos.X, mouPos.Y, 0, 0);
                    break;
                case "down":
                    MouseEvent(mouseDown, mouPos.X, mouPos.Y, 0, 0);
                    break;
                case "up":
                    MouseEvent(mouseUp, mouPos.X, mouPos.Y, 0, 0);
                    break;
            }
            
        }
    }

    public static class EventControl
    {

        public static string[] osdFunctions = { "mute", "vol-up", "vol-dwn" };
        public static string[] mediaFunctions = { "mute", "vol-up", "vol-dwn", "play", "stop", "track-next", "track-prev" };
        public static string[] stepFunctions = { "vol-up", "vol-dwn" };

        public static string[] mouseFunctions = {"move-left", "move-right", "move-up", "move-down", "move-to", "click", "dbl-click", "rclick", "mclick" };

        public static async void MediaEvent(string command, bool osd = false, int step = 10)
        {
            //MessageBox.Show("Media Event Started; Media Event Command: " + command + " Media Event OSD: " + osd + " Media Event Step: " + step);
            if (!mediaFunctions.Contains(command)) return;

            if (step < 1) step = 1;
            if (step > 100) step = 100;
            if (stepFunctions.Contains(command) && osd && step < 2) step = 2;

            if (!osd && osdFunctions.Contains(command))
            {
                switch(command)
                {
                    case "mute":
                        AudioControl.ToggleMasterMute();
                        break;
                    case "vol-up":
                        AudioControl.StepMasterVol(step);
                        break;
                    case "vol-dwn":
                        AudioControl.StepMasterVol(0 - step);
                        break;
                }
                return;
            }
            else
            {
                //if it's a step function then perform
                if (stepFunctions.Contains(command) && step > 2)
                {
                    float volLevel = AudioControl.GetVol();
                    KBControl.SendMediaKey(command);
                    await Task.Delay(10);
                    switch (command)
                    {
                        case "vol-up":
                            if (volLevel + step < 100) AudioControl.SetVol(volLevel + step);
                            else AudioControl.SetVol(100);
                            break;
                        case "vol-dwn":
                            if (volLevel - step > 0) AudioControl.SetVol(volLevel - step);
                            else AudioControl.SetVol(0);
                            break;
                    }
                } else
                    KBControl.SendMediaKey(command);

                return;
            }

        }

        public static void MouseEvent(string command, string payload)
        {
            if (!mouseFunctions.Contains(command)) return;

            switch (command)
            {
                case "click":
                    MOUControl.MouseClick("left");
                    return;
                case "rclick":
                    MOUControl.MouseClick("right");
                    return;
                case "mclick":
                    MOUControl.MouseClick("middle");
                    return;
                case "dbl-click":
                    MOUControl.MouseClick("left", "double");
                    return;     
            }
            if (command == "move-to")
            {
                if (payload.Length - payload.Replace(",", "").Length != 1) return; //only fire if there's exactly one comma
                
                int X = (payload.Split(',')[0] != "" && payload.Split(',')[0].All(c => c <= '9' && c >= '0')) ? int.Parse(payload.Split(',')[0]) : -1; //take number before comma and make sure it's only digits
                if (X == -1) return;
                int Y = (payload.Split(',')[1] != "" && payload.Split(',')[1].All(c => c <= '9' && c >= '0')) ? int.Parse(payload.Split(',')[1]) : -1; //take number after comma and make sure it's only digits
                if (Y == -1) return;

                MOUControl.SetCursorPos(X, Y);
            }
            else
            {
                if (payload != "" && payload.All(c => c <= '9' && c >= '0'))
                {
                    int amount = int.Parse(payload);
                    string direction = command.Remove(0,5);
                    MOUControl.MoveCursor(direction, amount);
                }
            }
        }
    }

    #region COM interfaces from Windows CoreAudio API

    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    internal class MMDeviceEnumerator
    {
    }

    internal enum EDataFlow
    {
        eRender,
        eCapture,
        eAll,
        EDataFlow_enum_count
    }

    internal enum ERole
    {
        eConsole,
        eMultimedia,
        eCommunications,
        ERole_enum_count
    }

    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDeviceEnumerator
    {
        int NotImpl1();

        [PreserveSig]
        int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);

    }

    [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
        [PreserveSig]
        int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

    }

    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionManager2
    {
        int NotImpl1();
        int NotImpl2();

        [PreserveSig]
        int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

    }

    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionEnumerator
    {
        [PreserveSig]
        int GetCount(out int SessionCount);

        [PreserveSig]
        int GetSession(int SessionCount, out IAudioSessionControl2 Session);
    }

    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ISimpleAudioVolume
    {
        [PreserveSig]
        int SetVol(float fLevel, ref Guid EventContext);

        [PreserveSig]
        int GetVol(out float pfLevel);

        [PreserveSig]
        int SetMute(bool bMute, ref Guid EventContext);

        [PreserveSig]
        int GetMute(out bool pbMute);
    }

    [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionControl2
    {
        // IAudioSessionControl
        [PreserveSig]
        int NotImpl0();

        [PreserveSig]
        int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetDisplayName([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetIconPath([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetGroupingParam(out Guid pRetVal);

        [PreserveSig]
        int SetGroupingParam([MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int NotImpl1();

        [PreserveSig]
        int NotImpl2();

        // IAudioSessionControl2
        [PreserveSig]
        int GetSessionIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetSessionInstanceIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetProcessId(out int pRetVal);

        [PreserveSig]
        int IsSystemSoundsSession();

        [PreserveSig]
        int SetDuckingPreference(bool optOut);
    }

    [Guid("5CDF2C82-841E-4546-9722-0CF74078229A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAudioEndpointVolume
    {
        [PreserveSig]
        int RegisterControlChangeNotify(IntPtr pNotify);

        [PreserveSig]
        int UnregisterControlChangeNotify(IntPtr pNotify);

        [PreserveSig]
        int GetChannelCount(
            [Out][MarshalAs(UnmanagedType.U4)] out UInt32 channelCount);

        [PreserveSig]
        int SetVolLevel(
            [In][MarshalAs(UnmanagedType.R4)] float level,
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int SetVolLevelScalar(
            [In][MarshalAs(UnmanagedType.R4)] float level,
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int GetVolLevel(
            [Out][MarshalAs(UnmanagedType.R4)] out float level);

        /// <summary>
        /// Gets the master volume level, expressed as a normalized, audio-tapered value.
        /// </summary>
        /// <param name="level">The volume level expressed as a normalized value between 0.0 and 1.0.</param>
        /// <returns>An HRESULT code indicating whether the operation passed of failed.</returns>
        [PreserveSig]
        int GetVolLevelScalar(
            [Out][MarshalAs(UnmanagedType.R4)] out float level);

        [PreserveSig]
        int SetChannelVolumeLevel(
            [In][MarshalAs(UnmanagedType.U4)] UInt32 channelNumber,
            [In][MarshalAs(UnmanagedType.R4)] float level,
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int SetChannelVolumeLevelScalar(
            [In][MarshalAs(UnmanagedType.U4)] UInt32 channelNumber,
            [In][MarshalAs(UnmanagedType.R4)] float level,
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int GetChannelVolumeLevel(
            [In][MarshalAs(UnmanagedType.U4)] UInt32 channelNumber,
            [Out][MarshalAs(UnmanagedType.R4)] out float level);

        [PreserveSig]
        int GetChannelVolumeLevelScalar(
            [In][MarshalAs(UnmanagedType.U4)] UInt32 channelNumber,
            [Out][MarshalAs(UnmanagedType.R4)] out float level);

        /// <summary>
        /// Sets the muting state of the audio stream.
        /// </summary>
        /// <param name="isMuted">True to mute the stream, or false to unmute the stream.</param>
        /// <param name="eventContext">A user context value that is passed to the notification callback.</param>
        /// <returns>An HRESULT code indicating whether the operation passed of failed.</returns>
        [PreserveSig]
        int SetMute(
            [In][MarshalAs(UnmanagedType.Bool)] Boolean isMuted,
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        /// <summary>
        /// Gets the muting state of the audio stream.
        /// </summary>
        /// <param name="isMuted">The muting state. True if the stream is muted, false otherwise.</param>
        /// <returns>An HRESULT code indicating whether the operation passed of failed.</returns>
        [PreserveSig]
        int GetMute(
            [Out][MarshalAs(UnmanagedType.Bool)] out Boolean isMuted);

        [PreserveSig]
        int GetVolumeStepInfo(
            [Out][MarshalAs(UnmanagedType.U4)] out UInt32 step,
            [Out][MarshalAs(UnmanagedType.U4)] out UInt32 stepCount);

        [PreserveSig]
        int VolumeStepUp(
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int VolumeStepDown(
            [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

        [PreserveSig]
        int QueryHardwareSupport(
            [Out][MarshalAs(UnmanagedType.U4)] out UInt32 hardwareSupportMask);

        [PreserveSig]
        int GetVolumeRange(
            [Out][MarshalAs(UnmanagedType.R4)] out float volumeMin,
            [Out][MarshalAs(UnmanagedType.R4)] out float volumeMax,
            [Out][MarshalAs(UnmanagedType.R4)] out float volumeStep);
    }

    #endregion

}