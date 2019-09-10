using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExPortExcelOrCSV
{
    public partial class Form1 : Form
    {
        private string numberPattern = " ({0})";
        private List<Customer> sampledata = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
            CreateData();
            CustomerDetailsDataGridView.DataSource = sampledata;
        }

        #region data
        public class Customer
        {
            public string EmailAddress { get; set; }
            public string FirstName { get; set; }
            public int Id { get; set; }
            public string LastName { get; set; }
            public string TelephoneNumber { get; set; }
        }
        private void CreateData()
        {
            for (int i = 1; i < 300; i++)
            {
                Customer cust = new Customer
                {
                    EmailAddress = "khanal.pashupati" + i + "@gmail.com",
                    FirstName = "Pashupati" + i,
                    Id = i,
                    LastName = "Khanal" + i,
                    TelephoneNumber = "980000000" + i
                };
                sampledata.Add(cust);
            }
        }
        #endregion

        private void lblExportAsCSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (sampledata.Count() > 0)
                {
                    string fileName = "Commit Details_CSV";
                    string finalPath = GetFinalFilePath(fileName, false, true);
                    ExportCsv(sampledata, finalPath);
                    ShowAlertMessage("Export completed Successfully!", exportStatus.success);
                }
                else
                {
                    string errormessage = "Export Failed! No Data to Export";
                    ShowAlertMessage(errormessage, exportStatus.nodata);
                }
            }
            catch (Exception exe)
            {
                string errormessage = "Export Failed! Something went wrong. Please try Later";
                ShowAlertMessage(errormessage, exportStatus.failed);
            }
        }
        private void lblExportAsExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (sampledata.Count() > 0)
                {
                    string fileName = "Commit Details_Excel";
                    string finalPath = GetFinalFilePath(fileName, true, false);
                    ExportExcel(sampledata, finalPath);
                    ShowAlertMessage("Export completed Successfully!", exportStatus.success);
                }
                else
                {
                    string errormessage = "Export Failed! No Data to Export";
                    ShowAlertMessage(errormessage, exportStatus.nodata);
                }

            }
            catch (Exception exe)
            {
                string errormessage = "Export Failed! Something went wrong. Please try Later";
                ShowAlertMessage(errormessage, exportStatus.failed);
            }
        }
      
        public void ExportCsv<T>(List<T> genericList, string fileName)
        {
            var sb = new StringBuilder();

            //header
            var header = "";
            var info = typeof(T).GetProperties();
            foreach (var prop in info)
            {
                header +=  prop.Name+ ", ";
            }
            header = header.Substring(0, header.Length - 2);
            sb.AppendLine(header);
            TextWriter sw = new StreamWriter(fileName, true);
            sw.Write(sb.ToString());
            //data
            foreach (var obj in genericList)
            {
                sb = new StringBuilder();
                var line = "";
                foreach (var prop in info)
                {
                    line += prop.GetValue(obj, null) + ", ";
                }
                line = line.Substring(0, line.Length - 2);
                sb.AppendLine(line);
                sw.Write(sb.ToString());

            }
            sw.Close();
        }
        private void ExportExcel<T>(List<T> data, string fileName)
        {
            var info = typeof(T).GetProperties();
            var headertitles = info.Select(x => x.Name);
            List<string> orginalheader = new List<string>();
            //header
            foreach (var header in headertitles)
            {
                orginalheader.Add(header);
            }
            var titles = new List<string[]> { orginalheader.ToArray() };
            //Inizializar Librerias
            var wb = new XLWorkbook(); //create workbook
            var ws = wb.Worksheets.Add("CommitDetails"); //add worksheet to workbook
                                                         //Insert header
            ws.Cell(1, 1).InsertData(titles); //insert titles to first row
                                              //insert data to from second row on
            ws.Cell(2, 1).InsertData(data);
            ws.Columns().AdjustToContents();
            wb.SaveAs(fileName);
        }

        private void ShowAlertMessage(string message, exportStatus exportstatus)
        {
            switch (exportstatus)
            {
                case exportStatus.success:
                    MessageBox.Show(
                this, message, "Deployer", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case exportStatus.failed:
                    MessageBox.Show(
                this, message, "Deployer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case exportStatus.nodata:
                    MessageBox.Show(
                this, message, "Deployer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    break;

            }
        }

        #region Filename
        private string GetFinalFilePath(string fileName, bool isExcel, bool isCSV)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(basePath + "Exports\\", fileName);
            string finalPath = string.Empty;
            if (isCSV)
            {
                finalPath = path + ".csv";
            }
            else if (isExcel)
            {
                finalPath = path + ".xlsx";
            }
            finalPath = NextAvailableFilename(finalPath);
            FileInfo file = new FileInfo(finalPath);
            file.Directory.Create();
            return finalPath;
        }
        private string NextAvailableFilename(string path)
        {
            // Short-cut if already available
            if (!File.Exists(path))
                return path;

            // If path has extension then insert the number pattern just before the extension and return next filename
            if (Path.HasExtension(path))
                return GetNextFilename(path.Insert(path.LastIndexOf(Path.GetExtension(path)), numberPattern));

            // Otherwise just append the pattern to the path and return next filename
            return GetNextFilename(path + numberPattern);
        }
        private string GetNextFilename(string pattern)
        {
            string tmp = string.Format(pattern, 1);
            if (tmp == pattern)
                throw new ArgumentException("The pattern must include an index place-holder", "pattern");

            if (!File.Exists(tmp))
                return tmp; // short-circuit if no matches

            int min = 1, max = 2; // min is inclusive, max is exclusive/untested

            while (File.Exists(string.Format(pattern, max)))
            {
                min = max;
                max *= 2;
            }

            while (max != min + 1)
            {
                int pivot = (max + min) / 2;
                if (File.Exists(string.Format(pattern, pivot)))
                    min = pivot;
                else
                    max = pivot;
            }

            return string.Format(pattern, max);
        }
        #endregion

        enum exportStatus
        {
            success,
            failed,
            nodata,
        }
    }
}

