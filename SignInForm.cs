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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        //login to the app
        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserController login = new UserController();
            if (login.UserLogin(signinpasswordText.Text.Trim(), signiemailText.Text.Trim()))
            {
                this.Hide();//hide the form
                MainForm mp = new MainForm(login.GetUserEmail(),login.GetUserId());
                mp.ShowDialog();
            }
        }

        private void SigninLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//hide the form
            SignUpForm sup = new SignUpForm();
            sup.ShowDialog();
        }
    }
}
  