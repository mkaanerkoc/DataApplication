using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataApplication.Devices;
using DataApplication.Models;

namespace DataApplication.DataWriter
{
    public class CSVWriter : IDataWriter
    {
        StreamWriter _writer;
        StringBuilder _sb;
        string _seperator;
        private string _fileName;

        public CSVWriter()
        {
            _sb = new StringBuilder();
            _seperator = ";";
        }

        public CSVWriter(string fileNameParam)
        {
            _sb = new StringBuilder();
            _fileName = fileNameParam;
        }

        public CSVWriter( string fileNameParam, string seperatorParam = ";")
        {
            _sb = new StringBuilder();
            _seperator = seperatorParam;
            _fileName = fileNameParam;
        }


        public int create()
        {
            if (File.Exists(_fileName))
            {
                return -1;
            }
            File.Create(_fileName);
            return 1;
        }

        public int create(string nameParam)
        {
            if (File.Exists(nameParam))
            {
                return -1;
            }
            File.Create(nameParam);
            return 1;
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

        public int open()
        {
            if( _fileName.Length < 3 )
            {
                return -1;
            }
            _writer = File.AppendText(_fileName);
            if (_writer == null)
            {
                _writer = new StreamWriter(_fileName);
            }
            if (_writer == null)
            {
                return -1;
            }
            return 1;
        }

        public int close()
        {
            _writer.Close();
            _writer.Dispose();
            return 1;
        }

        public int write( List<IWritable> dataList )
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

        public int write(List<List<IWritable>> dataList)
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

        public int writeHeader(List<ChannelModel> channels, OperatorModel operatorParam, FacilityModel facilityParam)
        {
            return 1; 
        }
    }
}
