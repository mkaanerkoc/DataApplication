using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class Writable<T> : IWritable
    {
        private T _value;
        private string _alias;
        private int _uniqueId;

        public Writable( T valueParam, string aliasParam, int uniqueIdParam )
        {
            _value = valueParam;
            _alias = aliasParam;
            _uniqueId = uniqueIdParam;
        }

        public Type Type()
        {
            return typeof(T);
        }

        public int GetUniqueID()
        {
            return _uniqueId;
        }

        public string GetAlias()
        {
            return _alias;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
