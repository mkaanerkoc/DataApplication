using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataApplication.Models
{
    [Serializable]
    public class MeasurementPointModel
    {
        [XmlIgnore]
        private FacilityModel factory;
        [XmlAttribute]
        public string Name { get; set; }
        public int ID { get; set; }

        public MeasurementPointModel( string nameParam, int idParam )
        {
            Name = nameParam;
            ID = idParam;
        }
        public MeasurementPointModel()
        {

        }
    }
}
