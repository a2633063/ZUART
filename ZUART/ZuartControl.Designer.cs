﻿
namespace ZUARTControl
{
    partial class ZuartControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            System.Diagnostics.Debug.WriteLine("Dispose");
            setting_save(null, null);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.groupboxSendSetting = new System.Windows.Forms.GroupBox();
            this.txtAutoSendms = new System.Windows.Forms.TextBox();
            this.chkAutoCleanSend = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.chkfromFileSend = new System.Windows.Forms.CheckBox();
            this.chkAutoAddSend = new System.Windows.Forms.CheckBox();
            this.rbtnSendUnicode = new System.Windows.Forms.RadioButton();
            this.rbtnSendHex = new System.Windows.Forms.RadioButton();
            this.rbtnSendASCII = new System.Windows.Forms.RadioButton();
            this.rbtnSendUTF8 = new System.Windows.Forms.RadioButton();
            this.lkbReadSend = new System.Windows.Forms.LinkLabel();
            this.lkbClearSend = new System.Windows.Forms.LinkLabel();
            this.groupboxRecSetting = new System.Windows.Forms.GroupBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.chkAutoScroll = new System.Windows.Forms.CheckBox();
            this.chkRecSend = new System.Windows.Forms.CheckBox();
            this.lkbSaveRev = new System.Windows.Forms.LinkLabel();
            this.rbtnUnicode = new System.Windows.Forms.RadioButton();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.lkbClearRev = new System.Windows.Forms.LinkLabel();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkAutoLine = new System.Windows.Forms.CheckBox();
            this.groupBoxComSetting = new System.Windows.Forms.GroupBox();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbbComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComDevice = new System.IO.Ports.SerialPort(this.components);
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.panel_Setting.SuspendLayout();
            this.groupboxSendSetting.SuspendLayout();
            this.groupboxRecSetting.SuspendLayout();
            this.groupBoxComSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Setting
            // 
            this.panel_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Setting.Controls.Add(this.groupboxSendSetting);
            this.panel_Setting.Controls.Add(this.groupboxRecSetting);
            this.panel_Setting.Controls.Add(this.groupBoxComSetting);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Setting.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(182, 572);
            this.panel_Setting.TabIndex = 0;
            // 
            // groupboxSendSetting
            // 
            this.groupboxSendSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxSendSetting.Controls.Add(this.txtAutoSendms);
            this.groupboxSendSetting.Controls.Add(this.chkAutoCleanSend);
            this.groupboxSendSetting.Controls.Add(this.chkAutoSend);
            this.groupboxSendSetting.Controls.Add(this.chkTrans);
            this.groupboxSendSetting.Controls.Add(this.chkfromFileSend);
            this.groupboxSendSetting.Controls.Add(this.chkAutoAddSend);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUnicode);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendHex);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendASCII);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUTF8);
            this.groupboxSendSetting.Controls.Add(this.lkbReadSend);
            this.groupboxSendSetting.Controls.Add(this.lkbClearSend);
            this.groupboxSendSetting.Location = new System.Drawing.Point(3, 377);
            this.groupboxSendSetting.Name = "groupboxSendSetting";
            this.groupboxSendSetting.Size = new System.Drawing.Size(170, 195);
            this.groupboxSendSetting.TabIndex = 3;
            this.groupboxSendSetting.TabStop = false;
            this.groupboxSendSetting.Text = "发送区设置";
            // 
            // txtAutoSendms
            // 
            this.txtAutoSendms.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAutoSendms.Location = new System.Drawing.Point(105, 100);
            this.txtAutoSendms.MaxLength = 5;
            this.txtAutoSendms.Name = "txtAutoSendms";
            this.txtAutoSendms.Size = new System.Drawing.Size(32, 21);
            this.txtAutoSendms.TabIndex = 5;
            this.txtAutoSendms.Text = "500";
            this.txtAutoSendms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAutoSendms, "建议20-60000范围内");
            this.txtAutoSendms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutoSendms_KeyPress);
            // 
            // chkAutoCleanSend
            // 
            this.chkAutoCleanSend.AutoSize = true;
            this.chkAutoCleanSend.Location = new System.Drawing.Point(9, 81);
            this.chkAutoCleanSend.Name = "chkAutoCleanSend";
            this.chkAutoCleanSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoCleanSend.TabIndex = 3;
            this.chkAutoCleanSend.Text = "发送完自动清空";
            this.chkAutoCleanSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(9, 104);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(96, 16);
            this.chkAutoSend.TabIndex = 4;
            this.chkAutoSend.Text = "发送周期(ms)";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // chkfromFileSend
            // 
            this.chkfromFileSend.AutoSize = true;
            this.chkfromFileSend.Enabled = false;
            this.chkfromFileSend.Location = new System.Drawing.Point(9, 39);
            this.chkfromFileSend.Name = "chkfromFileSend";
            this.chkfromFileSend.Size = new System.Drawing.Size(108, 16);
            this.chkfromFileSend.TabIndex = 1;
            this.chkfromFileSend.Text = "启用文件数据源";
            this.chkfromFileSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoAddSend
            // 
            this.chkAutoAddSend.AutoSize = true;
            this.chkAutoAddSend.Enabled = false;
            this.chkAutoAddSend.Location = new System.Drawing.Point(9, 60);
            this.chkAutoAddSend.Name = "chkAutoAddSend";
            this.chkAutoAddSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoAddSend.TabIndex = 2;
            this.chkAutoAddSend.Text = "自动发送附加位";
            this.chkAutoAddSend.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUnicode
            // 
            this.rbtnSendUnicode.AutoSize = true;
            this.rbtnSendUnicode.Location = new System.Drawing.Point(68, 148);
            this.rbtnSendUnicode.Name = "rbtnSendUnicode";
            this.rbtnSendUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnSendUnicode.TabIndex = 9;
            this.rbtnSendUnicode.Text = "Unicode";
            this.rbtnSendUnicode.UseVisualStyleBackColor = true;
            this.rbtnSendUnicode.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendHex
            // 
            this.rbtnSendHex.AutoSize = true;
            this.rbtnSendHex.Location = new System.Drawing.Point(9, 126);
            this.rbtnSendHex.Name = "rbtnSendHex";
            this.rbtnSendHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendHex.TabIndex = 6;
            this.rbtnSendHex.Text = "Hex";
            this.rbtnSendHex.UseVisualStyleBackColor = true;
            this.rbtnSendHex.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendASCII
            // 
            this.rbtnSendASCII.AutoSize = true;
            this.rbtnSendASCII.Checked = true;
            this.rbtnSendASCII.Location = new System.Drawing.Point(68, 127);
            this.rbtnSendASCII.Name = "rbtnSendASCII";
            this.rbtnSendASCII.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendASCII.TabIndex = 7;
            this.rbtnSendASCII.TabStop = true;
            this.rbtnSendASCII.Text = "GBK";
            this.rbtnSendASCII.UseVisualStyleBackColor = true;
            this.rbtnSendASCII.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendUTF8
            // 
            this.rbtnSendUTF8.AutoSize = true;
            this.rbtnSendUTF8.Location = new System.Drawing.Point(9, 148);
            this.rbtnSendUTF8.Name = "rbtnSendUTF8";
            this.rbtnSendUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendUTF8.TabIndex = 8;
            this.rbtnSendUTF8.Text = "UTF-8";
            this.rbtnSendUTF8.UseVisualStyleBackColor = true;
            this.rbtnSendUTF8.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // lkbReadSend
            // 
            this.lkbReadSend.AutoSize = true;
            this.lkbReadSend.Location = new System.Drawing.Point(16, 177);
            this.lkbReadSend.Name = "lkbReadSend";
            this.lkbReadSend.Size = new System.Drawing.Size(53, 12);
            this.lkbReadSend.TabIndex = 10;
            this.lkbReadSend.TabStop = true;
            this.lkbReadSend.Text = "文件载入";
            this.lkbReadSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbReadSend_LinkClicked);
            // 
            // lkbClearSend
            // 
            this.lkbClearSend.AutoSize = true;
            this.lkbClearSend.Location = new System.Drawing.Point(83, 177);
            this.lkbClearSend.Name = "lkbClearSend";
            this.lkbClearSend.Size = new System.Drawing.Size(53, 12);
            this.lkbClearSend.TabIndex = 11;
            this.lkbClearSend.TabStop = true;
            this.lkbClearSend.Text = "清除发送";
            this.lkbClearSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearSend_LinkClicked);
            // 
            // groupboxRecSetting
            // 
            this.groupboxRecSetting.Controls.Add(this.chkRTS);
            this.groupboxRecSetting.Controls.Add(this.chkDTR);
            this.groupboxRecSetting.Controls.Add(this.chkAutoScroll);
            this.groupboxRecSetting.Controls.Add(this.chkRecSend);
            this.groupboxRecSetting.Controls.Add(this.lkbSaveRev);
            this.groupboxRecSetting.Controls.Add(this.rbtnUnicode);
            this.groupboxRecSetting.Controls.Add(this.rbtnUTF8);
            this.groupboxRecSetting.Controls.Add(this.rbtnASCII);
            this.groupboxRecSetting.Controls.Add(this.rbtnHex);
            this.groupboxRecSetting.Controls.Add(this.lkbClearRev);
            this.groupboxRecSetting.Controls.Add(this.chkShowTime);
            this.groupboxRecSetting.Controls.Add(this.chkAutoLine);
            this.groupboxRecSetting.Location = new System.Drawing.Point(3, 203);
            this.groupboxRecSetting.Name = "groupboxRecSetting";
            this.groupboxRecSetting.Size = new System.Drawing.Size(170, 168);
            this.groupboxRecSetting.TabIndex = 2;
            this.groupboxRecSetting.TabStop = false;
            this.groupboxRecSetting.Text = "接收区设置";
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(129, -1);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(42, 16);
            this.chkRTS.TabIndex = 2;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_DTR_CheckedChanged);
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(82, -1);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(42, 16);
            this.chkDTR.TabIndex = 1;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkRTS_DTR_CheckedChanged);
            // 
            // chkAutoScroll
            // 
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Checked = true;
            this.chkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoScroll.Enabled = false;
            this.chkAutoScroll.Location = new System.Drawing.Point(13, 83);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(72, 16);
            this.chkAutoScroll.TabIndex = 6;
            this.chkAutoScroll.Text = "自动滚屏";
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // chkRecSend
            // 
            this.chkRecSend.AutoSize = true;
            this.chkRecSend.Location = new System.Drawing.Point(13, 62);
            this.chkRecSend.Name = "chkRecSend";
            this.chkRecSend.Size = new System.Drawing.Size(96, 16);
            this.chkRecSend.TabIndex = 5;
            this.chkRecSend.Text = "输入直接发送";
            this.chkRecSend.UseVisualStyleBackColor = true;
            // 
            // lkbSaveRev
            // 
            this.lkbSaveRev.AutoSize = true;
            this.lkbSaveRev.Location = new System.Drawing.Point(16, 149);
            this.lkbSaveRev.Name = "lkbSaveRev";
            this.lkbSaveRev.Size = new System.Drawing.Size(53, 12);
            this.lkbSaveRev.TabIndex = 11;
            this.lkbSaveRev.TabStop = true;
            this.lkbSaveRev.Text = "保存数据";
            this.lkbSaveRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSaveRev_LinkClicked);
            // 
            // rbtnUnicode
            // 
            this.rbtnUnicode.AutoSize = true;
            this.rbtnUnicode.Location = new System.Drawing.Point(72, 127);
            this.rbtnUnicode.Name = "rbtnUnicode";
            this.rbtnUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnUnicode.TabIndex = 10;
            this.rbtnUnicode.Text = "Unicode";
            this.rbtnUnicode.UseVisualStyleBackColor = true;
            this.rbtnUnicode.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(12, 127);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnUTF8.TabIndex = 9;
            this.rbtnUTF8.Text = "UTF-8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            this.rbtnUTF8.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Checked = true;
            this.rbtnASCII.Location = new System.Drawing.Point(72, 105);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(41, 16);
            this.rbtnASCII.TabIndex = 8;
            this.rbtnASCII.TabStop = true;
            this.rbtnASCII.Text = "GBK";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            this.rbtnASCII.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(13, 105);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 7;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // lkbClearRev
            // 
            this.lkbClearRev.AutoSize = true;
            this.lkbClearRev.Location = new System.Drawing.Point(83, 149);
            this.lkbClearRev.Name = "lkbClearRev";
            this.lkbClearRev.Size = new System.Drawing.Size(53, 12);
            this.lkbClearRev.TabIndex = 12;
            this.lkbClearRev.TabStop = true;
            this.lkbClearRev.Text = "清除接收";
            this.lkbClearRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearRev_LinkClicked);
            // 
            // chkShowTime
            // 
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Location = new System.Drawing.Point(13, 41);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(96, 16);
            this.chkShowTime.TabIndex = 4;
            this.chkShowTime.Text = "显示接收时间";
            this.chkShowTime.UseVisualStyleBackColor = true;
            this.chkShowTime.CheckedChanged += new System.EventHandler(this.chkShowTime_CheckedChanged);
            // 
            // chkAutoLine
            // 
            this.chkAutoLine.AutoSize = true;
            this.chkAutoLine.Location = new System.Drawing.Point(13, 20);
            this.chkAutoLine.Name = "chkAutoLine";
            this.chkAutoLine.Size = new System.Drawing.Size(96, 16);
            this.chkAutoLine.TabIndex = 3;
            this.chkAutoLine.Text = "自动换行显示";
            this.chkAutoLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxComSetting
            // 
            this.groupBoxComSetting.Controls.Add(this.cbbParity);
            this.groupBoxComSetting.Controls.Add(this.cbbStopBits);
            this.groupBoxComSetting.Controls.Add(this.btnOpen);
            this.groupBoxComSetting.Controls.Add(this.cbbDataBits);
            this.groupBoxComSetting.Controls.Add(this.cbbBaudRate);
            this.groupBoxComSetting.Controls.Add(this.cbbComList);
            this.groupBoxComSetting.Controls.Add(this.label2);
            this.groupBoxComSetting.Controls.Add(this.label5);
            this.groupBoxComSetting.Controls.Add(this.label1);
            this.groupBoxComSetting.Controls.Add(this.label4);
            this.groupBoxComSetting.Controls.Add(this.label3);
            this.groupBoxComSetting.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBoxComSetting.Location = new System.Drawing.Point(3, 3);
            this.groupBoxComSetting.Name = "groupBoxComSetting";
            this.groupBoxComSetting.Size = new System.Drawing.Size(170, 194);
            this.groupBoxComSetting.TabIndex = 1;
            this.groupBoxComSetting.TabStop = false;
            this.groupBoxComSetting.Text = "端口设置";
            // 
            // cbbParity
            // 
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbbParity.Location = new System.Drawing.Point(61, 130);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(98, 21);
            this.cbbParity.TabIndex = 5;
            this.cbbParity.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbStopBits.Location = new System.Drawing.Point(61, 104);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(98, 21);
            this.cbbStopBits.TabIndex = 4;
            this.cbbStopBits.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // btnOpen
            // 
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpen.Font = new System.Drawing.Font("宋体", 10F);
            this.btnOpen.Image = global::ZUART.Properties.Resources.close;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(9, 157);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(8, 0, 25, 0);
            this.btnOpen.Size = new System.Drawing.Size(150, 32);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbbDataBits.Location = new System.Drawing.Point(61, 77);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(98, 21);
            this.cbbDataBits.TabIndex = 3;
            this.cbbDataBits.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.DisplayMember = "1";
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "74880",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate.Location = new System.Drawing.Point(61, 48);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(98, 21);
            this.cbbBaudRate.TabIndex = 2;
            this.cbbBaudRate.Text = global::ZUART.Properties.Settings.Default.cbbBaudRate;
            this.cbbBaudRate.ValueMember = "1";
            this.cbbBaudRate.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // cbbComList
            // 
            this.cbbComList.DisplayMember = "1";
            this.cbbComList.FormattingEnabled = true;
            this.cbbComList.Location = new System.Drawing.Point(61, 22);
            this.cbbComList.Name = "cbbComList";
            this.cbbComList.Size = new System.Drawing.Size(98, 21);
            this.cbbComList.TabIndex = 1;
            this.cbbComList.DropDown += new System.EventHandler(this.cbbComList_DropDown);
            this.cbbComList.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "校验位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位";
            // 
            // ComDevice
            // 
            this.ComDevice.ReadTimeout = 1000;
            this.ComDevice.WriteTimeout = 1000;
            this.ComDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Com_DataReceived);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Interval = 1;
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Location = new System.Drawing.Point(9, 18);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(96, 16);
            this.chkTrans.TabIndex = 1;
            this.chkTrans.Text = "转义字符处理";
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // ZuartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Setting);
            this.Name = "ZuartControl";
            this.Size = new System.Drawing.Size(182, 572);
            this.panel_Setting.ResumeLayout(false);
            this.groupboxSendSetting.ResumeLayout(false);
            this.groupboxSendSetting.PerformLayout();
            this.groupboxRecSetting.ResumeLayout(false);
            this.groupboxRecSetting.PerformLayout();
            this.groupBoxComSetting.ResumeLayout(false);
            this.groupBoxComSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.GroupBox groupBoxComSetting;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupboxRecSetting;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.IO.Ports.SerialPort ComDevice;
        private System.Windows.Forms.LinkLabel lkbSaveRev;
        private System.Windows.Forms.RadioButton rbtnUnicode;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.GroupBox groupboxSendSetting;
        private System.Windows.Forms.LinkLabel lkbClearSend;
        private System.Windows.Forms.LinkLabel lkbClearRev;
        private System.Windows.Forms.LinkLabel lkbReadSend;
        private System.Windows.Forms.RadioButton rbtnSendUnicode;
        private System.Windows.Forms.RadioButton rbtnSendHex;
        private System.Windows.Forms.RadioButton rbtnSendASCII;
        private System.Windows.Forms.RadioButton rbtnSendUTF8;
        private System.Windows.Forms.CheckBox chkAutoCleanSend;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.CheckBox chkfromFileSend;
        private System.Windows.Forms.CheckBox chkAutoAddSend;
        private System.Windows.Forms.TextBox txtAutoSendms;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkRecSend;
        private System.Windows.Forms.CheckBox chkAutoScroll;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.CheckBox chkTrans;
    }
}
