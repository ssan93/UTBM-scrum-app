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
        public MainForm()
        {
            InitializeComponent();
        }
        public string ID { get; }
        public int EMAIL { get; }
        public MainForm(string email, int id)
        {
            ID = email;
            EMAIL = id;
        }

       
    }
}
