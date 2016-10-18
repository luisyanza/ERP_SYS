using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_TerminoPago_Distribucion_Info
    {

        public string IdTerminoPago { get; set; }
        public int Secuencia { get; set; }
        public int Num_Dias_Vcto { get; set; }
        public double Por_distribucion { get; set; }


        public fac_TerminoPago_Distribucion_Info()
        {


        }
        public fac_TerminoPago_Distribucion_Info(string _IdTerminoPago,	int _Secuencia,	int _Num_Dias_Vcto,	double _Por_distribucion)
        {
            IdTerminoPago = _IdTerminoPago;
            Secuencia = _Secuencia;
            Num_Dias_Vcto = _Num_Dias_Vcto;
            Por_distribucion = _Por_distribucion;

        }
    }
}
