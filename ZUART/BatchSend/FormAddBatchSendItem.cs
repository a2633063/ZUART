using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZUART.BatchSend
{
    public partial class FormAddBatchSendItem : Form
    {
        private static FormAddBatchSendItem staticForm = null;
        private int index = -1;
        public FormAddBatchSendItem(int index)
        {
            if (!(staticForm == null || staticForm.IsDisposed))
            {
                staticForm.Close();
            }

            staticForm = this;
            InitializeComponent();
            this.index = index;
        }
        public FormAddBatchSendItem(BatchSendItem item, int index)
        {

            if (!(staticForm == null || staticForm.IsDisposed))
            {
                staticForm.Close();
            }

            InitializeComponent();
            if (item == null)
            {
                this.Close();
                return;
            }
            staticForm = this;
            this.index = index;

            txtDat.Text = item.dat;
            txtDelay.Text = item.delay.ToString();
            txtName.Text = item.name;
            if (item.ishex) rbtnHEX.Checked = true;
            else rbtnASCII.Checked = true;

        }

        #region 串口开关事件回调
        public class AddBatchSendItem_EventArgs : EventArgs
        {
            public BatchSendItem Item { get; set; }
            public int Index { get; set; }
        }
        protected EventHandler<AddBatchSendItem_EventArgs> onBatchSendItem;
        [Category("自定义事件"), Description("新增完成时调用,返回BatchSendItem"), Browsable(true)]
        public event EventHandler<AddBatchSendItem_EventArgs> ReturnBatchSendItem
        {
            add
            {
                if (onBatchSendItem != null)
                {
                    foreach (Delegate d in onBatchSendItem.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                onBatchSendItem = (EventHandler<AddBatchSendItem_EventArgs>)Delegate.Combine(onBatchSendItem, value);
            }
            remove
            {
                onBatchSendItem = (EventHandler<AddBatchSendItem_EventArgs>)Delegate.Remove(onBatchSendItem, value);
            }

        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDat.Text.Length < 1)
            {
                MessageBox.Show("数据内容为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbtnHEX.Checked)
            {
                try
                {
                    byte[] b = Function.ToByteFromHexStr(txtDat.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("十六进制数据字符包含非法字符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            try
            {
                int delay = Convert.ToInt32(txtDelay.Text);
                BatchSendItem item = new BatchSendItem(delay, rbtnHEX.Checked, txtDat.Text, txtName.Text);


                AddBatchSendItem_EventArgs addBatchSendItem_EventArgs = new AddBatchSendItem_EventArgs();
                addBatchSendItem_EventArgs.Item = item;
                addBatchSendItem_EventArgs.Index = this.index;
                if (onBatchSendItem != null) onBatchSendItem(this, addBatchSendItem_EventArgs);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("无效的延时参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }




        }
    }
}
