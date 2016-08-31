using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class tb_seg_usuario_Data
    {

        public List<tb_seg_usuario_Info> Get_List_Usuario()
        {
            List<tb_seg_usuario_Info> ListInfo = new List<tb_seg_usuario_Info>();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_usuario
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new tb_seg_usuario_Info(item.IdUsuario, item.nom_usuario, item.contrasenia, item.Estado, item.IdPerfil, item.Exigir_directivas_seguridad, item.Exigir_expiracion_contrasenia, item.usuario_debe_cambiar_contra_inicio_sesion, item.Fecha_expiracion_contrasenia));
                }

            }
            catch (Exception)
            {
                return new List<tb_seg_usuario_Info>();
            }

            return ListInfo;
        }


        public tb_seg_usuario_Info Get_Info_Usuario(string IdUsuario)
        {
            tb_seg_usuario_Info Info = new tb_seg_usuario_Info();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_usuario
                              where q.IdUsuario  == IdUsuario
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdUsuario = item.IdUsuario;
                    Info.nom_usuario = item.nom_usuario;
                    Info.contrasenia = item.contrasenia;
                    Info.Estado = item.Estado;
                    Info.IdPerfil = item.IdPerfil;
                    Info.Exigir_directivas_seguridad = item.Exigir_directivas_seguridad;
                    Info.Exigir_expiracion_contrasenia = item.Exigir_expiracion_contrasenia;
                    Info.usuario_debe_cambiar_contra_inicio_sesion = item.usuario_debe_cambiar_contra_inicio_sesion;
                    Info.Fecha_expiracion_contrasenia = item.Fecha_expiracion_contrasenia;

                }
            }
            catch (Exception)
            {
                return new tb_seg_usuario_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(tb_seg_usuario_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var addressG = new seg_usuario ();
                    addressG.nom_usuario = Info.nom_usuario;
                    addressG.contrasenia = Info.contrasenia;
                    addressG.Estado = true;
                    addressG.IdPerfil = Info.IdPerfil;
                    addressG.Exigir_directivas_seguridad = Info.Exigir_directivas_seguridad;
                    addressG.Exigir_expiracion_contrasenia = Info.Exigir_expiracion_contrasenia;
                    addressG.usuario_debe_cambiar_contra_inicio_sesion = Info.usuario_debe_cambiar_contra_inicio_sesion;
                    addressG.Fecha_expiracion_contrasenia = Info.Fecha_expiracion_contrasenia;
                    context.seg_usuario.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(tb_seg_usuario_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var contact = context.seg_usuario.FirstOrDefault(cot => cot.IdUsuario == Info.IdUsuario);

                    if (contact != null)
                    {

                        contact.nom_usuario = Info.nom_usuario;
                        contact.contrasenia = Info.contrasenia;
                        contact.Estado = Info.Estado;
                        contact.IdPerfil = Info.IdPerfil;
                        contact.Exigir_directivas_seguridad = Info.Exigir_directivas_seguridad;
                        contact.Exigir_expiracion_contrasenia = Info.Exigir_expiracion_contrasenia;
                        contact.usuario_debe_cambiar_contra_inicio_sesion = Info.usuario_debe_cambiar_contra_inicio_sesion;
                        contact.Fecha_expiracion_contrasenia = Info.Fecha_expiracion_contrasenia;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

        public Boolean AnularDB(tb_seg_usuario_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var contact = context.seg_usuario .FirstOrDefault(cot => cot.IdUsuario == Info.IdUsuario);
                    if (contact != null)
                    {
                        contact.Estado = false;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

    }
}
