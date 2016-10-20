using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_guia_remision_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string CodGuiaRemision { get; set; }
        public string num_CbteVta { get; set; }
        public string num_autorizacion { get; set; }
        public DateTime? Fecha_Autorizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdTransportista { get; set; }
        public DateTime gi_fecha { get; set; }
        public decimal? gi_plazo { get; set; }
        public DateTime? gi_fech_venc { get; set; }
        public string gi_Observacion { get; set; }
        public double? gi_TotalKilos { get; set; }
        public double? gi_TotalQuintales { get; set; }
        public Boolean estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Boolean? Impreso { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime gi_FechaIniTraslado { get; set; }
        public DateTime gi_FechaFinTraslado { get; set; }
        public string placa { get; set; }
        public string ruta { get; set; }
        public string Direccion_Origen { get; set; }
        public string Direccion_Destino { get; set; }
        public List<fac_guia_remision_det_Info> List_detalle { get; set; }

        public fac_guia_remision_Info()
        {
            List_detalle = new List<fac_guia_remision_det_Info>();
        }

        public fac_guia_remision_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, decimal _IdGuiaRemision, string _CodGuiaRemision,
                                        string _num_CbteVta, string _num_autorizacion, DateTime? _Fecha_Autorizacion, decimal _IdCliente, int _IdVendedor,
                                        decimal _IdTransportista, DateTime _gi_fecha, decimal? _gi_plazo, DateTime? _gi_fech_venc, string _gi_Observacion,
                                        double? _gi_TotalKilos, double? _gi_TotalQuintales, Boolean _estado, string _IdUsuario, DateTime _Fecha_Transac,
                                        string _IdUsuarioUltMod, DateTime? _Fecha_UltMod, string _IdUsuarioUltAnu, DateTime? _Fecha_UltAnu, string _nom_pc,
                                        string _ip, string _MotiAnula, Boolean? _Impreso, int _IdPeriodo, DateTime _gi_FechaIniTraslado, DateTime _gi_FechaFinTraslado,
                                        string _placa, string _ruta, string _Direccion_Origen, string _Direccion_Destino)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdGuiaRemision = _IdGuiaRemision;
            CodGuiaRemision = _CodGuiaRemision;
            num_CbteVta = _num_CbteVta;
            num_autorizacion = _num_autorizacion;
            Fecha_Autorizacion = _Fecha_Autorizacion;
            IdCliente = _IdCliente;
            IdVendedor = _IdVendedor;
            IdTransportista = _IdTransportista;
            gi_fecha = _gi_fecha;
            gi_plazo = _gi_plazo;
            gi_fech_venc = _gi_fech_venc;
            gi_Observacion = _gi_Observacion;
            gi_TotalKilos = _gi_TotalKilos;
            gi_TotalQuintales = _gi_TotalQuintales;
            estado = _estado;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            nom_pc = _nom_pc;
            ip = _ip;
            MotiAnula = _MotiAnula;
            Impreso = _Impreso;
            IdPeriodo = _IdPeriodo;
            gi_FechaIniTraslado = _gi_FechaIniTraslado;
            gi_FechaFinTraslado = _gi_FechaFinTraslado;
            placa = _placa;
            ruta = _ruta;
            Direccion_Origen = _Direccion_Origen;
            Direccion_Destino = _Direccion_Destino;
            List_detalle = new List<fac_guia_remision_det_Info>();
        }
    }
}
