using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cotizacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdCotizacion { get; set; }
        public string CodCotizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime cc_fecha { get; set; }
        public short  cc_diasPlazo { get; set; }
        public DateTime cc_fechaVencimiento { get; set; }
        public string cc_observacion { get; set; }
        public string cc_tipopago { get; set; }
        public Boolean cc_estado { get; set; }
        public string cc_dirigidoA { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public List<fac_cotizacion_det_Info> ListDetalle;

        public fac_cotizacion_Info()
        {
            ListDetalle = new List<fac_cotizacion_det_Info>();
        }
        public fac_cotizacion_Info(int _IdEmpresa,	int _IdSucursal,	int _IdPuntoVta,	decimal _IdCotizacion,	string _CodCotizacion,	decimal _IdCliente,	int _IdVendedor,
                                    DateTime _cc_fecha,	short _cc_diasPlazo,	DateTime _cc_fechaVencimiento,	string _cc_observacion,	string _cc_tipopago,	Boolean _cc_estado,
                                    string _cc_dirigidoA,	string _IdUsuario,	DateTime _Fecha_Transac,	string _IdUsuarioUltMod,	DateTime? _Fecha_UltMod,	string _IdUsuarioUltAnu,
                                    DateTime? _Fecha_UltAnu,	string _MotivoAnu,	string _nom_pc,	string _ip)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdCotizacion = _IdCotizacion;
            CodCotizacion = _CodCotizacion;
            IdCliente = _IdCliente;
            IdVendedor = _IdVendedor;
            cc_fecha = _cc_fecha;
            cc_diasPlazo = _cc_diasPlazo;
            cc_fechaVencimiento = _cc_fechaVencimiento;
            cc_observacion = _cc_observacion;
            cc_tipopago = _cc_tipopago;
            cc_estado = _cc_estado;
            cc_dirigidoA = _cc_dirigidoA;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            MotivoAnu = _MotivoAnu;
            nom_pc = _nom_pc;
            ListDetalle = new List<fac_cotizacion_det_Info>();
        }
    }
}
