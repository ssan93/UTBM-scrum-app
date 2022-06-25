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
    public partial class ProjectForm : Form
    {

        Controller.ProjectController pc = new Controller.ProjectController();

        private int projectId;
        private int userId;
        private Project project;
        private Member member;

        public ProjectForm(int currentProjectId, int currentUserId)
        {
            this.projectId = currentProjectId;
            this.userId = currentUserId; 
            this.project = pc.FetchProjectById(this.projectId);
            this.member = pc.FetchMember(this.projectId, this.userId);
            
            InitializeComponent();

            projectNameLabel.Text = this.project.Name;
            porjectDescription.Text = this.project.Description;
            archiveProjectButton.Visible = false;
            addToBacklogButton.Visible = false;
            addToMembersButton.Visible = false;
            addToSprintsButton.Visible = false;

            if (member.Role == "SM" || member.Role == "PO")
            {
                archiveProjectButton.Visible = true;
                addToBacklogButton.Visible = true;
                addToMembersButton.Visible = true;
                addToSprintsButton.Visible = true;
            }
        }

        private void addToMembersButton_Click(object sender, EventArgs e)
        {
            AddNewMemberForm form = new AddNewMemberForm(this.projectId);
            form.ShowDialog();
        }

        private void addToSprintsButton_Click(object sender, EventArgs e)
        {
            AddNewSprintForm form = new AddNewSprintForm(this.projectId);
            form.Show();
        }

        private void addToBacklogButton_Click(object sender, EventArgs e)
        {
            AddFeatureToBacklogForm form = new AddFeatureToBacklogForm(this.projectId);
            form.Show();
        }

        private void archiveProjectButton_Click(object sender, EventArgs e)
        {
            ArchiveProjectConfirmationForm form = new ArchiveProjectConfirmationForm(this.projectId);
            form.Show();
        }

        private void projectNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
