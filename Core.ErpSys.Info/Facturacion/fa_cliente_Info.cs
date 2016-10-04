using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fa_cliente_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdPersona { get; set; }
        public int IdTipoCliente { get; set; }
        public Boolean estado { get; set; }

        public fa_cliente_Info()
        {

        }
        public fa_cliente_Info(int _IdEmpresa,	decimal _IdCliente,	decimal _IdPersona,	int _IdTipoCliente,	Boolean _estado)
        {
            IdEmpresa = _IdEmpresa;
            IdCliente = _IdCliente;
            IdPersona = _IdPersona;
            IdTipoCliente = _IdTipoCliente;
            estado = _estado;

        }
    }
}
