using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Data.General
{
    public class tb_puntoVta_Data
    {

        public List<tb_puntoVta_Info> Get_List_PuntoVta(tb_puntoVta_Info Info)
        {
            List<tb_puntoVta_Info> ListInfo = new List<tb_puntoVta_Info>();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_puntoVta
                              where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucursal 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new tb_puntoVta_Info(	item.IdEmpresa,	item.IdPuntoVta,	item.IdSucursal,	item.cod_puntoVta,	item.nom_puntoVta,	item.estado));
                }

            }
            catch (Exception)
            {
                return new List<tb_puntoVta_Info>();
            }

            return ListInfo;
        }

        public tb_puntoVta_Info Get_Info_PuntoVta(int idEmpresa, int IdSucursal)
        {
            tb_puntoVta_Info Info = new tb_puntoVta_Info();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_puntoVta
                              where q.IdSucursal == IdSucursal && q.IdEmpresa == idEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdSucursal = item.IdSucursal;
                    Info.cod_puntoVta = item.cod_puntoVta;
                    Info.nom_puntoVta = item.nom_puntoVta;
                    Info.estado = item.estado;

                }
            }
            catch (Exception)
            {
                return new tb_puntoVta_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(tb_puntoVta_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {


                    var addressG = new tb_puntoVta();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdPuntoVta = Info.IdPuntoVta;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.cod_puntoVta = Info.cod_puntoVta;
                    addressG.nom_puntoVta = Info.nom_puntoVta;
                    addressG.estado = true ;

                    context.tb_puntoVta.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(tb_puntoVta_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var contact = context.tb_puntoVta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal == Info.IdSucursal && cot.IdSucursal == Info.IdSucursal);

                    if (contact != null)
                    {
                        contact.cod_puntoVta = Info.cod_puntoVta;
                        contact.nom_puntoVta = Info.nom_puntoVta;                        
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

        public Boolean AnularDB(tb_puntoVta_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var contact = context.tb_puntoVta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal== Info.IdSucursal && cot.IdSucursal == Info.IdSucursal);

                    if (contact != null)
                    {

                        contact.estado = false;

                        context.SaveChanges();
                    }
                    else
                        return false;

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
