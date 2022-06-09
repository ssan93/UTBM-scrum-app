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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        //button to create a new user 
        private void SignupButton_Click(object sender, EventArgs e)
        {
            UserController reg = new UserController();
            if(reg.UserRegistration(firstnameText.Text,lastnameText.Text,emailText.Text,passwordText.Text,confirmpasswordText.Text))//if true go to sign in form 
            {
                this.Hide();//close the actuel form
                SignInForm signin = new SignInForm();
                signin.ShowDialog();
            }
        }

        //On click on link text sign in ths open the form signin
        private void SigninLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//hide the actuel form
            SignInForm signin = new SignInForm();
            signin.ShowDialog();
        }
    }
}
