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
    public partial class UpdateInfos : Form
    {
        readonly UserController user = new UserController();
        public UpdateInfos()
        {
            InitializeComponent();
            firstnameText.Text = user.GetUserFirstName();
            lastnameText.Text = user.GetUserLastName();
            emailText.Text = user.GetUserEmail();
            passwordText.Text = user.GetUserPassword();
        }

        private void SauvegarderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstnameText.Text) || string.IsNullOrWhiteSpace(lastnameText.Text))
            {
                ErrorLabel.Visible = true;
                Console.WriteLine("can't be show");
            }
            else
            {
                Console.WriteLine("im here");
                user.SetUserFirstName(firstnameText.Text);
                user.SetUserLastName(lastnameText.Text);
                User u = new User(user.GetUserId(),
                    firstnameText.Text,
                    lastnameText.Text,
                    passwordText.Text,
                    emailText.Text);
                u.Update();
                ErrorLabel.Visible = false;
            }
        }
    }
}
