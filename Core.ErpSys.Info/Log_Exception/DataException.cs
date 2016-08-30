using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Core.ErpSys.Info.Log_Exception
{

    [Serializable]
    public class DataException : Exception
    {
        public DataException() { }
        public DataException(string message) : base(message) { }
        public DataException(string message, Exception inner) : base(message, inner) { }
        protected DataException(
          SerializationInfo info,
          StreamingContext context)
            : base(info, context) { }
    }

   
}
