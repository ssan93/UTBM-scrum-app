using pr74_scrum_app.View.Components;
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
    public partial class MainForm : Form
    {
        public int ID { get; } //id of the user connected
        public string EMAIL { get; } //eamil of the user connected
        public Dictionary<int,string> pinnedProjects;
        public Dictionary<int, string> myProjects;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string email, int id)
        {
            InitializeComponent();
            ID = id;
            EMAIL = email;
            SidebarController controller = new SidebarController();

            this.pinnedProjects = controller.GetProjects(1, true);
            this.myProjects = controller.GetProjects(1, false);

            //Add pinned project list
            generateProjectList(this.pinnedProjects, this.panel2, 55, "../../Ressources/pin.ico");
            
            //Add Separator
            Separator sep = new Separator();
            sep.Size = new Size(160, 20);
            sep.Left = 0;
            sep.Top = this.pinnedProjects.Count() * 30 + 100;
            this.panel2.Controls.Add(sep);

            //Add Title
            Label project = new Label();
            project.Text = "Autre projets";
            project.Left = 5;
            project.Font = this.label8.Font;
            project.Size = new Size(160, 20);
            project.Top = this.pinnedProjects.Count() * 30 + 130;
            this.panel2.Controls.Add(project);

            //Add other projects list
            generateProjectList(this.myProjects, this.panel2, this.pinnedProjects.Count() * 30 + 140, "../../Ressources/proj.ico");


        }
        //Generate project list on a specific panel
        private void generateProjectList(Dictionary<int, string> projects, Panel panel, int top, string imgLink)
        {
            for (int i = 0; i < projects.Count(); i++)
            {
                //Add icon
                PictureBox pictureBox = new PictureBox();
                pictureBox.Load(imgLink);
                pictureBox.Size = new Size(20, 20);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Left = 10;
                pictureBox.Top = top - 3 + (i + 1) * 30;
                
                //Add project name
                LinkLabel label = new LinkLabel();
                label.Text = String.Format("{0}", projects.Values.ElementAt(i));
                label.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                label.LinkColor = Color.FromArgb(0, 0, 0);//(R, G, B) (0, 0, 0 = black) System.Drawing.Color.Black;
                label.Left = 35;
                label.Top = top + (i + 1) * 30;
                int projectID = projects.Keys.ElementAt(i);
                //Add click event to send to project page
                label.Click += (sender, EventArgs) => { GoToProject(sender, EventArgs, projectID); };

                
                //Add controls to form
                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);

            }
        }

        //Send to "projectID" project page
        private void GoToProject(object sender, EventArgs e, int projectID)
        {
            this.Hide();
            Console.WriteLine(projectID.ToString());
            //ProjectForm projectPage = new ProjectForm(projectID);
            //projectPage.ShowDialog();
            HomeForm home = new HomeForm();
            home.ShowDialog();
        }
    }
    
}
