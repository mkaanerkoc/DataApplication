using DataApplication.DataWriter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class CSV_Writer : IDataWriter
    {
        StreamWriter _writer;
        StringBuilder _sb;
        string _seperator;

        public CSV_Writer()
        {
            _sb = new StringBuilder();
            _seperator = ";";
        }

        public CSV_Writer(string seperatorParam)
        {
            _sb = new StringBuilder();
            _seperator = seperatorParam;
        }

        public int close()
        {
            _writer.Close();
            _writer.Dispose();
            return 1;
        }

        public int open(string nameParam)
        {
            _writer = File.AppendText(nameParam);
            if (_writer == null)
            {
                _writer = new StreamWriter(nameParam);
            }
            if (_writer == null)
            {
                return 0;
            }
            return 1;
        }

        public int write(List<List<IWritable>> dataList)
        {
            throw new NotImplementedException();
        }

        public int write(List<IWritable> dataList)
        {
            throw new NotImplementedException();
        }
    }
}
