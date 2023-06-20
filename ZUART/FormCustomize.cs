using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuartControl;

namespace ZUART
{
    public partial class FormCustomize : Form
    {
        //请定义宏CUSTOM_PARSING 启用此页面

        private ZuartControl.ZuartControl zuartControl1 = null;
        public FormCustomize()
        {
            InitializeComponent();
        }
        public FormCustomize(ZuartControl.ZuartControl zuartControl)
        {
            this.zuartControl1 = zuartControl;
            InitializeComponent();
            if (zuartControl1 != null)
                zuartControl1.ComDataReceivedProperties += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataReceived);

        }

        private void zuartControl1_ComDataReceived(object sender, ZuartControl.ZuartControl.ComData_EventArgs e)
        {
            byte[] data = e.data;
            string str = e.recived_string;
            
        }
    }
}
