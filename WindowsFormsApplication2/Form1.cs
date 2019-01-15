using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog duke = new OpenFileDialog();
        List<string> SheetName = new List<string>();

        private void btnOpenXls_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;

            if (duke.ShowDialog() == DialogResult.OK)
            {

                txtExcelName.Text = duke.FileName;
                duke.Filter = "*.xls|*.xls";

                GetSheetName(duke.FileName);
                ReadExcelData(duke.FileName);

            }
        }

        public void ReadExcelData(string excelFile)
        {
            DataTable dt = new DataTable();

            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;";

            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            OleDbDataAdapter mycommand = null;

            string strExcel = "";


            strExcel = string.Format("select * from [{0}]", SheetName[0].ToString());
            mycommand = new OleDbDataAdapter(strExcel, strConn);
            mycommand.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();

        }

        public void GetSheetName(string excelFile)
        {
            OleDbConnection oleDbConn = null;
            DataTable dataTable = null;

            String connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;";

            oleDbConn = new OleDbConnection(connString);
            oleDbConn.Open();
            dataTable = oleDbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            if (dataTable == null)
            {
                richTextBox1.AppendText("No table\r\n");
            }
            foreach (DataRow row in dataTable.Rows)
            {
                richTextBox1.AppendText(row["TABLE_NAME"].ToString() + "\r\n");

                SheetName.Add(row["TABLE_NAME"].ToString());
            }

            oleDbConn.Close();
        }

    }
}
