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
    public partial class ProjectViewForm : Form
    {
        public ProjectViewForm()
        {
            InitializeComponent();
        }

        private void addToMembersButton_Click(object sender, EventArgs e)
        {
            AddNewMemberForm form = new AddNewMemberForm();
            form.ShowDialog();
        }

        private void addToSprintsButton_Click(object sender, EventArgs e)
        {
            AddNewSprintForm form = new AddNewSprintForm();
            form.Show();
        }

        private void addToBacklogButton_Click(object sender, EventArgs e)
        {
            AddFeatureToBacklogForm form = new AddFeatureToBacklogForm();
            form.Show();
        }
    }
}
