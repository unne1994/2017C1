using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_2024Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = oo();
            dataGridView1.DataSource = list;

        }

        private List<contect> oo()
        {

            string filename = "Hw_88.csv";
            char[] splits = new char[] { ',' };
            List<contect> result = new List<contect>();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] item = lines[i].Split(splits);

                    var con = new contect
                    {
                        na = item[0],
                        adress = item[1],
                        tel = int.Parse(item[2])
                    };
                    result.Add(con);
                }

            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkconnect();
        }
        private void checkconnect()
        {
            string check = textBox1.Text;
            string filename = "Hw_88.csv";
            char[] splits = new char[] { ',' };
            List<contect> result = new List<contect>();
            if (File.Exists(filename))
            {
                string[] line = File.ReadAllLines(filename);

                for (int i = 1; i < line.Count(); i++)
                {
                    string[] item = line[i].Split(splits);

                    if (item[0] == check || item[1] == check || item[2] == check)
                    {
                        MessageBox.Show("姓名" + item[0] + "地址" + item[1] + "電話" + item[2]);

                    }

                }
            }
        }
    }
}
