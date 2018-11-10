using DataApplication.DataWriter;
using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Factories
{
    public class DataWriterFactory
    {
        public static IDataWriter CreateDataWriter( string fileName, DataStorageType typeParam )
        {
            IDataWriter retVal = null;
            if( typeParam == DataStorageType.CSV_FILE )
            {
                retVal = new CSVWriter( fileName, ";" );
            }
            else if( typeParam == DataStorageType.EXCEL_FILE )
            {
                retVal = new ExcelWriter( fileName );
            }
            else if( typeParam == DataStorageType.SQL_DATABASE )
            {
                throw new NotImplementedException("SQL Database not implemented yet ");
            }
            else
            {
                throw new NotImplementedException("Unknown DataStorageType received " + typeParam);
            }
            return retVal;
        }
    }
}
