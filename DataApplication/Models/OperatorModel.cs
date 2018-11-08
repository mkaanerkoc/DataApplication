using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataApplication.Models
{
    /// <summary>
    /// Serializable Operator model class holds the needed information. 
    /// </summary>
    [Serializable]
    public class OperatorModel
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }
        [XmlIgnore]
        public string Fullname
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        [XmlElement]
        public string Email { get; set; }
        [XmlElement]
        public int ID { get; set; }

        public OperatorModel()
        {

        }
        public OperatorModel( string nameParam, string surnameParam, string emailParam, int idParam)
        {
            Name = nameParam;
            Surname = surnameParam;
            Email = emailParam;
            ID = idParam;
        }
    }
}
