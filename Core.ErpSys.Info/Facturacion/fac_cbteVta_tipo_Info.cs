using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cbteVta_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public string nom_CbteVtaTipo { get; set; }
        public Boolean estado { get; set; }

        public fac_cbteVta_tipo_Info()
        {

        }
        public fac_cbteVta_tipo_Info(int _IdEmpresa,	string _IdCbteVtaTipo,	string _nom_CbteVtaTipo,	Boolean _estado)
        {
            IdEmpresa = _IdEmpresa;
            IdCbteVtaTipo = _IdCbteVtaTipo;
            nom_CbteVtaTipo = _nom_CbteVtaTipo;
            estado = _estado;

        }
    }
}
