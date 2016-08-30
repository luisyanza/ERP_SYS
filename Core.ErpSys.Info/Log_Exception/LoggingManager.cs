using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.ErpSys.Info.Log_Exception
{
   public class LoggingManager
    {
        public static ILogger Logger { get; set; }

        static LoggingManager()
        {
            //Default logger.
            //Logger = new ConsoleLogger();

            //Logger = new FileLogger();

            Logger = new FileLogger();

            
        }


    }
}
