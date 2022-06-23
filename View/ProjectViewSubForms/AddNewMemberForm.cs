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
    public partial class AddNewMemberForm : Form
    {
        public AddNewMemberForm()
        {
            InitializeComponent();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            // get form data
            string featureName = memberEmailAddressTextBox.Text;
            string featureType = roleSelectionComboBox.Text;
           
            Console.WriteLine("featureComplexity : " + featureName);
            Console.WriteLine("description : " + featureType);

            // add data to DB



            // close form
            this.Close();
        }

    }
}
