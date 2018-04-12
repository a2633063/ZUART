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

namespace ZUART
{
    public partial class ZUART : Form
    {
        const int ListSend_Count = 50;
        Button[] ListSendButton = new Button[ListSend_Count];
        TextBox[] ListSendTextBox = new TextBox[ListSend_Count];
        CheckBox[] ListSendCheckBox = new CheckBox[ListSend_Count];

        public ZUART()
        {
            InitializeComponent();
            init();

        }

        #region 初始化
        private void init()
        {
            btnSend.Enabled = false;
            cbbComList.Items.AddRange(SerialPort.GetPortNames());
            if (cbbComList.Items.Count > 0)
            {
                cbbComList.SelectedIndex = 0;
            }
            cbbBaudRate.SelectedIndex = 13;
            cbbDataBits.SelectedIndex = 0;
            cbbParity.SelectedIndex = 0;
            cbbStopBits.SelectedIndex = 0;

            ListSendButton[0] = ListSend_Send0;
            ListSendTextBox[0] = ListSend_Text0;
            ListSendCheckBox[0] = ListSend_Hex0;
            for (int i = 1; i < ListSend_Count; i++)
            {
                #region 增加Button
                ListSendButton[i] = new Button();
                ListSendButton[i].Left = ListSendButton[0].Left;
                ListSendButton[i].Size = ListSendButton[0].Size;
                ListSendButton[i].Text = (i + 1).ToString();
                ListSendButton[i].Top = ListSendButton[i - 1].Top + ListSendButton[0].Height + 1;
                ListSendButton[i].Click += ListSendButton_Click;
                ListSendButton[i].TabStop = ListSendButton[0].TabStop;
                ListSendButton[i].TabIndex = i;
                panel_ListSend.Controls.Add(ListSendButton[i]);
                #endregion

                #region 增加TextBox
                ListSendTextBox[i] = new TextBox();
                ListSendTextBox[i].Left = ListSendTextBox[0].Left;
                ListSendTextBox[i].Size = ListSendTextBox[0].Size;
                ListSendTextBox[i].Top = ListSendButton[i - 1].Top + ListSendButton[0].Height + 1;
                ListSendTextBox[i].TabStop = ListSendTextBox[0].TabStop;
                panel_ListSend.Controls.Add(ListSendTextBox[i]);
                #endregion

                #region 增加CheckBox

                ListSendCheckBox[i] = new CheckBox();
                ListSendCheckBox[i].Left = ListSendCheckBox[0].Left;
                ListSendCheckBox[i].Size = ListSendCheckBox[0].Size;
                ListSendCheckBox[i].Text = ListSendCheckBox[0].Text;
                ListSendCheckBox[i].Top = ListSendButton[i - 1].Top + ListSendButton[0].Height + 5;
                ListSendCheckBox[i].TabStop = ListSendCheckBox[0].TabStop;
                panel_ListSend.Controls.Add(ListSendCheckBox[i]);
                #endregion
            }

        }
        #endregion


        #region 打开串口按钮
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbbComList.Items.Count <= 0)
            {
                //MessageBox.Show("没有发现串口,请检查线路！");
                Log.Text = "没有发现串口,请检查线路！";
                return;
            }

            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = cbbComList.Text.ToString();
                ComDevice.BaudRate = Convert.ToInt32(cbbBaudRate.Text.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(cbbDataBits.Text.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(cbbStopBits.Text.ToString());
                try
                {
                    ComDevice.Open();
                    btnSend.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnOpen.Text = "关闭串口";
                btnOpen.Image = Properties.Resources.open;
                // 串口号,波特率,数据位,停止位.校验位
                Log.Text = "串口已开启:" + cbbComList.Text + "," + cbbBaudRate.Text + "," + cbbDataBits.Text + "," + cbbStopBits.Text + "," + cbbParity.Text;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                    btnSend.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnOpen.Text = "打开串口";
                btnOpen.Image = Properties.Resources.close;
                Log.Text = "串口已关闭";
            }

            //cbbComList.Enabled = !ComDevice.IsOpen;
            //cbbBaudRate.Enabled = !ComDevice.IsOpen;
            //cbbParity.Enabled = !ComDevice.IsOpen;
            //cbbDataBits.Enabled = !ComDevice.IsOpen;
            //cbbStopBits.Enabled = !ComDevice.IsOpen;
        }

        #endregion
        #region 打开串口后设置串口参数立即生效(关闭后重新打开串口)
        private void cbbComSetChange(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen)
            {
                btnOpen_Click(null, null);
                btnOpen_Click(null, null);
            }

        } 
        #endregion
        /// <summary>
        /// 关闭串口
        /// </summary>
        public void ClearSelf()
        {
            if (ComDevice.IsOpen)
            {
                ComDevice.Close();
            }
        }

        #region 发送数据
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据
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
        /// <summary>
        /// 发送数据button事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListSendButton_Click(object sender, EventArgs e)
        {
            int item = ((Button)sender).TabIndex;
            SendStr(ListSendTextBox[item].Text, ListSendCheckBox[item].Checked);
        }
        #endregion

        #region 发送数据button事件
        /// <summary>
        /// 发送数据button事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (SendStr(txtSendData.Text))
            {
                if (chkAutoCleanSend.Checked)
                {
                    txtSendData.Text = "";
                }
            }
        }
        #endregion

        
        #region 选择编码发送字符串
        private bool SendStr(String str)
        {
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
                sendData = Encoding.ASCII.GetBytes(str);
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
                sendData = Encoding.ASCII.GetBytes(str);
            }

            if (this.SendData(sendData))//发送数据成功计数
            {
                lblSendCount.Invoke(new MethodInvoker(delegate
                {
                    lblSendCount.Text = "发送:" + (int.Parse(lblSendCount.Text.Substring(3)) + txtSendData.Text.Length).ToString();
                }));
                return true;
            }

            return false;
        } 
        #endregion

        #region 字符串转换16进制字节数组
        /// <summary>
        /// 字符串转换16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            this.AddData(ReDatas);//输出数据
        }
        #endregion

        #region 接收文本框字符处理
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
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
                AddContent(new ASCIIEncoding().GetString(data));
            }

            lblRevCount.Invoke(new MethodInvoker(delegate
            {
                lblRevCount.Text = "接收:" + (int.Parse(lblRevCount.Text.Substring(3)) + data.Length).ToString();
            }));
        }



        /// <summary>
        /// 输入到显示区域
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (chkAutoLine.Checked && txtShowData.Text.Length > 0)
                {
                    txtShowData.AppendText("\r\n");
                    if (chkShowTime.Checked)
                    {
                        txtShowData.AppendText("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "】" + "\r\n");
                    }
                }
                txtShowData.AppendText(content);
            }));
        }
        #endregion

        #region 清空接收区
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkbClearRev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtShowData.Clear();
        }
        #endregion
        #region 清空发送
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkbClearSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSendData.Clear();

        }
        #endregion

        #region 显示接受时间监听
        private void chkShowTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowTime.Checked)
            {
                chkAutoLine.Enabled = false;
                chkAutoLine.Checked = true;
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

        private void lkbReadSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofdg = new OpenFileDialog();
            if (ofdg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string file = ofdg.FileName;//得到选择的文件的完整路径
                txtSendData.Text = System.IO.File.ReadAllText(file, Encoding.Default);//把读出来的数据显示在textbox中
            }
        }

        private void btnCleanCount_Click(object sender, EventArgs e)
        {
            lblSendCount.Text = "发送:0";
            lblRevCount.Text = "接收:0";
        }
    }
}
