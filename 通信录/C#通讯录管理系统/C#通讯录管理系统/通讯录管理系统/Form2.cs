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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D5.accdb");
            string s = @"Select * From 通信录信息表";
            OleDbCommand comm = new OleDbCommand(s, conn);
            conn.Open();
            OleDbDataReader dr = comm.ExecuteReader();
            textBox11.Text = "序号\t姓名\t性别\t生日\t\t电话\t\t邮箱\t\t地址\n";
            while (dr.Read())
            {
                textBox11.AppendText(dr[0] + "\t");
                textBox11.AppendText(dr["姓名"] + "\t");
                textBox11.AppendText(dr["性别"] + "\t");
                textBox11.AppendText(dr["生日"] + "\t");
                textBox11.AppendText(dr["电话"] + "\t");
                textBox11.AppendText(dr["邮箱"] + "\t");
                textBox11.AppendText(dr["地址"] + "\t");
                textBox11.AppendText("\n");
            }
            conn.Close();
        }
           
     private void button2_Click(object sender, EventArgs e)
     {
         textBox11.Clear();
     }

     private void button5_Click(object sender, EventArgs e)
     {
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D5.accdb");
         string s = @"Select * From 通信录信息表";
         OleDbCommand comm = new OleDbCommand(s, conn);
         conn.Open();
         OleDbDataReader dr = comm.ExecuteReader();
         textBox12.Text = "序号\t姓名\t性别\t生日\t\t电话\t\t邮箱\t\t地址\n";
         while (dr.Read())
         {
             textBox12.AppendText(dr[0] + "\t");
             textBox12.AppendText(dr["姓名"] + "\t");
             textBox12.AppendText(dr["性别"] + "\t");
             textBox12.AppendText(dr["生日"] + "\t");
             textBox12.AppendText(dr["电话"] + "\t");
             textBox12.AppendText(dr["邮箱"] + "\t");
             textBox12.AppendText(dr["地址"] + "\t");
             textBox12.AppendText("\n");
         }
         conn.Close();
     }

     private void button3_Click(object sender, EventArgs e)
     {
         string xm = textBox1.Text;
         string xb = comboBox1.Text;
         if (comboBox1.Text == "男")
             xb = "男";
         if (comboBox1.Text == "女")
             xb = "女";
         string dh = textBox2.Text;
         string shr = dateTimePicker1.Text;
         string yx = textBox3.Text;
         string dzh = textBox4.Text;
         string s = @"Insert into 通信录信息表(姓名,性别,生日,电话,邮箱,地址) values('"+xm+"','"+xb+"','"+shr+"','"+dh+"','"+yx+"','"+dzh+"')";
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D5.accdb");
         OleDbCommand comm = new OleDbCommand(s,conn);
         conn.Open();
         comm.ExecuteNonQuery();
         MessageBox.Show("插入成功，请刷新查看");
         conn.Close();
     }

     private void button6_Click(object sender, EventArgs e)
     {
         string xm = textBox5.Text;
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D5.accdb");
         string s = @"Select * From 通信录信息表 where 姓名='" + xm + "'";
         conn.Open();
         OleDbCommand comm = conn.CreateCommand();
         comm.CommandText = s;
         OleDbDataReader dr = comm.ExecuteReader();
         if (!dr.Read())
         {
             MessageBox.Show("姓名为" + xm + "的学生在数据库中不存在！");
             return;
         }
         else
         {
             textBox13.Text = "序号\t姓名\t性别\t生日\t\t电话\t\t邮箱\t\t地址\n";
             textBox13.AppendText(dr[0] + "\t");
             textBox13.AppendText(dr["姓名"] + "\t");
             textBox13.AppendText(dr["性别"] + "\t");
             textBox13.AppendText(dr["生日"] + "\t");
             textBox13.AppendText(dr["电话"] + "\t");
             textBox13.AppendText(dr["邮箱"] + "\t");
             textBox13.AppendText(dr["地址"] + "\t");
             textBox13.AppendText("\n");
         }
         conn.Close();
     }

     private void button7_Click(object sender, EventArgs e)
     {
         textBox5.Clear();
     }

     private void button9_Click(object sender, EventArgs e)
     {
         string xm = textBox6.Text;
         string xb = comboBox2.Text;
         if (comboBox2.Text == "男")
             xb = "男";
         if (comboBox2.Text == "女")
             xb = "女";
         string dh = textBox8.Text;
         string shr = dateTimePicker2.Text;
         string yx = textBox9.Text;
         string dzh = textBox10.Text;
         string sqlString = @"Update 通信录信息表 set 性别='"+xb+"',电话='"+dh+"',生日='"+shr+"',邮箱='"+yx+"',地址='"+dzh+"' where 姓名='"+xm+"'";
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D5.accdb");
         OleDbCommand comm = new OleDbCommand(sqlString, conn);
         conn.Open();
         try
         {
             comm.ExecuteNonQuery();
             MessageBox.Show("姓名为" + xm + "的记录更新成功！");
         }
         catch (Exception)
         {
             MessageBox.Show("error!");
         }
         conn.Close();
     }

     private void button12_Click(object sender, EventArgs e)
     {
         string stNo = textBox7.Text;
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D5.accdb");
         string sqlString = @"Delete From 通信录信息表 where 姓名='" + stNo + "'";
         OleDbCommand comm = new OleDbCommand(sqlString, conn);
         conn.Open();
         try
         {
             comm.ExecuteNonQuery();
             MessageBox.Show("姓名为" + stNo + "的记录删除成功！");
         }
         catch (Exception ex)
         {
             MessageBox.Show("删除出错！错误原因为：\n" + ex.Message + "\n");
         }
         conn.Close();
     }

     private void button11_Click(object sender, EventArgs e)
     {
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D5.accdb");
         string s = @"Select * From 通信录信息表";
         OleDbCommand comm = new OleDbCommand(s, conn);
         conn.Open();
         OleDbDataReader dr = comm.ExecuteReader();
         textBox14.Text = "序号\t姓名\t性别\t生日\t\t电话\t\t邮箱\t\t地址\n";
         while (dr.Read())
         {
             textBox14.AppendText(dr[0] + "\t");
             textBox14.AppendText(dr["姓名"] + "\t");
             textBox14.AppendText(dr["性别"] + "\t");
             textBox14.AppendText(dr["生日"] + "\t");
             textBox14.AppendText(dr["电话"] + "\t");
             textBox14.AppendText(dr["邮箱"] + "\t");
             textBox14.AppendText(dr["地址"] + "\t");
             textBox14.AppendText("\n");
         }
         conn.Close();
     }

     private void button8_Click(object sender, EventArgs e)
     {
         OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D5.accdb");
         string s = @"Select * From 通信录信息表";
         OleDbCommand comm = new OleDbCommand(s, conn);
         conn.Open();
         OleDbDataReader dr = comm.ExecuteReader();
         textBox15.Text = "序号\t姓名\t性别\t生日\t\t电话\t\t邮箱\t\t地址\n";
         while (dr.Read())
         {
             textBox15.AppendText(dr[0] + "\t");
             textBox15.AppendText(dr["姓名"] + "\t");
             textBox15.AppendText(dr["性别"] + "\t");
             textBox15.AppendText(dr["生日"] + "\t");
             textBox15.AppendText(dr["电话"] + "\t");
             textBox15.AppendText(dr["邮箱"] + "\t");
             textBox15.AppendText(dr["地址"] + "\t");
             textBox15.AppendText("\n");
         }
         conn.Close();
     }

     private void button10_Click(object sender, EventArgs e)
     {
         textBox6.Clear();
         textBox8.Clear();
         textBox9.Clear();
         textBox10.Clear();
     }

     private void button13_Click(object sender, EventArgs e)
     {
         textBox7.Clear();
     }

     private void button14_Click(object sender, EventArgs e)
     {
         Application.Exit();
     }

     private void button4_Click(object sender, EventArgs e)
     {
         textBox1.Clear();
         textBox2.Clear();
         textBox3.Clear();
         textBox4.Clear();
     }

     private void textBox11_TextChanged(object sender, EventArgs e)
     {

     }

     private void Form2_Load(object sender, EventArgs e)
     {

     }

    
    }
}
