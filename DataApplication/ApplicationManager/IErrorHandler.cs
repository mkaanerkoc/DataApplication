using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationManager
{
    public interface IErrorHandler
    {
        void handleError(Exception e);
        void handleErrorMessage(string str);
    }
}
