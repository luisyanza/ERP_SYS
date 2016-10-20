using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_orden_pedido_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdPedido { get; set; }
        public int Secuencial { get; set; }
        public decimal IdProducto { get; set; }
        public double dp_cantidad { get; set; }
        public double dp_precio { get; set; }
        public double dp_Porc_descuento { get; set; }
        public double cp_valor_desUni { get; set; }
        public double cp_PrecioFinal { get; set; }
        public double dp_subtotal { get; set; }
        public double dp_valor_impuesto_iva { get; set; }
        public string dp_detallexItems { get; set; }
        public double dp_por_impuesto_iva { get; set; }
        public string IdImpuesto_Iva { get; set; }
        public string IdImpuesto_Ice { get; set; }
        public double valor_impuesto_ice { get; set; }
        public double por_impuesto_ice { get; set; }
        public double dp_total { get; set; }


        public fac_orden_pedido_det_Info()
        {

        }

        public fac_orden_pedido_det_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, decimal _IdPedido, int _Secuencial,
                                            decimal _IdProducto, double _dp_cantidad, double _dp_precio, double _dp_Porc_descuento, double _cp_valor_desUni,
                                            double _cp_PrecioFinal, double _dp_subtotal, double _dp_valor_impuesto_iva, string _dp_detallexItems, double _dp_por_impuesto_iva,
                                            string _IdImpuesto_Iva, string _IdImpuesto_Ice, double _valor_impuesto_ice, double _por_impuesto_ice, double _dp_total)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdPedido = _IdPedido;
            Secuencial = _Secuencial;
            IdProducto = _IdProducto;
            dp_cantidad = _dp_cantidad;
            dp_precio = _dp_precio;
            dp_Porc_descuento = _dp_Porc_descuento;
            cp_valor_desUni = _cp_valor_desUni;
            cp_PrecioFinal = _cp_PrecioFinal;
            dp_subtotal = _dp_subtotal;
            dp_valor_impuesto_iva = _dp_valor_impuesto_iva;
            dp_detallexItems = _dp_detallexItems;
            dp_por_impuesto_iva = _dp_por_impuesto_iva;
            IdImpuesto_Iva = _IdImpuesto_Iva;
            IdImpuesto_Ice = _IdImpuesto_Ice;
            valor_impuesto_ice = _valor_impuesto_ice;
            por_impuesto_ice = _por_impuesto_ice;
            dp_total = _dp_total;

        }
    }
}
