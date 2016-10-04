using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_sucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string cod_sucursal { get; set; }
        public string cod_establecimiento { get; set; }
        public string nom_sucursal { get; set; }
        public Boolean estado { get; set; }

        public tb_sucursal_Info()
        {

        }

        public tb_sucursal_Info(int _IdEmpresa, int _IdSucursal, string _cod_sucursal, string _cod_establecimiento, string _nom_sucursal, Boolean _estado)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            cod_sucursal = _cod_sucursal;
            cod_establecimiento = _cod_establecimiento;
            nom_sucursal = _nom_sucursal;
            estado = _estado;

        }
    }
}
