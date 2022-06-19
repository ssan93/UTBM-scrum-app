using pr74_scrum_app.Model;
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
        private readonly User user;

        public ProfilForm(User User)
        {
            InitializeComponent();
            EmailtextBox.Text = User.Email;
            this.user = User;

            labels = new List<System.Windows.Forms.Label>();
            labels.Add(ProjectLabel1);
            labels.Add(ProjectLabel2);
            labels.Add(ProjectLabel3);
            labels.Add(ProjectLabel4);
            roudboutonProjet = new List<View.RoundButton>();
            roudboutonProjet.Add(ProjectRoundButton1);
            roudboutonProjet.Add(ProjectRoundButton2);
            roudboutonProjet.Add(ProjectRoundButton3);
            roudboutonProjet.Add(ProjectRoundButton4);
            ProjectPictureBoxs= new List<System.Windows.Forms.PictureBox>();
            ProjectPictureBoxs.Add(ProjectPictureBox1);
            ProjectPictureBoxs.Add(ProjectPictureBox2);
            ProjectPictureBoxs.Add(ProjectPictureBox3);
            ProjectPictureBoxs.Add(ProjectPictureBox4);
            Loaddata();
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
                    UpdateInfos update = new UpdateInfos(user);
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

        private void CreateProjetButton_Click(object sender, EventArgs e)
        {
            CreatePojetForm create = new CreatePojetForm(user);
            create.Show();
        }

        public void Loaddata()
        {
            UserController usercontroller = new UserController();
            var projects =usercontroller.ReloadProjet(this.user.Id);
            if(!projects.Any()) //hide all projet composent and show no projet
            {
                for(int i = 1; i < 4; i++)
                {
                    roudboutonProjet[i].Visible = false;
                    ProjectPictureBoxs[i].Visible = false;
                    labels[i].Visible = false;
                }
                Console.WriteLine("              no item              ");
            }
            else 
            {
                int i = 0;
                foreach(var item in projects) //[1,2,name]
                {
                    Label label = labels[i];
                    View.RoundButton button = roudboutonProjet[i];
                    PictureBox picture = ProjectPictureBoxs[i];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    i++;
                }
            }
            
        }
    }
}