using System;
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

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstnameText.Text) || string.IsNullOrWhiteSpace(lastnameText.Text))
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                user.SetUserFirstName(firstnameText.Text);
                user.SetUserLastName(lastnameText.Text);
                User u = new User(user.GetUserId(),
                    firstnameText.Text,
                    lastnameText.Text,
                    passwordText.Text,
                    emailText.Text);
                u.UpdateInfos();
                ErrorLabel.Visible = false;
                this.Close();
            }
        }
    }
}
