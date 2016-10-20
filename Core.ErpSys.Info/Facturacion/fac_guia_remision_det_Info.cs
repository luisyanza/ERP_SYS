using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_guia_remision_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double gi_cantidad { get; set; }
        public double gi_Precio { get; set; }
        public double gi_PorDescUnitario { get; set; }
        public double gi_DescUnitario { get; set; }
        public double gi_PrecioFinal { get; set; }
        public double gi_Subtotal { get; set; }
        public double gi_iva { get; set; }
        public double gi_total { get; set; }
        public double gi_costo { get; set; }
        public string gi_tieneIVA { get; set; }
        public string gi_detallexItems { get; set; }


        public fac_guia_remision_det_Info()
        {

        }
        public fac_guia_remision_det_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, decimal _IdGuiaRemision, int _Secuencia,
                                            decimal _IdProducto, double _gi_cantidad, double _gi_Precio, double _gi_PorDescUnitario, double _gi_DescUnitario,
                                            double _gi_PrecioFinal, double _gi_Subtotal, double _gi_iva, double _gi_total, double _gi_costo,
                                            string _gi_tieneIVA, string _gi_detallexItems)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdGuiaRemision = _IdGuiaRemision;
            Secuencia = _Secuencia;
            IdProducto = _IdProducto;
            gi_cantidad = _gi_cantidad;
            gi_Precio = _gi_Precio;
            gi_PorDescUnitario = _gi_PorDescUnitario;
            gi_DescUnitario = _gi_DescUnitario;
            gi_PrecioFinal = _gi_PrecioFinal;
            gi_Subtotal = _gi_Subtotal;
            gi_iva = _gi_iva;
            gi_total = _gi_total;
            gi_costo = _gi_costo;
            gi_tieneIVA = _gi_tieneIVA;
            gi_detallexItems = _gi_detallexItems;

        }
    }
}
