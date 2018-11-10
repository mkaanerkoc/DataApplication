using System;
using System.Collections.Generic;
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
        [XmlElement]
        public int ID { get; set; }
        [XmlArray]
        public List<MeasurementPointModel> Points { get; set; }
        [XmlIgnore]
        public string ListDisplay {
            get
            {
                return  Name + " - " + City;
            }
        }

        public FacilityModel()
        {
            Points = new List<MeasurementPointModel>();
        }
        public FacilityModel( string nameParam, string cityParam, int idParam )
        {
            Points = new List<MeasurementPointModel>();
            Name = nameParam;
            City = cityParam;
            ID = idParam;
        }

    }
}
