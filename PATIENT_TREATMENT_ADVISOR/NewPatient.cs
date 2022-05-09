﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(IDBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    IDBox.Text = IDBox.Text.Remove(IDBox.Text.Length - 1);
                    IDBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                IDBox.Text = "";
                IDBox.Focus();
            }
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(FirstNameBox.Text, "[^\u0590-\u05FF -]"))
                {
                    MessageBox.Show("אנא הכנס שם פרטי בעברית");
                    FirstNameBox.Text = FirstNameBox.Text.Remove(FirstNameBox.Text.Length - 1);
                    FirstNameBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                FirstNameBox.Text = "";
                FirstNameBox.Focus();
            }

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(LastNameBox.Text, "[^\u0590-\u05FF -]"))
                {
                    MessageBox.Show("אנא הכנס שם משפחה בעברית");
                    LastNameBox.Text = LastNameBox.Text.Remove(LastNameBox.Text.Length - 1);
                    LastNameBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                LastNameBox.Text = "";
                LastNameBox.Focus();
            }
        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(AgeBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    AgeBox.Text = AgeBox.Text.Remove(AgeBox.Text.Length - 1);
                    AgeBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                AgeBox.Text = "";
                AgeBox.Focus();
            }
        }

        private void WBCBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(WBCBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    WBCBox.Text = WBCBox.Text.Remove(WBCBox.Text.Length - 1);
                    WBCBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                WBCBox.Text = "";
                WBCBox.Focus();
            }
        }

        private void NeutBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(NeutBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    NeutBox.Text = NeutBox.Text.Remove(NeutBox.Text.Length - 1);
                    NeutBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                NeutBox.Text = "";
                NeutBox.Focus();
            }
        }

        private void LymphBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(LymphBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    LymphBox.Text = LymphBox.Text.Remove(LymphBox.Text.Length - 1);
                    LymphBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                LymphBox.Text = "";
                LymphBox.Focus();
            }
        }

        private void RBCBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(RBCBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    RBCBox.Text = RBCBox.Text.Remove(RBCBox.Text.Length - 1);
                    RBCBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                RBCBox.Text = "";
                RBCBox.Focus();
            }
        }

        private void HCTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(HCTBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    HCTBox.Text = HCTBox.Text.Remove(HCTBox.Text.Length - 1);
                    HCTBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                HCTBox.Text = "";
                HCTBox.Focus();
            }
        }

        private void UreaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(UreaBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    UreaBox.Text = UreaBox.Text.Remove(UreaBox.Text.Length - 1);
                    UreaBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                UreaBox.Text = "";
                UreaBox.Focus();
            }
        }

        private void HbBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(HbBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    HbBox.Text = HbBox.Text.Remove(HbBox.Text.Length - 1);
                    HbBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                HbBox.Text = "";
                HbBox.Focus();
            }
        }

        private void CrtnBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(CrtnBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    CrtnBox.Text = CrtnBox.Text.Remove(CrtnBox.Text.Length - 1);
                    CrtnBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                CrtnBox.Text = "";
                CrtnBox.Focus();
            }
        }

        private void IronBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(IronBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    IronBox.Text = IronBox.Text.Remove(IronBox.Text.Length - 1);
                    IronBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                IronBox.Text = "";
                IronBox.Focus();
            }
        }

        private void HDLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(HDLBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    HDLBox.Text = HDLBox.Text.Remove(HDLBox.Text.Length - 1);
                    HDLBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                HDLBox.Text = "";
                HDLBox.Focus();
            }
        }

        private void APBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(APBox.Text, "[^0-9.]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    APBox.Text = APBox.Text.Remove(APBox.Text.Length - 1);
                    APBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                APBox.Text = "";
                APBox.Focus();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Excel.Application excel_Application = new(); // Launch Excel
            Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(FileDialog.FileName); //Open database
            Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.ActiveSheet; // Select active sheet
            WBCBox.Text = (excel_Worksheet.Cells[2, 1].Value2).ToString();
            NeutBox.Text = (excel_Worksheet.Cells[2, 2].Value2).ToString();
            LymphBox.Text = (excel_Worksheet.Cells[2, 3].Value2).ToString();
            RBCBox.Text = (excel_Worksheet.Cells[2, 4].Value2).ToString();
            HCTBox.Text = (excel_Worksheet.Cells[2, 5].Value2).ToString();
            UreaBox.Text = (excel_Worksheet.Cells[2, 6].Value2).ToString();
            HbBox.Text = (excel_Worksheet.Cells[2, 7].Value2).ToString();
            CrtnBox.Text = (excel_Worksheet.Cells[2, 8].Value2).ToString();
            IronBox.Text = (excel_Worksheet.Cells[2, 9].Value2).ToString();
            HDLBox.Text = (excel_Worksheet.Cells[2, 10].Value2).ToString();
            APBox.Text = (excel_Worksheet.Cells[2, 11].Value2).ToString();
            excel_Application.Quit();
        }
    }
}
