using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Data
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณากรอก  Username");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("กรุณากรอก Password");
                textBox2.Focus();
            }

            else if (textBox1.Text != "test" || textBox2.Text != "123456")
            {
                MessageBox.Show("กรุณาใส่ Username และ Password ให้ถูกต้อง");
                textBox2.Focus();
                textBox2.SelectAll();
            }
            else
            {
                this.Hide();
                Coffee f2 = new Coffee ();
                f2.Show();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            สมัครสมาชิก f2 = new สมัครสมาชิก();
            f2.Show();
        }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ลืมรหัสผ่าน f2 = new ลืมรหัสผ่าน();
            f2.Show();
           }

        }
    }

