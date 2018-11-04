using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class CSVWriter : IDataWriter
    {
        StreamWriter _writer;
        StringBuilder _sb;
        string _seperator;

        public CSVWriter()
        {
            _sb = new StringBuilder();
            _seperator = ";";
        }

        public CSVWriter(string seperatorParam )
        {
            _sb = new StringBuilder();
            _seperator = seperatorParam;
        }

        public int open( string nameParam)
        {
            _writer = File.AppendText(nameParam);
            if( _writer == null )
            {
                _writer = new StreamWriter(nameParam);
            }
            if( _writer == null )
            {
                return 0;
            }
            return 1;
        }

        public int close()
        {
            _writer.Close();
            _writer.Dispose();
            return 1;
        }

        public int write( List<WritableBase> dataList )
        {
            _sb.Clear();
            for ( int k = 0; k < dataList.Count; k++)
            {
                _sb.Append(dataList[k].ToString());
                if( k != dataList.Count -1 )
                {
                    _sb.Append(_seperator);
                }
            }
            _writer.Write(_sb.ToString() + Environment.NewLine);
            return 1;
        }

        public int write(List<List<WritableBase>> dataList)
        {
            _sb.Clear();
            for(int j = 0; j < dataList.Count; j++ )
            {
                for (int k = 0; k < dataList[j].Count; k++)
                {
                    _sb.Append(dataList[j][k].ToString());
                    if (k != dataList[j].Count - 1)
                    {
                        _sb.Append(_seperator);
                    }
                }
                _sb.Append(Environment.NewLine);
            }
            _writer.Write(_sb.ToString());
            return 1;
        }
    }
}
