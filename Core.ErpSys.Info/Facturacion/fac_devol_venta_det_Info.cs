using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_devol_venta_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdDevolucion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dv_cantidad { get; set; }
        public double dv_Precio { get; set; }
        public double dv_PorDescUni { get; set; }
        public double dv_ValordescUni { get; set; }
        public double dv_PrecioFinal { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_valor_impuesto_iva { get; set; }
        public double dv_costo_Uni { get; set; }
        public string dv_detallexItems { get; set; }
        public double dv_por_impuesto_iva { get; set; }
        public string IdImpuesto_Iva { get; set; }
        public double dv_total { get; set; }

        public fac_devol_venta_det_Info()
        {

        }
        public fac_devol_venta_det_Info(int _IdEmpresa,int _IdSucursal,int _IdPuntoVta,decimal _IdDevolucion,int _Secuencia,
                                        decimal _IdProducto,double _dv_cantidad,double _dv_Precio,double _dv_PorDescUni,double _dv_ValordescUni,
                                        double _dv_PrecioFinal,double _dv_subtotal,double _dv_valor_impuesto_iva,double _dv_costo_Uni,string _dv_detallexItems,
                                        double _dv_por_impuesto_iva,string _IdImpuesto_Iva,double _dv_total)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdDevolucion = _IdDevolucion;
            Secuencia = _Secuencia;
            IdProducto = _IdProducto;
            dv_cantidad = _dv_cantidad;
            dv_Precio = _dv_Precio;
            dv_PorDescUni = _dv_PorDescUni;
            dv_ValordescUni = _dv_ValordescUni;
            dv_PrecioFinal = _dv_PrecioFinal;
            dv_subtotal = _dv_subtotal;
            dv_valor_impuesto_iva = _dv_valor_impuesto_iva;
            dv_costo_Uni = _dv_costo_Uni;
            dv_detallexItems = _dv_detallexItems;
            dv_por_impuesto_iva = _dv_por_impuesto_iva;
            IdImpuesto_Iva = _IdImpuesto_Iva;
            dv_total = _dv_total;

        }
    }
}
