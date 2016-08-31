using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    /// <summary>
    /// tabla relacional entre menu y usuario
    /// </summary>
    public class tb_seg_menu_x_seg_usuario_Info
    {

        public string IdMenu { get; set; }
        public string IdUsuario { get; set; }
        public string observacion { get; set; }

        public tb_seg_menu_x_seg_usuario_Info()
        {

        }

        public tb_seg_menu_x_seg_usuario_Info(string _IdMenu, string _IdUsuario, string _observacion)
        {
            IdMenu = _IdMenu;
            IdUsuario = _IdUsuario;
            observacion = _observacion;

        }
    }
}
