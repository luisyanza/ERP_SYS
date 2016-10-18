using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_devol_venta_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdDevolucion { get; set; }
        public string CodDevolucion { get; set; }
        public decimal IdNota { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdCbteVta { get; set; }
        public DateTime dv_fecha { get; set; }
        public Boolean Estado { get; set; }
        public string dv_Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string MotivoAnulacion { get; set; }
        public int? mvInv_IdEmpresa { get; set; }
        public int? mvInv_IdSucursal { get; set; }
        public int? mvInv_IdBodega { get; set; }
        public int? mvInv_IdMovi_inven_tipo { get; set; }
        public decimal? mvInv_IdNumMovi { get; set; }
        public int? mvInv_IdEmpresa_x_Anu { get; set; }
        public int? mvInv_IdSucursal_x_Anu { get; set; }
        public int? mvInv_IdBodega_x_Anu { get; set; }
        public int? mvInv_IdMovi_inven_tipo_x_Anu { get; set; }
        public decimal? mvInv_IdNumMovi_x_Anu { get; set; }
        public List<fac_devol_venta_det_Info> ListDetalle { get; set; }

        public fac_devol_venta_Info()
        {
            ListDetalle = new List<fac_devol_venta_det_Info>();
        }
        public fac_devol_venta_Info(int _IdEmpresa,	int _IdSucursal,	int _IdPuntoVta,	decimal _IdDevolucion,	string _CodDevolucion,
                                    decimal _IdNota,	decimal _IdCliente,	int _IdVendedor,	decimal _IdCbteVta,	DateTime _dv_fecha,
                                    Boolean _Estado,	string _dv_Observacion,	string _IdUsuario,	string _MotivoAnulacion,	int? _mvInv_IdEmpresa,
                                    int? _mvInv_IdSucursal,	int? _mvInv_IdBodega,	int? _mvInv_IdMovi_inven_tipo,	decimal? _mvInv_IdNumMovi,	int? _mvInv_IdEmpresa_x_Anu,
                                    int? _mvInv_IdSucursal_x_Anu,	int? _mvInv_IdBodega_x_Anu,	int? _mvInv_IdMovi_inven_tipo_x_Anu,	decimal? _mvInv_IdNumMovi_x_Anu)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdDevolucion = _IdDevolucion;
            CodDevolucion = _CodDevolucion;
            IdNota = _IdNota;
            IdCliente = _IdCliente;
            IdVendedor = _IdVendedor;
            IdCbteVta = _IdCbteVta;
            dv_fecha = _dv_fecha;
            Estado = _Estado;
            dv_Observacion = _dv_Observacion;
            IdUsuario = _IdUsuario;
            MotivoAnulacion = _MotivoAnulacion;
            mvInv_IdEmpresa = _mvInv_IdEmpresa;
            mvInv_IdSucursal = _mvInv_IdSucursal;
            mvInv_IdBodega = _mvInv_IdBodega;
            mvInv_IdMovi_inven_tipo = _mvInv_IdMovi_inven_tipo;
            mvInv_IdNumMovi = _mvInv_IdNumMovi;
            mvInv_IdEmpresa_x_Anu = _mvInv_IdEmpresa_x_Anu;
            mvInv_IdSucursal_x_Anu = _mvInv_IdSucursal_x_Anu;
            mvInv_IdBodega_x_Anu = _mvInv_IdBodega_x_Anu;
            mvInv_IdMovi_inven_tipo_x_Anu = _mvInv_IdMovi_inven_tipo_x_Anu;
            mvInv_IdNumMovi_x_Anu = _mvInv_IdNumMovi_x_Anu;
            ListDetalle = new List<fac_devol_venta_det_Info>();
        }
    }
}
