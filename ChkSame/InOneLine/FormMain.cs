using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InOneLine
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in textBox1.Lines)
            {
                string[] line = str.Split('\t');
                if (line.Length > 1)
                {
                    bool same = true;
                    for (int i = 1; i < line.Length; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (line[j].Trim() != line[i].Trim())
                            {
                                same = false;
                                break;
                            }
                        }
                        if (!same)
                        {
                            break;
                        }
                    }
                    if (same != checkBoxDef.Checked)
                    {
                        sb.Append(str + Environment.NewLine);
                    }
                }
            }
            textBox2.Text = sb.ToString(); ;
        }
    }
}
