using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cbteVta_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public decimal IdCbteVta { get; set; }
        public string CodCbteVta { get; set; }
        public string num_CbteVta { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public int IdTipoNota { get; set; }
        public int IdCaja { get; set; }
        public decimal IdCliente { get; set; }
        public Boolean estado { get; set; }
        public string vt_Observacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public string num_autorizacion { get; set; }
        public int vt_plazo { get; set; }
        public DateTime vt_fecha_venc { get; set; }
        public DateTime vt_fecha { get; set; }
        public List<fac_cbteVta_det_Info> List_detalle { get; set; }

        public fac_cbteVta_Info()
        {
            List_detalle = new List<fac_cbteVta_det_Info>();

        }

        public fac_cbteVta_Info(int _IdEmpresa,	string _IdCbteVtaTipo,	decimal _IdCbteVta,	string _CodCbteVta,	string _num_CbteVta,	int _IdSucursal,	int _IdPuntoVta,
                                int _IdTipoNota,	int _IdCaja,	decimal _IdCliente,	Boolean _estado,	string _vt_Observacion,	DateTime _Fecha_Autorizacion,
                                string _num_autorizacion,	int _vt_plazo,	DateTime _vt_fecha_venc,	DateTime _vt_fecha)
        {
            IdEmpresa = _IdEmpresa;
            IdCbteVtaTipo = _IdCbteVtaTipo;
            IdCbteVta = _IdCbteVta;
            CodCbteVta = _CodCbteVta;
            num_CbteVta = _num_CbteVta;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdTipoNota = _IdTipoNota;
            IdCaja = _IdCaja;
            IdCliente = _IdCliente;
            estado = _estado;
            vt_Observacion = _vt_Observacion;
            Fecha_Autorizacion = _Fecha_Autorizacion;
            num_autorizacion = _num_autorizacion;
            vt_plazo = _vt_plazo;
            vt_fecha_venc = _vt_fecha_venc;
            vt_fecha = _vt_fecha;
            List_detalle = new List<fac_cbteVta_det_Info>();


        }
    }
}
