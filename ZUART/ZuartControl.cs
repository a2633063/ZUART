using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ZUARTControl
{
    public partial class ZuartControl : UserControl
    {


        #region 自定义属性
        [Category("显示设置"), Description("自动换行显示开关"), Browsable(true)]
        public bool AutoLine
        {
            get
            {
                return chkAutoLine.Checked;
            }
            set
            {
                chkAutoLine.Checked = value;
            }
        }

        private Label labLog;
        [Category("控件绑定"), Description("设置显示log的Label"), Browsable(true)]
        public Label Labellog
        {
            get
            {
                return labLog;
            }
            set
            {
                labLog = value;

            }
        }



        private TextBox txtShowData;
        [Category("控件绑定"), Description("设置接收文本的TextBox"), Browsable(true)]
        public TextBox TextBoxShowData
        {
            get
            {
                return txtShowData;
            }
            set
            {
                txtShowData = value;
                if (txtShowData != null)
                {
                    txtShowData.AcceptsTab = true;
                    txtShowData.KeyPress += txtShowData_KeyPress;
                }
            }
        }

        private TextBox txtSendData;
        [Category("控件绑定"), Description("设置发送文本的TextBox"), Browsable(true)]
        public TextBox TextBoxSendData
        {
            get
            {
                return txtSendData;
            }
            set
            {
                txtSendData = value;
                if (txtSendData == null) return;
                //txtSendData.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "txtSendData", true, DataSourceUpdateMode.OnPropertyChanged));

                // txtSendData.AcceptsTab = true;
                txtSendData.KeyPress += txtSendData_KeyPress;
                txtSendData.KeyDown += txtSendData_KeyDown;

            }
        }


        private Button btnSend;
        [Category("控件绑定"), Description("绑定发送按钮Button"), Browsable(true)]
        public Button ButtonSend
        {
            get
            {
                return btnSend;
            }
            set
            {
                if (btnSend != null)
                    btnSend.Click -= btnSend_Click;
                btnSend = value;
                if (btnSend != null)
                {
                    btnSend.Enabled = ComDevice.IsOpen;
                    btnSend.Click += btnSend_Click;
                }
            }
        }

        private Panel panel_ListSend;
        [Category("控件绑定"), Description("批量发送列表添加的Panel"), Browsable(true)]
        public Panel PanelListSend
        {
            get
            {
                return panel_ListSend;
            }
            set
            {
                panel_ListSend = value;
                if (panel_ListSend == null) return;

                //todo 增加控件
                for (int i = 0; i < ListSend_Count; i++)
                {
                    #region 增加Button
                    ListSendButton[i] = new Button();
                    ListSendButton[i].Left = -1;
                    ListSendButton[i].Size = new Size(25, 21);
                    ListSendButton[i].Text = (i + 1).ToString();
                    ListSendButton[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height + 1));
                    ListSendButton[i].Click += ListSendButton_Click;
                    ListSendButton[i].TabStop = true;
                    ListSendButton[i].TabIndex = i;
                    panel_ListSend.Controls.Add(ListSendButton[i]);
                    #endregion

                    #region 增加TextBox
                    ListSendTextBox[i] = new TextBox();
                    ListSendTextBox[i].Left = 25;
                    ListSendTextBox[i].Size = new Size(panel_ListSend.Width - ListSendTextBox[i].Left - 17, 21);
                    ListSendTextBox[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height + 1));
                    ListSendTextBox[i].TabStop = true;
                    ListSendTextBox[i].TabIndex = i;
                    ListSendTextBox[i].Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
                    panel_ListSend.Controls.Add(ListSendTextBox[i]);
                    #endregion

                    #region 增加CheckBox
                    ListSendCheckBox[i] = new CheckBox();
                    ListSendCheckBox[i].Left = panel_ListSend.Width - 16;
                    ListSendCheckBox[i].Size = new Size(15, 15);
                    ListSendCheckBox[i].Text = "";
                    ListSendCheckBox[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height) + 1) + 4;
                    ListSendCheckBox[i].TabStop = true;
                    ListSendCheckBox[i].TabIndex = i;
                    ListSendCheckBox[i].Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    panel_ListSend.Controls.Add(ListSendCheckBox[i]);
                    #endregion

                    toolTip1.SetToolTip(ListSendCheckBox[i], toolTip1.GetToolTip(ListSendCheckBox[0]));
                }
                /* for (int i = 0; i < ListSend_Count; i++)
                 {
                     ListSendTextBox[i].DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "ListSend_Text" + i, true, DataSourceUpdateMode.OnPropertyChanged));
                     ListSendCheckBox[i].DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "ListSend_Hex" + i, true, DataSourceUpdateMode.OnPropertyChanged));
                 }*/

            }
        }

        #endregion


        #region 自定义事件
        #region 串口开关事件回调
        public class ComConnectState_EventArgs : EventArgs
        {
            public bool IsComOpen { get; set; }
        }
        protected EventHandler<ComConnectState_EventArgs> OnComConnectState;
        [Category("控件事件"), Description("串口开关状态变化时调用"), Browsable(true)]
        public event EventHandler<ComConnectState_EventArgs> ComConnectState
        {
            add
            {
                if (OnComConnectState != null)
                {
                    foreach (Delegate d in OnComConnectState.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComConnectState = (EventHandler<ComConnectState_EventArgs>)Delegate.Combine(OnComConnectState, value);
            }
            remove
            {
                OnComConnectState = (EventHandler<ComConnectState_EventArgs>)Delegate.Remove(OnComConnectState, value);
            }

        }
        #endregion

        #region 串口接收事件回调
        public class ComData_EventArgs : EventArgs
        {
            public byte[] data { get; set; }
        }
        protected EventHandler<ComData_EventArgs> OnComDataReceived;
        [Category("控件事件"), Description("串口接收到数据后调用"), Browsable(true)]
        public event EventHandler<ComData_EventArgs> ComDataReceived
        {
            add
            {
                if (OnComDataReceived != null)
                {
                    foreach (Delegate d in OnComDataReceived.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComDataReceived = (EventHandler<ComData_EventArgs>)Delegate.Combine(OnComDataReceived, value);
            }
            remove
            {
                OnComDataReceived = (EventHandler<ComData_EventArgs>)Delegate.Remove(OnComDataReceived, value);
            }

        }
        #endregion
        #region 串口发送事件回调

        protected EventHandler<ComData_EventArgs> OnComDataSend;
        [Category("控件事件"), Description("串口发送数据后调用"), Browsable(true)]
        public event EventHandler<ComData_EventArgs> ComDataSend
        {
            add
            {
                if (OnComDataSend != null)
                {
                    foreach (Delegate d in OnComDataSend.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComDataSend = (EventHandler<ComData_EventArgs>)Delegate.Combine(OnComDataSend, value);
            }
            remove
            {
                OnComDataSend = (EventHandler<ComData_EventArgs>)Delegate.Remove(OnComDataSend, value);
            }

        }
        #endregion
        #endregion

        public UInt64 RevCount { get; set; }    //接收计数
        public UInt64 SendCount { get; set; }    //发送计数
        public string SendFileName { get; set; }    //外部文件源
        public bool IsComOpen
        {
            get
            {
                return ComDevice.IsOpen;
            }
        }
        public ZuartControl()
        {
            System.Diagnostics.Debug.WriteLine("ZuartControl");
            InitializeComponent();
            init();
            RevCount = 0;
            SendCount = 0;
        }



        #region 初始化

        const int ListSend_Count = 50;
        Button[] ListSendButton = new Button[ListSend_Count];
        TextBox[] ListSendTextBox = new TextBox[ListSend_Count];
        CheckBox[] ListSendCheckBox = new CheckBox[ListSend_Count];
        private void init()
        {
            #region 控件初始化
            cbbComList.Items.AddRange(SerialPort.GetPortNames());


            #endregion
            #region 设置保存初始化
            cbbComList.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "cbbComList", true, DataSourceUpdateMode.OnPropertyChanged));
            cbbBaudRate.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "cbbBaudRate", true, DataSourceUpdateMode.OnPropertyChanged));
            cbbDataBits.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "cbbDataBits", true, DataSourceUpdateMode.OnPropertyChanged));
            cbbStopBits.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "cbbStopBits", true, DataSourceUpdateMode.OnPropertyChanged));
            cbbParity.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "cbbParity", true, DataSourceUpdateMode.OnPropertyChanged));
            // txtSendData.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "txtSendData", true, DataSourceUpdateMode.OnPropertyChanged));
            txtAutoSendms.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "txtAutoSendms", true, DataSourceUpdateMode.OnPropertyChanged));
            chkAutoLine.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoLine", true, DataSourceUpdateMode.OnPropertyChanged));
            chkShowTime.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkShowTime", true, DataSourceUpdateMode.OnPropertyChanged));
            chkRecSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkRecSend", true, DataSourceUpdateMode.OnPropertyChanged));
            chkTrans.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkTrans", true, DataSourceUpdateMode.OnPropertyChanged));
            //chkfromFileSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkfromFileSend", true, DataSourceUpdateMode.OnPropertyChanged)); 
            chkAutoAddSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoAddSend", true, DataSourceUpdateMode.OnPropertyChanged));
            chkAutoCleanSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoCleanSend", true, DataSourceUpdateMode.OnPropertyChanged));
            chkAutoSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoSend", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnHex.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnHex", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnASCII.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnASCII", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnUTF8.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnUTF8", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnUnicode.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnUnicode", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendHex.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendHex", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendASCII.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendASCII", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendUTF8.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendUTF8", true, DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendUnicode.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendUnicode", true, DataSourceUpdateMode.OnPropertyChanged));

            toolStripMenuItem1.CheckState = global::ZUART.Properties.Settings.Default.menuItemSendKey1;
            toolStripMenuItem2.CheckState = global::ZUART.Properties.Settings.Default.menuItemSendKey2;
            toolStripMenuItem3.CheckState = global::ZUART.Properties.Settings.Default.menuItemSendKey3;
            toolStripMenuItem4.CheckState = global::ZUART.Properties.Settings.Default.menuItemSendKey4;
            //this.toolStripMenuItem1.CheckState = global::ZUART.Properties.Settings.Default.menuItemSendKey1;

            //for (int i = 0; i < ListSend_Count; i++)
            //{
            //    ListSendTextBox[i].DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "ListSend_Text" + i, true, DataSourceUpdateMode.OnPropertyChanged));
            //    ListSendCheckBox[i].DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "ListSend_Hex" + i, true, DataSourceUpdateMode.OnPropertyChanged));
            //}

            if(txtSendData != null)
                txtSendData.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "txtSendData", true, DataSourceUpdateMode.OnPropertyChanged));

            #endregion
        }
        #endregion

        private void setting_save(object sender, EventArgs e)
        {
            ZUART.Properties.Settings.Default.menuItemSendKey1 = toolStripMenuItem1.CheckState;
            ZUART.Properties.Settings.Default.menuItemSendKey2 = toolStripMenuItem2.CheckState;
            ZUART.Properties.Settings.Default.menuItemSendKey3 = toolStripMenuItem3.CheckState;
            ZUART.Properties.Settings.Default.menuItemSendKey4 = toolStripMenuItem4.CheckState;
            ZUART.Properties.Settings.Default.Save();
        }

        private void Log(string s)
        {
            if (Labellog == null) return;
            Labellog.Text = s;
        }

        #region 打开串口按钮
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbbComList.Items.Count <= 0)
            {
                //MessageBox.Show("没有发现串口,请检查线路！");
                Log("没有发现串口,请检查线路！");
                return;
            }

            try
            {
                //if (ComDevice.IsOpen == false)
                if (btnOpen.Text == "打开串口")
                {
                    ComDevice.PortName = cbbComList.Text.ToString();
                    ComDevice.BaudRate = Convert.ToInt32(cbbBaudRate.Text.ToString());
                    ComDevice.Parity = (Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                    ComDevice.DataBits = Convert.ToInt32(cbbDataBits.Text.ToString());
                    ComDevice.StopBits = (StopBits)Convert.ToInt32(cbbStopBits.Text.ToString());

                    ComDevice.Open();
                }
                else
                {
                    ComDevice.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddContent("串口打开错误:" + ex.Message + "\r\n");

            }
            finally
            {
                if (ComDevice.IsOpen == false)
                {
                    if (btnSend != null)
                        btnSend.Enabled = false;
                    chkDTR.Enabled = false;
                    chkRTS.Enabled = false;
                    btnOpen.Text = "打开串口";
                    btnOpen.Image = ZUART.Properties.Resources.close;
                    Log("串口已关闭");
                }
                else
                {
                    if (btnSend != null)
                        btnSend.Enabled = true;
                    btnOpen.Text = "关闭串口";
                    btnOpen.Image = ZUART.Properties.Resources.open;
                    // 串口号,波特率,数据位,停止位.校验位
                    Log("串口已开启:" + cbbComList.Text + "," + cbbBaudRate.Text + "," + cbbDataBits.Text + "," + cbbStopBits.Text + "," + cbbParity.Text);

                    chkDTR.Enabled = true;
                    chkRTS.Enabled = true;
                    ComDevice.DtrEnable = chkDTR.Checked;
                    ComDevice.RtsEnable = chkRTS.Checked;
                }

                ComConnectState_EventArgs comConnectState_EventArgs = new ComConnectState_EventArgs();
                comConnectState_EventArgs.IsComOpen = ComDevice.IsOpen;
                if (OnComConnectState != null) OnComConnectState(this, comConnectState_EventArgs);
            }


        }
        private void chkRTS_DTR_CheckedChanged(object sender, EventArgs e)
        {
            ComDevice.DtrEnable = chkDTR.Checked;
            ComDevice.RtsEnable = chkRTS.Checked;
        }
        #endregion
        #region 串口参数设置监听 打开串口后设置串口参数立即生效(关闭后重新打开串口)
        private void cbbComList_DropDown(object sender, EventArgs e)
        {
            cbbComList.Items.Clear();
            cbbComList.Items.AddRange(SerialPort.GetPortNames());
        }
        private void cbbComSetChange(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen)
            {
                btnOpen_Click(null, null);
                btnOpen_Click(null, null);
            }

        }
        #endregion



        #region 发送数据
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {

                    byte[] data_temp = new byte[4096];

                    long offect = 0;
                    long length = 4096;

                    for(offect=0; offect<data.LongLength; offect += length)
                    {
                        length = 4096;
                        if (length > data.LongLength - offect) length = data.LongLength - offect;
                        Array.Copy(data, offect, data_temp, 0, length);
                        ComDevice.Write(data_temp, 0, (int)length);//发送数据
                        SendCount += (UInt64)length;
                    }

                    //ComDevice.Write(data, 0, data.Length);//发送数据
                    //SendCount += (UInt64)data.Length;

                    if (OnComDataSend != null)
                    {
                        ComData_EventArgs comData_EventArgs = new ComData_EventArgs();
                        comData_EventArgs.data = data;
                        OnComDataSend(this, comData_EventArgs);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddContent("串口未打开\r\n");
            }
            return false;
        }
        #endregion

        #region 多字符串发送
        private void ListSendButton_Click(object sender, EventArgs e)
        {

            int item = ((Button)sender).TabIndex;
            if (ListSendTextBox[item].Text.Length > 0)
                SendStr(ListSendTextBox[item].Text, ListSendCheckBox[item].Checked);
        }
        #endregion

        #region 发送数据button事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            if(chkfromFileSend.Checked && SendFileName!=null && File.Exists(SendFileName))
            {
                byte[] file = File.ReadAllBytes(SendFileName);
                SendData(file);//TODO 发送大量数据时容易出问题 需要优化

                if (chkShowTime.Checked)
                {
                    if (txtShowData.Text.Length > 0)
                    {
                        txtShowData.AppendText("\r\n");
                    }
                    txtShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send file:" + "\r\n发送文件数据源:"+ SendFileName);
                }
                return;
            }
            if (txtSendData == null) return;
            if (txtSendData.Text.Length < 1)
            {
                MessageBox.Show("发送数据为空!", "错误");
                return;
            }
            if (chkAutoSend.Checked)
            {
                if (txtAutoSendms.Text.Length < 1) txtAutoSendms.Text = "500";
                timerAutoSend.Interval = Convert.ToInt32(txtAutoSendms.Text);
                if (timerAutoSend.Enabled)
                {
                    timerAutoSend.Enabled = false;
                    groupBoxComSetting.Enabled = true;
                    groupboxSendSetting.Enabled = true;
                    if (btnSend != null) btnSend.Text = "发送";
                }
                else
                {
                    timerAutoSend.Enabled = true;
                    groupBoxComSetting.Enabled = false;
                    groupboxSendSetting.Enabled = false;
                    if (btnSend != null) btnSend.Text = "停止发送";
                }
            }
            else
            {
                if (SendStr(txtSendData.Text, rbtnSendHex.Checked))
                {
                    if (chkAutoCleanSend.Checked)
                    {
                        txtSendData.Text = "";
                    }
                }
            }
        }
        #endregion


        #region 选择编码发送字符串
        private bool SendStr(String str, bool hexbool)
        {

            byte[] sendData = null;

            if (hexbool)
            {
                try
                {
                    sendData = strToHexByte(str.Trim());

                    if (chkShowTime.Checked)
                    {
                        if (txtShowData.Text.Length > 0)
                        {
                            txtShowData.AppendText("\r\n");
                        }
                        txtShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send Hex:" + "\r\n" + str.Trim());
                    }

                }
                catch (Exception)
                {
                    //throw;
                    MessageBox.Show("字符串转十六进制有误,请检测输入格式.", "错误!");
                    return false;
                }
            }
            else
            {
                if (chkShowTime.Checked)
                {
                    if (txtShowData.Text.Length > 0)
                    {
                        txtShowData.AppendText("\r\n");
                    }
                    txtShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send Str:" + "\r\n" + str);
                }

                #region 转义字符的处理
                if (chkTrans.Checked)
                {//转义字符的处理
                    string s = "";
                    char c_temp = (char)0;
                    int is_trans_status = 0;
                    foreach (char c in str)
                    {
                        switch (is_trans_status)
                        {
                            case 0:
                                {
                                    if (c != '\\')
                                    {
                                        s += c;
                                    }
                                    else
                                    {
                                        is_trans_status = 1;
                                    }
                                    c_temp = (char)0;
                                    continue;
                                }
                            case 1:
                                switch (c)
                                {
                                    case 'a': s += '\x07'; is_trans_status = 0; break;
                                    case 'b': s += '\x08'; is_trans_status = 0; break;
                                    case 'f': s += '\x0C'; is_trans_status = 0; break;
                                    case 'n': s += '\x0A'; is_trans_status = 0; break;
                                    case 'r': s += '\x0D'; is_trans_status = 0; break;
                                    case 't': s += '\x09'; is_trans_status = 0; break;
                                    case 'v': s += '\x0B'; is_trans_status = 0; break;
                                    case '\\': s += '\\'; is_trans_status = 0; break;
                                    case '\'': s += '\''; is_trans_status = 0; break;
                                    case '\"': s += '\x22'; is_trans_status = 0; break;
                                    case '?': s += '?'; is_trans_status = 0; break;
                                    //case '0': s += '\x00'; is_trans_status = 0; break;
                                    case 'x': is_trans_status = 2; break;
                                    case '0': goto CASE_7;
                                    case '1': goto CASE_7;
                                    case '2': goto CASE_7;
                                    case '3': goto CASE_7;
                                    case '4': goto CASE_7;
                                    case '5': goto CASE_7;
                                    case '6': goto CASE_7;
                                    case '7':
                                    CASE_7:
                                        c_temp = (char)(c - '0');
                                        is_trans_status = 4;
                                        break;
                                    default:
                                        s += c;
                                        is_trans_status = 0;
                                        break;
                                }
                                break;
                            case 2:
                                {
                                    is_trans_status++;
                                    if (c <= 'F' && c >= 'A')
                                    {
                                        c_temp = (char)(c - 'A' + 10);
                                    }
                                    else if (c <= 'f' && c >= 'a')
                                    {
                                        c_temp = (char)(c - 'a' + 10);
                                    }
                                    if (c <= '9' && c >= '0')
                                    {
                                        c_temp = (char)(c - '0');
                                    }
                                    else
                                    {   //\x后非十六进制,着则忽略\符号
                                        s += 'x' + c;
                                        is_trans_status = 0;
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (c <= 'F' && c >= 'A')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - 'A' + 10));
                                    }
                                    else if (c <= 'f' && c >= 'a')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - 'a' + 10));
                                    }
                                    if (c <= '9' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - '0'));
                                    }

                                    s += c_temp;

                                    if (!((c <= 'F' && c >= 'A') || (c <= 'f' && c >= 'a') || (c <= '9' && c >= '0')))
                                    {
                                        s += c;
                                    }

                                    is_trans_status = 0;
                                }
                                break;

                            case 4://\d[d]
                                {
                                    if (c < '8' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 8 + c - '0');
                                        is_trans_status++;
                                    }
                                    else
                                    {   //\d后非8进制
                                        s += c_temp;
                                        s += c;
                                        is_trans_status = 0;
                                    }
                                }
                                break;
                            case 5: //\dd[d]最后一个字符
                                {
                                    if (c < '8' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 8 + c - '0');
                                    }
                                    s += c_temp;

                                    if (!(c < '8' && c >= '0'))
                                    {
                                        s += c;
                                    }
                                    is_trans_status = 0;
                                }
                                break;
                        }
                    }

                    if(is_trans_status >=2 && is_trans_status<=5) s += c_temp;


                    str = s;
                    //str = Regex.Replace(str, @"(?<!\\)\\a", "\a");
                    //str = Regex.Replace(str, @"(?<!\\)\\b", "\b");
                    //str = Regex.Replace(str, @"(?<!\\)\\f", "\f");
                    //str = Regex.Replace(str, @"(?<!\\)\\n", "\n");
                    //str = Regex.Replace(str, @"(?<!\\)\\r", "\r");
                    //str = Regex.Replace(str, @"(?<!\\)\\t", "\t");
                    //str = Regex.Replace(str, @"(?<!\\)\\v", "\v");
                    //str = Regex.Replace(str, @"(?<!\\)\\\\", "\\");
                    //str = Regex.Replace(str, @"(?<!\\)\\'", "\'");
                    //str = Regex.Replace(str, @"(?<!\\)\\""", "\"");
                    //str = Regex.Replace(str, @"(?<!\\)\\?", "?");
                    //str = Regex.Replace(str, @"(?<!\\)\\0", "\0");

                    #endregion

                }
                if (rbtnSendASCII.Checked)
                {
                    //sendData = Encoding.ASCII.GetBytes(str);
                    sendData = Encoding.GetEncoding("GBK").GetBytes(str);
                }
                else if (rbtnSendUTF8.Checked)
                {
                    sendData = Encoding.UTF8.GetBytes(str);
                }
                else if (rbtnSendUnicode.Checked)
                {
                    sendData = Encoding.Unicode.GetBytes(str);
                }
                else
                {
                    sendData = Encoding.GetEncoding("GBK").GetBytes(str);
                }
            }

            if (this.SendData(sendData))//发送数据成功计数
            {
                return true;
            }

            return false;
        }
        #endregion

        #region 字符串转换16进制字节数组
        private byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
        #endregion

        #region 接收数据监听
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            this.BeginInvoke(new MethodInvoker(delegate
            {
                RevCount += (UInt64)ReDatas.Length;
                this.AddData(ReDatas);//输出数据
                ComData_EventArgs comDataReceived_EventArgs = new ComData_EventArgs();
                comDataReceived_EventArgs.data = ReDatas;
                if (OnComDataReceived != null) OnComDataReceived(this, comDataReceived_EventArgs);
            }));
        }
        #endregion
        #region 接收文本框,输入监听,供输入直接发送
        private void txtShowData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkRecSend.Checked && ComDevice.IsOpen)
            {
                //if ((e.KeyChar >= ' ' && e.KeyChar <= '~') || e.KeyChar == '\r')//这是允许输入退格键允许输入0-9数字
                //{
                SendStr(e.KeyChar.ToString(), false);

                //}
            }
            e.Handled = true;
        }
        #endregion
        #region 发送文本框,输入监听,供设置发送/换行按键
        private bool eHandled = false;
        private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
        {      
            e.Handled = eHandled;

            if(rbtnSendHex.Checked &&!eHandled)
            {   //\u0016\u0001\u0018\u0003\u001a
                if (!"\r\babcdefABCDEF 0123456789".Contains(e.KeyChar.ToString()) && e.KeyChar> '\u0020')
                {
                    e.Handled = true;
                }
            }
        }
        private void txtSendData_KeyDown(object sender, KeyEventArgs e)
        {
            eHandled = false;
            if (e.KeyCode== Keys.Enter && e.Control && !e.Shift)
            {
                //Console.WriteLine("Ctrl+Enter");
                if(toolStripMenuItem3.CheckState==CheckState.Checked)
                {//Ctrl+Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            else if (e.KeyCode == Keys.Enter && !e.Control && e.Shift)
            {
                //Console.WriteLine("Shift+Enter");
                if (toolStripMenuItem4.CheckState == CheckState.Checked)
                {//Shift+Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            else if (e.KeyCode == Keys.Enter && !e.Shift && !e.Control && !e.Alt)
            {
                //Console.WriteLine("Enter");
                if (toolStripMenuItem1.CheckState == CheckState.Checked || toolStripMenuItem2.CheckState == CheckState.Checked)
                {//Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            eHandled = e.Handled;
        }
        #endregion
        #region 接收文本框字符处理
        public void AddData(byte[] data)
        {
            if (rbtnHex.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AddContent(sb.ToString().ToUpper());
            }
            else if (rbtnUTF8.Checked)
            {
                AddContent(new UTF8Encoding().GetString(data));
            }
            else if (rbtnUnicode.Checked)
            {
                AddContent(new UnicodeEncoding().GetString(data));
            }
            else// if (rbtnASCII.Checked)
            {
                //AddContent(new ASCIIEncoding().GetString(data));
                AddContent(Encoding.GetEncoding("GBK").GetString(data));
            }

        }




        //输入到显示区域
        private void AddContent(string content)
        {
            //this.BeginInvoke(new MethodInvoker(delegate
            //{
            string str = "";
            if (txtShowData == null) return;

            if (chkAutoLine.Checked && txtShowData.Text.Length > 0)
            {
                str = "\r\n";
                //txtShowData.AppendText("\r\n");
            }

            if (chkShowTime.Checked)
            {
                str += " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Rec:" + "\r\n";
                //txtShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]" + "\r\n");
            }

            str += content;
            if (chkAutoScroll.Checked)
            {
                txtShowData.AppendText(str);
            }
            else
            {
                txtShowData.Text += str;
            }

            //}));
        }
        #endregion

        #region 清空接收区
        private void lkbClearRev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtShowData != null)
                txtShowData.Clear();
        }
        #endregion
        #region 清空发送
        private void lkbClearSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtSendData != null) txtSendData.Clear();

        }
        #endregion

        #region 显示接受时间监听
        private void chkShowTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowTime.Checked)
            {
                chkAutoLine.Checked = true;
                chkAutoLine.Enabled = false;
                chkShowTime.Checked = true;
            }
            else
            {
                chkAutoLine.Enabled = true;
            }
        }
        #endregion

        #region 保存数据
        private void lkbSaveRev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (txtShowData.Text.Length < 1)
            //{
            //    MessageBox("");
            //    return;
            //}
            if (txtShowData == null) return;
            StreamWriter myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "保存接受区数据";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = new StreamWriter(saveFileDialog1.FileName);
                myStream.Write(txtShowData.Text); //写入
                myStream.Close();//关闭流
            }
        }


        #endregion

        #region 外部文件源载入 
        private void chkfromFileSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfromFileSend.Checked)
            {
                OpenFileDialog ofdg = new OpenFileDialog();
                if (ofdg.ShowDialog(this) == DialogResult.OK)
                {
                    SendFileName = ofdg.FileName;//得到选择的文件的完整路径
                    //if (txtSendData != null) txtSendData.Text = System.IO.File.ReadAllText(file, Encoding.Default);//把读出来的数据显示在textbox中
 
                    if (txtSendData != null)
                    {
                        //txtSendData.Enabled = false;
                        txtSendData.Tag = txtSendData.Text;
                        txtSendData.Text = "启用外部文件数据源:\r\n"+ofdg.FileName;
                    }
                }
                else
                {
                    chkfromFileSend.Checked = false;
                }
            }
            txtSendData.Enabled = !chkfromFileSend.Checked;
            if (txtSendData.Enabled)
            {
                txtSendData.Text = (string)txtSendData.Tag;
                SendFileName = null;
            }

        }
        #endregion



        #region 自动定时发送
        #region 自动发送定时器函数
        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            if (txtSendData != null)
            {
                SendStr(txtSendData.Text, rbtnSendHex.Checked);
            }
        }
        #endregion
        #region 自动发送间隔时间,只能输入数字
        private void txtAutoSendms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && ((e.KeyChar < '0') || (e.KeyChar > '9')))//这是允许输入退格键允许输入0-9数字
            {
                e.Handled = true;
            }
        }
        #endregion

        #endregion


        #region 编码RadioButton控件单击监听
        private void rbtnSend_Click(object sender, EventArgs e)
        {
            rbtnSendHex.Checked = false;
            rbtnSendASCII.Checked = false;
            rbtnSendUTF8.Checked = false;
            rbtnSendUnicode.Checked = false;
            ((RadioButton)sender).Checked = true;
        }
        private void rbtn_Click(object sender, EventArgs e)
        {
            rbtnHex.Checked = false;
            rbtnASCII.Checked = false;
            rbtnUTF8.Checked = false;
            rbtnUnicode.Checked = false;
            ((RadioButton)sender).Checked = true;
        }
        #endregion

        private void lkbSendKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menuSendKey.Show(lkbSendKey, 0, lkbSendKey.Height);
 
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.CheckState = CheckState.Unchecked;
            toolStripMenuItem2.CheckState = CheckState.Unchecked;
            toolStripMenuItem3.CheckState = CheckState.Unchecked;
            toolStripMenuItem4.CheckState = CheckState.Unchecked;

            ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;

        }

        private void toolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if(((ToolStripMenuItem)sender).CheckState == CheckState.Checked)
                lkbSendKey.Text = ((ToolStripMenuItem)sender).Text;
        }


    }
}
