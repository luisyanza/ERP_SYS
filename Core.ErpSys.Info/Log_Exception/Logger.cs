using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;



namespace Core.ErpSys.Info.Log_Exception
{
   
        public interface ILogger
        {
            void Log(LoggingCategory category, string message);
            void Clear();
            void Flush();
        }

        public class ConsoleLogger : ILogger
        {
            #region ILogger Members

            public void Log(LoggingCategory category, string message)
            {
                switch (category)
                {
                    case LoggingCategory.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case LoggingCategory.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                Console.WriteLine(category);
                Console.WriteLine(message);
            }

            public void Clear()
            {
                Console.Clear();
            }

            public void Flush() { }

            #endregion
        }

        public class FileLogger : ILogger
        {
            #region ILogger Members

            public FileLogger()
            {
                string Fecha = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() +DateTime.Now.Millisecond.ToString() ;
                Path = "Log" + Fecha + ".txt";
            }

            public string Path { get; set; }

            public void Log(LoggingCategory category, string message)
            {
                try
                {
                    var writer = File.AppendText(Path);
                    writer.WriteLine(string.Format("Category: {0}, Message: {1}", category.ToString(), message));
                    writer.Flush();
                }
                catch (Exception ex)
                {
                    //In case the message cannot be written to a file - write it to the EventLog
                    try
                    {
                        EventLog.WriteEntry(Process.GetCurrentProcess().ProcessName,
                        string.Format("CouldNot log the message: {0}, Exception: {1}", message, ex.ToString()), EventLogEntryType.Error);
                    }
                    catch (Exception )
                    {
                        
                    }
                }


            }

            public void Clear()
            {
                File.Delete(Path);
            }

            public void Flush() { }

            
            #endregion
        }

        public class MemoryLogger : ILogger
        {
            StringBuilder sb = new StringBuilder();

            public MemoryLogger()
            {
                //Default value
                Path = "Log.txt";
            }

            public string Path { get; set; }
            #region ILogger Members

            public void Log(LoggingCategory category, string message)
            {
                sb.AppendLine(string.Format("Category: {0}, Message: {1}", category.ToString(), message));
            }

            public void Clear()
            {
                sb.Clear();
                if (File.Exists(Path))
                    File.Delete(Path);
                sb.AppendLine(DateTime.Now.ToLongTimeString());
            }

            public void Flush()
            {
                File.WriteAllText(Path, sb.ToString());
            }

            #endregion
        }

        public enum LoggingCategory
        {
            Info,
            Warning,
            Error
        }
   
}
