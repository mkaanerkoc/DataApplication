using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    /*
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    public enum PG250ChannelType
    {
        
    }
    public class PG250Information
    {
        public static ReadOnlyDictionary<int, string> dataChannelsByIndexes = new ReadOnlyDictionary<int, string>(
                new Dictionary<int, string> {
                    { 0, "NO" },
                    { 1, "NOx" },
                    { 2, "Correlated NO" },
                    { 3, "Correlated NOx" },
                    { 4, "CO" },
                    { 5, "CO2" },
                    { 6, "O2" },
                    { 7, "SO2" },
                    { 8, "Correlated SO2" }
                });
        public static ReadOnlyDictionary<int, string> diagnosticChannelsByIndexes = new ReadOnlyDictionary<int, string>(
              new Dictionary<int, string> {
                    { 0, "FlowRate" },
                    { 1, "Temperature" }
              });
        public static ReadOnlyDictionary<string, int> dataChannelsByNames = new ReadOnlyDictionary<string, int>(
               new Dictionary<string, int> {
                    { "NO", 0 },
                    { "NOx", 1 },
                    { "Correlated NO", 2 },
                    { "Correlated NOx", 3 },
                    { "CO", 4 },
                    { "CO2", 5 },
                    { "O2", 6 },
                    { "SO2", 7 },
                    { "Correlated SO2", 8 },
               });
        public static ReadOnlyDictionary<string, int> diagnosticChannelsByNames = new ReadOnlyDictionary<string, int>(
               new Dictionary<string, int> {
                    { "FlowRate", 0 },
                    { "Temperature", 1 },
               });
        /*
         *             parameterTable.Add(new PG250Param(9, "FlowRate"));
            parameterTable.Add(new PG250Param(10, "Temperature"));*/
    }
}
