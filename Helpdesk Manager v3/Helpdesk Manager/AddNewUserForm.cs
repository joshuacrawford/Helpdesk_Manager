using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Helpdesk_Manager
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void NameCheckTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameCheckButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter File_Users = File.AppendText("WorkersList.txt"))
            {
                File_Users.WriteLine(AddUserTextbox.Text);
            }

            this.Close();
        }
    }
}
