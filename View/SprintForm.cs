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
        int index = 0;
        Sprint sprint;
        ListBox source;
        public SprintForm(int id)
        {
            InitializeComponent();
            SprintController sprintController = new SprintController();
            sprint = sprintController.FetchSprintById(id);
            if(sprint == null)
                // TODO: redirection vers menu project
                MessageBox.Show("404 : Sprint not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            source = sender as ListBox;
            index = source.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                source.DoDragDrop(source.Items[index].ToString(), DragDropEffects.Move);
            }
        }
        private void ListBox_DragDrop(object sender, DragEventArgs e)
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
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            ListBox actuel = sender as ListBox;
            if(actuel != source)
            {
                actuel.Items.Add(source.Items[index]);
                source.Items.RemoveAt(index);
                source = actuel;
                index = source.Items.Count-1;
            }
        }
    }
}
