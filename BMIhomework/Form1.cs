using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIhomework
{
    public partial class Form1 : Form
    {
        private BMICalculation _data;
        public Form1()
        {
            
            InitializeComponent();
            _data = new BMICalculation(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _data.x = double.Parse(textBox1.Text);
            _data.y = double.Parse(textBox2.Text);

            double z = _data.add();

            if (z < 18.5)
            {
               MessageBox.Show("BMI:"+_data.add().ToString("#0.0") + "\n" + "評語:過瘦");
            }
            if (z >= 18.5 && z < 24)
            {
                MessageBox.Show("BMI:" + _data.add().ToString("#0.0") + "\n" + "評語:正常範圍");
              
            }
            if (z >= 24 && z < 27)
            {
                MessageBox.Show("BMI:" + _data.add().ToString("#0.0") + "\n" + "評語:過重");
           
            }
            if (z >= 27 && z < 30)
            {
                MessageBox.Show("BMI:" + _data.add().ToString("#0.0") + "\n" + "評語:輕度肥胖");
          
            }
            if (z >= 30 && z < 35)
            {
                MessageBox.Show("BMI:" + _data.add().ToString("#0.0") + "\n"+ "評語:中度肥胖");
              
            }
            if (z > 35)
            {
                MessageBox.Show("BMI:" + _data.add().ToString("#0.0") +"\n"+"重度肥胖");
                
            }

        }

    }
}
