using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Microsoft.Data.Analysis;
using System.Diagnostics;

namespace DataClassLibrary2024
{
    public struct CSVConfig
    {
        public bool header = true;
        public char separator = ',';
        public string comment = "#";
        public string nullValue = "";
        public string trueValue = "true";
        public string falseValue = "false";
        public char delimiter = ';';
        public char decimalSeparator = '.';

        public CSVConfig() { }
    }
    public class DataFromFile
    {
        public int Id { get; set; } = 0;
        public string FileName { get; set; } = "";

        public CSVConfig CSVCfg { get; set; } = new CSVConfig();
        
        public Microsoft.Data.Analysis.DataFrame DF { get; set; } = new DataFrame();

        public void SelectFile()
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt;*.csv)|*.txt;*.csv|All files (*.*)|*.*";
            openDialog.Title = "Open text file";
            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openDialog.FileName;
                OpenFile();
            }
        }

        public void OpenFile()
        {
            if(File.Exists(FileName))
            {
                DF = DataFrame.LoadCsv(FileName, separator: CSVCfg.separator, header: true, encoding: Encoding.UTF8);
            }
        }
        public List<string> GetColumns()
        {
            var res = new List<string>();
            foreach (var col in DF.Columns)
            {
                res.Add(col.Name);
            }
            return res;
        }

        public int GetId(string columnName)
        {
            return DF.Columns.IndexOf(columnName);
        }
        public string GetColumnName(int id = 0)
        {
            return DF.Columns[id].Name;
        }
        bool IfExists(string columnName) => GetId(columnName) >=0? true : false;
        
        // get type of column
        public string GetColumnType(string columnName)
        {
            if (IfExists(columnName))
            {
                return DF.Columns[GetId(columnName)].DataType.Name;
            }
            return string.Empty;
        }

    }
}
