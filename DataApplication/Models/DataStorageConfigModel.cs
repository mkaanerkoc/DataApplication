using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Models
{
    public enum DataStorageType
    {
        CSV_FILE,
        EXCEL_FILE,
        SQL_DATABASE
    }

    public class DataStorageConfigModel
    {
        public string Name { get; set; }
        public DataStorageType Type { get; set; }
        public string Extension { get; set; }
       
        public DataStorageConfigModel(  DataStorageType typeParam )
        {
            Type = typeParam;
            if ( typeParam == DataStorageType.CSV_FILE )
            {
                Name = "CSV Dosyası";
                Extension = ".csv";
            }
            else if( typeParam == DataStorageType.EXCEL_FILE )
            {
                Name = "Excel Dosyası";
                Extension = ".xlsx";
            }
            else if( typeParam == DataStorageType.SQL_DATABASE )
            {
                Name = "SQL Veritabanı";
                Extension = ".sql";
            }
        }
    }
}
