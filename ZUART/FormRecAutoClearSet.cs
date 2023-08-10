using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ZUART
{
    public partial class FormRecAutoClearSet : Form
    {

        public FormRecAutoClearSet()
        {
            InitializeComponent();
            autoClearSet = null;
        }
        public FormRecAutoClearSet(AutoClearSet _autoClearSet)
        {
            InitializeComponent();
            autoClearSet = null;

            if (_autoClearSet != null)
            {
                radioButton1.Checked = _autoClearSet.mod == AutoClearSet.MOD.StrCount;
                radioButton2.Checked = _autoClearSet.mod == AutoClearSet.MOD.Timer;

                radioButton_CheckedChanged(null, null);
                if (numericUpDown1.Enabled) numericUpDown1.Value = _autoClearSet.val;
                if (numericUpDown2.Enabled) numericUpDown2.Value = _autoClearSet.val;
            }
        }
        public AutoClearSet autoClearSet=null;
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = radioButton1.Checked;
            numericUpDown2.Enabled = radioButton2.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            autoClearSet = new AutoClearSet();
            if(radioButton1.Checked)
            {
                autoClearSet.mod = AutoClearSet.MOD.StrCount;
                autoClearSet.val = (int)numericUpDown1.Value;
            }
            else if (radioButton2.Checked)
            {
                autoClearSet.mod = AutoClearSet.MOD.Timer;
                autoClearSet.val = (int)numericUpDown2.Value;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            autoClearSet = null;
            this.Close();
        }
    }
}
