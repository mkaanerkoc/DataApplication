using System;
using System.Xml.Serialization;

namespace DataApplication.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class FacilityModel
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement]
        public string City { get; set; }

        [XmlIgnore]
        public string ListDisplay {
            get
            {
                return  Name + " - " + City;
            }
        }

        public FacilityModel()
        {

        }
        public FacilityModel( string nameParam, string cityParam )
        {
            Name = nameParam;
            City = cityParam;
        }

    }
}
