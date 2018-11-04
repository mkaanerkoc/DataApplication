using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public abstract class WritableBase
    {
        public override abstract string ToString();
        public string alias { get; set; }

    }
}
