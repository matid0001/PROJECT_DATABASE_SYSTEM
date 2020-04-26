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
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            newรายการ f2 = new newรายการ();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ยอดขาย f2 = new ยอดขาย();
            f2.Show();
        }
    }
}
