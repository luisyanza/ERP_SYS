using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    public class tb_seg_usuario_Info
    {
        private string p1;
        private string p2;
        private string p3;
        private bool p4;
        private int? nullable;
        private bool p5;
        private bool p6;
        private bool p7;
        private DateTime dateTime;

        public string IdUsuario { get; set; }
        public string nom_usuario { get; set; }
        public string contrasenia { get; set; }
        public bool Estado { get; set; }
        public int? IdPerfil { get; set; }
        public bool Exigir_directivas_seguridad { get; set; }
        public bool Exigir_expiracion_contrasenia { get; set; }
        public bool usuario_debe_cambiar_contra_inicio_sesion { get; set; }
        public DateTime Fecha_expiracion_contrasenia { get; set; }


        public tb_seg_usuario_Info()
        {

        }

        public tb_seg_usuario_Info(string _IdUsuario, string _nom_usuario, string _contrasenia, bool _Estado, int? _IdPerfil, bool _Exigir_directivas_seguridad, bool _Exigir_expiracion_contrasenia, bool _usuario_debe_cambiar_contra_inicio_sesion, DateTime _Fecha_expiracion_contrasenia)
        {
            IdUsuario = _IdUsuario;
            nom_usuario = _nom_usuario;
            contrasenia = _contrasenia;
            Estado = _Estado;
            IdPerfil = _IdPerfil;
            Exigir_directivas_seguridad = _Exigir_directivas_seguridad;
            Exigir_expiracion_contrasenia = _Exigir_expiracion_contrasenia;
            usuario_debe_cambiar_contra_inicio_sesion = _usuario_debe_cambiar_contra_inicio_sesion;
            Fecha_expiracion_contrasenia = _Fecha_expiracion_contrasenia;

        }

      
    }
}
