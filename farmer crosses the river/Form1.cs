using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmer_crosses_the_river
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;

        public Form1()
        {
            InitializeComponent(); //呼叫方法
            CreateList();//呼叫方法
            SetListBoxDataSource();//呼叫方法
            changeData();//呼叫方法
        }

        private void CreateList()
        {
            _leftList = new List<string> { "農夫", "羊", "狼", "菜" }; //初始化給abcd值
            _rightList = new List<string>(); //初始化


        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;//(單)複選  屬性裡有SelectionMode可調 
            listBox2.SelectionMode = SelectionMode.MultiSimple;

        }

        private void changeData()  //把 _lifeList 和 _rightList 值給到 listBox裡
        {
            listBox1.DataSource = null;  //清空
            listBox2.DataSource = null; //清空

            listBox1.DataSource = _leftList; //_lifeList值給到 listBox裡
            listBox2.DataSource = _rightList;// _rightList 值給到 listBox裡

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //先拉 labl1物件在使用
            // label1.Text = listBox1.SelectedIndex.ToString();  //a位置0 b位置1 ...  //測試用
            //label1.Text = listBox1.Text;  //直接顯示選取值  //測試用
            //label1.Text = listBox1.Items.Count.ToString();  //算出目前有多少項目     //測試用
            //label1.Text = listBox1.SelectedIndices.Count.ToString(); //選取多少項目 //測試用
            /*    foreach (string _listbox in listBox1.SelectedItems)  //顯示選取(複數)的數字    //測試用
                {
                    MessageBox.Show(_listbox);
                }*/

            int yesno = 0;// 判斷是否有農夫預設(無)=0  (有)=1

            if (listBox1.SelectedItem != null) //如果左邊選到不等於空值=如果左邊有選到東西 
            {

                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--) //listBox1.SelectedItems.Count 表示listBox1選取項目的數目  -1表示 EX:選三個跑兩次即可
                {

                    string name = ((string)listBox1.SelectedItems[i]); // name 存 listBox1.SelectedItems[0] ->name 存 listBox1.SelectedItems[1]....

                    if (name == "農夫")  //假如name有農夫的內容  yesno 就=1
                    {
                        yesno = 1;
                    }

                }
            }

            if (yesno == 1)   //有讀取到內容有農夫即進入

            {
                if (listBox1.SelectedItem != null) //如果左邊選到不等於空值=如果左邊有選到東西 
                {
                    if (listBox1.SelectedItems.Count < 3) //限制listbox1選取項目的個數
                    {
                        for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)//listBox1.SelectedItems.Count 表示listBox1選取項目的數目  -1表示 EX:選三個跑兩次即可
                        {
                            _leftList.Remove((string)listBox1.SelectedItems[i]); // 選重的第一個從 listBox1.SelectedItems[0]開始->listBox1.SelectedItems[i].... 依序刪除 _leftList內容

                            _rightList.Add((string)listBox1.SelectedItems[i]);// 選重的第一個從 listBox1.SelectedItems[0]開始->listBox1.SelectedItems[i].... 依序增加_rightList內容



                        }
                        //↓判斷 選取是否包含農夫 和 左邊內容狼跟羊是否再一起 或者 左邊的羊跟菜是否再一起
                        if (_leftList.Contains("農夫") == false && _leftList.Contains("狼") && _leftList.Contains("羊") || _leftList.Contains("農夫") == false && _leftList.Contains("羊") && _leftList.Contains("菜"))
                        {

                            MessageBox.Show("左GGGG"); //顯示 輸了
                        }
                    }
                }
                changeData(); //呼叫方法 


            }
            else //yesno == 0  代表沒有選擇農夫
            {

                MessageBox.Show("缺少農夫");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yesnoo = 0;

            if (listBox2.SelectedItem != null) //如果左邊選到不等於空值=如果左邊有選到東西 
            {
                if (listBox2.SelectedItems.Count < 3)
                {
                    for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
                    {

                        string name = ((string)listBox2.SelectedItems[i]);

                        if (name == "農夫")
                        {
                            yesnoo = 1;
                        }

                    }
                }
            }

            if (yesnoo == 1)

            {




                if (listBox2.SelectedItem != null) //如果左邊選到不等於空值=如果左邊有選到東西 
                {



                    for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--) //選取幾個就跑-1幾次
                    {
                        _rightList.Remove((string)listBox2.SelectedItems[i]);

                        _leftList.Add((string)listBox2.SelectedItems[i]);

                    }
                }
                changeData();

            }
            else
            {

                MessageBox.Show("缺少農夫");


            }
            if (_rightList.Contains("農夫") == false && _rightList.Contains("狼") && _rightList.Contains("羊") || _rightList.Contains("農夫") == false && _rightList.Contains("羊") && _rightList.Contains("菜"))
            {
                MessageBox.Show("右GGGG");
            }
        }
    }
}
