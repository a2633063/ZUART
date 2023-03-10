using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZUARTControl.ZuartControl;

namespace ZUART.ShortcutSend
{
    public partial class FormAddShortcutSendItem : Form
    {
        private static FormAddShortcutSendItem staticForm = null;
        private int index = -1;
        public FormAddShortcutSendItem(int index)
        {
            if (!(staticForm == null || staticForm.IsDisposed))
            {
                staticForm.Close();
            }

            staticForm = this;
            InitializeComponent();
            this.index = index;
        }
        public FormAddShortcutSendItem(ShortcutSendItem item, int index)
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
            txtName.Text = item.name;
            if (item.ishex) rbtnHEX.Checked = true;
            else rbtnASCII.Checked = true;

        }

        #region 串口开关事件回调
        public class AddShortcutSendItem_EventArgs : EventArgs
        {
            public ShortcutSendItem Item { get; set; }
            public int Index { get; set; }
        }
        protected EventHandler<AddShortcutSendItem_EventArgs> onShortcutSendItem;
        [Category("自定义事件"), Description("新增完成时调用,返回ShortcutSendItem"), Browsable(true)]
        public event EventHandler<AddShortcutSendItem_EventArgs> ReturnShortcutSendItem
        {
            add
            {
                if (onShortcutSendItem != null)
                {
                    foreach (Delegate d in onShortcutSendItem.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                onShortcutSendItem = (EventHandler<AddShortcutSendItem_EventArgs>)Delegate.Combine(onShortcutSendItem, value);
            }
            remove
            {
                onShortcutSendItem = (EventHandler<AddShortcutSendItem_EventArgs>)Delegate.Remove(onShortcutSendItem, value);
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
                ShortcutSendItem item = new ShortcutSendItem(rbtnHEX.Checked, txtDat.Text, txtName.Text);
                AddShortcutSendItem_EventArgs addShortcutSendItem_EventArgs = new AddShortcutSendItem_EventArgs();
                addShortcutSendItem_EventArgs.Item = item;
                addShortcutSendItem_EventArgs.Index = this.index;
                if (onShortcutSendItem != null) onShortcutSendItem(this, addShortcutSendItem_EventArgs);
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
