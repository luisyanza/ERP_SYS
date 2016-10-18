using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_TerminoPago_Info
    {
        public string IdTerminoPago { get; set; }
        public string nom_TerminoPago { get; set; }
        public int Num_Coutas { get; set; }
        public int Dias_Vct { get; set; }

        public fac_TerminoPago_Info()
        {


        }
        public fac_TerminoPago_Info(string _IdTerminoPago,	string _nom_TerminoPago,	int _Num_Coutas,	int _Dias_Vct)
        {
            IdTerminoPago = _IdTerminoPago;
            nom_TerminoPago = _nom_TerminoPago;
            Num_Coutas = _Num_Coutas;
            Dias_Vct = _Dias_Vct;


        }
    }
}
