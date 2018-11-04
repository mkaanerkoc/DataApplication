using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;

namespace DataApplication.ApplicationManager
{
    public class ConfigurationManager
    {
        private XmlTextReader textReader;
        public List<DeviceModel> devices;

        public ConfigurationManager()
        {
            
        }

        public int ParseConfigXML()
        {
            int retVal = 0;
            textReader = new XmlTextReader("app_config.xml");
            while (textReader.Read())
            {
                
            }
            return retVal;
        }

        public int CreateNewConfigFile()
        {
            int retVal = 0;
            return retVal;
        }

        public DeviceModel GetDeviceModel( string deviceName )
        {
            DeviceModel retValTemp;
            retValTemp = devices.Where(x => x.Name.Equals(deviceName)).FirstOrDefault();
            if( retValTemp == null )
            {
                throw new DeviceModelNotFoundException("Logfile cannot be read-only");
            }
            return devices.Where(x => x.Name.Equals(deviceName)).FirstOrDefault();
        }


    }

 
}
