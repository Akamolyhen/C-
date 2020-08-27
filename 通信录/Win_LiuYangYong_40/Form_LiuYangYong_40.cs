using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace Win_LiuYangYong_40
{
    public partial class Form_LiuYangYong_40 : Form
    {
        public Form_LiuYangYong_40()
        {
            InitializeComponent();
        }        
        ClassAttribute per = new ClassAttribute();        
        public void GetInput()
        {
            //赋值
            per.Number = textBoxNumber.Text.Trim();
            per.Name = textBoxName.Text.Trim();
            per.Phone = textBoxPhone.Text.Trim();
            per.Address = textBoxAddress.Text.Trim();
        }      
        private void Form_LiuYangYong_40_Load(object sender, EventArgs e)
        {
            //向ListBox中写入信息
            RefreshInfo();
            //添加标题
            if (listBoxInfo.Items.Count == 0)
            {
                //string sList = "学号" + "\t\t" + "姓名" + "\t\t" + "联系电话" + "\t\t" + "联系地址";
                string sList = "学号".PadRight(16) + "姓名".PadRight(16) + "联系电话".PadRight(14) + "联系地址";
                this.listBoxInfo.Items.Add(sList);
                AddTxt(sList);
            }
            this.buttonSave.Enabled = false;
            this.buttonUptadeOk.Enabled = false;     
        }      
        private void buttonOperate(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "增加":
                    Add();
                    break;
                case "修改":
                    Update();
                    break;
                case "删除":
                    Delete();
                    break;
                case "保存":
                    Save();
                    break;
                case "确认修改":
                    UpdateOk();
                    break;
                case "刷新":
                    RefreshInfo();
                    break;
                case "查找":
                    Seaech();
                    break;
            }
        }
        public void Add()
        {
            this.buttonSave.Enabled = true;
            this.buttonUptadeOk.Enabled = false;
            this.textBoxNumber.Enabled = true;
            this.textBoxNumber.Clear();
            this.textBoxName.Clear();
            this.textBoxPhone.Clear();
            this.textBoxAddress.Clear();   
        } 
        public void Update()
        {
            this.buttonSave.Enabled = false;
            this.buttonUptadeOk.Enabled = true;
            this.textBoxNumber.Enabled = false;
            int i =listBoxInfo.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("请选择你要修改的行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.buttonUptadeOk.Enabled = false;
                return;
            }
            if (i == 0)
            {
                MessageBox.Show("标题不能修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.buttonUptadeOk.Enabled = false;
                return;
            }
            string str = listBoxInfo.Text;
            string[] strArr = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.textBoxNumber.Text = strArr[0].ToString();
            this.textBoxName.Text = strArr[1].ToString();
            this.textBoxPhone.Text = strArr[2].ToString();
            this.textBoxAddress.Text = strArr[3].ToString(); 
          
            //Substring()方法
        }
        public void Delete()
        {
            int i =listBoxInfo.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("请选择你要删除的行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (i == 0)
            {
                MessageBox.Show("标题不能删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string str2 = listBoxInfo.Items[i].ToString();
            DialogResult result;
            result = MessageBox.Show("确认删除以下学生信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                listBoxInfo.Items.RemoveAt(i);// Remove(str2)
                coverMyTxt();              
            }          
        }
        public void Save()
        {
            //判断输入是否有效
            if (!CheckText())
            {
                return;
            }
            //检查学号是否重复
            string path = "my.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fs);
            string re = "";
            do
            {
                if (re != "")
                {
                    string[] strArr = re.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (strArr[0].ToString() == per.Number)
                    {
                        MessageBox.Show("保存失败，查看学号是否重复", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();
                        fs.Close();
                        return;
                    }
                }
                re = reader.ReadLine();
            } while (re != null);
            reader.Close();
            fs.Close();           
            AddTxt(per.ToString());
            RefreshInfo();
            MessageBox.Show("保存成功"); 
        }
        public void UpdateOk()
        {
            //判断输入是否有效
            if (!CheckText())
            {
                return;
            }           
           List<string> Arr=new List<string>();
           foreach (object o in listBoxInfo.Items)
           {
              Arr.Add(o.ToString());
           }
            for (int i = 0; i < Arr.Count; i++)
            {
                string[] newArr = Arr[i].ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (per.Number == newArr[0])
                {
                    Arr[i] = per.ToString();
                }
            }
            DialogResult result;
            result = MessageBox.Show("确认修改吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                listBoxInfo.Items.Clear();
                foreach (string s in Arr)
                {
                    listBoxInfo.Items.Add(s);
                }
                coverMyTxt();
            }    
           

        }
        public void RefreshInfo()
        {
            string path = "my.txt";
            //StreamReader reader = File.OpenText(path);//path必须存在
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fs);
            listBoxInfo.Items.Clear();
            string re = "";
            do
            {
                if (re != "")
                {

                    listBoxInfo.Items.Add(re);
                }
                re = reader.ReadLine();
            } while (re != null);
            reader.Close();
            fs.Close();           
        }
        public void Seaech()
        {
            string select =text_No_Name.Text.Trim();
            string path = "my.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fs);
            string re = "";
            int count = 0;
            do
            {
                if (re != "")
                {
                    string[] strArr = re.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (strArr[0].ToString() == select || strArr[1].ToString() == select)
                    {
                       listBoxInfo.Text = re;
                        break;
                    }
                    count++;
                }
                re = reader.ReadLine();
            } while (re != null);
            if (count == listBoxInfo.Items.Count)
            {
                MessageBox.Show("没有查到信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            reader.Close();
            fs.Close();
        }        
        #region 写入文本文档，追加
        public void AddTxt(string ss)
        {
            string path = "my.txt";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine(ss);
            writer.Close();
        }
        #endregion     
        #region 写入文本文档，覆盖
        public void coverMyTxt()
        {
            string path = "my.txt";
            FileStream fs = new FileStream(path, FileMode.Create);//Createtext
            StreamWriter writer = new StreamWriter(fs);
            for (int i = 0; i < listBoxInfo.Items.Count; i++)
            {
                writer.WriteLine(listBoxInfo.Items[i].ToString());
            }
            writer.Close();
            fs.Close();
        }
        #endregion
        #region 判断输入是否有效
        public bool CheckText()
        {
            GetInput();
            string reNumber = @"^msd_11[0-9][0-9][0-9]$";
            string rePhone = @"^1[3|4|5|8][0-9]\d{4,8}$";
            string reAddress = @" ";
            string reName1 = @"^[\u4E00-\u9FA5]+$";//判断中文
            string reName2 = @"^[A-Za-z]+$";//判断英文
            if (!per.CheckEmpty(per.Number, per.Name, per.Phone, per.Address))
            {
                MessageBox.Show("请输入完整的信息");
                return false;
            }
            if (!per.CheckInput(reNumber, per.Number.ToString()))
            {
                MessageBox.Show("学号格式错误");
                return false;
            }
            if (!per.CheckName(reName1, reName2, per.Name.ToString()))
            {
                MessageBox.Show("姓名只能为汉字或字母");
                return false;
            }
            if (!per.CheckInput(rePhone, per.Phone.ToString()))
            {
                MessageBox.Show("电话号码格式错误");
                return false;
            }
            if (per.CheckInput(reAddress, per.Address.ToString()))
            {
                MessageBox.Show("地址不能有空格");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.button1.Text == "字体变大")
            {
                this.Font = new Font("宋体", 18);
                this.button1.Text = "字体变小";
            }
            else
            {
                this.Font = new Font("宋体", 9);
                this.button1.Text = "字体变大";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.button2.Text == "背景颜色")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.panel1.BackColor = colorDialog1.Color;
                    this.panel2.BackColor = colorDialog1.Color;
                    this.panel3.BackColor = colorDialog1.Color;
                    this.button2.Text = "默认颜色";
                }

            }
            else
            {
                this.panel1.BackColor = Color.White;
                this.panel2.BackColor = Color.White;
                this.panel3.BackColor = Color.White;
                this.button2.Text = "背景颜色";
            }
           
        }  
    }
}