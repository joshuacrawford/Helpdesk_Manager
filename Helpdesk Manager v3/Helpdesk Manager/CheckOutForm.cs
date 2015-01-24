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
    public partial class CheckOutForm : Form
    {
        #region Initialization Of Outside Varibles

        DataGridView MainDataGrid_Out;
        string path;
        Microsoft.Office.Interop.Excel.Application Application_Out;
        Microsoft.Office.Interop.Excel.Workbook Workbook_Out;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet1_Out;
        Microsoft.Office.Interop.Excel.Sheets Sheets_Out;

        #endregion

        public CheckOutForm(DataGridView MDG, string location, Microsoft.Office.Interop.Excel.Application Application, Microsoft.Office.Interop.Excel.Workbook Workbook, Microsoft.Office.Interop.Excel.Worksheet Worksheet1, Microsoft.Office.Interop.Excel.Sheets Sheets)
        {
            InitializeComponent();

            #region Assignment Of Outside Varibles

            MainDataGrid_Out = MDG;
            path = location;
            Application_Out = Application;
            Workbook_Out = Workbook;
            WorkSheet1_Out = Worksheet1;
            Sheets_Out = Sheets;

            #endregion

        }

        private void SubmitButton_Out_Click(object sender, EventArgs e)
        {           
            #region Check for Incorrect inputs
            
            #region Check for empty boxes

            if (string.IsNullOrWhiteSpace(FirstNameTextbox_Out.Text) || string.IsNullOrWhiteSpace(LastNameTextbox_Out.Text) || string.IsNullOrWhiteSpace(UINTextbox_Out.Text) || string.IsNullOrWhiteSpace(LaptopMakeListbox_Out.Text) || string.IsNullOrWhiteSpace(LaptopNumberCombobox_Out.Text))
            {
                MessageBox.Show("One or more fields were not completed, couldn't continue.");
                return;
            }

            #endregion
            
            #region Check for correct character input

            if (FirstNameTextbox_Out.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your First name can not include digits.");
                FirstNameTextbox_Out.Text = "";
                return;
            }
            if (LastNameTextbox_Out.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your Last name can not include digits.");
                LastNameTextbox_Out.Text = "";
                return;
            }
            if (UINTextbox_Out.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Your UIN can not include letters.");
                UINTextbox_Out.Text = "";
                return;
            }
            if (LaptopNumberCombobox_Out.Text.Any(char.IsLetter) && LaptopNumberCombobox_Out.Text != "Charger Only")
            {
                MessageBox.Show("The laptop number can not include letters.");
                LaptopNumberCombobox_Out.Text = "";
                return;
            }

            int LaptopNumber_Out;
            if (LaptopNumberCombobox_Out.Text == "Charger Only")
                LaptopNumber_Out = 0;
            else
                LaptopNumber_Out = Int32.Parse(LaptopNumberCombobox_Out.Text);
            
            if (LaptopMakeListbox_Out.Text == "Mac" && LaptopNumber_Out > 11)
            {
                MessageBox.Show("Sorry but Mac " + LaptopNumber_Out + " does not exsit.");
                LaptopNumberCombobox_Out.Text = "";
                return;
            }
            if (LaptopMakeListbox_Out.Text == "Dell" && LaptopNumber_Out > 29)
            {
                MessageBox.Show("Sorry but Dell " + LaptopNumber_Out + " does not exsit.");
                LaptopNumberCombobox_Out.Text = "";
                return;
            }

            #endregion
            
            #region Check length of input

            if (FirstNameTextbox_Out.Text.Length > 25)
            {
                MessageBox.Show("Your First name can only be 25 characters.");
                FirstNameTextbox_Out.Text = "";
                return;
            }
            if (LastNameTextbox_Out.Text.Length > 25)
            {
                MessageBox.Show("Your Last name can only be 25 characters.");
                LastNameTextbox_Out.Text = "";
                return;
            }
            if (UINTextbox_Out.Text.Length != 9)
            {
                MessageBox.Show("Your UIN did not contain the correct number of digits.");
                UINTextbox_Out.Text = "";
                return;
            }

            #endregion

            #endregion

            #region Start and Open Execl File

            Application_Out = new Microsoft.Office.Interop.Excel.Application();
            Workbook_Out = Application_Out.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            Sheets_Out = Workbook_Out.Worksheets;
            WorkSheet1_Out = (Microsoft.Office.Interop.Excel.Worksheet)Sheets_Out.get_Item("Sheet1");

            #endregion

            #region Find Last Row of Data

            Microsoft.Office.Interop.Excel.Range LastRow_Out = WorkSheet1_Out.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            int LastRowUsed_Out = LastRow_Out.Row;

            #endregion

            #region Write to Excel

            string ChargerAnswer_Out;
            if (ChargerCheckbox_Out.Checked == true)
                ChargerAnswer_Out = "Yes";
            else
                ChargerAnswer_Out = "No";

            DateTime CurrentDateTime_Out = DateTime.Now;
            string Date_Out = CurrentDateTime_Out.GetDateTimeFormats('d')[0];
            string Time_Out = CurrentDateTime_Out.GetDateTimeFormats('t')[0];

            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 1] = Date_Out;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 2] = Time_Out;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 3] = "Checked Out";
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 4] = FirstNameTextbox_Out.Text;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 5] = LastNameTextbox_Out.Text;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 6] = UINTextbox_Out.Text;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 7] = LaptopMakeListbox_Out.Text;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 8] = LaptopNumberCombobox_Out.Text;
            WorkSheet1_Out.Cells[LastRowUsed_Out + 1, 9] = ChargerAnswer_Out;

            #endregion

            #region Save and Close Excel File

            Workbook_Out.Save();
            Workbook_Out.Close(false, path, Type.Missing);

            #endregion

            #region Write to Main DataGrid

            string LaptopMakeNumber_Out = LaptopMakeListbox_Out.Text + "    " + LaptopNumberCombobox_Out.Text;
            MainDataGrid_Out.Rows.Add(LastNameTextbox_Out.Text, FirstNameTextbox_Out.Text, LaptopMakeNumber_Out, ChargerAnswer_Out);

            #endregion

            #region Write To Check-Out file

            using (StreamWriter File_Out = File.AppendText("CheckOut_List.txt"))
            {
                File_Out.WriteLine(FirstNameTextbox_Out.Text);
                File_Out.WriteLine(LastNameTextbox_Out.Text);
                File_Out.WriteLine(UINTextbox_Out.Text);
                File_Out.WriteLine(LaptopMakeNumber_Out);
                File_Out.WriteLine(ChargerAnswer_Out);
            }	

            #endregion

            this.Close();
        }
    }
}
