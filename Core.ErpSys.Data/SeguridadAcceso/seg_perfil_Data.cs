using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class seg_perfil_Data
    {


        public List<seg_perfil_Info> Get_List_Perfil()
        {
            List<seg_perfil_Info> ListInfo = new List<seg_perfil_Info>();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_perfil 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new seg_perfil_Info(item.IdPerfil, item.nom_perfil, item.estado));
                }

            }
            catch (Exception)
            {
                return new List<seg_perfil_Info>();
            }

            return ListInfo;
        }


        public seg_perfil_Info Get_Info_Perfil(int  IdPerfil)
        {
            seg_perfil_Info Info = new seg_perfil_Info();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_perfil 
                              where q.IdPerfil== IdPerfil 
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdPerfil  = item.IdPerfil ;
                    Info.nom_perfil = item.nom_perfil;
                    Info.estado = item.estado;
                }
            }
            catch (Exception)
            {
                return new seg_perfil_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(seg_perfil_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {

                    var addressG = new seg_perfil();
                    addressG.IdPerfil = Info.IdPerfil;
                    addressG.nom_perfil = Info.nom_perfil;
                    addressG.estado = Info.estado;
                    context.seg_perfil.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(seg_perfil_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var contact = context.seg_perfil.FirstOrDefault(cot => cot.IdPerfil == Info.IdPerfil);

                    if (contact != null)
                    {
                       contact.nom_perfil = Info.nom_perfil;
                       contact.estado= Info.estado;
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

        public Boolean AnularDB(seg_perfil_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var contact = context.seg_perfil.FirstOrDefault(cot => cot.IdPerfil == Info.IdPerfil);
                    if (contact != null)
                    {
                        contact.estado = false;
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
