using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;


namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class seg_usuario_sesion_Data
    {

        public List<seg_usuario_sesion_Info> Get_List_Usuario_Sesion()
        {
            List<seg_usuario_sesion_Info> ListInfo = new List<seg_usuario_sesion_Info>();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_usuario_sesion 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new seg_usuario_sesion_Info(item.IdRegistro,item.IdUsuario,item.fecha_hora, item.tipo,item.ip,item.equipo));

                }

            }
            catch (Exception)
            {
                return new List<seg_usuario_sesion_Info>();
            }

            return ListInfo;
        }

        public List<seg_usuario_sesion_Info> Get_List_Usuario_Sesion(DateTime fechaIni, DateTime fechaFin)
        {
            List<seg_usuario_sesion_Info> ListInfo = new List<seg_usuario_sesion_Info>();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_usuario_sesion
                              where q.fecha_hora < fechaFin & q.fecha_hora >fechaIni 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new seg_usuario_sesion_Info(item.IdRegistro, item.IdUsuario, item.fecha_hora, item.tipo, item.ip, item.equipo));

                }

            }
            catch (Exception)
            {
                return new List<seg_usuario_sesion_Info>();
            }

            return ListInfo;
        }


        public seg_usuario_sesion_Info Get_Info_Registro(decimal  IdRegistro)
        {
            seg_usuario_sesion_Info Info = new seg_usuario_sesion_Info();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_usuario_sesion
                              where q.IdRegistro == IdRegistro
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdRegistro = item.IdRegistro;
                    Info.IdUsuario = item.IdUsuario;
                    Info.fecha_hora = item.fecha_hora;
                    Info.tipo = item.tipo;
                    Info.ip = item.ip;
                    Info.equipo = item.equipo;

                }
            }
            catch (Exception)
            {
                return new seg_usuario_sesion_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(seg_usuario_sesion_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var addressG = new seg_usuario_sesion();
                    addressG.IdRegistro = Info.IdRegistro;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.fecha_hora = Info.fecha_hora;
                    addressG.tipo = Info.tipo;
                    addressG.ip = Info.ip;
                    addressG.equipo = Info.equipo;
                    context.seg_usuario_sesion.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(seg_usuario_sesion_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var contact = context.seg_usuario_sesion.FirstOrDefault(cot => cot.IdRegistro == Info.IdRegistro);

                    if (contact != null)
                    {
                        contact.IdRegistro = Info.IdRegistro;
                        contact.IdUsuario = Info.IdUsuario;
                        contact.fecha_hora = Info.fecha_hora;
                        contact.tipo = Info.tipo;
                        contact.ip = Info.ip;
                        contact.equipo = Info.equipo;

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
