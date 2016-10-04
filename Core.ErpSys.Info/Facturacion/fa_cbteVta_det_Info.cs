using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
   public class fa_cbteVta_det_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public decimal IdCbteVta { get; set; }
        public int secuencia { get; set; }
        public decimal IdProducto { get; set; }

        public string observacion_det { get; set; }
        public string IdImpuesto_Iva { get; set; }

        public decimal cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal por_descuento { get; set; }
        public decimal valor_descuento { get; set; }
        public decimal precio_final { get; set; }
        public decimal subtotal { get; set; }
        public decimal valor_impuesto_iva { get; set; }
        public decimal por_impuesto_iva { get; set; }
        public decimal total { get; set; }






    }
}
