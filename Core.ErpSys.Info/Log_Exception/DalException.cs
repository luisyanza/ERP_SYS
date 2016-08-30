using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Core.ErpSys.Info.Log_Exception
{
   public  class DalException : Exception 
    {
       
        public DalException() : base() { }
        public DalException(string message) : base(message) { }
        public DalException(string message, Exception inner) : base(message, inner) { }

        public DalException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            EntityType = (Type)info.GetValue("EntityType", typeof(Type));
        }

        public Type EntityType { get; set; }

        override public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("EntityType", EntityType);
        }


    }
}
