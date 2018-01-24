using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Lottery : Form
    {
        public Lottery()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numGuess;
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            numGuess = Convert.ToInt32(txtGuess.Text);

            lblResult.Text = randomNumber.ToString("n");

            if (numGuess == randomNumber)
            {
                lblWinnerOrLoser.Text = "Congratulations you picked the right number " + numGuess;
            }
            else
            {
                lblWinnerOrLoser.Text = "You are a loser the computer picked " + randomNumber;
            }
        }
    }
}
