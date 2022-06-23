using pr74_scrum_app.Controller;
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


namespace pr74_scrum_app.View
{
    public partial class SprintForm : Form
    {
        Sprint sprint;
        Control control;
        ListPanel source;
        UserStoryController userStoryController = new UserStoryController();
        SprintController sprintController = new SprintController();
        public SprintForm(int id)
        {
            InitializeComponent();
            
            sprint = sprintController.FetchSprintById(id);
            if(sprint == null)
                // TODO: redirection vers menu project
                MessageBox.Show("404 : Sprint not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
            sprintController.test();

        }
        private void GenerateUserStoryPanels(List<UserStory> userStories)
        {
            ClearLists();
            foreach (UserStory us in userStories)
            {
                UserStoryPanel usp = new UserStoryPanel(us);
                usp.MouseDown += new MouseEventHandler(List_MouseDown);
                switch (us.State){
                    case "TODO" : todoList.Add(usp); break;
                    case "PROGRESS" : inProgressList.Add(usp); break;
                    case "REVIEW" : inReviewList.Add(usp); break;
                    case "DONE" : doneList.Add(usp); break;
                }
            }
        }
        private List<UserStory> Search(string query)
        {
            List<UserStory> selected = new List<UserStory> ();
            foreach(UserStory us in sprint.Backlog.UserStories)
            {
                bool selectable = false;
                if (us.Name.Contains(query)){
                    selectable = true;
                }
                foreach(Member assignee in us.Assignees)
                {
                    string fullname = assignee.User.FirstName+" "+assignee.User.LastName;
                    if (fullname.Contains(query))
                    {
                        selectable = true;
                    }
                }
                if (selectable)
                {
                    selected.Add(us);
                }
            }
            return selected;
        }
        private void ClearLists() {
            todoList.Clear();
            inProgressList.Clear();
            inReviewList.Clear();
            doneList.Clear();
        }
        private void List_MouseDown(object sender, MouseEventArgs e)
        {
            control= sender as Control;
            source = control.Parent as ListPanel;

            source.DoDragDrop(control.Text, DragDropEffects.Move);

        }
        private void List_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void List_DragEnter(object sender, DragEventArgs e)
        {
            ListPanel actuel = sender as ListPanel;
            if (actuel != source)
            {
                actuel.Add(control);
                actuel.RefreshControls();
                source.Remove(control);
                source.RefreshControls();
                source = actuel;
                UpdateSprint();
            }
        }
        private void UpdateSprint()
        {
            foreach(UserStoryPanel c in todoList.Controls)
            {
                c.UserStory.State = "TODO";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in inProgressList.Controls)
            {
                c.UserStory.State = "PROGRESS";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in inReviewList.Controls)
            {
                c.UserStory.State = "REVIEW";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in inReviewList.Controls)
            {
                c.UserStory.State = "DONE";
                userStoryController.UpdateState(c.UserStory);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
            if (searchBar.Text.Length != 0)
            {
                cancelSearchButton.Visible = true;
                string query = searchBar.Text;
                GenerateUserStoryPanels(Search(query));
            }
        }
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            cancelSearchButton.Visible = false;
            searchBar.Text = "";
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
        }
    }
}
