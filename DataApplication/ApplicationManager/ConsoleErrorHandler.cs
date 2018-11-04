using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationManager
{
    public class ConsoleErrorHandler : IErrorHandler
    {
        public void handleError(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        public void handleErrorMessage(string str)
        {
            Console.WriteLine( str );
        }
    }
}
