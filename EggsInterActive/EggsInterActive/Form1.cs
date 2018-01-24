using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInterActive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dozens;
            int totalEggs;
            int remainderEggs;
            int chicken1Num, chicken2Num, chicken3Num, chicken4Num, chicken5Num;

            chicken1Num = Convert.ToInt32(textBox1.Text);
            chicken2Num = Convert.ToInt32(textBox2.Text);
            chicken3Num = Convert.ToInt32(textBox3.Text);
            chicken4Num = Convert.ToInt32(textBox4.Text);
            chicken5Num = Convert.ToInt32(textBox5.Text);

            totalEggs = chicken1Num + chicken2Num + chicken3Num + chicken4Num + chicken5Num;
            remainderEggs = totalEggs % 12;
            dozens = totalEggs / 12;

            lblResult.Text = "The total number of eggs is "+totalEggs+", there are " +totalEggs+
                " dozen eggs, with a remainder of "+ remainderEggs;


        }
    }
}
