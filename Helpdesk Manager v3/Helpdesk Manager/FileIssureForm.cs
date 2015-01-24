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
    public partial class FileIssueForm : Form
    {
        #region Initialization Of Outside Varibles

        string path;
        Microsoft.Office.Interop.Excel.Application Application_Issue;
        Microsoft.Office.Interop.Excel.Workbook Workbook_Issue;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet2_Issue;
        Microsoft.Office.Interop.Excel.Sheets Sheets_Issue;

        #endregion

        public FileIssueForm(string location, Microsoft.Office.Interop.Excel.Application Application, Microsoft.Office.Interop.Excel.Workbook Workbook, Microsoft.Office.Interop.Excel.Worksheet WorkSheet2, Microsoft.Office.Interop.Excel.Sheets Sheets)
        {
            InitializeComponent();

            #region Assignment Of Outside Varibles

            path = location;
            Application_Issue = Application;
            Workbook_Issue = Workbook;
            WorkSheet2_Issue = WorkSheet2;
            Sheets_Issue = Sheets;

            #endregion

        }

        #region Where I Double Clicked Labels

        private void UINLabel_Issue_Click(object sender, EventArgs e)
        {

        }

        private void LastNameLabel_Issue_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void SubmitButton_Issue_Click(object sender, EventArgs e)
        {
            
            #region Check for Incorrect inputs

            #region Check For Empty Boxes

            if (string.IsNullOrWhiteSpace(FirstNameTextbox_Issue.Text) || string.IsNullOrWhiteSpace(LastNameTextbox_Issue.Text) || string.IsNullOrWhiteSpace(UINTextbox_Issue.Text) || string.IsNullOrWhiteSpace(DiscribeIssueTextbox_Issue.Text))
            {
                MessageBox.Show("One or more fields were not completed, couldn't continue.");
                return;
            }

            #endregion

            #region Check For Correct Character Input

            if (FirstNameTextbox_Issue.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your First name can not include digits.");
                FirstNameTextbox_Issue.Text = "";
                return;
            }
            if (LastNameTextbox_Issue.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your Last name can not include digits.");
                LastNameTextbox_Issue.Text = "";
                return;
            }
            if (UINTextbox_Issue.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Your UIN can not include letters.");
                UINTextbox_Issue.Text = "";
                return;
            }

            #endregion

            #region Check Length Of Input

            if (FirstNameTextbox_Issue.Text.Length > 25)
            {
                MessageBox.Show("Your First name can only be 25 characters.");
                FirstNameTextbox_Issue.Text = "";
                return;
            }
            if (LastNameTextbox_Issue.Text.Length > 25)
            {
                MessageBox.Show("Your Last name can only be 25 characters.");
                LastNameTextbox_Issue.Text = "";
                return;
            }
            if (UINTextbox_Issue.Text.Length != 9)
            {
                MessageBox.Show("Your UIN did not contain the correct number of digits.");
                UINTextbox_Issue.Text = "";
                return;
            }

            #endregion

            #endregion

            #region Start And Open Execl File

            Application_Issue = new Microsoft.Office.Interop.Excel.Application();
            Workbook_Issue = Application_Issue.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            Sheets_Issue = Workbook_Issue.Worksheets;
            WorkSheet2_Issue = (Microsoft.Office.Interop.Excel.Worksheet)Sheets_Issue.get_Item("Sheet2");

            #endregion

            #region Find Last Row Of Data

            Microsoft.Office.Interop.Excel.Range LastRow_Issue = WorkSheet2_Issue.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            int LastRowUsed_Issue = LastRow_Issue.Row;

            #endregion

            #region Write To Excel

            string Solved;
            if (SolvedCheckbox_Issue.Checked == true)
                Solved = "Yes";
            else
                Solved = "No";

            DateTime CurrentDateTime_Issue = DateTime.Now;
            string Date_Issue = CurrentDateTime_Issue.GetDateTimeFormats('d')[0];
            string Time_Issue = CurrentDateTime_Issue.GetDateTimeFormats('t')[0];

            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 1] = Date_Issue;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 2] = Time_Issue;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 3] = FirstNameTextbox_Issue.Text;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 4] = LastNameTextbox_Issue.Text;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 5] = UINTextbox_Issue.Text;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 6] = DiscribeIssueTextbox_Issue.Text;
            WorkSheet2_Issue.Cells[LastRowUsed_Issue + 1, 7] = Solved;

            #endregion

            #region Save And Close Excel File

            Workbook_Issue.Save();
            Workbook_Issue.Close(false, path, Type.Missing);

            #endregion

            this.Close();

        }
    }
}
