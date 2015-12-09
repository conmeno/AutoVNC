using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NPNDAutoVNC
{
    class CTLImportFileCSV
    {
        public static string sqlConnString = @"server=(local);
	database=Test_CSV_impex;Trusted_Connection=True";
        public DataSet LoadCSV(int numberOfRows)
{
	DataSet ds = new DataSet();
	try
	{
		// Creates and opens an ODBC connection
		string strConnString = @"Driver={Microsoft Text Driver (*.txt; *.csv)};
			Dbq=" +Path.Combine(Application.StartupPath,"DS Folder.csv") + @";
			Extensions=asc,csv,tab,txt;Persist Security Info=False";
		string sql_select;
		OdbcConnection conn;
		conn = new OdbcConnection(strConnString.Trim());
		conn.Open();

		//Creates the select command text
		if (numberOfRows == -1)
		{
			sql_select = "select * from [" +
                    "list.csv" + "]";
		}
		else
		{
			sql_select = "select top " + numberOfRows +
                " * from [" + "list.csv" + "]";
		}

		//Creates the data adapter
		OdbcDataAdapter obj_oledb_da = new OdbcDataAdapter(sql_select, conn);
				
		//Fills dataset with the records from CSV file
		obj_oledb_da.Fill(ds, "csv");
				
		//closes the connection
		conn.Close();
	}
	catch (Exception e) //Error
	{
	    CtlError.WriteError("LoadCSV ", e.Message);
	    return null;
	    //MessageBox.Show(e.Message, "Error - LoadCSV",
	    //        MessageBoxButtons.OK,MessageBoxIcon.Error);
	}
	return ds;
}
        public static DataTable ReadFromCsv(string fileName, Encoding encoding, char separator)
        {
            DataTable table = null;

            if (fileName != null &&
            !fileName.Equals(string.Empty) &&
            File.Exists(fileName))
            {
                try
                {
                    // If required, you can collect some useful info from the file
                    FileInfo info = new FileInfo(fileName);
                    string tableName = info.Name;

                    // Prepare for the data to be processed into a DataTable
                    // We don't know how many records there are in the .csv, so we
                    // use a List<string> to store the records in it temporarily.
                    // We also prepare a DataTable;
                    List<string> rows = new List<string>();

                    // Then we read in the raw data
                    StreamReader reader = new StreamReader(fileName, encoding);
                    string record = reader.ReadLine();
                    while (record != null)
                    {
                        rows.Add(record);
                        record = reader.ReadLine();
                    }

                    // And we split it into chuncks.
                    // Note that we keep track of the number of columns
                    // in case the file has been tampered with, or has been made
                    // in a weird kind of way (believe me: this does happen)

                    // Here we will store the converted rows
                    List<string[]> rowObjects = new List<string[]>();

                    int maxColsCount = 0;
                    foreach (string s in rows)
                    {
                        string[] convertedRow = s.Split(new char[] { separator });
                        if (convertedRow.Length > maxColsCount)
                            maxColsCount = convertedRow.Length;
                        rowObjects.Add(convertedRow);
                    }

                    // Then we build the table
                    table = new DataTable(tableName);
                    //for (int i = 0; i < maxColsCount; i++)
                    //{
                    //    // Change this if you want other datatypes
                    //    // make sure you also convert the string[] to
                    //    // the corect datataype
                    //    table.Columns.Add(new DataColumn("Folder"));
                    //}

                    foreach (string[] rowArray in rowObjects)
                    {
                        table.Rows.Add(rowArray);
                    }
                    table.AcceptChanges();
                }
                catch(Exception exception)
                {
                    throw new Exception("Error in ReadFromCsv: IO error.");
                }
            }
            else
            {
                throw new FileNotFoundException("Error in ReadFromCsv: the file path could not be found.");
            }
            return table;
        }
    }
}
