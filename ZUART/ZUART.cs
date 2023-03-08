using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZUART.Properties;
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

            ImageList imageList1 = new ImageList();
            imageList1.Images.Add(Resources.ico_ab);
            imageList1.Images.Add(Resources.ico_bin);

            lvwBatchSend.LargeImageList = imageList1;//大图标
            lvwBatchSend.SmallImageList = imageList1;//小图标
            lvwBatchSend.Columns.Add("列标题1", 100, HorizontalAlignment.Left);
            lvwBatchSend.Columns.Add("列标题2", 100, HorizontalAlignment.Left);
            lvwBatchSend.Columns.Add("列标题3", 100, HorizontalAlignment.Left);
            lvwBatchSend.Columns.Add("列标题4", 100, HorizontalAlignment.Left);
            lvwBatchSend.LargeImageList = imageList1;
            lvwBatchSend.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            for (int i = 0; i < 100; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i%2;     //通过与imageList绑定，显示imageList中第i项图标
                lvi.Text = "" + i;
                lvi.SubItems.Add("1000");
                lvi.SubItems.Add("10000");

                lvwBatchSend.Items.Add(lvi);
            }

            lvwBatchSend.EndUpdate();  //结束数据处理，UI界面一次性绘制。

            FormBatchSend form = new FormBatchSend(zuartControl1);
            form.TopLevel = false; //指示子窗体非顶级窗体
            form.Dock = DockStyle.Fill;//将窗体最大化填充
            form.FormBorderStyle = FormBorderStyle.None;
            this.tabPage3.Controls.Add(form);
            form.Show();
            new FormBatchSend(zuartControl1).Show();

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
                this.Icon = Resources.zuart;
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
