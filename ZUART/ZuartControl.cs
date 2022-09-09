using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZUARTControl
{
    public partial class ZuartControl : UserControl
    {


        #region 自定义属性
        [Category("显示设置"),Description("自动换行显示开关"),Browsable(true)]
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

        private Label labLog ;
        [Category("控件绑定"),Description("设置显示log的Label"),Browsable(true)]
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
                    txtShowData.KeyPress += txtShowData_KeyPress;
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
               // txtSendData.DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "txtSendData", true, DataSourceUpdateMode.OnPropertyChanged));

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
                    ListSendButton[i].Left = 0;
                    ListSendButton[i].Size = new Size(25, 21);
                    ListSendButton[i].Text = (i + 1).ToString();
                    ListSendButton[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height + 1));
                    ListSendButton[i].Click += ListSendButton_Click;
                    ListSendButton[i].TabStop = false;
                    ListSendButton[i].TabIndex = i;
                    panel_ListSend.Controls.Add(ListSendButton[i]);
                    #endregion

                    #region 增加TextBox
                    ListSendTextBox[i] = new TextBox();
                    ListSendTextBox[i].Size = new Size(125, 21);
                    ListSendTextBox[i].Left = 27;
                    ListSendTextBox[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height + 1));
                    ListSendTextBox[i].TabStop = false;
                    ListSendTextBox[i].Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
                    panel_ListSend.Controls.Add(ListSendTextBox[i]);
                    #endregion

                    #region 增加CheckBox
                    ListSendCheckBox[i] = new CheckBox();
                    ListSendCheckBox[i].Left = 157;
                    ListSendCheckBox[i].Size = new Size(15, 14);
                    ListSendCheckBox[i].Text = "";
                    ListSendCheckBox[i].Top = (i == 0 ? 0 : (ListSendButton[i - 1].Top + ListSendButton[0].Height) +1) + 4;
                    ListSendCheckBox[i].TabStop = false;
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
        public class ComConnectState_EventArgs :EventArgs
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
                    foreach(Delegate d in OnComConnectState.GetInvocationList())
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
        public class ComDataReceived_EventArgs : EventArgs
        {
            public byte[] data { get; set; }
        }
        protected EventHandler<ComDataReceived_EventArgs> OnComDataReceived;
        [Category("控件事件"), Description("串口接收到数据后调用"), Browsable(true)]
        public event EventHandler<ComDataReceived_EventArgs> ComDataReceived
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
                    OnComDataReceived = (EventHandler<ComDataReceived_EventArgs>)Delegate.Combine(OnComDataReceived, value);
            }
            remove
            {
                OnComDataReceived = (EventHandler<ComDataReceived_EventArgs>)Delegate.Remove(OnComDataReceived, value);
            }

        }
        #endregion
        #endregion

        UInt64 RevCount = 0;    //接收计数
        UInt64 SendCount = 0;   //发送计数
        public ZuartControl()
        {
            System.Diagnostics.Debug.WriteLine("ZuartControl");
            InitializeComponent();
            init();
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
            chkfromFileSend.DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "chkfromFileSend", true, DataSourceUpdateMode.OnPropertyChanged));
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

            //for (int i = 0; i < ListSend_Count; i++)
            //{
            //    ListSendTextBox[i].DataBindings.Add(new Binding("Text", global::ZUART.Properties.Settings.Default, "ListSend_Text" + i, true, DataSourceUpdateMode.OnPropertyChanged));
            //    ListSendCheckBox[i].DataBindings.Add(new Binding("Checked", global::ZUART.Properties.Settings.Default, "ListSend_Hex" + i, true, DataSourceUpdateMode.OnPropertyChanged));
            //}
            #endregion
        }
        #endregion

        private void setting_save(object sender, EventArgs e)
        {
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
                }

                ComConnectState_EventArgs comConnectState_EventArgs = new ComConnectState_EventArgs();
                comConnectState_EventArgs.IsComOpen = ComDevice.IsOpen;
                if (OnComConnectState != null) OnComConnectState(this, comConnectState_EventArgs);
            }


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
                    ComDevice.Write(data, 0, data.Length);//发送数据
                    SendCount += (UInt64)data.Length;
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
            SendStr(ListSendTextBox[item].Text, ListSendCheckBox[item].Checked);
        }
        #endregion

        #region 发送数据button事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSendData == null) return;
            if (chkAutoSend.Checked)
            {
                if (txtSendData.Text.Length < 1)
                {
                    MessageBox.Show("发送数据为空!", "错误");
                    return;
                }
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
                if (SendStr(txtSendData.Text))
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
        private bool SendStr(String str)
        {
            if (txtSendData == null) return false;
            return SendStr(txtSendData.Text, rbtnSendHex.Checked);
        }
        private bool SendStr(String str, bool hexbool)
        {

            byte[] sendData = null;

            if (hexbool)
            {
                try
                {
                    sendData = strToHexByte(str.Trim());
                }
                catch (Exception)
                {
                    //throw;
                    MessageBox.Show("字符串转十六进制有误,请检测输入格式.", "错误!");
                    return false;
                }
            }
            else if (rbtnSendASCII.Checked)
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
                ComDataReceived_EventArgs comDataReceived_EventArgs = new ComDataReceived_EventArgs();
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
            if (txtShowData == null) return;

            if (chkAutoLine.Checked && txtShowData.Text.Length > 0)
            {
                txtShowData.AppendText("\r\n");
            }
            if (chkShowTime.Checked)
            {
                txtShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]" + "\r\n");
            }
            txtShowData.AppendText(content);
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

        #region 发送文件载入
        private void lkbReadSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofdg = new OpenFileDialog();
            if (ofdg.ShowDialog(this) == DialogResult.OK)
            {
                string file = ofdg.FileName;//得到选择的文件的完整路径
                if (txtSendData != null) txtSendData.Text = System.IO.File.ReadAllText(file, Encoding.Default);//把读出来的数据显示在textbox中
            }
        }
        #endregion



        #region 自动定时发送
        #region 自动发送定时器函数
        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            if (txtSendData != null) SendStr(txtSendData.Text);
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

    }
}
