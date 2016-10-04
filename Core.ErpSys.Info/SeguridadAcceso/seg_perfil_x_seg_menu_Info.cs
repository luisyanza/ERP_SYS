using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    public class seg_perfil_x_seg_menu_Info
    {

        public int IdPerfil { get; set; }
        public string IdMenu { get; set; }
        public string observacion { get; set; }

        public seg_perfil_x_seg_menu_Info()
        {

        }
        public seg_perfil_x_seg_menu_Info(int _IdPerfil,	string	_IdMenu,	string	_observacion)
        {
            IdPerfil = _IdPerfil;
            IdMenu = _IdMenu;
            observacion = _observacion;

        }
    }
}
