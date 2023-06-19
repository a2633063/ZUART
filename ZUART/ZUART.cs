using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ZUART.Properties;
using static System.Net.WebRequestMethods;

namespace ZUART
{
    public partial class ZUART : Form
    {
        const int ListSend_Count = 50;
        Button[] ListSendButton = new Button[ListSend_Count];
        TextBox[] ListSendTextBox = new TextBox[ListSend_Count];
        CheckBox[] ListSendCheckBox = new CheckBox[ListSend_Count];
        List<Form> FormChild = new List<Form> { };
        List<string> tabPage = new List<string> { };

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

            tabPage1.Tag = false;
            tabPage2.Tag = false;
            tabPage3.Tag = false;
            PageDataSendRec.Tag = false;
            int i = 0;
            FormChild.Add(new FormShortcutSend(zuartControl1));
            FormChild[i].TopLevel = false; //指示子窗体非顶级窗体
            FormChild[i].Dock = DockStyle.Fill;//将窗体最大化填充
            FormChild[i].FormBorderStyle = FormBorderStyle.None;
            tabPage1.Controls.Add(FormChild[i]);
            FormChild[i].Show();

            i++;
            FormChild.Add(new FormBatchSend(zuartControl1));
            FormChild[i].TopLevel = false; //指示子窗体非顶级窗体
            FormChild[i].Dock = DockStyle.Fill;//将窗体最大化填充
            FormChild[i].FormBorderStyle = FormBorderStyle.None;
            tabPage2.Controls.Add(FormChild[i]);
            FormChild[i].Show();

            i++;
            FormChild.Add(new FormASCII());
            FormChild[i].TopLevel = false; //指示子窗体非顶级窗体
            FormChild[i].Dock = DockStyle.Fill;//将窗体最大化填充
            FormChild[i].FormBorderStyle = FormBorderStyle.None;
            tabPage3.Controls.Add(FormChild[i]);
            FormChild[i].Show();


            string[] files = Properties.Settings.Default.tabPage.Split('|');
            foreach (string file in files)
            {
                ImportDllForm(file);
            }

            splitContainer1.Panel1Collapsed = Properties.Settings.Default.Panel1Collapsed;
            splitContainer1.Panel2Collapsed = Properties.Settings.Default.Panel2Collapsed;

#if CUSTOM_PARSING
            Form userForm = new FormCustomize(zuartControl1);
            userForm.Location = new Point(0, 0);
            userForm.TopLevel = false;
            userForm.Dock = DockStyle.Fill;
            userForm.BackColor = Color.White;
            userForm.FormBorderStyle = FormBorderStyle.None;

            string title = userForm.Text;
            if (String.IsNullOrWhiteSpace(title)) title = "自定义控件";
            TabPage tabPageNew = new TabPage(title);
            tabPageNew.Location = new System.Drawing.Point(4, 22);
            tabPageNew.Name = "tabPageNew";
            tabPageNew.Padding = new Padding(3);
            tabPageNew.Size = new Size(35, 550);
            tabPageNew.TabIndex = 0;
            tabPageNew.BackColor = Color.White;
            userForm.Parent = tabPageNew;
            tabPageNew.Controls.Add(userForm);
            userForm.Show();
            tabLeft.Controls.Add(tabPageNew);
            tabLeft.SelectedIndex = 0;
            移动到右侧ToolStripMenuItem_Click(null,null); 
#endif
        }
        #endregion

        private void setting_save(object sender, EventArgs e)
        {
            string str = "";
            foreach (string s in tabPage)
            {
                str = str + "|" + s;
            }

            Properties.Settings.Default.tabPage=str;
            Properties.Settings.Default.Panel1Collapsed = splitContainer1.Panel1Collapsed;
            Properties.Settings.Default.Panel2Collapsed = splitContainer1.Panel2Collapsed;
            Properties.Settings.Default.Save();
        }

        private void ZUART_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormChild != null)
            {
                foreach (Form form in FormChild)
                {
                    if (form != null && !form.IsDisposed)
                    {
                        form.Close();
                        form.Dispose();
                    }
                }
            }
            setting_save(null, null);
        }


        #region 开关串口状态
        private void zuartControl1_ComConnectState(object sender, ZuartControl.ZuartControl.ComConnectState_EventArgs e)
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
        private void zuartControl1_ComDataReceived(object sender, ZuartControl.ZuartControl.ComData_EventArgs e)
        {
            byte[] data = e.data;

            lblRevCount.Text = "接收:" + zuartControl1.RevCount.ToString();
        }
        private void zuartControl1_ComDataSend(object sender, ZuartControl.ZuartControl.ComData_EventArgs e)
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

        private void labSplit1Switch_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }
        private void labSplit2Switch_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void ImportDllForm(string dll_file_name)
        {
            if (dll_file_name == null || !System.IO.File.Exists(dll_file_name)) return;
            if (!Path.GetExtension(dll_file_name).Equals(".dll")) return;

            Assembly assembly1 = Assembly.LoadFrom(dll_file_name);
            Type[] ty = assembly1.GetTypes();//只好得到所有的类型名，然后遍历，通过类型名字来区别了

            foreach (Type tp in ty)
            {

                try
                {
                    if (tp.BaseType.FullName.Equals("System.Windows.Forms.Form"))
                    {
                        Form userForm = (Form)Activator.CreateInstance(tp, new object[] { zuartControl1 });
                        userForm.Location = new Point(0, 0);
                        userForm.TopLevel = false;
                        userForm.Dock = DockStyle.Fill;
                        userForm.FormBorderStyle = FormBorderStyle.None;
                        string title = userForm.Text;
                        if (String.IsNullOrWhiteSpace(title)) title = "自定义控件";
                        TabPage tabPageNew = new TabPage(title);
                        tabPageNew.Location = new System.Drawing.Point(4, 22);
                        tabPageNew.Name = "tabPageNew";
                        tabPageNew.Padding = new Padding(3);
                        tabPageNew.Size = new Size(35, 550);
                        tabPageNew.TabIndex = 0;
                        userForm.Parent = tabPageNew;
                        tabPageNew.Controls.Add(userForm);
                        userForm.Show();
                        this.tabRight.Controls.Add(tabPageNew);
                        tabRight.SelectedTab = tabPageNew;
                        FormChild.Add(userForm);
                        tabPage.Add(dll_file_name);

                    }
                    else if (tp.BaseType.FullName.Equals("System.Windows.Forms.UserControl"))
                    {
                        UserControl userControl = (UserControl)Activator.CreateInstance(tp, new object[] { zuartControl1 });
                        userControl.Location = new Point(0, 0);
                        userControl.Dock = DockStyle.Fill;
                        string title = userControl.Name;
                        if (String.IsNullOrWhiteSpace(title)) title = "自定义控件";

                        TabPage tabPageNew = new TabPage(title);
                        tabPageNew.Location = new System.Drawing.Point(4, 22);
                        tabPageNew.Name = "tabPageNew";
                        tabPageNew.Padding = new Padding(3);
                        tabPageNew.Size = new Size(35, 550);
                        tabPageNew.TabIndex = 0;
                        tabPageNew.Controls.Add(userControl);
                        this.tabRight.Controls.Add(tabPageNew);
                        tabRight.SelectedTab = tabPageNew;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "导入错误");
                    //throw;
                }
            }
        }


        private void TabRight_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TabRight_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length < 1) return;
            foreach (string file in files)
            {
                if (!Path.GetExtension(file).Equals(".dll"))
                {
                    MessageBox.Show("仅支持form窗口的dll文件拖到到tabPage", "错误");
                    return;
                }
            }
            foreach (string file in files)
            {

                ImportDllForm(file);
            }
        }

        private void TabRight_Click(object sender, EventArgs ee)
        {
            MouseEventArgs e = (MouseEventArgs)ee;
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                Point p = new Point(e.X, e.Y);
                for (int i = 0; i < ((TabControl)sender).TabCount; i++)
                {
                    Rectangle rect = ((TabControl)sender).GetTabRect(i);
                    if (rect.Contains(p))
                    {
                        ((TabControl)sender).SelectedIndex = i;
                        break;
                    }
                }
                menuTab.Show(((TabControl)sender), p);
            }
        }
        #region TabPage 菜单相关功能

        private void menuTab_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            object obj = ((ContextMenuStrip)sender).SourceControl;




            if (obj.GetType() == typeof(TabControl))
            {
                TabControl tab = (TabControl)obj;

                删除ToolStripMenuItem.Enabled = !(tab.SelectedTab.Tag!=null && tab.SelectedTab.Tag.GetType() == typeof(bool) && !(bool)tab.SelectedTab.Tag);
                移动到左侧ToolStripMenuItem.Visible = (obj == tabRight);
                移动到右侧ToolStripMenuItem.Visible = (obj == tabLeft);

                移动到左侧ToolStripMenuItem.Enabled = (tab.TabCount >1);
                移动到右侧ToolStripMenuItem.Enabled = (tab.TabCount > 1);

            }



        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dll_file_name;
            OpenFileDialog ofdg = new OpenFileDialog();
            ofdg.DefaultExt = "*.dll";
            if (ofdg.ShowDialog(this) != DialogResult.OK) return;


            dll_file_name = ofdg.FileName;//得到选择的文件的完整路径
            ImportDllForm(dll_file_name);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = FormChild[tabRight.SelectedIndex];
            form.Close();
            if (form != null && !form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            FormChild.Remove(form);
            tabPage.RemoveAt(tabRight.SelectedIndex - 3);
            tabRight.TabPages.RemoveAt(tabRight.SelectedIndex);

        }

        private void 移动到右侧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object obj;
            if (sender == null)
            {
                obj = tabLeft;
            }
            else
                obj = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;

            if (obj.GetType() == typeof(TabControl))
            {
                TabControl tab = (TabControl)obj;
                TabPage t = tab.SelectedTab;
                tab.TabPages.Remove(t);
                tabRight.TabPages.Add(t);
                tabRight.SelectedTab = t;
            }
        }

        private void 移动到左侧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object obj;
            if (sender == null)
            {
                obj = tabLeft;
            }
            else
                obj = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;

            if (obj.GetType() == typeof(TabControl))
            {
                TabControl tab = (TabControl)obj;
                TabPage t = tab.SelectedTab;
                tab.TabPages.Remove(t);
                tabLeft.TabPages.Add(t);
                tabLeft.SelectedTab = t;
            }

        }
        #endregion
    }
}

