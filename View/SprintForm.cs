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
        public SprintForm(int id)
        {
            initPanels();
            InitializeComponent();
            SprintController sprintController = new SprintController();
            sprint = sprintController.FetchSprintById(id);
            if(sprint == null)
                // TODO: redirection vers menu project
                MessageBox.Show("404 : Sprint not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            panel1.MouseDown += new MouseEventHandler(this.List_MouseDown);
            todoList.Add(panel1);
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            Panel test = sender as Panel;
            test.BackColor = Color.Aqua;
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
            }
        }

    }
}
