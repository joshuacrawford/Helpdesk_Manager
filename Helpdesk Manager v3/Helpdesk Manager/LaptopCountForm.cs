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
    public partial class LaptopCountForm : Form
    {
        string path;
        string WorkerName_Count;
        public LaptopCountForm(string EmployeeName, string location)
        {
            InitializeComponent();
            path = location;
            WorkerName_Count = EmployeeName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_In_Click(object sender, EventArgs e)
        {
            #region Check For Incorrect Inputs

            #region Check For Empty Boxes

            if(string.IsNullOrWhiteSpace(CheckedInCombobox_Dell.Text) || string.IsNullOrWhiteSpace(CheckedOutCombobox_Dell.Text) || string.IsNullOrWhiteSpace(CheckedInCombobox_Mac.Text) || string.IsNullOrWhiteSpace(CheckedOutCombobox_Mac.Text))
            {
                MessageBox.Show("One or more fields were not completed, couldn't continue.");
                return;
            }

            #endregion

            #region Check For Correct Input

            int CheckedInDell = Int32.Parse(CheckedInCombobox_Dell.Text);
            int CheckedOutDell = Int32.Parse(CheckedOutCombobox_Dell.Text);
            int CheckedInMac = Int32.Parse(CheckedInCombobox_Mac.Text);
            int CheckedOutMac = Int32.Parse(CheckedOutCombobox_Mac.Text);

            if (CheckedInDell + CheckedOutDell != 29)
            {
                MessageBox.Show("Sorry but the numbers for Dell do not add up. Please try again.");
                return;
            }
            if (CheckedInMac + CheckedOutMac != 11)
            {
                MessageBox.Show("Sorry but the numbers for Mac do not add up. Please try again.");
                return;
            }

            #endregion

            #endregion

            #region Assignment of Excel Components

            Microsoft.Office.Interop.Excel.Application Application_Count;
            Microsoft.Office.Interop.Excel.Workbook Workbook_Count;
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet3_Count;
            Microsoft.Office.Interop.Excel.Sheets Sheets_Count;

            #endregion

            #region Start And Open Execl File

            Application_Count = new Microsoft.Office.Interop.Excel.Application();
            Workbook_Count = Application_Count.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            Sheets_Count = Workbook_Count.Worksheets;
            WorkSheet3_Count = (Microsoft.Office.Interop.Excel.Worksheet)Sheets_Count.get_Item("Sheet3");

            #endregion

            #region Find Last Row Of Data

            Microsoft.Office.Interop.Excel.Range LastRow_Count = WorkSheet3_Count.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            int LastRowUsed_Count = LastRow_Count.Row;

            #endregion

            #region Write To Excel

            DateTime CurrentDateTime_Count = DateTime.Now;
            string Date_Count = CurrentDateTime_Count.GetDateTimeFormats('d')[0];
            string Time_Count = CurrentDateTime_Count.GetDateTimeFormats('t')[0];

            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 1] = Date_Count;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 2] = Time_Count;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 3] = WorkerName_Count;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 4] = CheckedInCombobox_Dell.Text;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 5] = CheckedOutCombobox_Dell.Text;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 6] = CheckedInCombobox_Mac.Text;
            WorkSheet3_Count.Cells[LastRowUsed_Count + 1, 7] = CheckedOutCombobox_Mac.Text;

            #endregion

            #region Save And Close Excel File

            Workbook_Count.Save();
            Workbook_Count.Close(false, path, Type.Missing);

            #endregion

            this.Close();

        }
    }
}
