using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStrengthEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimateStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            //this is will tell you good if you put it number, character and punction
            if (password.Length > 10 && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsPunctuation))
            {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightGreen;
            }
            // this line will tell you ok if put it a number and character only 
            else if (password.Length > 5 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblResult.Text = "Ok";
                lblResult.BackColor = Color.Orange;
            }
                // bad is if you put it less charcters
            else
            {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
