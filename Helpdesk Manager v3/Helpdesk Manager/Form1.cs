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
    public partial class HelpdeskManager : Form
    {
        string path_Master;

        #region Create Excel Names

        Microsoft.Office.Interop.Excel.Application Application_Master;
        Microsoft.Office.Interop.Excel.Workbook Workbook_Master;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet1_Master;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet2_Master;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet3_Master;
        Microsoft.Office.Interop.Excel.Sheets Sheets_Master;

        #endregion

        public HelpdeskManager()
        {
            InitializeComponent();

            path_Master = @"H:\Helpdesk\Helpdesk Manager v2\Helpdesk Manager\bin\Debug\Test_Records.xlsx";

            #region Read Check-Out List On Start-Up

            //string line, Lastname, Firstname, Laptop, Charger;

            if (File.Exists("CheckOut_List.txt"))
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("CheckOut_List.txt");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string Firstname = line;
                    string Lastname= file.ReadLine();
                    file.ReadLine();
                    string Laptop = file.ReadLine();
                    string Charger = file.ReadLine();
                    HelpdeskManagerData.Rows.Add(Lastname, Firstname, Laptop, Charger);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File could not be opened");
            }

            #endregion
        }

        #region Check-Out Button

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CheckOutForm CheckOut_f = new CheckOutForm(HelpdeskManagerData, path_Master, Application_Master, Workbook_Master, WorkSheet1_Master, Sheets_Master);
            CheckOut_f.Show();
        }

        #endregion

        #region Check-In Button

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            CheckInForm CheckIn_f = new CheckInForm(HelpdeskManagerData, path_Master, Application_Master, Workbook_Master, WorkSheet1_Master, Sheets_Master);
            CheckIn_f.Show();
        }

        #endregion

        #region File Issue Button

        private void FileIssueButton_Click(object sender, EventArgs e)
        {
            FileIssueForm FileIssue_f = new FileIssueForm(path_Master, Application_Master, Workbook_Master, WorkSheet2_Master, Sheets_Master);
            FileIssue_f.Show();
        }

        #endregion

        #region Helpdesk Tools Button

        private void HelpdeskToolsButton_Click(object sender, EventArgs e)
        {
            NameCheckForm NameCheck_f = new NameCheckForm(path_Master);
            NameCheck_f.Show();
        }

        #endregion
    }
}
