using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_TipoNota_x_tbsucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdTipoNota { get; set; }
        public string IdCtaCble { get; set; }

        public fac_TipoNota_x_tbsucursal_Info()
        {


        }
        public fac_TipoNota_x_tbsucursal_Info(int _IdEmpresa,	int _IdSucursal,	int _IdTipoNota,	string _IdCtaCble)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdTipoNota = _IdTipoNota;
            IdCtaCble = _IdCtaCble;

        }
    }
}
