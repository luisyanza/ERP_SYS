using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cliente_pto_emision_cliente_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public int IdPuntoEmision { get; set; }
        public string cod_ptoemision { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail1 { get; set; }
        public string mail2 { get; set; }
        public Boolean Estado { get; set; }

     
        public fac_cliente_pto_emision_cliente_Info()
        {

        }

        public fac_cliente_pto_emision_cliente_Info(int _IdEmpresa, decimal _IdCliente, int _IdPuntoEmision, string _cod_ptoemision, string _ruc, string _direccion, string _telefono, string _mail1, string _mail2, Boolean _Estado)
        {
            IdEmpresa = _IdEmpresa;
            IdCliente = _IdCliente;
            IdPuntoEmision = _IdPuntoEmision;
            cod_ptoemision = _cod_ptoemision;
            ruc = _ruc;
            direccion = _direccion;
            telefono = _telefono;
            mail1 = _mail1;
            mail2 = _mail2;
            Estado = _Estado;

        }
    }
}
