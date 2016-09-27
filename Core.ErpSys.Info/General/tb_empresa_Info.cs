using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_empresa_Info
    {

        public int IdEmpresa { get; set; }
        public string cod_empresa { get; set; }
        public string nom_empresa { get; set; }
        public string ruc_empresa { get; set; }
        public Boolean  estado { get; set; }

        public tb_empresa_Info()
        {

        }
        public tb_empresa_Info(int _IdEmpresa, string _cod_empresa, string _nom_empresa, string _ruc_empresa, Boolean _Estado)
        {
            IdEmpresa = _IdEmpresa;
            cod_empresa = _cod_empresa;
            nom_empresa = _nom_empresa;
            ruc_empresa = _ruc_empresa;
            estado = _Estado;
        }
    }
}
