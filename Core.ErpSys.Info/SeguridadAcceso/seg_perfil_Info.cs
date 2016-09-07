using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    /// <summary>
    /// Info de tabla de perfiles
    /// </summary>
    public class seg_perfil_Info
    {

        public int IdPerfil { get; set; }
        public string nom_perfil { get; set; }
        public bool estado { get; set; }



        public seg_perfil_Info()
        {


        }
        public seg_perfil_Info( int	_IdPerfil,	string	_nom_perfil,	bool	_estado)
        {
            IdPerfil = _IdPerfil;
            nom_perfil = _nom_perfil;
            estado = _estado;

        }
    }
}
