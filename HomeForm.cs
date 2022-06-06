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
        //when cick open form signUp
        private void SignUpHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // you can hide or close this form
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        //when cick open form signin
        private void SigninHomebutton_Click(object sender, EventArgs e)
        {
            this.Hide(); // you can hide or close this form
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
        }
    }
}
