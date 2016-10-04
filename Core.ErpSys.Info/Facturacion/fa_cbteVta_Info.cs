using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
   public class fa_cbteVta_Info
    {
       public int IdEmpresa { get; set; }
       public string IdCbteVtaTipo { get; set; }
       public decimal IdCbteVta { get; set; }
       public string num_CbteVta { get; set; }
       public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
       public decimal IdCliente { get; set; }
       public bool estado { get; set; }
       public string observacion { get; set; }

       public List<fa_cbteVta_det_Info> List_detalle  { get; set; }

       public fa_cbteVta_Info()
       {
           List_detalle = new List<fa_cbteVta_det_Info>();

       }


    }
}
