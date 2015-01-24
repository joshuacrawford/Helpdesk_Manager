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
    public partial class CheckInForm : Form
    {

        #region Initialization Of Outside Varibles

        DataGridView MainDataGrid_In;
        string path;
        Microsoft.Office.Interop.Excel.Application Application_In;
        Microsoft.Office.Interop.Excel.Workbook Workbook_In;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet1_In;
        Microsoft.Office.Interop.Excel.Sheets Sheets_In;

        #endregion

        public CheckInForm(DataGridView MDG, string location, Microsoft.Office.Interop.Excel.Application Application, Microsoft.Office.Interop.Excel.Workbook Workbook, Microsoft.Office.Interop.Excel.Worksheet Worksheet1, Microsoft.Office.Interop.Excel.Sheets Sheets)
        {
            InitializeComponent();

            #region Assignment of Outside Varibles

            MainDataGrid_In = MDG;
            path = location;
            Application_In = Application;
            Workbook_In = Workbook;
            WorkSheet1_In = Worksheet1;
            Sheets_In = Sheets;

            #endregion

            #region Load Data From Selected Row In Main DataGrid

            //if (MainDataGrid_In.SelectedRows.Count != 0)
            //{
                MainDataGrid_In.SelectedCells[0].OwningRow.Selected = true;//
                DataGridViewRow row = this.MainDataGrid_In.SelectedRows[0];
                LastNameTextbox_In.Text = row.Cells[0].Value.ToString();
                FirstNameTextbox_In.Text = row.Cells[1].Value.ToString();

                

                string LaptopMake_In = "";
                string LaptopNumber_In = "";
                string LaptopMakeandNumber_In = row.Cells[2].Value.ToString();
                for (int i = 0; i < LaptopMakeandNumber_In.Length; ++i)
                {
                    if (char.IsLetter(LaptopMakeandNumber_In[i]))
                        LaptopMake_In = LaptopMake_In + LaptopMakeandNumber_In[i];
                    if (char.IsDigit(LaptopMakeandNumber_In[i]))
                        LaptopNumber_In = LaptopNumber_In + LaptopMakeandNumber_In[i];
                }
                if (LaptopMake_In == "DellChargerOnly")
                {
                    LaptopMakeListbox_In.Text = "Dell";
                    LaptopNumberCombobox_In.Text = "Charger Only";
                }
                else if (LaptopMake_In == "MacChargerOnly")
                {
                    LaptopMakeListbox_In.Text = "Mac";
                    LaptopNumberCombobox_In.Text = "Charger Only";
                }
                else
                {
                    LaptopMakeListbox_In.Text = LaptopMake_In;
                    LaptopNumberCombobox_In.Text = LaptopNumber_In;
                }

                if (row.Cells[3].Value.ToString() == "Yes")
                    ChargerCheckbox_In.Checked = true;
                else
                    ChargerCheckbox_In.Checked = false;

                UINTextbox_In.Select();//
            //}

            #endregion
        }

        private void SubmitButton_Out_Click(object sender, EventArgs e)
        {
            #region Check For Incorrect Inputs

            #region Check For Empty Boxes

            if (string.IsNullOrWhiteSpace(FirstNameTextbox_In.Text) || string.IsNullOrWhiteSpace(LastNameTextbox_In.Text) || string.IsNullOrWhiteSpace(UINTextbox_In.Text) || string.IsNullOrWhiteSpace(LaptopMakeListbox_In.Text) || string.IsNullOrWhiteSpace(LaptopNumberCombobox_In.Text))
            {
                MessageBox.Show("One or more fields were not completed, couldn't continue.");
                return;
            }

            #endregion

            #region Check For Correct Character Input

            if (FirstNameTextbox_In.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your First name can not include digits.");
                FirstNameTextbox_In.Text = "";
                return;
            }
            if (LastNameTextbox_In.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Your Last name can not include digits.");
                LastNameTextbox_In.Text = "";
                return;
            }
            if (UINTextbox_In.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Your UIN can not include letters.");
                UINTextbox_In.Text = "";
                return;
            }
            if (LaptopNumberCombobox_In.Text.Any(char.IsLetter) && LaptopNumberCombobox_In.Text != "Charger Only")
            {
                MessageBox.Show("The laptop number can not include letters.");
                LaptopNumberCombobox_In.Text = "";
                return;
            }

            int LaptopNumber_In;
            if (LaptopNumberCombobox_In.Text == "Charger Only")
                LaptopNumber_In = 0;
            else
                LaptopNumber_In = Int32.Parse(LaptopNumberCombobox_In.Text);

            if (LaptopMakeListbox_In.Text == "Mac" && LaptopNumber_In > 11)
            {
                MessageBox.Show("Sorry but Mac " + LaptopNumber_In + " does not exsit.");
                LaptopNumberCombobox_In.Text = "";
                return;
            }
            if (LaptopMakeListbox_In.Text == "Dell" && LaptopNumber_In > 29)
            {
                MessageBox.Show("Sorry but Dell " + LaptopNumber_In + " does not exsit.");
                LaptopNumberCombobox_In.Text = "";
                return;
            }

            #endregion

            #region Check Length Of Input

            if (FirstNameTextbox_In.Text.Length > 25)
            {
                MessageBox.Show("Your First name can only be 25 characters.");
                FirstNameTextbox_In.Text = "";
                return;
            }
            if (LastNameTextbox_In.Text.Length > 25)
            {
                MessageBox.Show("Your Last name can only be 25 characters.");
                LastNameTextbox_In.Text = "";
                return;
            }
            if (UINTextbox_In.Text.Length != 9)
            {
                MessageBox.Show("Your UIN did not contain the correct number of digits.");
                UINTextbox_In.Text = "";
                return;
            }

            #endregion

            #endregion

            #region Find Data In Temp File

            string ChargerAnswer_In;
            if (ChargerCheckbox_In.Checked == true)
                ChargerAnswer_In = "Yes";
            else
                ChargerAnswer_In = "No";

            string LaptopMakeNumber_In = LaptopMakeListbox_In.Text + "    " + LaptopNumberCombobox_In.Text;

            System.IO.StreamReader file = new System.IO.StreamReader("CheckOut_List.txt");
            string line, FirstTest, LastTest, UINTest, LaptopTest, ChargerTest; 
            int line_count=0;
            int match = 0;
            while ((line = file.ReadLine()) != null)
            {
                FirstTest = line;
                LastTest = file.ReadLine();
                UINTest = file.ReadLine();
                LaptopTest = file.ReadLine();
                ChargerTest = file.ReadLine();

                if(FirstNameTextbox_In.Text == FirstTest)
                {
                    if(LastNameTextbox_In.Text == LastTest)
                    {
                        if(UINTextbox_In.Text == UINTest)
                        {
                            if(LaptopMakeNumber_In == LaptopTest)
                            {
                                if(ChargerAnswer_In == ChargerTest)
                                {
                                    match = 1;
                                }
                            }
                        }
                    }
                }
                if (match == 0)
                {
                    line_count = line_count + 5;
                }
            }
            file.Close();

            if (match == 0)
            {
                MessageBox.Show("Sorry the information you provided does not match our records. Please try again");
                return;
            }



            #endregion

            #region Start And Open Execl File

            Application_In = new Microsoft.Office.Interop.Excel.Application();
            Workbook_In = Application_In.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            Sheets_In = Workbook_In.Worksheets;
            WorkSheet1_In = (Microsoft.Office.Interop.Excel.Worksheet)Sheets_In.get_Item("Sheet1");

            #endregion

            #region Find Last Row Of Data

            Microsoft.Office.Interop.Excel.Range LastRow_In = WorkSheet1_In.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            int LastRowUsed_In = LastRow_In.Row;

            #endregion

            #region Write To Excel

            DateTime CurrentDateTime_In = DateTime.Now;
            string Date_In = CurrentDateTime_In.GetDateTimeFormats('d')[0];
            string Time_In = CurrentDateTime_In.GetDateTimeFormats('t')[0];

            WorkSheet1_In.Cells[LastRowUsed_In + 1, 1] = Date_In;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 2] = Time_In;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 3] = "Checked In";
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 4] = FirstNameTextbox_In.Text;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 5] = LastNameTextbox_In.Text;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 6] = UINTextbox_In.Text;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 7] = LaptopMakeListbox_In.Text;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 8] = LaptopNumberCombobox_In.Text;
            WorkSheet1_In.Cells[LastRowUsed_In + 1, 9] = ChargerAnswer_In;

            #endregion

            #region Save And Close Excel File

            Workbook_In.Save();
            Workbook_In.Close(false, path, Type.Missing);

            #endregion

            #region Delete Row From Main DataGrid

            int RemoveCheck = 0;
            int Row_In =0 ;
            for (int ro = 0; ro < MainDataGrid_In.RowCount; ro++)
            {
                if (LaptopMakeListbox_In.Text + "    " + LaptopNumberCombobox_In.Text == MainDataGrid_In.Rows[ro].Cells[2].Value.ToString()){
                    RemoveCheck = 1;
                    Row_In = ro;
                }
            }
            if (RemoveCheck == 1)
                MainDataGrid_In.Rows.RemoveAt(Row_In);
            else
            {
                MessageBox.Show("That Laptop is not Checked Out");
                return;
            }

            #endregion

            #region Delete From Check-Out List

            List<string> linesList = File.ReadAllLines("CheckOut_List.txt").ToList();

            for (int i = 0; i < 5; ++i)
            {
                linesList.RemoveAt(line_count);
            }

            File.WriteAllLines(("CheckOut_List.txt"), linesList.ToArray());

            #endregion

            this.Close();
        }

        #region Where I Double Clicked Labels

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChargerLabel_Out_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
