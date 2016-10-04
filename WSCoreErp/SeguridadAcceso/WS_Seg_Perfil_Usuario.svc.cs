using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.SeguridadAcceso;
using Core.ErpSys.Bus.SeguridadAcceso;

namespace WSCoreErp.SeguridadAcceso
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_Seg_Perfil_Usuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_Seg_Perfil_Usuario.svc or WS_Seg_Perfil_Usuario.svc.cs at the Solution Explorer and start debugging.
    public class WS_Seg_Perfil_Usuario : IWS_Seg_Perfil_Usuario
    {

        seg_perfil_Bus oBusPerfil = new seg_perfil_Bus();
        public List<seg_perfil_Info> Get_List_Perfil()
        {
            return oBusPerfil.Get_List_Perfil();
        }

        public seg_perfil_Info Get_Info_Perfil(int IdPErfil)
        {
            return oBusPerfil.Get_Info_Perfil(IdPErfil);
        }

        public bool GrabarDBPerfil(seg_perfil_Info Info)
        {
            return oBusPerfil.GrabarDB(Info);
        }

        public bool ModificarDBPerfil(seg_perfil_Info Info)
        {
            return oBusPerfil.ModificarDB(Info);
        }

        public bool AnularDBPerfil(seg_perfil_Info Info)
        {
            return oBusPerfil.AnularDB(Info);
        }

        //seg_usuario_Bus

        seg_usuario_Bus oBusUsuario = new seg_usuario_Bus();

        public List<seg_usuario_Info> Get_List_Usuario()
        {
            return oBusUsuario.Get_List_Usuario();
        }

        public seg_usuario_Info Get_Info_Usuario(string IdUsuario)
        {
            return oBusUsuario.Get_Info_Usuario(IdUsuario);
        }

        public bool GrabarDBUsuario(seg_usuario_Info Info)
        {
            return oBusUsuario.GrabarDB(Info);
        }


        public bool ModificarDBUsuario(seg_usuario_Info Info)
        {
            return oBusUsuario.ModificarDB(Info);

        }

        public bool AnularDBUsuario(seg_usuario_Info Info)
        {
            return oBusUsuario.AnularDB(Info);
        }


        /// <summary>
        /// seg_usuario_sesion_Bus
        /// </summary>
        /// <returns></returns>
        seg_usuario_sesion_Bus oBusUsuarioSesion = new seg_usuario_sesion_Bus();

        public List<seg_usuario_sesion_Info> Get_List_Usuario_Sesion()
        {
            return oBusUsuarioSesion.Get_List_Usuario_Sesion();
        }

        public seg_usuario_sesion_Info Get_Info_Usuario_Sesion(decimal IdRegistro)
        {
            return oBusUsuarioSesion.Get_Info_Usuario_Sesion(IdRegistro);
        }

        public bool GrabarDBUsuarioSesion(seg_usuario_sesion_Info Info)
        {
            return oBusUsuarioSesion.GrabarDB(Info);
        }

        public bool ModificarDBUsuarioSesion(seg_usuario_sesion_Info Info)
        {
            return oBusUsuarioSesion.ModificarDB(Info);
        }
    }
}
