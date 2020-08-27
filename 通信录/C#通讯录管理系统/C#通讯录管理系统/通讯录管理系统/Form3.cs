using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 通讯录管理系统
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null&&textBox1.Text.Length<6)
            {
                if (textBox2.Text == textBox3.Text && textBox2.Text.Length >=6)
                {
                    string yhm = textBox1.Text;
                    string mm = textBox2.Text;
                    string s = @"Insert into 用户登录表 (姓名,密码) values('" + yhm + "','" + mm + "')";
                    OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D5.accdb");
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand(s, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");
                    conn.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();

                }
                else
                {
                    DialogResult res=MessageBox.Show("二次密码要一样且密码不能小于六个字符！", "输入提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("用户名不能为空且不超过六个字符！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
