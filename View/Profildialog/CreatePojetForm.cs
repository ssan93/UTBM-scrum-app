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
        readonly UserController usercontroller = new UserController();
        private User user;
 
        public CreatePojetForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CreateValidedButton_Click(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length<250 && NameProjetText.Text.Length < 20)
            {
                TailleDescriptionLabel.Visible = false;
                if (string.IsNullOrWhiteSpace(NameProjetText.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                {
                    ErrorLabel.Visible = true;
                }
                else
                {
                    usercontroller.CreateProjet(NameProjetText.Text,DescriptionTextBox.Text,this.user.Id);
                    ErrorLabel.Visible = false;
                    //refresh/reload profil form
                    foreach (Form oForm in Application.OpenForms)
                    {
                        if (oForm is ProfilForm)
                        {
                            oForm.Hide();
                            break;
                        }
                    }
                    ProfilForm pro= new ProfilForm(user)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    pro.Show();
                    this.Close();
                }
            }
            else
            {
                if (DescriptionTextBox.Text.Length > 250)
                {
                    TailleDescriptionLabel.Visible = true;
                }
                if (NameProjetText.Text.Length > 20)
                {
                    MaxnameLabel.Visible = true;
                }
            }
        }
    }
}
