using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SameLines
{
    public partial class FormSameLines : Form
    {
        public FormSameLines()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Lines.Length < 2)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            if (!checkBoxFindSame.Checked)
            {
                sb.Append(textBox1.Lines[0].Trim() + Environment.NewLine);
            }
            string[] txin = textBox1.Lines;
            for (int i = 1; i < txin.Length; i++)
            {
                bool same = false;
                for (int j = 0; j < i; j++)
                {
                    same = false;
                    if (txin[i].Trim() == txin[j].Trim())
                    {
                        same = true;
                        break;
                    }
                }
                if (same == checkBoxFindSame.Checked)
                {
                    sb.Append(txin[i] + Environment.NewLine);
                }
            }
            textBox2.Text = sb.ToString();
        }
    }
}
