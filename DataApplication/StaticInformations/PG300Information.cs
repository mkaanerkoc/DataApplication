using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public class PG300Information
    {

        public static ReadOnlyDictionary<int, string> dataChannelsByIndexes = new ReadOnlyDictionary<int, string>(
               new Dictionary<int, string> {
                    { 1, "NO" },
                    { 2, "Converted NO" },
                    { 3, "NO avg" },
                    { 4, "Converted NO avg" },

                    { 9, "NOx" },
                    { 10, "Conveted NOx" },
                    { 11, "NOx avg" },
                    { 12, "Converted NOx avg" },

                    { 13, "SO2" },
                    { 14, "Conveted SO2" },
                    { 15, "SO2 avg" },
                    { 16, "Converted SO2 avg" },

                    { 17, "CH4" },
                    { 19, "CH4 avg" },

                    { 21, "CO" },
                    { 22, "Conveted CO" },
                    { 23, "CO avg" },
                    { 24, "Converted CO avg" },

                    { 25, "CO2" },
                    { 27, "CO2 avg" },

                    { 29, "O2" },
                    { 31, "O2 avg" },

               });
        public static ReadOnlyDictionary<int, string> diagnosticChannelsByIndexes = new ReadOnlyDictionary<int, string>(
              new Dictionary<int, string> {
                    { 0, "---" },
                    { 1, "---" }
              });
        public static ReadOnlyDictionary<string, int> dataChannelsByNames = new ReadOnlyDictionary<string, int>(
               new Dictionary<string, int> {
                    { "NO",                  1 },
                    { "Converted NO",        2 },
                    { "NO avg",              3 },
                    { "Converted NO avg",    4 },

                    { "NOx",                 9 },
                    { "Converted NOx",       10 },
                    { "NOx avg",             11 },
                    { "Converted NOx avg",   12 },

                    { "SO2",                 13 },
                    { "Converted SO2",       14 },
                    { "SO2 avg",             15 },
                    { "Converted SO2 avg",   16 },

                    { "CH4",                 17 },
                    { "CH4 avg",             19 },

                    { "CO",                  21 },
                    { "Converted CO",        22 },
                    { "CO avg",              23 },
                    { "Converted CO avg",    24 },

                    { "CO2 avg",             25 },
                    { "Converted CO2 avg",   27 },

                    { "O2 avg",              29 },
                    { "Converted O2 avg",    31 }
               });
        public static ReadOnlyDictionary<string, int> diagnosticChannelsByNames = new ReadOnlyDictionary<string, int>(
               new Dictionary<string, int> {
                    { "---", 0 },
                    { "---", 1 },
               });
    }
}
