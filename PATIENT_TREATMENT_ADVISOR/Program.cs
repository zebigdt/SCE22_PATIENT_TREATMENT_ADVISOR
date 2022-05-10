using Excel = Microsoft.Office.Interop.Excel;
namespace PATIENT_TREATMENT_ADVISOR
{
    internal static class Program
    {
        public static readonly string db_path = Directory.GetCurrentDirectory() + @"\database.xlsx";
        public static Excel.Application? excel_Application;
        public static Excel.Workbook? excel_Workbook;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                excel_Application = new(); // Launch Excel
                ApplicationConfiguration.Initialize();
                InitializeDatabase();
                Application.Run(new UserSignInPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(excel_Workbook != null)
                {
                    excel_Workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Workbook); // Cleanup
                    excel_Workbook = null;
                }
                if (excel_Application != null)
                {
                    excel_Application.Quit(); // Quit Excel
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Application); // Cleanup
                    excel_Application = null;
                }
            }
        }

        private static void InitializeDatabase()
        {
            if (!File.Exists(db_path) && excel_Application != null) // Create new database file if it doesn't exist
            {
                Excel.Workbook new_Excel_Workbook = excel_Application.Workbooks.Add(System.Reflection.Missing.Value); // Create new Excel workbook
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)new_Excel_Workbook.Sheets[1]; // Select worksheet number 1
                excel_Worksheet.Name = "users"; // Set worksheet number 1 name
                // Add users titles
                excel_Worksheet.Cells[1, 1] = "Username";
                excel_Worksheet.Cells[1, 2] = "Password";
                excel_Worksheet.Cells[1, 3] = "ID";
                new_Excel_Workbook.Worksheets.Add(After: new_Excel_Workbook.Sheets[new_Excel_Workbook.Sheets.Count]); // Create new worksheet
                excel_Worksheet = (Excel.Worksheet)new_Excel_Workbook.Sheets[2]; // Select worksheet number 2
                excel_Worksheet.Name = "patients";// Set worksheet number 2 name
                // Add patient titles
                excel_Worksheet.Cells[1, 1] = "First Name";
                excel_Worksheet.Cells[1, 2] = "Last Name";
                excel_Worksheet.Cells[1, 3] = "ID";
                excel_Worksheet.Cells[1, 4] = "Age";
                excel_Worksheet.Cells[1, 5] = "Gender";
                excel_Worksheet.Cells[1, 6] = "Doctor ID";
                excel_Worksheet.Cells[1, 7] = "WBC";
                excel_Worksheet.Cells[1, 8] = "Neut";
                excel_Worksheet.Cells[1, 9] = "Lymph";
                excel_Worksheet.Cells[1, 10] = "RBC";
                excel_Worksheet.Cells[1, 11] = "HCT";
                excel_Worksheet.Cells[1, 12] = "Urea";
                excel_Worksheet.Cells[1, 13] = "Hb";
                excel_Worksheet.Cells[1, 14] = "Crtn";
                excel_Worksheet.Cells[1, 15] = "Iron";
                excel_Worksheet.Cells[1, 16] = "HDL";
                excel_Worksheet.Cells[1, 17] = "AP";
                excel_Worksheet.Cells[1, 18] = "Diagnosis";
                excel_Worksheet.Cells[1, 19] = "Recommendation";
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                // Save new workbook, close, and release ComObject
                new_Excel_Workbook.SaveAs2(db_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                new_Excel_Workbook.Close(false);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(new_Excel_Workbook);
                excel_Workbook = excel_Application.Workbooks.Open(db_path); //Open database
            }
            else
            {
                if(excel_Application != null)
                {
                    excel_Workbook = excel_Application.Workbooks.Open(db_path); //Open database
                }
            }
        }
    }
}