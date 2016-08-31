using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    public class tb_seg_usuario_sesion_Info
    { 
        public decimal  IdRegistro { get; set; }
        public string IdUsuario { get; set; }
        public DateTime fecha_hora { get; set; }
        public string tipo { get; set; }
        public string ip { get; set; }
        public string equipo { get; set; }


        public tb_seg_usuario_sesion_Info()
        {

        }
        public tb_seg_usuario_sesion_Info(decimal	_IdRegistro,string	_IdUsuario,	DateTime _fecha_hora,	string	_tipo,	string	_ip,	string	_equipo)
        {
            IdRegistro = _IdRegistro;
            IdUsuario = _IdUsuario;
            fecha_hora = _fecha_hora;
            tipo = _tipo;
            ip = _ip;
            equipo = _equipo;

        }

       
    }
}
