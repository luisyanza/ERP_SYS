using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cotizacion_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencial { get; set; }
        public decimal IdProducto { get; set; }
        public double dc_cantidad { get; set; }
        public double dc_precio { get; set; }
        public double dc_por_desUni { get; set; }
        public double dc_valor_desUni { get; set; }
        public double dc_precioFinal { get; set; }
        public double dc_subtotal { get; set; }
        public double dc_valor_impuesto_iva { get; set; }
        public string dc_detallexItems { get; set; }
        public double dc_por_impuesto_iva { get; set; }
        public string IdImpuesto_Iva { get; set; }
        public double dc_total { get; set; }

        public fac_cotizacion_det_Info()
        {

        }
        public fac_cotizacion_det_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, decimal _IdCotizacion, int _Secuencial,
                                        decimal _IdProducto, double _dc_cantidad, double _dc_precio, double _dc_por_desUni, double _dc_valor_desUni,
                                        double _dc_precioFinal, double _dc_subtotal, double _dc_valor_impuesto_iva, string _dc_detallexItems, double _dc_por_impuesto_iva,
                                        string _IdImpuesto_Iva, double _dc_total)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdCotizacion = _IdCotizacion;
            Secuencial = _Secuencial;
            IdProducto = _IdProducto;
            dc_cantidad = _dc_cantidad;
            dc_precio = _dc_precio;
            dc_por_desUni = _dc_por_desUni;
            dc_valor_desUni = _dc_valor_desUni;
            dc_precioFinal = _dc_precioFinal;
            dc_subtotal = _dc_subtotal;
            dc_valor_impuesto_iva = _dc_valor_impuesto_iva;
            dc_detallexItems = _dc_detallexItems;
            dc_por_impuesto_iva = _dc_por_impuesto_iva;
            IdImpuesto_Iva = _IdImpuesto_Iva;
            dc_total = _dc_total;


        }
    }
}
