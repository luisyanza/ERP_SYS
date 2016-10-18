using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_formaPago_Info
    {
        public string  IdFormaPago { get; set; }
        public string nom_FormaPago { get; set; }


        public fac_formaPago_Info()
        {

        }

        public fac_formaPago_Info(string _IdFormaPago, string _nom_FormaPago)
        {
            IdFormaPago = _IdFormaPago;
            nom_FormaPago = _nom_FormaPago;

        }
    }
}
