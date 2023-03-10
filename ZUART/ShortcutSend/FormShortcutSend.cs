using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZUART.ShortcutSend;
using ZUART.Properties;

namespace ZUART
{
    public partial class FormShortcutSend : Form
    {
        private ZUARTControl.ZuartControl zuartControl = null;
        private string IniPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Zip", "ShortcutSend.ini");
        public FormShortcutSend(ZUARTControl.ZuartControl zuartControl)
        {
            this.zuartControl = zuartControl;
            InitializeComponent();

            ImportFile(IniPath);
        }

        #region 列表增加一项
        int addItem(ShortcutSendItem item)
        {
            return addItem(item, this.dataGridView1.Rows.Add());
        }
        int addItem(ShortcutSendItem item, int index)
        {
            if (item == null) return -1;
            if (index >= dataGridView1.Rows.Count) return -1;
            if (index < 0) index = this.dataGridView1.Rows.Add();

            this.dataGridView1.Rows[index].Tag = item;
            this.dataGridView1.Rows[index].Cells[0].Value = item.name;
            this.dataGridView1.Rows[index].Cells[1].Value = item.dat;
            this.dataGridView1.Rows[index].Cells[2].Value = "发送";
            dataGridView1.ClearSelection();
            return index;
        }

        #endregion
        #region 退出前保存
        private void FormShortcutSend_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSave_Click(null, null);
        }
        #endregion


        #region dataGridView外观/功能
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = this.dataGridView1.CurrentRow.Index;//获取当前选中行的索引

            if (e.ColumnIndex == 2)
            {
                ShortcutSendItem item = (ShortcutSendItem)this.dataGridView1.Rows[e.RowIndex].Tag;
                zuartControl.SendStr(item.dat, item.ishex);
            }


        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' || dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            ShortcutSendItem item = (ShortcutSendItem)this.dataGridView1.SelectedRows[0].Tag;
            zuartControl.SendStr(item.dat, item.ishex);
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Rectangle rectangle = new Rectangle(e.RowBounds.Location.X + 8, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            //TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle,
            //dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);


            int x = e.RowBounds.Location.X + 4;
            int y = e.RowBounds.Location.Y + (e.RowBounds.Height - Resources.ico_bin.Height) / 2;
            Rectangle rectangle = new Rectangle(x, y,
                 Resources.ico_bin.Width, Resources.ico_bin.Height);


            ShortcutSendItem item = (ShortcutSendItem)this.dataGridView1.Rows[e.RowIndex].Tag;
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
            if (e.Button != MouseButtons.Left) return;
            if (e.ColumnIndex == 2)
            {
                ShortcutSendItem item = (ShortcutSendItem)this.dataGridView1.Rows[e.RowIndex].Tag;
                zuartControl.SendStr(item.dat, item.ishex);
                return;
            }
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
        void ExportFile(string file)
        {
            IniFile ini = new IniFile(file);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ShortcutSendItem item = (ShortcutSendItem)dataGridView1.Rows[i].Tag;
                ini.Write(item.name, item.getSerializeStr(i+1), "SHORTCUT");
            }
        }
        void ImportFile(string file)
        {
            IniFile ini = new IniFile(file);


            string[] sections=ini.ReadSectionAll("SHORTCUT");

            foreach(string s in sections)
            {
                ShortcutSendItem item = ShortcutSendItem.ShortcutSendItemFromOneStr(s);
                if (item != null) addItem(item);
            }
        }

        #endregion

        #region 新增/删除/上下移动/导入导出/保存及右键菜单等功能
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddShortcutSendItem form = new FormAddShortcutSendItem(-1);
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
            form.ReturnShortcutSendItem += Add_ShortcutSendItem_Return;
        }

        private void Add_ShortcutSendItem_Return(object sender, FormAddShortcutSendItem.AddShortcutSendItem_EventArgs e)
        {
            addItem(e.Item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }

            FormAddShortcutSendItem form = new FormAddShortcutSendItem((ShortcutSendItem)dataGridView1.SelectedRows[0].Tag, dataGridView1.SelectedRows[0].Index);
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
            form.ReturnShortcutSendItem += Edit_ShortcutSendItem_Return;
        }
        private void Edit_ShortcutSendItem_Return(object sender, FormAddShortcutSendItem.AddShortcutSendItem_EventArgs e)
        {

            addItem(e.Item, e.Index);
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



            ShortcutSendItem item1 = (ShortcutSendItem)dataGridView1.Rows[index1].Tag;
            ShortcutSendItem item2 = (ShortcutSendItem)dataGridView1.Rows[index2].Tag;
            addItem(item1, index2);
            addItem(item2, index1);

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
            ExportFile(filename);

        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            ExportFile(IniPath);
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
