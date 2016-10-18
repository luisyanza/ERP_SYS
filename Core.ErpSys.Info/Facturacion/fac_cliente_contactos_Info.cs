using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cliente_contactos_Info
    {
        public int IdEmpresa_cli { get; set; }
        public decimal IdCliente { get; set; }
        public int IdEmpresa_cont { get; set; }
        public decimal IdContacto { get; set; }
        public string observacion { get; set; }

        public fac_cliente_contactos_Info()
        {

        }

        public fac_cliente_contactos_Info(int _IdEmpresa_cli, decimal _IdCliente, int _IdEmpresa_cont, decimal _IdContacto, string _observacion)
        {
            IdEmpresa_cli = _IdEmpresa_cli;
            IdCliente = _IdCliente;
            IdEmpresa_cont = _IdEmpresa_cont;
            IdContacto = _IdContacto;
            observacion = _observacion;

        }
    }
}
