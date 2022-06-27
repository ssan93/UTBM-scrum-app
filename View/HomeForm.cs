using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        //when cick open form signUp and hide the actual form
        private void SignUpHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        //when cick open form signin and hide the actual form
        private void SigninHomebutton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
        }
        //when cick open form signUp and hide the actual form
        private void CommencerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer l'application", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Environment.Exit(0);
                else e.Cancel = true;
            }
            else e.Cancel = true;
        }
    }
}
