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
        public string pe_nombreCompleto { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string pe_razon_social { get; set; }
        public string IdTipoDocumento { get; set; }
        public string Num_documento { get; set; }
        public string IdTipoPersona { get; set; }
        public Boolean estado { get; set; }
        public string pe_Naturaleza_cat { get; set; }
        public string pe_sexo { get; set; }
        public string IdEstadoCivil_cat { get; set; }
        public DateTime pe_fechaNacimiento { get; set; }
        public string pe_correo { get; set; }
        public string pe_correo1 { get; set; }
        public string pe_correo2 { get; set; }
        public string pe_telef_Casa { get; set; }
        public string pe_telef_Trab { get; set; }
        public string pe_telef_Contacto { get; set; }
        public string pe_direccion { get; set; }
        public string pe_fax { get; set; }
        public string pe_casilla { get; set; }
        public string IdTipoCta_acreditacion_cat { get; set; }
        public string num_cta_acreditacion { get; set; }
        public int? IdBanco_acreditacion { get; set; }


        public tb_persona_Info()
        {

        }

        public tb_persona_Info(decimal _IdPersona,	string _cod_persona,	string _pe_nombreCompleto,	string _pe_nombre,	string _pe_apellido,	string _pe_razon_social,	string _IdTipoDocumento,
                                string _Num_documento,	string _IdTipoPersona,	Boolean _estado,	string _pe_Naturaleza_cat,	string _pe_sexo,	string _IdEstadoCivil_cat,
                                DateTime _pe_fechaNacimiento,	string _pe_correo,	string _pe_correo1,	string _pe_correo2,	string _pe_telef_Casa,	string _pe_telef_Trab,
                                string _pe_telef_Contacto,	string _pe_direccion,	string _pe_fax,	string _pe_casilla,	string _IdTipoCta_acreditacion_cat,	string _num_cta_acreditacion,	int? _IdBanco_acreditacion)

        {
            IdPersona = _IdPersona;
            cod_persona = _cod_persona;
            pe_nombreCompleto = _pe_nombreCompleto;
            pe_nombre = _pe_nombre;
            pe_apellido = _pe_apellido;
            pe_razon_social = _pe_razon_social;
            IdTipoDocumento = _IdTipoDocumento;
            Num_documento = _Num_documento;
            IdTipoPersona = _IdTipoPersona;
            estado = _estado;
            pe_Naturaleza_cat = _pe_Naturaleza_cat;
            pe_sexo = _pe_sexo;
            IdEstadoCivil_cat = _IdEstadoCivil_cat;
            pe_fechaNacimiento = _pe_fechaNacimiento;
            pe_correo = _pe_correo;
            pe_correo1 = _pe_correo1;
            pe_correo2 = _pe_correo2;
            pe_telef_Casa = _pe_telef_Casa;
            pe_telef_Trab = _pe_telef_Trab;
            pe_telef_Contacto = _pe_telef_Contacto;
            pe_direccion = _pe_direccion;
            pe_fax = _pe_fax;
            pe_casilla = _pe_casilla;
            IdTipoCta_acreditacion_cat = _IdTipoCta_acreditacion_cat;
            num_cta_acreditacion = _num_cta_acreditacion;
            IdBanco_acreditacion = _IdBanco_acreditacion;            
        }
    }
}
