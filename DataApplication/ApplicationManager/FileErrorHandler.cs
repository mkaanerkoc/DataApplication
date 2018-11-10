using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationManager
{
    public class FileErrorHandler : IErrorHandler
    {
        private string _filename;
        StreamWriter _writer;

        public FileErrorHandler(string logFileName )
        {
            _filename = logFileName;

        }

        public void handleError(Exception e)
        {
            var _writer = File.AppendText(_filename);
            var _sb = new StringBuilder();
            var _dt = DateTime.Now;
            if (_writer == null)
            {
                _writer = new StreamWriter(_filename);
            }
            if (_writer == null)
            {
                return;
            }
            _sb.Append(_dt.ToShortDateString());
            _sb.Append("_");
            _sb.Append(_dt.ToShortTimeString());
            _sb.Append("_Message : ");
            _sb.Append(e.Message);
            _writer.WriteLine(_sb.ToString());
            _writer.Close();
            _writer.Dispose();
            return;
        }

        public void handleErrorMessage(string str)
        {
            var _writer = File.AppendText(_filename);
            var _sb = new StringBuilder();
            var _dt = DateTime.Now;
            if (_writer == null)
            {
                _writer = new StreamWriter(_filename);
            }
            if (_writer == null)
            {
                return;
            }
            _sb.Append(_dt.ToShortDateString());
            _sb.Append("_");
            _sb.Append(_dt.ToShortTimeString());
            _sb.Append("_Message : ");
            _sb.Append(str);
            _writer.WriteLine(_sb.ToString());
            _writer.Close();
            _writer.Dispose();
            return;
        }
    }
}
