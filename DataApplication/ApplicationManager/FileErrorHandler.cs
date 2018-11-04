using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationManager
{
    public class FileErrorHandler : IErrorHandler
    {
        private string _filename;

        public FileErrorHandler(string logFileName )
        {
            _filename = logFileName;
        }

        public void handleError(Exception e)
        {
            //todo log in file
        }

        public void handleErrorMessage(string str)
        {
            // todo log in file
        }
    }
}
