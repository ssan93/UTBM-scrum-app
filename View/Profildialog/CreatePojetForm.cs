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
    public partial class CreatePojetForm : Form
    {
        readonly UserController user = new UserController();
        public CreatePojetForm()
        {
            InitializeComponent();
        }

        private void CreateValidedButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameProjetText.Text))
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                User u = new User(user.GetUserId(),
                    user.GetUserFirstName(),
                    user.GetUserLastName(),
                    user.GetUserPassword(),
                    user.GetUserEmail());
                u.CreateProjet();
                ErrorLabel.Visible = false;
                this.Close();
            }
        }
    }
}
