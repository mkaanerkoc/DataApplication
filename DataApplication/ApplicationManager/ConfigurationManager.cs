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
            XmlSerializer serializer = new XmlSerializer(typeof(List<DeviceModel>));
            StreamReader reader = new StreamReader("app_config.xml");
            config.devices = (List<DeviceModel>)serializer.Deserialize(reader);
            reader.Close();
            reader.Dispose();
            return retVal;
        }

        public int CreateNewConfigFile()
        {
            int retVal = 0;

            XmlSerializer oSerialiser = new XmlSerializer(typeof(List<DeviceModel>));

            Stream oStream = new FileStream(@"app_config.xml", FileMode.Create);

            oSerialiser.Serialize(oStream, config.devices);

            oStream.Close();


            return retVal;
        }

        public DeviceModel GetDeviceModel(string deviceName)
        {
            DeviceModel retValTemp;
            retValTemp = config.devices.Where(x => x.Name.Equals(deviceName)).FirstOrDefault();
            if (retValTemp == null)
            {
                throw new DeviceModelNotFoundException("Logfile cannot be read-only");
            }
            return config.devices.Where(x => x.Name.Equals(deviceName)).FirstOrDefault();
        }
    }

    public class ConfigurationModel
    {
        public List<DeviceModel> devices { get; set; }
        public List<OperatorModel> operators { get; set; }
        public List<FacilityModel> facilities { get; set; }
        public ConfigurationModel()
        {
            devices = new List<DeviceModel>();
            operators = new List<OperatorModel>();
            facilities = new List<FacilityModel>();
        }
    }

}
