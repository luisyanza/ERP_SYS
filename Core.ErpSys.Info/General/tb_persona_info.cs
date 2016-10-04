using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;


namespace Core.ErpSys.Info.General
{
   public class tb_persona_Info
    {
        public decimal IdPersona { get; set; }
        public string cod_persona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string razon_social { get; set; }
        public string IdTipoDocumento { get; set; }
        public string Num_documento { get; set; }
        public string  IdTipoPersona { get; set; }
        public bool estado { get; set; }



        public tb_persona_Info()
        {

        }

        public tb_persona_Info(decimal _IdPersona, string _cod_persona, string _nombre, string _apellido, string _razon_social, string _IdTipoDocumento,
                            string _Num_documento, string _IdTipoPersona, bool _estado)
        {
            IdPersona = _IdPersona;
            cod_persona = _cod_persona;
            nombre = _nombre;
            apellido = _apellido;
            razon_social = _razon_social;
            IdTipoDocumento = _IdTipoDocumento;
            Num_documento = _Num_documento;
            IdTipoPersona = _IdTipoPersona;
            estado = _estado;
            
        }
    }
}
