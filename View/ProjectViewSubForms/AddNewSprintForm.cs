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
    public partial class AddNewSprintForm : Form
    {
        public AddNewSprintForm()
        {
            InitializeComponent();
        }

        private void AddNewSprintForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            // get form data
            string sprintName = sprintNameTextBox.Text;
            string startingDate = startingDateTimePicker.Text;
            string endingDate = endingDateTimePicker.Text;

            Console.WriteLine("sprintName : " + sprintName);
            Console.WriteLine("startingDate : " + startingDate);
            Console.WriteLine("endingDate : " + endingDate);

            // add data to DB



            // close form
            this.Close();
        }
    }
}
