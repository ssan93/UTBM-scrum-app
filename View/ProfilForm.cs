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
    public partial class ProfilForm : Form
    {
        public ProfilForm()
        {
            InitializeComponent();
        }
        public int ID { get; } //id of the user connected
        public string EMAIL { get; } //eamil of the user connected
        public ProfilForm(string email, int id)
        {
            ID = id;
            EMAIL = email;
            InitializeComponent();
            EmailLabel.Text = EMAIL;
        }

        private void PictureProfilBox_Click(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

        private void ProfilViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is HomeForm)
                {
                    oForm.Show();
                    break;
                }
            }
        }

        private void ProfilListBox_MouseHover(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

        private void ProfilListBox_MouseLeave(object sender, EventArgs e)
        {
            ProfilListBox.Visible = false;
        }
        //if i click on an item proffil list box i ave 2 choices
        private void ProfilListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProfilListBox.SelectedItem != null)
            {
                if(ProfilListBox.SelectedItem.ToString()=="Mon profil")
                {
                    UpdateInfos update = new UpdateInfos();
                    update.ShowDialog();
                }
                if(ProfilListBox.SelectedItem.ToString() == "Déconnexion")
                {
                    MessageBoxButtons conf = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnection", conf);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                        foreach (Form oForm in Application.OpenForms)
                        {
                            if (oForm is HomeForm)
                            {
                                oForm.Show();
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}