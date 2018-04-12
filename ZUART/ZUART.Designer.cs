namespace ZUART
{
    partial class ZUART
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
            this.panel_Rec = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShowData = new System.Windows.Forms.TextBox();
            this.panel_Send = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.panel_Log = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.Label();
            this.btnCleanCount = new System.Windows.Forms.Button();
            this.lblRevCount = new System.Windows.Forms.Label();
            this.lblSendCount = new System.Windows.Forms.Label();
            this.ComDevice = new System.IO.Ports.SerialPort(this.components);
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel_ListSend = new System.Windows.Forms.Panel();
            this.ListSend_Send0 = new System.Windows.Forms.Button();
            this.ListSend_Text0 = new System.Windows.Forms.TextBox();
            this.ListSend_Hex0 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnabout = new System.Windows.Forms.Button();
            this.panel_Setting.SuspendLayout();
            this.groupboxSendSetting.SuspendLayout();
            this.groupboxRecSetting.SuspendLayout();
            this.groupBoxComSetting.SuspendLayout();
            this.panel_Rec.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Send.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_Log.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel_ListSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Setting
            // 
            this.panel_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Setting.Controls.Add(this.groupboxSendSetting);
            this.panel_Setting.Controls.Add(this.groupboxRecSetting);
            this.panel_Setting.Controls.Add(this.groupBoxComSetting);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Setting.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(174, 535);
            this.panel_Setting.TabIndex = 0;
            // 
            // groupboxSendSetting
            // 
            this.groupboxSendSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupboxSendSetting.Controls.Add(this.txtAutoSendms);
            this.groupboxSendSetting.Controls.Add(this.chkAutoCleanSend);
            this.groupboxSendSetting.Controls.Add(this.chkAutoSend);
            this.groupboxSendSetting.Controls.Add(this.chkfromFileSend);
            this.groupboxSendSetting.Controls.Add(this.chkAutoAddSend);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUnicode);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendHex);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendASCII);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUTF8);
            this.groupboxSendSetting.Controls.Add(this.lkbReadSend);
            this.groupboxSendSetting.Controls.Add(this.lkbClearSend);
            this.groupboxSendSetting.Location = new System.Drawing.Point(3, 348);
            this.groupboxSendSetting.Name = "groupboxSendSetting";
            this.groupboxSendSetting.Size = new System.Drawing.Size(170, 187);
            this.groupboxSendSetting.TabIndex = 3;
            this.groupboxSendSetting.TabStop = false;
            this.groupboxSendSetting.Text = "发送区设置";
            // 
            // txtAutoSendms
            // 
            this.txtAutoSendms.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAutoSendms.Location = new System.Drawing.Point(105, 82);
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
            this.chkAutoCleanSend.Location = new System.Drawing.Point(9, 64);
            this.chkAutoCleanSend.Name = "chkAutoCleanSend";
            this.chkAutoCleanSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoCleanSend.TabIndex = 3;
            this.chkAutoCleanSend.Text = "发送完自动清空";
            this.chkAutoCleanSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(9, 86);
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
            this.chkfromFileSend.Location = new System.Drawing.Point(9, 20);
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
            this.chkAutoAddSend.Location = new System.Drawing.Point(9, 42);
            this.chkAutoAddSend.Name = "chkAutoAddSend";
            this.chkAutoAddSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoAddSend.TabIndex = 2;
            this.chkAutoAddSend.Text = "自动发送附加位";
            this.chkAutoAddSend.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUnicode
            // 
            this.rbtnSendUnicode.AutoSize = true;
            this.rbtnSendUnicode.Location = new System.Drawing.Point(68, 130);
            this.rbtnSendUnicode.Name = "rbtnSendUnicode";
            this.rbtnSendUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnSendUnicode.TabIndex = 9;
            this.rbtnSendUnicode.Text = "Unicode";
            this.rbtnSendUnicode.UseVisualStyleBackColor = true;
            // 
            // rbtnSendHex
            // 
            this.rbtnSendHex.AutoSize = true;
            this.rbtnSendHex.Location = new System.Drawing.Point(9, 108);
            this.rbtnSendHex.Name = "rbtnSendHex";
            this.rbtnSendHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendHex.TabIndex = 6;
            this.rbtnSendHex.Text = "Hex";
            this.rbtnSendHex.UseVisualStyleBackColor = true;
            // 
            // rbtnSendASCII
            // 
            this.rbtnSendASCII.AutoSize = true;
            this.rbtnSendASCII.Checked = true;
            this.rbtnSendASCII.Location = new System.Drawing.Point(68, 109);
            this.rbtnSendASCII.Name = "rbtnSendASCII";
            this.rbtnSendASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendASCII.TabIndex = 7;
            this.rbtnSendASCII.TabStop = true;
            this.rbtnSendASCII.Text = "ASCII";
            this.rbtnSendASCII.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUTF8
            // 
            this.rbtnSendUTF8.AutoSize = true;
            this.rbtnSendUTF8.Location = new System.Drawing.Point(9, 130);
            this.rbtnSendUTF8.Name = "rbtnSendUTF8";
            this.rbtnSendUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendUTF8.TabIndex = 8;
            this.rbtnSendUTF8.Text = "UTF-8";
            this.rbtnSendUTF8.UseVisualStyleBackColor = true;
            // 
            // lkbReadSend
            // 
            this.lkbReadSend.AutoSize = true;
            this.lkbReadSend.Location = new System.Drawing.Point(16, 159);
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
            this.lkbClearSend.Location = new System.Drawing.Point(83, 159);
            this.lkbClearSend.Name = "lkbClearSend";
            this.lkbClearSend.Size = new System.Drawing.Size(53, 12);
            this.lkbClearSend.TabIndex = 11;
            this.lkbClearSend.TabStop = true;
            this.lkbClearSend.Text = "清除发送";
            this.lkbClearSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearSend_LinkClicked);
            // 
            // groupboxRecSetting
            // 
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
            this.groupboxRecSetting.Size = new System.Drawing.Size(170, 141);
            this.groupboxRecSetting.TabIndex = 2;
            this.groupboxRecSetting.TabStop = false;
            this.groupboxRecSetting.Text = "接收区设置";
            // 
            // lkbSaveRev
            // 
            this.lkbSaveRev.AutoSize = true;
            this.lkbSaveRev.Location = new System.Drawing.Point(16, 118);
            this.lkbSaveRev.Name = "lkbSaveRev";
            this.lkbSaveRev.Size = new System.Drawing.Size(53, 12);
            this.lkbSaveRev.TabIndex = 7;
            this.lkbSaveRev.TabStop = true;
            this.lkbSaveRev.Text = "保存数据";
            this.lkbSaveRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSaveRev_LinkClicked);
            // 
            // rbtnUnicode
            // 
            this.rbtnUnicode.AutoSize = true;
            this.rbtnUnicode.Location = new System.Drawing.Point(72, 87);
            this.rbtnUnicode.Name = "rbtnUnicode";
            this.rbtnUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnUnicode.TabIndex = 6;
            this.rbtnUnicode.TabStop = true;
            this.rbtnUnicode.Text = "Unicode";
            this.rbtnUnicode.UseVisualStyleBackColor = true;
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(12, 87);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnUTF8.TabIndex = 5;
            this.rbtnUTF8.TabStop = true;
            this.rbtnUTF8.Text = "UTF-8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Checked = true;
            this.rbtnASCII.Location = new System.Drawing.Point(72, 65);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnASCII.TabIndex = 4;
            this.rbtnASCII.TabStop = true;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(13, 65);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 3;
            this.rbtnHex.TabStop = true;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            // 
            // lkbClearRev
            // 
            this.lkbClearRev.AutoSize = true;
            this.lkbClearRev.Location = new System.Drawing.Point(83, 118);
            this.lkbClearRev.Name = "lkbClearRev";
            this.lkbClearRev.Size = new System.Drawing.Size(53, 12);
            this.lkbClearRev.TabIndex = 8;
            this.lkbClearRev.TabStop = true;
            this.lkbClearRev.Text = "清除接收";
            this.lkbClearRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearRev_LinkClicked);
            // 
            // chkShowTime
            // 
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Location = new System.Drawing.Point(13, 42);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(96, 16);
            this.chkShowTime.TabIndex = 2;
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
            this.chkAutoLine.TabIndex = 1;
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
            // panel_Rec
            // 
            this.panel_Rec.Controls.Add(this.groupBox2);
            this.panel_Rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Rec.Location = new System.Drawing.Point(174, 0);
            this.panel_Rec.Name = "panel_Rec";
            this.panel_Rec.Size = new System.Drawing.Size(646, 429);
            this.panel_Rec.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShowData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 429);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收区";
            // 
            // txtShowData
            // 
            this.txtShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowData.Location = new System.Drawing.Point(3, 19);
            this.txtShowData.Multiline = true;
            this.txtShowData.Name = "txtShowData";
            this.txtShowData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowData.Size = new System.Drawing.Size(640, 407);
            this.txtShowData.TabIndex = 2;
            // 
            // panel_Send
            // 
            this.panel_Send.Controls.Add(this.groupBox3);
            this.panel_Send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Send.Location = new System.Drawing.Point(174, 429);
            this.panel_Send.Name = "panel_Send";
            this.panel_Send.Size = new System.Drawing.Size(646, 106);
            this.panel_Send.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.txtSendData);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送区";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSend.Location = new System.Drawing.Point(564, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 76);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(3, 22);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(555, 76);
            this.txtSendData.TabIndex = 1;
            // 
            // panel_Log
            // 
            this.panel_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Log.Controls.Add(this.btnabout);
            this.panel_Log.Controls.Add(this.Log);
            this.panel_Log.Controls.Add(this.btnCleanCount);
            this.panel_Log.Controls.Add(this.lblRevCount);
            this.panel_Log.Controls.Add(this.lblSendCount);
            this.panel_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Log.Location = new System.Drawing.Point(0, 535);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(1005, 25);
            this.panel_Log.TabIndex = 3;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(6, 3);
            this.Log.MinimumSize = new System.Drawing.Size(100, 0);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(2);
            this.Log.Size = new System.Drawing.Size(100, 16);
            this.Log.TabIndex = 15;
            this.Log.Text = "串口关闭";
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCleanCount
            // 
            this.btnCleanCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCleanCount.Location = new System.Drawing.Point(877, 1);
            this.btnCleanCount.Name = "btnCleanCount";
            this.btnCleanCount.Size = new System.Drawing.Size(66, 20);
            this.btnCleanCount.TabIndex = 14;
            this.btnCleanCount.Text = "复位计数";
            this.btnCleanCount.UseVisualStyleBackColor = true;
            this.btnCleanCount.Click += new System.EventHandler(this.btnCleanCount_Click);
            // 
            // lblRevCount
            // 
            this.lblRevCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRevCount.AutoSize = true;
            this.lblRevCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevCount.Location = new System.Drawing.Point(671, 2);
            this.lblRevCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblRevCount.Name = "lblRevCount";
            this.lblRevCount.Padding = new System.Windows.Forms.Padding(2);
            this.lblRevCount.Size = new System.Drawing.Size(100, 18);
            this.lblRevCount.TabIndex = 13;
            this.lblRevCount.Text = "接收:0";
            this.lblRevCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSendCount
            // 
            this.lblSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendCount.AutoSize = true;
            this.lblSendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSendCount.Location = new System.Drawing.Point(774, 2);
            this.lblSendCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblSendCount.Name = "lblSendCount";
            this.lblSendCount.Padding = new System.Windows.Forms.Padding(2);
            this.lblSendCount.Size = new System.Drawing.Size(100, 18);
            this.lblSendCount.TabIndex = 11;
            this.lblSendCount.Text = "发送:0";
            this.lblSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComDevice
            // 
            this.ComDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Com_DataReceived);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Interval = 1;
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel_ListSend);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(820, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 535);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "多字符串发送";
            // 
            // panel_ListSend
            // 
            this.panel_ListSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ListSend.AutoScroll = true;
            this.panel_ListSend.BackColor = System.Drawing.Color.Transparent;
            this.panel_ListSend.Controls.Add(this.ListSend_Send0);
            this.panel_ListSend.Controls.Add(this.ListSend_Text0);
            this.panel_ListSend.Controls.Add(this.ListSend_Hex0);
            this.panel_ListSend.Location = new System.Drawing.Point(4, 32);
            this.panel_ListSend.Name = "panel_ListSend";
            this.panel_ListSend.Size = new System.Drawing.Size(181, 503);
            this.panel_ListSend.TabIndex = 6;
            // 
            // ListSend_Send0
            // 
            this.ListSend_Send0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListSend_Send0.Location = new System.Drawing.Point(0, 0);
            this.ListSend_Send0.Name = "ListSend_Send0";
            this.ListSend_Send0.Size = new System.Drawing.Size(25, 21);
            this.ListSend_Send0.TabIndex = 0;
            this.ListSend_Send0.TabStop = false;
            this.ListSend_Send0.Text = "1";
            this.ListSend_Send0.UseVisualStyleBackColor = true;
            this.ListSend_Send0.Click += new System.EventHandler(this.ListSendButton_Click);
            // 
            // ListSend_Text0
            // 
            this.ListSend_Text0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSend_Text0.Location = new System.Drawing.Point(27, 0);
            this.ListSend_Text0.Name = "ListSend_Text0";
            this.ListSend_Text0.Size = new System.Drawing.Size(125, 21);
            this.ListSend_Text0.TabIndex = 4;
            this.ListSend_Text0.TabStop = false;
            // 
            // ListSend_Hex0
            // 
            this.ListSend_Hex0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSend_Hex0.AutoSize = true;
            this.ListSend_Hex0.Location = new System.Drawing.Point(157, 4);
            this.ListSend_Hex0.Name = "ListSend_Hex0";
            this.ListSend_Hex0.Size = new System.Drawing.Size(15, 14);
            this.ListSend_Hex0.TabIndex = 3;
            this.ListSend_Hex0.TabStop = false;
            this.toolTip1.SetToolTip(this.ListSend_Hex0, "选择:以Hex发送\r\n不选:以文本发送");
            this.ListSend_Hex0.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "发送";
            // 
            // btnabout
            // 
            this.btnabout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnabout.Location = new System.Drawing.Point(949, 1);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(51, 20);
            this.btnabout.TabIndex = 16;
            this.btnabout.Text = "关于";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // ZUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 560);
            this.Controls.Add(this.panel_Rec);
            this.Controls.Add(this.panel_Send);
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel_Log);
            this.Name = "ZUART";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试助手";
            this.panel_Setting.ResumeLayout(false);
            this.groupboxSendSetting.ResumeLayout(false);
            this.groupboxSendSetting.PerformLayout();
            this.groupboxRecSetting.ResumeLayout(false);
            this.groupboxRecSetting.PerformLayout();
            this.groupBoxComSetting.ResumeLayout(false);
            this.groupBoxComSetting.PerformLayout();
            this.panel_Rec.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Send.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel_ListSend.ResumeLayout(false);
            this.panel_ListSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.Panel panel_Rec;
        private System.Windows.Forms.Panel panel_Send;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupboxRecSetting;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Label lblRevCount;
        private System.Windows.Forms.Label lblSendCount;
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
        private System.Windows.Forms.Button btnCleanCount;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.TextBox txtShowData;
        private System.Windows.Forms.RadioButton rbtnSendUnicode;
        private System.Windows.Forms.RadioButton rbtnSendHex;
        private System.Windows.Forms.RadioButton rbtnSendASCII;
        private System.Windows.Forms.RadioButton rbtnSendUTF8;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkAutoCleanSend;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.CheckBox chkfromFileSend;
        private System.Windows.Forms.CheckBox chkAutoAddSend;
        private System.Windows.Forms.TextBox txtAutoSendms;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel_ListSend;
        private System.Windows.Forms.Button ListSend_Send0;
        private System.Windows.Forms.TextBox ListSend_Text0;
        private System.Windows.Forms.CheckBox ListSend_Hex0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnabout;
    }
}

