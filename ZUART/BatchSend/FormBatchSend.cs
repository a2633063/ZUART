using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZUART.BatchSend;
using ZUART.Properties;
using ZUARTControl;
using static System.Net.Mime.MediaTypeNames;

namespace ZUART
{
    public partial class FormBatchSend : Form
    {
        private ZUARTControl.ZuartControl zuartControl = null;
        private string IniPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Zip", "BatchSend.ini");
        public FormBatchSend(ZUARTControl.ZuartControl zuartControl)
        {
            this.zuartControl = zuartControl;
            InitializeComponent();
            init();

            IniFile ini = new IniFile(IniPath);
            for (int i = 1; i > 0; i++) //死循环
            {
                string str = ini.Read(i.ToString(), "BATCHSEND");
                if (str != null)
                    ImportOneStr(i + "=" + str);
                else
                    break;
            }

        }


        int addItem(BatchSendItem item)
        {
            return addItem(item, true, this.dataGridView1.Rows.Add());
        }
        int addItem(BatchSendItem item, int index)
        {
            return addItem(item, true, index);
        }
        int addItem(BatchSendItem item, bool isCheck, int index)
        {
            if (item == null) return -1;
            if (index >= dataGridView1.Rows.Count) return -1;
            if (index < 0) index = this.dataGridView1.Rows.Add();


            this.dataGridView1.Rows[index].Tag = item;
            this.dataGridView1.Rows[index].Cells[0].Value = isCheck;

            //this.dataGridView1.Rows[index].Cells[1].Value = index.ToString();
            this.dataGridView1.Rows[index].Cells[1].Value = item.delay.ToString();
            //this.dataGridView1.Rows[index].Cells[2].Value = item.ishex ? Resources.ico_bin : Resources.ico_ab;
            this.dataGridView1.Rows[index].Cells[2].Value = item.dat;
            this.dataGridView1.Rows[index].Cells[3].Value = String.IsNullOrWhiteSpace(item.name) ? "Send" : item.name;
            dataGridView1.ClearSelection();
            return index;
        }

        void init()
        {

        }
        private void FormBatchSend_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSave_Click(null, null);
        }


        #region 自动发送功能
        private void timerSend_Tick(object sender, EventArgs e)
        {
            BatchSendItem item;
            if (send_index > 0)
            {
                //发送数据
                if (send_index - 1 >= dataGridView1.Rows.Count)
                {//超出范围
                    startSend(false);
                    return;
                }
                item = (BatchSendItem)this.dataGridView1.Rows[send_index - 1].Tag;
                if (!zuartControl.SendStr(item.dat, item.ishex))
                {   //发送出错
                    startSend(false);
                    return;
                }
            }
            if (dataGridView1.Rows.Count <= send_index)
            {
                if (chkCycleMode.Checked)
                {
                    send_index = 0;
                }
                else
                {
                    startSend(false);
                    return;
                }
            }
            if ((bool)dataGridView1.Rows[send_index].Cells[0].EditedFormattedValue == false)
            {
                while ((bool)dataGridView1.Rows[send_index].Cells[0].EditedFormattedValue == false)
                {
                    send_index++;
                    if (dataGridView1.Rows.Count <= send_index)
                    {
                        if (chkCycleMode.Checked)
                        {
                            send_index = 0;
                        }
                        else
                        {
                            startSend(false);
                            return;
                        }
                    }
                }
            }

            dataGridView1.Rows[send_index].Selected = true;
            item = (BatchSendItem)this.dataGridView1.Rows[send_index].Tag;
            send_index++;

            if (item.delay == 0) timerSend_Tick(null, null);
            else
                timerSend.Interval = item.delay;
        }

        int send_index = 0;
        private void btnStartSend_Click(object sender, EventArgs e)
        {
            startSend(btnStartSend.Text.Contains("启动"));
        }

        void startSend(bool start)
        {
            if (start)
            {
                if (!zuartControl.IsComOpen)
                {
                    MessageBox.Show("串口未开启");
                    return;
                }
                //dataGridView1.ClearSelection();
                if (dataGridView1.Rows.Count < 1) return;
                btnStartSend.Text = "停止批量发送";
                send_index = 0;
                timerSend_Tick(null, null);
                //timerSend.Interval = 1;
                timerSend.Enabled = true;
                btnStartSend.Image = Resources.open;
            }
            else
            {
                timerSend.Enabled = false;
                btnStartSend.Text = "启动批量发送";
                dataGridView1.ClearSelection();
                btnStartSend.Image = Resources.close;
            }
        }

        #endregion
        #region dataGridView外观/功能
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = this.dataGridView1.CurrentRow.Index;//获取当前选中行的索引

            if (e.ColumnIndex != 3) return;

            BatchSendItem item = (BatchSendItem)this.dataGridView1.Rows[e.RowIndex].Tag;

            zuartControl.SendStr(item.dat, item.ishex);

        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            BatchSendItem item = (BatchSendItem)this.dataGridView1.SelectedRows[0].Tag;

            zuartControl.SendStr(item.dat, item.ishex);
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X + 8, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle,
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);


            int x = e.RowBounds.Location.X + 4 + dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width;
            int y = e.RowBounds.Location.Y + (e.RowBounds.Height - Resources.ico_bin.Height) / 2;
            rectangle = new Rectangle(x, y,
                 Resources.ico_bin.Width, Resources.ico_bin.Height);


            BatchSendItem item = (BatchSendItem)this.dataGridView1.Rows[e.RowIndex].Tag;
            e.Graphics.DrawImage(item.ishex ? Resources.ico_bin : Resources.ico_ab, rectangle);
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;

            }
        }

        private int GetRowIndexAt(int mouseLocation_Y)
        {
            if (dataGridView1.FirstDisplayedScrollingRowIndex < 0)
            {
                return -1;
            }
            if (dataGridView1.ColumnHeadersVisible == true && mouseLocation_Y <= dataGridView1.ColumnHeadersHeight)
            {
                return -1;
            }
            int index = dataGridView1.FirstDisplayedScrollingRowIndex;
            int displayedCount = dataGridView1.DisplayedRowCount(true);
            for (int k = 1; k <= displayedCount;)
            {
                if (dataGridView1.Rows[index].Visible == true)
                {
                    Rectangle rect = dataGridView1.GetRowDisplayRectangle(index, true);  // 取该区域的显示部分区域   
                    if (rect.Top <= mouseLocation_Y && mouseLocation_Y < rect.Bottom)
                    {
                        return index;
                    }
                    k++;
                }
                index++;
            }
            return -1;
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetRowIndexAt(e.Y) == -1)
            {
                dataGridView1.ClearSelection();
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEdit_Click(null, null);
        }
        #endregion

        #region 接收拖入的配置文件
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length < 1) return;
            ImportFile(files[0]);

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
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
        #endregion
        #region 导入/导出批量发送
        void ImportOneStr(string str)
        {
            Regex regex = new Regex(@"^(\d+)\=([01])\|(\d+)\|([01])\|(.*?)\|(.*)$");
            //搜索匹配的字符串 
            MatchCollection matches;
            try
            {
                matches = regex.Matches(str);
                if (matches.Count != 1) return;
                Match match = matches[0];
                if (match.Groups.Count != 7) return;

                bool ischeck = Convert.ToInt32(match.Groups[2].Value) == 1 ? true : false;
                int delay = Convert.ToInt32(match.Groups[3].Value);
                bool ishex = Convert.ToInt32(match.Groups[4].Value) == 1 ? true : false;
                string name = match.Groups[5].Value;
                string dat = match.Groups[6].Value.Replace("\u0003", "\r").Replace("\u0002", "\n");


                //byte[] gb = Encoding.GetEncoding("gbk").GetBytes(name);       //导入编码确认
                //gb = Encoding.Convert(Encoding.GetEncoding("gbk"), Encoding.UTF8, gb);
                //name = Encoding.UTF8.GetString(gb);
                addItem(new BatchSendItem(delay, ishex, dat, name));
            }
            catch (Exception ex)
            {

            }
        }
        string ExportOneStr(BatchSendItem item, bool ischeck)
        {
            string context = "";
            context = context + (ischeck ? "1" : "0") + "|";
            context = context + item.delay + "|";
            context = context + (item.ishex ? "1" : "0") + "|";
            context = context + item.name + "|";
            context = context + item.dat.Replace("\r", "\u0003").Replace("\n", "\u0002");
            return context;
        }
        void ExportFile(string file)
        {
            string context = "[BATCHSEND]\r\n";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                BatchSendItem item = (BatchSendItem)dataGridView1.Rows[i].Tag;
                bool ischeck = (bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue;
                context = context + (i + 1).ToString() + "=" + ExportOneStr(item, ischeck) + "\r\n";
            }

            FileStream fs = new FileStream(file, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(context);
            sw.Close();
            fs.Close();
        }
        void ImportFile(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string str;
                int i = 0;
                do
                {
                    str = r.ReadLine();
                    Console.WriteLine(str);
                    ImportOneStr(str);
                }
                while (str != null);

            }
        }

        #endregion

        #region 新增/删除/上下移动/导入导出/保存及右键菜单等功能
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddBatchSendItem form = new FormAddBatchSendItem(-1);
            form.TopLevel = false; //指示子窗体非顶级窗体

            form.FormBorderStyle = FormBorderStyle.None;

            form.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;

            form.Left = 0;
            form.Width = dataGridView1.Width;
            form.Top = this.Height - 200;
            form.Height = 200;
            this.Controls.Add(form);
            form.Show();
            form.BringToFront();
            form.ReturnBatchSendItem += Add_BatchSendItem_Return;
        }

        private void Add_BatchSendItem_Return(object sender, FormAddBatchSendItem.AddBatchSendItem_EventArgs e)
        {
            addItem(e.Item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }

            FormAddBatchSendItem form = new FormAddBatchSendItem((BatchSendItem)dataGridView1.SelectedRows[0].Tag, dataGridView1.SelectedRows[0].Index);
            form.TopLevel = false; //指示子窗体非顶级窗体
            form.FormBorderStyle = FormBorderStyle.None;
            form.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
            form.Left = 0;
            form.Width = dataGridView1.Width;
            form.Top = this.Height - 200;
            form.Height = 200;
            this.Controls.Add(form);
            form.Show();
            form.BringToFront();
            form.ReturnBatchSendItem += Edit_BatchSendItem_Return;
        }
        private void Edit_BatchSendItem_Return(object sender, FormAddBatchSendItem.AddBatchSendItem_EventArgs e)
        {
            bool isselect = true;
            if (e.Index > 0 && e.Index < dataGridView1.Rows.Count)
            {
                isselect = (bool)dataGridView1.Rows[e.Index].Cells[0].EditedFormattedValue;
            }
            addItem(e.Item, isselect, e.Index);
            if (e.Index > 0 && e.Index < dataGridView1.Rows.Count)
            {
                this.dataGridView1.Rows[e.Index].Selected = true;
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("没有选择删除对象", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //让用户选择点击
            DialogResult result = MessageBox.Show("确定删除选中的1条记录?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
        #region 上下移动功能

        void dataGridView_exchange(int index1, int index2)
        {
            if (index1 < 0) return;
            if (index2 < 0) return;
            if (index1 >= dataGridView1.Rows.Count) return;
            if (index2 >= dataGridView1.Rows.Count) return;

            bool isselect1 = (bool)dataGridView1.Rows[index1].Cells[0].EditedFormattedValue;
            bool isselect2 = (bool)dataGridView1.Rows[index2].Cells[0].EditedFormattedValue;

            BatchSendItem item1 = (BatchSendItem)dataGridView1.Rows[index1].Tag;
            BatchSendItem item2 = (BatchSendItem)dataGridView1.Rows[index2].Tag;
            addItem(item1, isselect1, index2);
            addItem(item2, isselect2, index1);

            this.dataGridView1.Rows[index2].Selected = true;
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            dataGridView_exchange(index, index - 1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            dataGridView_exchange(index, index + 1);
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            //让用户选择点击
            DialogResult result = MessageBox.Show("确定清空所有数据?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
            }

        }

        //导入
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;

                ImportFile(file);
            }
        }
        //导出
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出";
            //saveFileDialog.InitialDirectory = App.ExportChartPath;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "cfg";
            saveFileDialog.Filter = "Config file|*.cfg|所有文件|*.*";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return; //被点了取消
            }
            var filename = saveFileDialog.FileName; //得到保存路径及文件名
            //MessageBox.Show(filename);
            ExportFile(filename);

        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            string context = "[BATCHSEND]\r\n";
            IniFile ini = new IniFile(IniPath);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                BatchSendItem item = (BatchSendItem)dataGridView1.Rows[i].Tag;
                bool ischeck = (bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue;
                ini.Write((i + 1).ToString(), ExportOneStr(item, ischeck), "BATCHSEND");
            }
        }
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            bool isSelect = (dataGridView1.SelectedRows.Count > 0);

            修改ToolStripMenuItem.Enabled = isSelect;
            删除ToolStripMenuItem.Enabled = isSelect;
            上移ToolStripMenuItem.Enabled = isSelect;
            下移ToolStripMenuItem.Enabled = isSelect;

        }

        #endregion


    }
}
