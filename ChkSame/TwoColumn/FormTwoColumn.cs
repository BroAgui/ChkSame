using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoColumn
{
    public partial class FormTwoColumn : Form
    {
        public FormTwoColumn()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] tx1 = checkBoxComp1.Checked ? textBox2.Lines : textBox1.Lines;
            string[] tx2 = checkBoxComp1.Checked ? textBox1.Lines : textBox2.Lines;
            StringBuilder sb = new StringBuilder();
            foreach (var item in tx2)
            {
                if (tx1.Contains(item) != checkBoxMore.Checked)
                {
                    sb.Append(item + Environment.NewLine);
                }
            }
            textBoxResult.Text = sb.ToString();
        }
    }
}
