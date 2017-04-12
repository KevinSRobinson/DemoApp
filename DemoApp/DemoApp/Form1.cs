using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.labelControl1.Text = ConfigurationManager.AppSettings["Environment"];
            this.lcConnctionString.Text = Properties.Settings.Default.ConnectionString;
            
            lcVersion.Text = "Version " + Application.ProductVersion;
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
