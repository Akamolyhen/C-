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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D5.accdb";
            OleDbConnection conn = new OleDbConnection(s1);
            conn.Open();
            string s2 = @"Select * From 用户登录表 where 姓名='" + textBox1.Text + "'";
            OleDbCommand comm = new OleDbCommand(s2, conn);
            OleDbDataReader re = comm.ExecuteReader();
            if (!re.Read())
            {
                MessageBox.Show("登录名不存在！");
                return;
            }
            if (textBox2.Text == re["密码"].ToString())
            {
                MessageBox.Show("登录成功！");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码不正确!");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
