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

            //projets
            projectLabels = new List<Label>();
            projectLabels.Add(ProjectLabel1);
            projectLabels.Add(ProjectLabel2);
            projectLabels.Add(ProjectLabel3);
            projectLabels.Add(ProjectLabel4);
            roudboutonProjet = new List<View.RoundButton>();
            roudboutonProjet.Add(ProjectRoundButton1);
            roudboutonProjet.Add(ProjectRoundButton2);
            roudboutonProjet.Add(ProjectRoundButton3);
            roudboutonProjet.Add(ProjectRoundButton4);
            ProjectPictureBoxs= new List<PictureBox>();
            ProjectPictureBoxs.Add(ProjectPictureBox1);
            ProjectPictureBoxs.Add(ProjectPictureBox2);
            ProjectPictureBoxs.Add(ProjectPictureBox3);
            ProjectPictureBoxs.Add(ProjectPictureBox4);

            //sprint
            Sprintlabels = new List<Label>();
            Sprintlabels.Add(SprintLabel1);
            Sprintlabels.Add(SprintLabel2);
            Sprintlabels.Add(SprintLabel3);
            Sprintlabels.Add(SprintLabel4);
            roudboutonSprints = new List<View.RoundButton>();
            roudboutonSprints.Add(roundButtonSprint1);
            roudboutonSprints.Add(roundButtonSprint2);
            roudboutonSprints.Add(roundButtonSprint3);
            roudboutonSprints.Add(roundButtonSprint4);
            SprintPictureBoxs = new List<PictureBox>();
            SprintPictureBoxs.Add(SprintpictureBox1);
            SprintPictureBoxs.Add(SprintpictureBox2);
            SprintPictureBoxs.Add(SprintpictureBox3);
            SprintPictureBoxs.Add(SprintpictureBox4);

            //stack
            tacklabels = new List<Label>();
            tacklabels.Add(Tasklabel1);
            tacklabels.Add(Tasklabel2);
            tacklabels.Add(Tasklabel3);
            tacklabels.Add(Tasklabel4);
            Tasksroudboutons = new List<View.RoundButton>();
            Tasksroudboutons.Add(TaskroundButton1);
            Tasksroudboutons.Add(TaskroundButton2);
            Tasksroudboutons.Add(TaskroundButton3);
            Tasksroudboutons.Add(TaskroundButton4);
            TaskPictureBoxs = new List<PictureBox>();
            TaskPictureBoxs.Add(TaskpictureBox1);
            TaskPictureBoxs.Add(TaskpictureBox2);
            TaskPictureBoxs.Add(TaskpictureBox3);
            TaskPictureBoxs.Add(TaskpictureBox4);

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
            var sprints = usercontroller.ReloadSprint(this.user.Id);
            var tasks = usercontroller.ReloadTask(this.user.Id);
            if(!projects.Any()) //hide all projet composent and show no projet
            {
                for(int i = 1; i < 4; i++)
                {
                    roudboutonProjet[i].Visible = false;
                    ProjectPictureBoxs[i].Visible = false;
                    projectLabels[i].Visible = false;
                }
                NoProjectLabel.Visible = true;
            }
            else
            {
                int i = 0;
                foreach (var item in projects)
                {
                    Label label = projectLabels[i];
                    View.RoundButton button = roudboutonProjet[i];
                    PictureBox picture = ProjectPictureBoxs[i];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    i++;
                }
            }
            if(!sprints.Any())
            {
                for (int i = 1; i < 4; i++)
                {
                    roudboutonSprints[i].Visible = false;
                    SprintPictureBoxs[i].Visible = false;
                    Sprintlabels[i].Visible = false;
                }
                NoSprintLabel.Visible = true;
            }
            else
            {
                int j = 0;
                foreach (var item in sprints)
                {
                    Label label = Sprintlabels[j];
                    View.RoundButton button = roudboutonSprints[j];
                    PictureBox picture = SprintPictureBoxs[j];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    j++;
                }
            }
            if(!tasks.Any())
            {
                for (int i = 1; i < 4; i++)
                {
                    Tasksroudboutons[i].Visible = false;
                    TaskPictureBoxs[i].Visible = false;
                    tacklabels[i].Visible = false;
                }
                NoTaskLabel.Visible = true; ;
            }
            else 
            {
                int k = 0;
                foreach (var item in sprints)
                {
                    Label label = tacklabels[k];
                    View.RoundButton button = Tasksroudboutons[k];
                    PictureBox picture = TaskPictureBoxs[k];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    k++;
                }
            }
            
        }
    }
}