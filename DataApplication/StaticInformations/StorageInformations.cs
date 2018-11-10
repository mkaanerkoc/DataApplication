using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.StaticInformations
{
    public class StorageInformations
    {
        public static readonly List<DataStorageConfigModel> storageOptions = new List<DataStorageConfigModel>()
        {
            { new DataStorageConfigModel( DataStorageType.CSV_FILE ) },
            { new DataStorageConfigModel( DataStorageType.EXCEL_FILE ) },
            { new DataStorageConfigModel( DataStorageType.SQL_DATABASE ) }
        };
    }
}
