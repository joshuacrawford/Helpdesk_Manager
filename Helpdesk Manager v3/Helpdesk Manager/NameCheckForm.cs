using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk_Manager
{
    public partial class NameCheckForm : Form
    {
        string path;
        public NameCheckForm(string location)
        {
            InitializeComponent();
            path = location;
        }

        private void NameCheckTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameCheckButton_Click(object sender, EventArgs e)
        {

            #region Check Username For Access

            System.IO.StreamReader file = new System.IO.StreamReader("WorkersList.txt");
            string line;
            string UserName = "";
            while ((line = file.ReadLine()) != null)
            {
                if (NameCheckTextbox.Text == line)
                {
                    UserName = NameCheckTextbox.Text;
                    this.Close();
                    HelpdeskToolsForm HelpdeskTools_f = new HelpdeskToolsForm(UserName, path);
                    HelpdeskTools_f.Show();
                }
            }
            if(UserName == "")
            {
                MessageBox.Show("Sorry, you don't seem to have access to these tools. Please try again");
                return;
            }

            file.Close();

            #endregion 
        }

        private void NameCheckLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
