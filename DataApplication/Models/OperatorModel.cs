using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Models
{
    public class OperatorModel
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        public string Email { get; set; }
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
