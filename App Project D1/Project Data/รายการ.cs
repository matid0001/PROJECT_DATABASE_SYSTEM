using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Data
{
    public partial class รายการ : Form
    {
        public รายการ()
        {
            InitializeComponent();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (x1.Checked)
            {
                C1.Enabled = true;
              
                
              
            }
            else
            {
                C1.Enabled = false;
                C1.Value = 0;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (x2.Checked)
            {
                C2.Enabled = true;
            }
            else
            {
                C2.Enabled = false;
                C2.Value = 0;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (x3.Checked)
            {
                C3.Enabled = true;
            }
            else
            {
                C3.Enabled = false;
                C3.Value = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (x4.Checked)
            {
                C4.Enabled = true;
            }
            else
            {
                C4.Enabled = false;
                C4.Value = 0;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (x5.Checked)
            {
                C5.Enabled = true;
            }
            else
            {
                C5.Enabled = false;
                C5.Value = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (x6.Checked)
            {
                C6.Enabled = true;
            }
            else
            {
                C6.Enabled = false;
                C6.Value = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (x7.Checked)
            {
                C7.Enabled = true;
            }
            else
            {
                C7.Enabled = false;
                C7.Value = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (x8.Checked)
            {
                C8.Enabled = true;
            }
            else
            {
                C8.Enabled = false;
                C8.Value = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (x9.Checked)
            {
                C9.Enabled = true;
            }
            else
            {
                C9.Enabled = false;
                C9.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you");
            this.Close();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (x10.Checked)
            {
                B1.Enabled = true;
            }
            else
            {
                B1.Enabled = false;
                B1.Value = 0;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (x11.Checked)
            {
                B2.Enabled = true;
            }
            else
            {
                B2.Enabled = false;
                B2.Value = 0;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (x12.Checked)
            {
                B3.Enabled = true;
            }
            else
            {
                B3.Enabled = false;
                B3.Value = 0;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (x13.Checked)
            {
                B4.Enabled = true;
            }
            else
            {
                B4.Enabled = false;
                B4.Value = 0;
            }
       
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (x14.Checked)
            {
                B5.Enabled = true;
            }
            else
            {
                B5.Enabled = false;
                B5.Value = 0;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (x15.Checked)
            {
                B6.Enabled = true;
            }
            else
            {
                B6.Enabled = false;
                B6.Value = 0;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (x16.Checked)
            {
                B7.Enabled = true;
            }
            else
            {
                B7.Enabled = false;
                B7.Value = 0;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (x17.Checked)
            {
                B8.Enabled = true;
            }
            else
            {
                B8.Enabled = false;
                B8.Value = 0;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (x18.Checked)
            {
                B9.Enabled = true;
            }
            else
            {
                B9.Enabled = false;
                B9.Value = 0;
            }
        }
       
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void C1_ValueChanged(object sender, EventArgs e)
        {
            
                 

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string str;
            double z1 , z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, sum;
            str = "";

            if (x1.Checked == true)
            {
                str = ("โอวันติน    " +  C1.Value.ToString() + "   แก้ว") ;
                z1 = 50;
            }
            else
            {
                z1 = 0;
            }
            
            if (this.x2.Checked == true)
            {
                str = ("กาแฟสด    " + C1.Value.ToString() + "    แก้ว");
                z2 = 55;
            }
            else
            {
                z2 = 0;
            }
            if (this.x3.Checked == true)
            {
                str = ("กาแฟดำ      " + C1.Value.ToString() + "   แก้ว");
                z3 = 55;
            }
            else
            {
                z3 = 0;
            }
            txtt.Text = str;
            



        }    
         
    }
}
