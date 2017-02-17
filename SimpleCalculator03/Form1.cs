using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          //  int a = 1;
            OOO(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        //    int b = 2;
            OOO(2);
        }

        private void OOO(int i)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            switch (i)
            { 
            case 1:
                    label1.Text = (x + y).ToString();

                    break;
            case 2:
                    label1.Text = (x - y).ToString();

                    break;
            }
        }
    }
}
