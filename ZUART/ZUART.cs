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
using ZUARTControl;

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
            this.MinimumSize = this.Size;
            init();

        }

        #region 初始化
        private void init()
        {

            #region 设置保存初始化
           /* cbbComList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "cbbComList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cbbBaudRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "cbbBaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cbbDataBits.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "cbbDataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cbbStopBits.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "cbbStopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cbbParity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "cbbParity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            txtSendData.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "txtSendData", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            txtAutoSendms.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "txtAutoSendms", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkAutoLine.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkShowTime.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkShowTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkRecSend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkRecSend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkfromFileSend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkfromFileSend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkAutoAddSend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoAddSend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkAutoCleanSend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoCleanSend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            chkAutoSend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "chkAutoSend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnHex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnHex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnASCII.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnASCII", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnUTF8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnUTF8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnUnicode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnUnicode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendHex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendHex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendASCII.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendASCII", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendUTF8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendUTF8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rbtnSendUnicode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "rbtnSendUnicode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            for (int i = 0; i < ListSend_Count; i++)
            {
                ListSendTextBox[i].DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZUART.Properties.Settings.Default, "ListSend_Text" + i, true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                ListSendCheckBox[i].DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ZUART.Properties.Settings.Default, "ListSend_Hex" + i, true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            }*/
            #endregion
        }
        #endregion

        private void setting_save(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        private void ZUART_FormClosing(object sender, FormClosingEventArgs e)
        {
            setting_save(null, null);
        }


        #region 开关串口状态
        private void zuartControl1_ComConnectState(object sender, ZuartControl.ComConnectState_EventArgs e)
        {
            if (e.IsComOpen)
            {
                timerIcon.Enabled = true;
            }
            else
            {
                timerIcon.Enabled = false;
                this.Icon = Properties.Resources.zuart;
            }
        }


        #endregion


        #region 接收/发送数据监听
        private void zuartControl1_ComDataReceived(object sender, ZuartControl.ComData_EventArgs e)
        {
            byte[] data = e.data;

            lblRevCount.Text = "接收:" + zuartControl1.RevCount.ToString();
        }
        private void zuartControl1_ComDataSend(object sender, ZuartControl.ComData_EventArgs e)
        {
            lblSendCount.Text = "发送:" + zuartControl1.SendCount.ToString();
        }
        #endregion








        #region 计数清零
        private void btnCleanCount_Click(object sender, EventArgs e)
        {
            lblSendCount.Text = "发送:0";
            lblRevCount.Text = "接收:0";
            zuartControl1.RevCount = 0;
            zuartControl1.SendCount = 0;
        }
        #endregion


        #region 关于按钮
        private void btnabout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
            frmAbout.Dispose();
        }
        #endregion

        int icon_flag = 0;
        private void timerIcon_Tick(object sender, EventArgs e)
        {
            icon_flag++;
            if (icon_flag > 2) icon_flag = 1;
            if (icon_flag == 1)
                this.Icon = Properties.Resources.zuart_open_1;
            else if (icon_flag == 2)
                this.Icon = Properties.Resources.zuart_open_2;
        }

    }
}
