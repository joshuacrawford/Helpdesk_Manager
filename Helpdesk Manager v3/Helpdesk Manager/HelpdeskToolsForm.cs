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
    public partial class HelpdeskToolsForm : Form
    {
        string WorkerName;
        string path;
        public HelpdeskToolsForm(string EmployeeName, string location)
        {
            InitializeComponent();
            WorkerName = EmployeeName;
            path = location;
        }

        private void LaptopCount_Tools_Click(object sender, EventArgs e)
        {
            LaptopCountForm LaptopCount_f = new LaptopCountForm(WorkerName, path);
            LaptopCount_f.Show();
        }

        private void ExitButton_Tools_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Tools_Click(object sender, EventArgs e)
        {
            AddNewUserForm AddNewUser_f = new AddNewUserForm();
            AddNewUser_f.Show();
        }
    }
}
