using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class FormCalculatrice : Form
    {
        public FormCalculatrice()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
               textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String equation = textBox1.Text;
            var result = new DataTable().Compute(equation, null);
            textBox1.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
