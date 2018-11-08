using DataApplication.Devices;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataApplication.Models
{
    public class ConfigurationModel
    {
        [XmlIgnore]
        public List<DeviceModel> devices { get; set; }
        [XmlArray("Operator")]
        public List<OperatorModel> operators { get; set; }
        [XmlArray("Facilities")]
        public List<FacilityModel> facilities { get; set; }
        public double FontSize { get; set; }
        
        public ConfigurationModel()
        {
            devices = new List<DeviceModel>();
            operators = new List<OperatorModel>();
            facilities = new List<FacilityModel>();
        }
    }
}
