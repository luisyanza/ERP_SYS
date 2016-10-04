using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.SeguridadAcceso;

namespace WSCoreErp.SeguridadAcceso
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_Seg_Perfil_Usuario" in both code and config file together.
    [ServiceContract]
    public interface IWS_Seg_Perfil_Usuario
    {
        //seg_perfil_Bus
        [OperationContract]
         List<seg_perfil_Info> Get_List_Perfil();

        [OperationContract]
         seg_perfil_Info Get_Info_Perfil(int IdPErfil);

        [OperationContract]
        Boolean GrabarDBPerfil(seg_perfil_Info Info);

        [OperationContract]
        Boolean ModificarDBPerfil(seg_perfil_Info Info);

        [OperationContract]
        Boolean AnularDBPerfil(seg_perfil_Info Info);


        // seg_usuario_Bus
        [OperationContract]
        List<seg_usuario_Info> Get_List_Usuario();

        [OperationContract]
        seg_usuario_Info Get_Info_Usuario(string IdUsuario);

        [OperationContract]
        Boolean GrabarDBUsuario(seg_usuario_Info Info);

        [OperationContract]
        Boolean ModificarDBUsuario(seg_usuario_Info Info);

        [OperationContract]
        Boolean AnularDBUsuario(seg_usuario_Info Info);


        ///seg_usuario_sesion_Bus
        [OperationContract]
        List<seg_usuario_sesion_Info> Get_List_Usuario_Sesion();

        [OperationContract]
        seg_usuario_sesion_Info Get_Info_Usuario_Sesion(decimal IdRegistro);

        [OperationContract]
        Boolean GrabarDBUsuarioSesion(seg_usuario_sesion_Info Info);

        [OperationContract]
        Boolean ModificarDBUsuarioSesion(seg_usuario_sesion_Info Info);


    }
}
