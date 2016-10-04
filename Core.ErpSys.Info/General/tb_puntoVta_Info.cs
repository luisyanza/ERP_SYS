using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_puntoVta_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPuntoVta { get; set; }
        public int IdSucursal { get; set; }
        public string cod_puntoVta { get; set; }
        public string nom_puntoVta { get; set; }
        public Boolean estado { get; set; }

        public tb_puntoVta_Info()
        {

        }
        public tb_puntoVta_Info(	int _IdEmpresa,	int _IdPuntoVta,	int _IdSucursal,	string _cod_puntoVta,	string _nom_puntoVta,	Boolean _estado	)
        {
            IdEmpresa = _IdEmpresa;
            IdPuntoVta = _IdPuntoVta;
            IdSucursal = _IdSucursal;
            cod_puntoVta = _cod_puntoVta;
            nom_puntoVta = _nom_puntoVta;
            estado = _estado;

        }
    }
}
