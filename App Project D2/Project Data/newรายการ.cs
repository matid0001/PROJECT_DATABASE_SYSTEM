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
    public partial class newรายการ : Form
    {
        
        public newรายการ()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
            if (checkBox2.Checked)
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
            if (checkBox3.Checked)
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
            if (checkBox4.Checked)
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
            if (checkBox5.Checked)
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
            if (checkBox6.Checked)
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
            if (checkBox7.Checked)
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
            if (checkBox8.Checked)
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
            if (checkBox9.Checked)
            {
                C9.Enabled = true;

            }
            else
            {
                C9.Enabled = false;
                C9.Value = 0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
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
            if (checkBox11.Checked)
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
            if (checkBox12.Checked)
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
            if (checkBox13.Checked)
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
            if (checkBox14.Checked)
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
            if (checkBox15.Checked)
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
            if (checkBox16.Checked)
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
            if (checkBox17.Checked)
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
            if (checkBox18.Checked)
            {
                B9.Enabled = true;

            }
            else
            {
                B9.Enabled = false;
                B9.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            double z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, sum;
            str = "";

            if (checkBox1.Checked == true)
            {
                str += ("\r\n\nอเมริกาโน่                            " + C1.Value.ToString() + "แก้ว");
                z1 = 80;
            }
            else
            {
                z1 = 0;
            }
            if (checkBox2.Checked == true)
            {
                str += ("\r\n\nกาแฟสด                              " + C2.Value.ToString() + "แก้ว");
                z2 = 65;
            }
            else
            {
                z2 = 0;
            }
            if (checkBox3.Checked == true)
            {
                str += ("\r\n\nกาแฟดำ                              " + C3.Value.ToString() + "แก้ว");
                z3 = 60;
            }
            else
            {
                z3 = 0;
            }
            if (checkBox4.Checked == true)
            {
                str += ("\r\n\nมอคค่า                                " + C4.Value.ToString() + "แก้ว");
                z4 = 100;
            }
            else
            {
                z4 = 0;
            }
            if (checkBox5.Checked == true)
            { 
                str += ("\r\n\nมัทฉะ คาเฟ่ ลาเต้                  " + C5.Value.ToString() + "แก้ว");
                z5 = 120;
            }
            else
            {
                z5 = 0;
            }
            if (checkBox6.Checked == true)
            {
                str += ("\r\n\nเอสเพรสโซ่                          " + C6.Value.ToString() + "แก้ว");
                z6 = 70;
            }
            else
            {
                z6 = 0;
            }
            if (checkBox7.Checked == true)
            {
                str += ("\r\n\nลาเต้                                   " + C7.Value.ToString() + "แก้ว");
                z7 = 100;
            }
            else
            {
                z7 = 0;
            }
            if (checkBox8.Checked == true)
            {       
                str += ("\r\n\nคาราเมล มัคคิอาโต้                " + C8.Value.ToString() + "แก้ว");
                z8 = 120;
            }
            else
            {
                z8 = 0;
            }
            if (checkBox9.Checked == true)
            {
                str += ("\r\n\nคาปูชิโน่                               " + C9.Value.ToString() + "แก้ว");
                z9 = 100;   
            }
            else
            {
                z9 = 0;
            }
            if (checkBox10.Checked == true)
            {
                str += ("\r\n\nCheese Pie                         " + B1.Value.ToString() + "ชิ้น");
                z10 = 140;
            }
            else
            {
                z10 = 0;
            }
            if (checkBox11.Checked == true)
            {
                str += ("\r\n\nmacarone                          " + B2.Value.ToString() + "กล่อง");
                z11 = 80;
            }
            else
            {
                z11 = 0;
            }
            if (checkBox12.Checked == true)
            {
                str += ("\r\n\nPastel Party Cake                " + B3.Value.ToString() + "ชิ้น");
                z12 = 125;
            }
            else
            {
                z12 = 0;
            }
            if (checkBox13.Checked == true)
            {
                str += ("\r\n\nPana Cotta                          " + B4.Value.ToString() + "แก้ว");
                z13 = 95;
            }
            else
            {
                z13 = 0;
            }
            if (checkBox14.Checked == true)
            {
                str += ("\r\n\nItalian Roll                            " + B5.Value.ToString() + "ชิ้น");
                z14 = 75;
            }
            else
            {
                z14 = 0;
            }
            if (checkBox15.Checked == true)
            {       
                str += ("\r\n\nRed Velvet Cake                  " + B6.Value.ToString() + "ชิ้น");
                z15 = 140;
            }
            else
            {
                z15 = 0;
            }
            if (checkBox16.Checked == true)
            { 
                str += ("\r\n\nCinnamon Roll                     " + B7.Value.ToString() + "ชิ้น");
                z16 = 75;
            }
            else
            {
                z16 = 0;
            }
            if (checkBox17.Checked == true)
            {
                str += ("\r\n\nBanoffee Pie                       " + B8.Value.ToString() + "ชิ้น");
                z17 = 130;
            }
            else
            {
                z17 = 0;
            }
            if (checkBox18.Checked == true)
            {
                str += ("\r\n\nSugar-Free Pumpkin Pie      " + B9.Value.ToString() + "ชิ้น");
                z18 = 125;
            }
            else
            {
                z18 = 0;
            }
            textBox1.Text = str; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Coffee form1 = new Coffee ();
            form1.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ใบเสร็จ form1 = new ใบเสร็จ();
            form1.Visible = true;
            ใบเสร็จ.Show();
            ใบเสร็จ.textBox1.Text = textBox6.Text;
            ใบเสร็จ.textBox6.Text = textBox6.Text;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
 }

