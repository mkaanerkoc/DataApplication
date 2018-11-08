using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using DataApplication.Models;

namespace DataApplication.ApplicationManager
{
    public class ConfigurationManager
    {
        public static ConfigurationModel config;


        public ConfigurationManager()
        {
            config = new ConfigurationModel();

        }

        public int ParseConfigXML()
        {
            int retVal = 0;
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationModel));
            StreamReader reader = new StreamReader("app_config.xml");
            config = (ConfigurationModel)serializer.Deserialize(reader);
            config.devices = DeviceInformations.devices;
            reader.Close();
            reader.Dispose();
            return retVal;
        }

        public int CreateNewConfigFile()
        {
            int retVal = 0;
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationModel));
            Stream outStream = new FileStream(@"app_config.xml", FileMode.Create);
            serializer.Serialize(outStream, config);
            outStream.Close();
            return retVal;
        }

        public DeviceModel GetDeviceModel(string deviceName)
        {
            DeviceModel retValTemp;
            retValTemp = config.devices.Where(x => x.DisplayName.Equals(deviceName)).FirstOrDefault();
            if (retValTemp == null)
            {
                throw new DeviceModelNotFoundException("Logfile cannot be read-only");
            }
            return config.devices.Where(x => x.DisplayName.Equals(deviceName)).FirstOrDefault();
        }
    }
}
