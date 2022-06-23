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
    public partial class AddFeatureToBacklogForm : Form
    {
        public AddFeatureToBacklogForm()
        {
            InitializeComponent();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFeatureToBacklogForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            // get form data
            string featureName = backlogFeatureTitleTextBox.Text;
            string featureType = typeSelectionComboBox.Text;
            string featurePriority = priorityComboBox.Text;
            decimal complexity = complexityLevelNumericUpDown.Value;
            int featureComplexity = ((int)complexity);
            string description = featureDescription.Text;

            Console.WriteLine("featureName : " + featureName );
            Console.WriteLine("featureType : " + featureType);
            Console.WriteLine("featurePriority : " + featurePriority);
            Console.WriteLine("featureComplexity : " + featureComplexity);
            Console.WriteLine("description : "+ description);

            // add data to DB



            // close form
            this.Close();
        }
    }
}
