namespace mqtt_play
{
    partial class MQTTPlaySettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MQTTPlaySettings));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIconMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutTabMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabButtonStatus = new System.Windows.Forms.Button();
            this.tabButtonControls = new System.Windows.Forms.Button();
            this.tabButtonMQTT = new System.Windows.Forms.Button();
            this.tabButtonUI = new System.Windows.Forms.Button();
            this.flowLayoutPanelTabContents = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPanel = new System.Windows.Forms.Panel();
            this.TableLayoutUI = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveIconButton = new System.Windows.Forms.Button();
            this.pendingSaveIconButton = new System.Windows.Forms.Button();
            this.saveRevertButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.titleFGLabel = new System.Windows.Forms.Label();
            this.titleBGLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.titleFGVal = new System.Windows.Forms.Label();
            this.titleBGVal = new System.Windows.Forms.Label();
            this.winBGVal = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiAppIconButton = new System.Windows.Forms.Button();
            this.uiIconRevertButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.controlKeyCommand = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.winBGLabel = new System.Windows.Forms.Label();
            this.mqttPanel = new System.Windows.Forms.Panel();
            this.tableLayoutMQTT = new System.Windows.Forms.TableLayoutPanel();
            this.mqttDeviceNameLabel = new System.Windows.Forms.Label();
            this.mqttDeviceNameVal = new System.Windows.Forms.TextBox();
            this.mqttBrokerIPLabel = new System.Windows.Forms.Label();
            this.mqttBrokerIPVal = new System.Windows.Forms.TextBox();
            this.mqttBrokerPortLabel = new System.Windows.Forms.Label();
            this.mqttBrokerPortVal = new System.Windows.Forms.TextBox();
            this.mqttUserLabel = new System.Windows.Forms.Label();
            this.mqttUserVal = new System.Windows.Forms.TextBox();
            this.mqttPasswordLabel = new System.Windows.Forms.Label();
            this.mqttPasswordVal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMQTTButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mqttDisconnect = new System.Windows.Forms.Button();
            this.mqttConnect = new System.Windows.Forms.Button();
            this.mqttCancel = new System.Windows.Forms.Button();
            this.mqttConnectOnStartup = new System.Windows.Forms.CheckBox();
            this.mqttConnectionAttempt = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.tableLayoutStatus = new System.Windows.Forms.TableLayoutPanel();
            this.statusCurrentLabel = new System.Windows.Forms.Label();
            this.statusCurrentVal = new System.Windows.Forms.TextBox();
            this.statusDeviceNameVal = new System.Windows.Forms.TextBox();
            this.statusDeviceNameLabel = new System.Windows.Forms.Label();
            this.statusUptime = new System.Windows.Forms.Label();
            this.statusUptimeVal = new System.Windows.Forms.TextBox();
            this.statusLastComm = new System.Windows.Forms.Label();
            this.statusLastCommVal = new System.Windows.Forms.TextBox();
            this.statusIPVal = new System.Windows.Forms.TextBox();
            this.statusIPLabel = new System.Windows.Forms.Label();
            this.statusPortLabel = new System.Windows.Forms.Label();
            this.statusPortVal = new System.Windows.Forms.TextBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutControls = new System.Windows.Forms.TableLayoutPanel();
            this.controlsButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlButtonAdd = new System.Windows.Forms.Button();
            this.controlButtonCollapse = new System.Windows.Forms.Button();
            this.controlButtonExpand = new System.Windows.Forms.Button();
            this.controlItemFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.uiColorDialog = new System.Windows.Forms.ColorDialog();
            this.uiOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIconMenu.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.flowLayoutTabMenuPanel.SuspendLayout();
            this.flowLayoutPanelTabContents.SuspendLayout();
            this.uiPanel.SuspendLayout();
            this.TableLayoutUI.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mqttPanel.SuspendLayout();
            this.tableLayoutMQTT.SuspendLayout();
            this.flowLayoutPanelMQTTButtons.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.tableLayoutStatus.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.tableLayoutControls.SuspendLayout();
            this.controlsButtonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.notifyIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "mqPC";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.notifyIconMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIconMenuSettings,
            this.notifyIconMenuClose});
            this.notifyIconMenu.Name = "contextMenuStrip1";
            this.notifyIconMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.notifyIconMenu.Size = new System.Drawing.Size(149, 68);
            // 
            // notifyIconMenuSettings
            // 
            this.notifyIconMenuSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.notifyIconMenuSettings.Name = "notifyIconMenuSettings";
            this.notifyIconMenuSettings.Size = new System.Drawing.Size(148, 32);
            this.notifyIconMenuSettings.Text = "Settings";
            this.notifyIconMenuSettings.Click += new System.EventHandler(this.NotifyIconMenu_SettingsButton);
            // 
            // notifyIconMenuClose
            // 
            this.notifyIconMenuClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.notifyIconMenuClose.Name = "notifyIconMenuClose";
            this.notifyIconMenuClose.Size = new System.Drawing.Size(148, 32);
            this.notifyIconMenuClose.Text = "Close";
            this.notifyIconMenuClose.Click += new System.EventHandler(this.NotifyIconMenu_CloseButton);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayout.Controls.Add(this.flowLayoutTabMenuPanel, 0, 1);
            this.mainTableLayout.Controls.Add(this.flowLayoutPanelTabContents, 0, 2);
            this.mainTableLayout.Controls.Add(this.buttonSave, 1, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(722, 807);
            this.mainTableLayout.TabIndex = 1;
            // 
            // flowLayoutTabMenuPanel
            // 
            this.flowLayoutTabMenuPanel.Controls.Add(this.tabButtonStatus);
            this.flowLayoutTabMenuPanel.Controls.Add(this.tabButtonControls);
            this.flowLayoutTabMenuPanel.Controls.Add(this.tabButtonMQTT);
            this.flowLayoutTabMenuPanel.Controls.Add(this.tabButtonUI);
            this.flowLayoutTabMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabMenuPanel.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutTabMenuPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutTabMenuPanel.Name = "flowLayoutTabMenuPanel";
            this.flowLayoutTabMenuPanel.Size = new System.Drawing.Size(607, 42);
            this.flowLayoutTabMenuPanel.TabIndex = 0;
            // 
            // tabButtonStatus
            // 
            this.tabButtonStatus.BackColor = System.Drawing.Color.Orange;
            this.tabButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabButtonStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabButtonStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabButtonStatus.Location = new System.Drawing.Point(3, 0);
            this.tabButtonStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tabButtonStatus.Name = "tabButtonStatus";
            this.tabButtonStatus.Size = new System.Drawing.Size(112, 42);
            this.tabButtonStatus.TabIndex = 0;
            this.tabButtonStatus.Text = "Status";
            this.tabButtonStatus.UseVisualStyleBackColor = false;
            this.tabButtonStatus.Click += new System.EventHandler(this.TabButtonStatus_Click);
            // 
            // tabButtonControls
            // 
            this.tabButtonControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabButtonControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tabButtonControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabButtonControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabButtonControls.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabButtonControls.Location = new System.Drawing.Point(115, 0);
            this.tabButtonControls.Margin = new System.Windows.Forms.Padding(0);
            this.tabButtonControls.Name = "tabButtonControls";
            this.tabButtonControls.Size = new System.Drawing.Size(112, 42);
            this.tabButtonControls.TabIndex = 0;
            this.tabButtonControls.Text = "Controls";
            this.tabButtonControls.UseVisualStyleBackColor = false;
            this.tabButtonControls.Click += new System.EventHandler(this.TabButtonControls_Click);
            // 
            // tabButtonMQTT
            // 
            this.tabButtonMQTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabButtonMQTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tabButtonMQTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabButtonMQTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabButtonMQTT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabButtonMQTT.Location = new System.Drawing.Point(227, 0);
            this.tabButtonMQTT.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tabButtonMQTT.Name = "tabButtonMQTT";
            this.tabButtonMQTT.Size = new System.Drawing.Size(112, 42);
            this.tabButtonMQTT.TabIndex = 0;
            this.tabButtonMQTT.Text = "MQTT";
            this.tabButtonMQTT.UseVisualStyleBackColor = false;
            this.tabButtonMQTT.Click += new System.EventHandler(this.TabButtonMQTT_Click);
            // 
            // tabButtonUI
            // 
            this.tabButtonUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabButtonUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tabButtonUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabButtonUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabButtonUI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabButtonUI.Location = new System.Drawing.Point(342, 0);
            this.tabButtonUI.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tabButtonUI.Name = "tabButtonUI";
            this.tabButtonUI.Size = new System.Drawing.Size(112, 42);
            this.tabButtonUI.TabIndex = 1;
            this.tabButtonUI.Text = "UI";
            this.tabButtonUI.UseVisualStyleBackColor = false;
            this.tabButtonUI.Click += new System.EventHandler(this.TabButtonUI_Click);
            // 
            // flowLayoutPanelTabContents
            // 
            this.mainTableLayout.SetColumnSpan(this.flowLayoutPanelTabContents, 2);
            this.flowLayoutPanelTabContents.Controls.Add(this.uiPanel);
            this.flowLayoutPanelTabContents.Controls.Add(this.mqttPanel);
            this.flowLayoutPanelTabContents.Controls.Add(this.statusPanel);
            this.flowLayoutPanelTabContents.Controls.Add(this.controlsPanel);
            this.flowLayoutPanelTabContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTabContents.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanelTabContents.Name = "flowLayoutPanelTabContents";
            this.flowLayoutPanelTabContents.Size = new System.Drawing.Size(716, 726);
            this.flowLayoutPanelTabContents.TabIndex = 1;
            // 
            // uiPanel
            // 
            this.uiPanel.AutoSize = true;
            this.uiPanel.Controls.Add(this.TableLayoutUI);
            this.uiPanel.Location = new System.Drawing.Point(0, 0);
            this.uiPanel.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Size = new System.Drawing.Size(710, 369);
            this.uiPanel.TabIndex = 3;
            this.uiPanel.Visible = false;
            // 
            // TableLayoutUI
            // 
            this.TableLayoutUI.AutoSize = true;
            this.TableLayoutUI.ColumnCount = 2;
            this.TableLayoutUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.TableLayoutUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.TableLayoutUI.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.TableLayoutUI.Controls.Add(this.label7, 0, 6);
            this.TableLayoutUI.Controls.Add(this.titleFGLabel, 0, 5);
            this.TableLayoutUI.Controls.Add(this.titleBGLabel, 0, 4);
            this.TableLayoutUI.Controls.Add(this.label8, 1, 6);
            this.TableLayoutUI.Controls.Add(this.titleFGVal, 1, 5);
            this.TableLayoutUI.Controls.Add(this.titleBGVal, 1, 4);
            this.TableLayoutUI.Controls.Add(this.winBGVal, 1, 3);
            this.TableLayoutUI.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.TableLayoutUI.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.TableLayoutUI.Controls.Add(this.winBGLabel, 0, 3);
            this.TableLayoutUI.Location = new System.Drawing.Point(8, 12);
            this.TableLayoutUI.Name = "TableLayoutUI";
            this.TableLayoutUI.RowCount = 7;
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutUI.Size = new System.Drawing.Size(699, 354);
            this.TableLayoutUI.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.TableLayoutUI.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.saveIconButton);
            this.flowLayoutPanel3.Controls.Add(this.pendingSaveIconButton);
            this.flowLayoutPanel3.Controls.Add(this.saveRevertButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(420, 48);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // saveIconButton
            // 
            this.saveIconButton.AutoSize = true;
            this.saveIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveIconButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveIconButton.Location = new System.Drawing.Point(3, 3);
            this.saveIconButton.Name = "saveIconButton";
            this.saveIconButton.Size = new System.Drawing.Size(134, 42);
            this.saveIconButton.TabIndex = 1;
            this.saveIconButton.Text = "Save Icon";
            this.saveIconButton.UseVisualStyleBackColor = true;
            this.saveIconButton.Click += new System.EventHandler(this.saveIconButton_Click);
            // 
            // pendingSaveIconButton
            // 
            this.pendingSaveIconButton.AutoSize = true;
            this.pendingSaveIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pendingSaveIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingSaveIconButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pendingSaveIconButton.Location = new System.Drawing.Point(143, 3);
            this.pendingSaveIconButton.Name = "pendingSaveIconButton";
            this.pendingSaveIconButton.Size = new System.Drawing.Size(134, 42);
            this.pendingSaveIconButton.TabIndex = 4;
            this.pendingSaveIconButton.Text = "*Save Icon";
            this.pendingSaveIconButton.UseVisualStyleBackColor = true;
            this.pendingSaveIconButton.Click += new System.EventHandler(this.pendingSaveIconButton_Click);
            // 
            // saveRevertButton
            // 
            this.saveRevertButton.AutoSize = true;
            this.saveRevertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveRevertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRevertButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveRevertButton.Location = new System.Drawing.Point(283, 3);
            this.saveRevertButton.Name = "saveRevertButton";
            this.saveRevertButton.Size = new System.Drawing.Size(134, 42);
            this.saveRevertButton.TabIndex = 2;
            this.saveRevertButton.Text = "Revert";
            this.saveRevertButton.UseVisualStyleBackColor = true;
            this.saveRevertButton.Click += new System.EventHandler(this.saveRevertButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Next Color:";
            // 
            // titleFGLabel
            // 
            this.titleFGLabel.AutoSize = true;
            this.titleFGLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleFGLabel.Location = new System.Drawing.Point(3, 263);
            this.titleFGLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.titleFGLabel.Name = "titleFGLabel";
            this.titleFGLabel.Size = new System.Drawing.Size(98, 30);
            this.titleFGLabel.TabIndex = 3;
            this.titleFGLabel.Text = "Title FG:";
            // 
            // titleBGLabel
            // 
            this.titleBGLabel.AutoSize = true;
            this.titleBGLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleBGLabel.Location = new System.Drawing.Point(3, 215);
            this.titleBGLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.titleBGLabel.Name = "titleBGLabel";
            this.titleBGLabel.Size = new System.Drawing.Size(101, 30);
            this.titleBGLabel.TabIndex = 1;
            this.titleBGLabel.Text = "Title BG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lime;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(158, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.label8.Size = new System.Drawing.Size(42, 42);
            this.label8.TabIndex = 11;
            // 
            // titleFGVal
            // 
            this.titleFGVal.AutoSize = true;
            this.titleFGVal.BackColor = System.Drawing.Color.DarkOrange;
            this.titleFGVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleFGVal.Location = new System.Drawing.Point(158, 261);
            this.titleFGVal.Margin = new System.Windows.Forms.Padding(3);
            this.titleFGVal.Name = "titleFGVal";
            this.titleFGVal.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.titleFGVal.Size = new System.Drawing.Size(42, 42);
            this.titleFGVal.TabIndex = 9;
            this.titleFGVal.Click += new System.EventHandler(this.TitleFGVal_Click);
            // 
            // titleBGVal
            // 
            this.titleBGVal.AutoSize = true;
            this.titleBGVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.titleBGVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBGVal.Location = new System.Drawing.Point(158, 213);
            this.titleBGVal.Margin = new System.Windows.Forms.Padding(3);
            this.titleBGVal.Name = "titleBGVal";
            this.titleBGVal.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.titleBGVal.Size = new System.Drawing.Size(42, 42);
            this.titleBGVal.TabIndex = 6;
            this.titleBGVal.Click += new System.EventHandler(this.TitleBGVal_Click);
            // 
            // winBGVal
            // 
            this.winBGVal.AutoSize = true;
            this.winBGVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.winBGVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winBGVal.Location = new System.Drawing.Point(158, 165);
            this.winBGVal.Margin = new System.Windows.Forms.Padding(3);
            this.winBGVal.Name = "winBGVal";
            this.winBGVal.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.winBGVal.Size = new System.Drawing.Size(42, 42);
            this.winBGVal.TabIndex = 8;
            this.winBGVal.Click += new System.EventHandler(this.WinBGVal_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.TableLayoutUI.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.uiAppIconButton);
            this.flowLayoutPanel2.Controls.Add(this.uiIconRevertButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(280, 48);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // uiAppIconButton
            // 
            this.uiAppIconButton.AutoSize = true;
            this.uiAppIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiAppIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiAppIconButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiAppIconButton.Location = new System.Drawing.Point(3, 3);
            this.uiAppIconButton.Name = "uiAppIconButton";
            this.uiAppIconButton.Size = new System.Drawing.Size(134, 42);
            this.uiAppIconButton.TabIndex = 1;
            this.uiAppIconButton.Text = "App Icon";
            this.uiAppIconButton.UseVisualStyleBackColor = true;
            this.uiAppIconButton.Click += new System.EventHandler(this.UiAppIconButton_Click);
            // 
            // uiIconRevertButton
            // 
            this.uiIconRevertButton.AutoSize = true;
            this.uiIconRevertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiIconRevertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIconRevertButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiIconRevertButton.Location = new System.Drawing.Point(143, 3);
            this.uiIconRevertButton.Name = "uiIconRevertButton";
            this.uiIconRevertButton.Size = new System.Drawing.Size(134, 42);
            this.uiIconRevertButton.TabIndex = 2;
            this.uiIconRevertButton.Text = "Revert";
            this.uiIconRevertButton.UseVisualStyleBackColor = true;
            this.uiIconRevertButton.Click += new System.EventHandler(this.UiIconRevertButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.TableLayoutUI.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.controlKeyCommand);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 48);
            this.flowLayoutPanel1.TabIndex = 12;
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
            "**User Defined**",
            "Orange / Green",
            "Obligatory Third Design Option"});
            this.controlKeyCommand.Location = new System.Drawing.Point(3, 3);
            this.controlKeyCommand.Name = "controlKeyCommand";
            this.controlKeyCommand.Size = new System.Drawing.Size(431, 33);
            this.controlKeyCommand.TabIndex = 16;
            this.controlKeyCommand.Visible = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(440, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // winBGLabel
            // 
            this.winBGLabel.AutoSize = true;
            this.winBGLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winBGLabel.Location = new System.Drawing.Point(3, 167);
            this.winBGLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.winBGLabel.Name = "winBGLabel";
            this.winBGLabel.Size = new System.Drawing.Size(141, 30);
            this.winBGLabel.TabIndex = 2;
            this.winBGLabel.Text = "Window BG:";
            // 
            // mqttPanel
            // 
            this.mqttPanel.AutoSize = true;
            this.mqttPanel.Controls.Add(this.tableLayoutMQTT);
            this.mqttPanel.Location = new System.Drawing.Point(3, 369);
            this.mqttPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.mqttPanel.Name = "mqttPanel";
            this.mqttPanel.Size = new System.Drawing.Size(617, 320);
            this.mqttPanel.TabIndex = 2;
            this.mqttPanel.Visible = false;
            // 
            // tableLayoutMQTT
            // 
            this.tableLayoutMQTT.AutoSize = true;
            this.tableLayoutMQTT.ColumnCount = 2;
            this.tableLayoutMQTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMQTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMQTT.Controls.Add(this.mqttDeviceNameLabel, 0, 0);
            this.tableLayoutMQTT.Controls.Add(this.mqttDeviceNameVal, 1, 0);
            this.tableLayoutMQTT.Controls.Add(this.mqttBrokerIPLabel, 0, 1);
            this.tableLayoutMQTT.Controls.Add(this.mqttBrokerIPVal, 1, 1);
            this.tableLayoutMQTT.Controls.Add(this.mqttBrokerPortLabel, 0, 2);
            this.tableLayoutMQTT.Controls.Add(this.mqttBrokerPortVal, 1, 2);
            this.tableLayoutMQTT.Controls.Add(this.mqttUserLabel, 0, 3);
            this.tableLayoutMQTT.Controls.Add(this.mqttUserVal, 1, 3);
            this.tableLayoutMQTT.Controls.Add(this.mqttPasswordLabel, 0, 4);
            this.tableLayoutMQTT.Controls.Add(this.mqttPasswordVal, 1, 4);
            this.tableLayoutMQTT.Controls.Add(this.flowLayoutPanelMQTTButtons, 0, 5);
            this.tableLayoutMQTT.Controls.Add(this.mqttConnectionAttempt, 0, 6);
            this.tableLayoutMQTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMQTT.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMQTT.Name = "tableLayoutMQTT";
            this.tableLayoutMQTT.RowCount = 7;
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMQTT.Size = new System.Drawing.Size(617, 320);
            this.tableLayoutMQTT.TabIndex = 0;
            // 
            // mqttDeviceNameLabel
            // 
            this.mqttDeviceNameLabel.AutoSize = true;
            this.mqttDeviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mqttDeviceNameLabel.Location = new System.Drawing.Point(3, 15);
            this.mqttDeviceNameLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 4);
            this.mqttDeviceNameLabel.Name = "mqttDeviceNameLabel";
            this.mqttDeviceNameLabel.Size = new System.Drawing.Size(155, 30);
            this.mqttDeviceNameLabel.TabIndex = 0;
            this.mqttDeviceNameLabel.Text = "Device Name:";
            // 
            // mqttDeviceNameVal
            // 
            this.mqttDeviceNameVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mqttDeviceNameVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttDeviceNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttDeviceNameVal.Location = new System.Drawing.Point(164, 15);
            this.mqttDeviceNameVal.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.mqttDeviceNameVal.Name = "mqttDeviceNameVal";
            this.mqttDeviceNameVal.Size = new System.Drawing.Size(450, 37);
            this.mqttDeviceNameVal.TabIndex = 2;
            this.mqttDeviceNameVal.TextChanged += new System.EventHandler(this.MQTTDeviceNameVal_TextChanged);
            // 
            // mqttBrokerIPLabel
            // 
            this.mqttBrokerIPLabel.AutoSize = true;
            this.mqttBrokerIPLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mqttBrokerIPLabel.Location = new System.Drawing.Point(3, 60);
            this.mqttBrokerIPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.mqttBrokerIPLabel.Name = "mqttBrokerIPLabel";
            this.mqttBrokerIPLabel.Size = new System.Drawing.Size(115, 30);
            this.mqttBrokerIPLabel.TabIndex = 0;
            this.mqttBrokerIPLabel.Text = "Broker IP:";
            // 
            // mqttBrokerIPVal
            // 
            this.mqttBrokerIPVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mqttBrokerIPVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttBrokerIPVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttBrokerIPVal.Location = new System.Drawing.Point(164, 60);
            this.mqttBrokerIPVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.mqttBrokerIPVal.Name = "mqttBrokerIPVal";
            this.mqttBrokerIPVal.Size = new System.Drawing.Size(220, 37);
            this.mqttBrokerIPVal.TabIndex = 2;
            this.mqttBrokerIPVal.TextChanged += new System.EventHandler(this.MQTTBrokerIPVal_TextChanged);
            // 
            // mqttBrokerPortLabel
            // 
            this.mqttBrokerPortLabel.AutoSize = true;
            this.mqttBrokerPortLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mqttBrokerPortLabel.Location = new System.Drawing.Point(3, 105);
            this.mqttBrokerPortLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.mqttBrokerPortLabel.Name = "mqttBrokerPortLabel";
            this.mqttBrokerPortLabel.Size = new System.Drawing.Size(139, 30);
            this.mqttBrokerPortLabel.TabIndex = 0;
            this.mqttBrokerPortLabel.Text = "Broker Port:";
            // 
            // mqttBrokerPortVal
            // 
            this.mqttBrokerPortVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mqttBrokerPortVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttBrokerPortVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttBrokerPortVal.Location = new System.Drawing.Point(164, 105);
            this.mqttBrokerPortVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.mqttBrokerPortVal.Name = "mqttBrokerPortVal";
            this.mqttBrokerPortVal.Size = new System.Drawing.Size(220, 37);
            this.mqttBrokerPortVal.TabIndex = 2;
            this.mqttBrokerPortVal.TextChanged += new System.EventHandler(this.MQTTBrokerPortVal_TextChanged);
            // 
            // mqttUserLabel
            // 
            this.mqttUserLabel.AutoSize = true;
            this.mqttUserLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mqttUserLabel.Location = new System.Drawing.Point(3, 150);
            this.mqttUserLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.mqttUserLabel.Name = "mqttUserLabel";
            this.mqttUserLabel.Size = new System.Drawing.Size(123, 30);
            this.mqttUserLabel.TabIndex = 0;
            this.mqttUserLabel.Text = "Username:";
            // 
            // mqttUserVal
            // 
            this.mqttUserVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mqttUserVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttUserVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttUserVal.Location = new System.Drawing.Point(164, 150);
            this.mqttUserVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.mqttUserVal.Name = "mqttUserVal";
            this.mqttUserVal.Size = new System.Drawing.Size(220, 37);
            this.mqttUserVal.TabIndex = 2;
            this.mqttUserVal.TextChanged += new System.EventHandler(this.MQTTUserVal_TextChanged);
            // 
            // mqttPasswordLabel
            // 
            this.mqttPasswordLabel.AutoSize = true;
            this.mqttPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mqttPasswordLabel.Location = new System.Drawing.Point(3, 195);
            this.mqttPasswordLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.mqttPasswordLabel.Name = "mqttPasswordLabel";
            this.mqttPasswordLabel.Size = new System.Drawing.Size(118, 30);
            this.mqttPasswordLabel.TabIndex = 0;
            this.mqttPasswordLabel.Text = "Password:";
            // 
            // mqttPasswordVal
            // 
            this.mqttPasswordVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mqttPasswordVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttPasswordVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttPasswordVal.Location = new System.Drawing.Point(164, 195);
            this.mqttPasswordVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.mqttPasswordVal.Name = "mqttPasswordVal";
            this.mqttPasswordVal.PasswordChar = '*';
            this.mqttPasswordVal.Size = new System.Drawing.Size(220, 37);
            this.mqttPasswordVal.TabIndex = 2;
            this.mqttPasswordVal.TextChanged += new System.EventHandler(this.MQTTPasswordVal_TextChanged);
            // 
            // flowLayoutPanelMQTTButtons
            // 
            this.tableLayoutMQTT.SetColumnSpan(this.flowLayoutPanelMQTTButtons, 2);
            this.flowLayoutPanelMQTTButtons.Controls.Add(this.mqttDisconnect);
            this.flowLayoutPanelMQTTButtons.Controls.Add(this.mqttConnect);
            this.flowLayoutPanelMQTTButtons.Controls.Add(this.mqttCancel);
            this.flowLayoutPanelMQTTButtons.Controls.Add(this.mqttConnectOnStartup);
            this.flowLayoutPanelMQTTButtons.Location = new System.Drawing.Point(3, 238);
            this.flowLayoutPanelMQTTButtons.Name = "flowLayoutPanelMQTTButtons";
            this.flowLayoutPanelMQTTButtons.Size = new System.Drawing.Size(611, 54);
            this.flowLayoutPanelMQTTButtons.TabIndex = 3;
            // 
            // mqttDisconnect
            // 
            this.mqttDisconnect.AutoSize = true;
            this.mqttDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mqttDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttDisconnect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttDisconnect.Location = new System.Drawing.Point(3, 3);
            this.mqttDisconnect.Name = "mqttDisconnect";
            this.mqttDisconnect.Size = new System.Drawing.Size(134, 42);
            this.mqttDisconnect.TabIndex = 0;
            this.mqttDisconnect.Text = "Disconnect";
            this.mqttDisconnect.UseVisualStyleBackColor = true;
            this.mqttDisconnect.Visible = false;
            this.mqttDisconnect.Click += new System.EventHandler(this.MQTTDisconnect_Click);
            // 
            // mqttConnect
            // 
            this.mqttConnect.AutoSize = true;
            this.mqttConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mqttConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttConnect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttConnect.Location = new System.Drawing.Point(143, 3);
            this.mqttConnect.Name = "mqttConnect";
            this.mqttConnect.Size = new System.Drawing.Size(134, 42);
            this.mqttConnect.TabIndex = 0;
            this.mqttConnect.Text = "Connect";
            this.mqttConnect.UseVisualStyleBackColor = true;
            this.mqttConnect.Click += new System.EventHandler(this.MQTTConnect_Click);
            // 
            // mqttCancel
            // 
            this.mqttCancel.AutoSize = true;
            this.mqttCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mqttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mqttCancel.Location = new System.Drawing.Point(283, 3);
            this.mqttCancel.Name = "mqttCancel";
            this.mqttCancel.Size = new System.Drawing.Size(134, 42);
            this.mqttCancel.TabIndex = 0;
            this.mqttCancel.Text = "Cancel";
            this.mqttCancel.UseVisualStyleBackColor = true;
            this.mqttCancel.Visible = false;
            this.mqttCancel.Click += new System.EventHandler(this.MQTTCancel_Click);
            // 
            // mqttConnectOnStartup
            // 
            this.mqttConnectOnStartup.AutoSize = true;
            this.mqttConnectOnStartup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttConnectOnStartup.Location = new System.Drawing.Point(5, 57);
            this.mqttConnectOnStartup.Margin = new System.Windows.Forms.Padding(5, 9, 3, 3);
            this.mqttConnectOnStartup.Name = "mqttConnectOnStartup";
            this.mqttConnectOnStartup.Size = new System.Drawing.Size(191, 29);
            this.mqttConnectOnStartup.TabIndex = 1;
            this.mqttConnectOnStartup.Text = "Connect on Startup";
            this.mqttConnectOnStartup.UseVisualStyleBackColor = true;
            this.mqttConnectOnStartup.CheckedChanged += new System.EventHandler(this.MQTTConnectOnStartup_CheckedChanged);
            // 
            // mqttConnectionAttempt
            // 
            this.mqttConnectionAttempt.AutoSize = true;
            this.tableLayoutMQTT.SetColumnSpan(this.mqttConnectionAttempt, 2);
            this.mqttConnectionAttempt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqttConnectionAttempt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.mqttConnectionAttempt.Location = new System.Drawing.Point(3, 295);
            this.mqttConnectionAttempt.Name = "mqttConnectionAttempt";
            this.mqttConnectionAttempt.Size = new System.Drawing.Size(611, 25);
            this.mqttConnectionAttempt.TabIndex = 4;
            // 
            // statusPanel
            // 
            this.statusPanel.AutoSize = true;
            this.statusPanel.Controls.Add(this.tableLayoutStatus);
            this.statusPanel.Location = new System.Drawing.Point(3, 692);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(638, 287);
            this.statusPanel.TabIndex = 1;
            // 
            // tableLayoutStatus
            // 
            this.tableLayoutStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutStatus.AutoSize = true;
            this.tableLayoutStatus.ColumnCount = 2;
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutStatus.Controls.Add(this.statusCurrentLabel, 0, 0);
            this.tableLayoutStatus.Controls.Add(this.statusCurrentVal, 1, 0);
            this.tableLayoutStatus.Controls.Add(this.statusDeviceNameVal, 1, 1);
            this.tableLayoutStatus.Controls.Add(this.statusDeviceNameLabel, 0, 1);
            this.tableLayoutStatus.Controls.Add(this.statusUptime, 0, 6);
            this.tableLayoutStatus.Controls.Add(this.statusUptimeVal, 1, 6);
            this.tableLayoutStatus.Controls.Add(this.statusLastComm, 0, 5);
            this.tableLayoutStatus.Controls.Add(this.statusLastCommVal, 1, 5);
            this.tableLayoutStatus.Controls.Add(this.statusIPVal, 1, 2);
            this.tableLayoutStatus.Controls.Add(this.statusIPLabel, 0, 2);
            this.tableLayoutStatus.Controls.Add(this.statusPortLabel, 0, 3);
            this.tableLayoutStatus.Controls.Add(this.statusPortVal, 1, 3);
            this.tableLayoutStatus.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutStatus.Name = "tableLayoutStatus";
            this.tableLayoutStatus.RowCount = 7;
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStatus.Size = new System.Drawing.Size(635, 284);
            this.tableLayoutStatus.TabIndex = 0;
            // 
            // statusCurrentLabel
            // 
            this.statusCurrentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusCurrentLabel.AutoSize = true;
            this.statusCurrentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusCurrentLabel.Location = new System.Drawing.Point(93, 15);
            this.statusCurrentLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 4);
            this.statusCurrentLabel.Name = "statusCurrentLabel";
            this.statusCurrentLabel.Size = new System.Drawing.Size(83, 30);
            this.statusCurrentLabel.TabIndex = 0;
            this.statusCurrentLabel.Text = "Status:";
            // 
            // statusCurrentVal
            // 
            this.statusCurrentVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusCurrentVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusCurrentVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusCurrentVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusCurrentVal.Location = new System.Drawing.Point(182, 15);
            this.statusCurrentVal.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.statusCurrentVal.Name = "statusCurrentVal";
            this.statusCurrentVal.ReadOnly = true;
            this.statusCurrentVal.Size = new System.Drawing.Size(450, 30);
            this.statusCurrentVal.TabIndex = 1;
            this.statusCurrentVal.Text = "Not Connected";
            // 
            // statusDeviceNameVal
            // 
            this.statusDeviceNameVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusDeviceNameVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusDeviceNameVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusDeviceNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusDeviceNameVal.Location = new System.Drawing.Point(182, 54);
            this.statusDeviceNameVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statusDeviceNameVal.Name = "statusDeviceNameVal";
            this.statusDeviceNameVal.ReadOnly = true;
            this.statusDeviceNameVal.Size = new System.Drawing.Size(450, 30);
            this.statusDeviceNameVal.TabIndex = 1;
            // 
            // statusDeviceNameLabel
            // 
            this.statusDeviceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusDeviceNameLabel.AutoSize = true;
            this.statusDeviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusDeviceNameLabel.Location = new System.Drawing.Point(21, 54);
            this.statusDeviceNameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.statusDeviceNameLabel.Name = "statusDeviceNameLabel";
            this.statusDeviceNameLabel.Size = new System.Drawing.Size(155, 30);
            this.statusDeviceNameLabel.TabIndex = 0;
            this.statusDeviceNameLabel.Text = "Device Name:";
            // 
            // statusUptime
            // 
            this.statusUptime.AutoSize = true;
            this.statusUptime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusUptime.Location = new System.Drawing.Point(3, 250);
            this.statusUptime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.statusUptime.Name = "statusUptime";
            this.statusUptime.Size = new System.Drawing.Size(96, 30);
            this.statusUptime.TabIndex = 0;
            this.statusUptime.Text = "Uptime:";
            // 
            // statusUptimeVal
            // 
            this.statusUptimeVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusUptimeVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusUptimeVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusUptimeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusUptimeVal.Location = new System.Drawing.Point(182, 250);
            this.statusUptimeVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statusUptimeVal.Name = "statusUptimeVal";
            this.statusUptimeVal.ReadOnly = true;
            this.statusUptimeVal.Size = new System.Drawing.Size(450, 30);
            this.statusUptimeVal.TabIndex = 1;
            this.statusUptimeVal.Text = "(not implemented)";
            // 
            // statusLastComm
            // 
            this.statusLastComm.AutoSize = true;
            this.statusLastComm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLastComm.Location = new System.Drawing.Point(3, 211);
            this.statusLastComm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.statusLastComm.Name = "statusLastComm";
            this.statusLastComm.Size = new System.Drawing.Size(173, 30);
            this.statusLastComm.TabIndex = 0;
            this.statusLastComm.Text = "Last Command:";
            // 
            // statusLastCommVal
            // 
            this.statusLastCommVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusLastCommVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusLastCommVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLastCommVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusLastCommVal.Location = new System.Drawing.Point(182, 211);
            this.statusLastCommVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statusLastCommVal.Name = "statusLastCommVal";
            this.statusLastCommVal.ReadOnly = true;
            this.statusLastCommVal.Size = new System.Drawing.Size(450, 30);
            this.statusLastCommVal.TabIndex = 1;
            // 
            // statusIPVal
            // 
            this.statusIPVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusIPVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusIPVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusIPVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusIPVal.Location = new System.Drawing.Point(182, 93);
            this.statusIPVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statusIPVal.Name = "statusIPVal";
            this.statusIPVal.ReadOnly = true;
            this.statusIPVal.Size = new System.Drawing.Size(450, 30);
            this.statusIPVal.TabIndex = 1;
            // 
            // statusIPLabel
            // 
            this.statusIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusIPLabel.AutoSize = true;
            this.statusIPLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusIPLabel.Location = new System.Drawing.Point(136, 93);
            this.statusIPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.statusIPLabel.Name = "statusIPLabel";
            this.statusIPLabel.Size = new System.Drawing.Size(40, 30);
            this.statusIPLabel.TabIndex = 2;
            this.statusIPLabel.Text = "IP:";
            // 
            // statusPortLabel
            // 
            this.statusPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPortLabel.AutoSize = true;
            this.statusPortLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusPortLabel.Location = new System.Drawing.Point(112, 132);
            this.statusPortLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.statusPortLabel.Name = "statusPortLabel";
            this.statusPortLabel.Size = new System.Drawing.Size(64, 30);
            this.statusPortLabel.TabIndex = 2;
            this.statusPortLabel.Text = "Port:";
            // 
            // statusPortVal
            // 
            this.statusPortVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.statusPortVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusPortVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusPortVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.statusPortVal.Location = new System.Drawing.Point(182, 132);
            this.statusPortVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statusPortVal.Name = "statusPortVal";
            this.statusPortVal.ReadOnly = true;
            this.statusPortVal.Size = new System.Drawing.Size(450, 30);
            this.statusPortVal.TabIndex = 1;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.tableLayoutControls);
            this.controlsPanel.Location = new System.Drawing.Point(3, 982);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(718, 722);
            this.controlsPanel.TabIndex = 1;
            this.controlsPanel.Visible = false;
            // 
            // tableLayoutControls
            // 
            this.tableLayoutControls.AutoSize = true;
            this.tableLayoutControls.ColumnCount = 2;
            this.tableLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutControls.Controls.Add(this.controlsButtonsFlowLayoutPanel, 0, 1);
            this.tableLayoutControls.Controls.Add(this.controlItemFlowPanel, 0, 0);
            this.tableLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutControls.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutControls.Name = "tableLayoutControls";
            this.tableLayoutControls.RowCount = 2;
            this.tableLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 671F));
            this.tableLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutControls.Size = new System.Drawing.Size(718, 722);
            this.tableLayoutControls.TabIndex = 0;
            // 
            // controlsButtonsFlowLayoutPanel
            // 
            this.controlsButtonsFlowLayoutPanel.Controls.Add(this.controlButtonAdd);
            this.controlsButtonsFlowLayoutPanel.Controls.Add(this.controlButtonCollapse);
            this.controlsButtonsFlowLayoutPanel.Controls.Add(this.controlButtonExpand);
            this.controlsButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsButtonsFlowLayoutPanel.Location = new System.Drawing.Point(3, 674);
            this.controlsButtonsFlowLayoutPanel.Name = "controlsButtonsFlowLayoutPanel";
            this.controlsButtonsFlowLayoutPanel.Size = new System.Drawing.Size(439, 49);
            this.controlsButtonsFlowLayoutPanel.TabIndex = 99999;
            // 
            // controlButtonAdd
            // 
            this.controlButtonAdd.AutoSize = true;
            this.controlButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlButtonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlButtonAdd.Location = new System.Drawing.Point(3, 10);
            this.controlButtonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.controlButtonAdd.Name = "controlButtonAdd";
            this.controlButtonAdd.Size = new System.Drawing.Size(122, 38);
            this.controlButtonAdd.TabIndex = 99990;
            this.controlButtonAdd.Text = "Add Control";
            this.controlButtonAdd.UseVisualStyleBackColor = true;
            this.controlButtonAdd.Click += new System.EventHandler(this.ControlButtonAdd_Click);
            // 
            // controlButtonCollapse
            // 
            this.controlButtonCollapse.AutoSize = true;
            this.controlButtonCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlButtonCollapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlButtonCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButtonCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlButtonCollapse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlButtonCollapse.Location = new System.Drawing.Point(131, 10);
            this.controlButtonCollapse.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.controlButtonCollapse.Name = "controlButtonCollapse";
            this.controlButtonCollapse.Size = new System.Drawing.Size(116, 38);
            this.controlButtonCollapse.TabIndex = 99991;
            this.controlButtonCollapse.Text = "Collapse All";
            this.controlButtonCollapse.UseVisualStyleBackColor = true;
            this.controlButtonCollapse.Click += new System.EventHandler(this.ControlButtonCollapse_Click);
            // 
            // controlButtonExpand
            // 
            this.controlButtonExpand.AutoSize = true;
            this.controlButtonExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlButtonExpand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlButtonExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButtonExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlButtonExpand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.controlButtonExpand.Location = new System.Drawing.Point(253, 10);
            this.controlButtonExpand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.controlButtonExpand.Name = "controlButtonExpand";
            this.controlButtonExpand.Size = new System.Drawing.Size(107, 38);
            this.controlButtonExpand.TabIndex = 99991;
            this.controlButtonExpand.Text = "Expand All";
            this.controlButtonExpand.UseVisualStyleBackColor = true;
            this.controlButtonExpand.Click += new System.EventHandler(this.ControlButtonExpand_Click);
            // 
            // controlItemFlowPanel
            // 
            this.controlItemFlowPanel.AutoScroll = true;
            this.tableLayoutControls.SetColumnSpan(this.controlItemFlowPanel, 2);
            this.controlItemFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlItemFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.controlItemFlowPanel.Name = "controlItemFlowPanel";
            this.controlItemFlowPanel.Size = new System.Drawing.Size(712, 665);
            this.controlItemFlowPanel.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonSave.Location = new System.Drawing.Point(677, 36);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(6);
            this.buttonSave.Size = new System.Drawing.Size(39, 39);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // uiColorDialog
            // 
            this.uiColorDialog.FullOpen = true;
            // 
            // uiOpenFileDialog
            // 
            this.uiOpenFileDialog.FileName = "uiOpenFileDialog";
            // 
            // MQTTPlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(722, 807);
            this.Controls.Add(this.mainTableLayout);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MQTTPlaySettings";
            this.Text = "mqtt PLAY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MQTTPlaySettings_FormClosing);
            this.notifyIconMenu.ResumeLayout(false);
            this.mainTableLayout.ResumeLayout(false);
            this.flowLayoutTabMenuPanel.ResumeLayout(false);
            this.flowLayoutPanelTabContents.ResumeLayout(false);
            this.flowLayoutPanelTabContents.PerformLayout();
            this.uiPanel.ResumeLayout(false);
            this.uiPanel.PerformLayout();
            this.TableLayoutUI.ResumeLayout(false);
            this.TableLayoutUI.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mqttPanel.ResumeLayout(false);
            this.mqttPanel.PerformLayout();
            this.tableLayoutMQTT.ResumeLayout(false);
            this.tableLayoutMQTT.PerformLayout();
            this.flowLayoutPanelMQTTButtons.ResumeLayout(false);
            this.flowLayoutPanelMQTTButtons.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.tableLayoutStatus.ResumeLayout(false);
            this.tableLayoutStatus.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.tableLayoutControls.ResumeLayout(false);
            this.controlsButtonsFlowLayoutPanel.ResumeLayout(false);
            this.controlsButtonsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuClose;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuSettings;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabMenuPanel;
        private System.Windows.Forms.Button tabButtonStatus;
        private System.Windows.Forms.Button tabButtonControls;
        private System.Windows.Forms.Button tabButtonMQTT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTabContents;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Panel mqttPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMQTT;
        private System.Windows.Forms.Label statusCurrentLabel;
        private System.Windows.Forms.Label statusDeviceNameLabel;
        private System.Windows.Forms.Label statusUptime;
        private System.Windows.Forms.Label statusLastComm;
        private System.Windows.Forms.Label mqttDeviceNameLabel;
        private System.Windows.Forms.Label mqttBrokerIPLabel;
        private System.Windows.Forms.Label mqttUserLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMQTTButtons;
        private System.Windows.Forms.TextBox statusUptimeVal;
        private System.Windows.Forms.TextBox statusLastCommVal;
        private System.Windows.Forms.TextBox statusDeviceNameVal;
        private System.Windows.Forms.TextBox statusCurrentVal;
        private System.Windows.Forms.TextBox mqttBrokerPortVal;
        private System.Windows.Forms.TextBox mqttBrokerIPVal;
        private System.Windows.Forms.TextBox mqttDeviceNameVal;
        private System.Windows.Forms.Label mqttBrokerPortLabel;
        private System.Windows.Forms.TextBox mqttUserVal;
        private System.Windows.Forms.TextBox mqttPasswordVal;
        private System.Windows.Forms.Label mqttPasswordLabel;
        private System.Windows.Forms.Button mqttConnect;
        private System.Windows.Forms.Button mqttDisconnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutControls;
        private System.Windows.Forms.FlowLayoutPanel controlsButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button controlButtonAdd;
        private System.Windows.Forms.FlowLayoutPanel controlItemFlowPanel;
        private System.Windows.Forms.Button controlButtonCollapse;
        private System.Windows.Forms.Button controlButtonExpand;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox statusIPVal;
        private System.Windows.Forms.Label statusIPLabel;
        private System.Windows.Forms.Label statusPortLabel;
        private System.Windows.Forms.TextBox statusPortVal;
        private System.Windows.Forms.CheckBox mqttConnectOnStartup;
        private System.Windows.Forms.Label mqttConnectionAttempt;
        private System.Windows.Forms.Button mqttCancel;
        private System.Windows.Forms.Button tabButtonUI;
        private System.Windows.Forms.ColorDialog uiColorDialog;
        private System.Windows.Forms.Panel uiPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutUI;
        private System.Windows.Forms.Label titleFGLabel;
        private System.Windows.Forms.Label titleBGLabel;
        private System.Windows.Forms.Label winBGLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label titleBGVal;
        private System.Windows.Forms.Label winBGVal;
        private System.Windows.Forms.Label titleFGVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog uiOpenFileDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button uiAppIconButton;
        private System.Windows.Forms.Button uiIconRevertButton;
        private System.Windows.Forms.ComboBox controlKeyCommand;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button saveIconButton;
        private System.Windows.Forms.Button saveRevertButton;
        private System.Windows.Forms.Button pendingSaveIconButton;
    }
}

