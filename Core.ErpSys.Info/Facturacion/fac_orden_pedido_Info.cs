using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_orden_pedido_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdPedido { get; set; }
        public string CodPedido { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime cp_fecha { get; set; }
        public int cp_diasPlazo { get; set; }
        public DateTime cp_fechaVenc { get; set; }
        public string cp_observacion { get; set; }
        public string cp_tipopago { get; set; }
        public Boolean Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public Boolean? Entregado { get; set; }
        public List<fac_orden_pedido_det_Info > List_detalle { get; set; }

        public fac_orden_pedido_Info()
        {

        }
        public fac_orden_pedido_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, decimal _IdPedido, string _CodPedido,
                                        decimal _IdCliente, int _IdVendedor, DateTime _cp_fecha, int _cp_diasPlazo, DateTime _cp_fechaVenc,
                                        string _cp_observacion, string _cp_tipopago, Boolean _Estado, string _IdEstadoAprobacion, string _IdUsuario,
                                        DateTime? _Fecha_Transac, string _IdUsuarioUltMod, DateTime? _Fecha_UltMod, string _IdUsuarioUltAnu, DateTime? _Fecha_UltAnu,
                                        string _nom_pc, string _ip, string _MotivoAnulacion, Boolean? _Entregado)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdPedido = _IdPedido;
            CodPedido = _CodPedido;
            IdCliente = _IdCliente;
            IdVendedor = _IdVendedor;
            cp_fecha = _cp_fecha;
            cp_diasPlazo = _cp_diasPlazo;
            cp_fechaVenc = _cp_fechaVenc;
            cp_observacion = _cp_observacion;
            cp_tipopago = _cp_tipopago;
            Estado = _Estado;
            IdEstadoAprobacion = _IdEstadoAprobacion;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            nom_pc = _nom_pc;
            ip = _ip;
            MotivoAnulacion = _MotivoAnulacion;
            Entregado = _Entregado;
        }
    }
}
