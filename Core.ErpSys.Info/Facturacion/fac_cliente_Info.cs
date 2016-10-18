using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cliente_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string cod_cliente { get; set; }
        public decimal IdPersona { get; set; }
        public int IdSucursal { get; set; }
        public int Idtipo_cliente { get; set; }
        public string IdTipoCredito { get; set; }
        public string cl_Cat_crediticia { get; set; }
        public int cl_plazo { get; set; }
        public double  cl_porc_descuento { get; set; }
        public string IdCtaCble_cxc { get; set; }
        public string IdCtaCble_Anti { get; set; }
        public string IdCtaCble_cxc_Credito { get; set; }
        public string Observacion { get; set; }
        public string IdCiudad { get; set; }
        public double cl_Cupo { get; set; }
        public decimal? IdClienteRelacionado { get; set; }
        public string cat_IdActividadComercial { get; set; }
        public Boolean Estado { get; set; }
        public string IdParroquia { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime ? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public tb_persona_Info  Persona { get; set; }
        public List <fac_cliente_contactos_Info> List_Contactos { get; set; }
        public List<fac_cliente_pto_emision_cliente_Info> List_PtoEmision { get; set; }

        public fac_cliente_Info()
        {
            List_Contactos = new List<fac_cliente_contactos_Info>();
            List_PtoEmision = new List<fac_cliente_pto_emision_cliente_Info>();
            Persona = new tb_persona_Info();
        }
        public fac_cliente_Info(int _IdEmpresa, decimal _IdCliente, string _cod_cliente, decimal _IdPersona, int _IdSucursal, int _Idtipo_cliente,
                                string _IdTipoCredito, string _cl_Cat_crediticia, int _cl_plazo, double  _cl_porc_descuento, string _IdCtaCble_cxc, string _IdCtaCble_Anti,
                                string _IdCtaCble_cxc_Credito, string _Observacion, string _IdCiudad, double _cl_Cupo, decimal? _IdClienteRelacionado,
                                string _cat_IdActividadComercial, Boolean _Estado, string _IdParroquia, string _IdUsuario, DateTime _Fecha_Transac,
                                string _IdUsuarioUltMod, DateTime? _Fecha_UltMod, string _IdUsuarioUltAnu, DateTime? _Fecha_UltAnu, string _nom_pc, string _ip)
        {
            IdEmpresa = _IdEmpresa;
            IdCliente = _IdCliente;
            cod_cliente = _cod_cliente;
            IdPersona = _IdPersona;
            IdSucursal = _IdSucursal;
            Idtipo_cliente = _Idtipo_cliente;
            IdTipoCredito = _IdTipoCredito;
            cl_Cat_crediticia = _cl_Cat_crediticia;
            cl_plazo = _cl_plazo;
            cl_porc_descuento = _cl_porc_descuento;
            IdCtaCble_cxc = _IdCtaCble_cxc;
            IdCtaCble_Anti = _IdCtaCble_Anti;
            IdCtaCble_cxc_Credito = _IdCtaCble_cxc_Credito;
            Observacion = _Observacion;
            IdCiudad = _IdCiudad;
            cl_Cupo = _cl_Cupo;
            IdClienteRelacionado = _IdClienteRelacionado;
            cat_IdActividadComercial = _cat_IdActividadComercial;
            Estado = _Estado;
            IdParroquia = _IdParroquia;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            nom_pc = _nom_pc;
            ip = _ip;
            Persona = new tb_persona_Info();
            List_Contactos = new List<fac_cliente_contactos_Info>();
            List_PtoEmision = new List<fac_cliente_pto_emision_cliente_Info>();
        }
    }
}
