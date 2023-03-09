using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUART.Properties
{
    public partial class FormASCII : Form
    {
        public FormASCII()
        {
            InitializeComponent();

            string[] str = {
                "<SOH>",    //1
                "<STX>",    //2
                "<ETX>",    //3
                "<EOT>",    //4
                "<ENQ>",    //5
                "<ACK>",    //6
                "<BEL> \\a",    //7
                "<BS> \\b",    //8
                "<HT> \\t",    //9
                "<LF> \\n",    //10
                "<VT> \\v",    //11
                "<FF> \\f",    //12
                "<CR> \\r",    //13
                "",    //14
                "",    //15
                "",    //16
                "",    //17
                "",    //18
                "",    //19
                "",    //20
                "",    //21
                "",    //22
                "",    //23
                "",    //24
                "",    //25
                "",    //26
                "<ESCAPE>",    //27
                "<FS>",    //28
                "<GS>",    //29
                "<RS>",    //30
                "<US>",    //31
                "<SPACE>",    //32
            };
            for(int i=1;i<256;i++)
            {
                int index=dataGridView1.Rows.Add();

                if(i<33)
                    this.dataGridView1.Rows[index].Cells[0].Value = str[i-1];
                else if(i>126)
                    this.dataGridView1.Rows[index].Cells[0].Value = "";
                else
                this.dataGridView1.Rows[index].Cells[0].Value = new UTF8Encoding().GetString(new byte[] { (byte)i });
                this.dataGridView1.Rows[index].Cells[1].Value = i.ToString();
                this.dataGridView1.Rows[index].Cells[2].Value = "0x"+i.ToString("X02");
            }
        }
    }
}
