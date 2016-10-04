using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Data.General
{
    public class tb_sucursal_Data
    {
        public List<tb_sucursal_Info> Get_List_Sucursal(tb_sucursal_Info Info)
        {
            List<tb_sucursal_Info> ListInfo = new List<tb_sucursal_Info>();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_sucursal
                              where q.IdEmpresa == Info.IdEmpresa 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new tb_sucursal_Info(item.IdEmpresa,item.IdSucursal, item.cod_sucursal, item.cod_establecimiento , item.nom_sucursal, item.estado ));
                }

            }
            catch (Exception)
            {
                return new List<tb_sucursal_Info>();
            }

            return ListInfo;
        }

        public tb_sucursal_Info Get_Info_Sucursal(int idEmpresa, int IdSucursal)
        {
            tb_sucursal_Info Info = new tb_sucursal_Info();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_sucursal
                              where q.IdSucursal == IdSucursal && q.IdEmpresa == idEmpresa 
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.cod_sucursal = item.cod_sucursal;
                    Info.cod_establecimiento = item.cod_establecimiento;
                    Info.nom_sucursal = item.nom_sucursal;
                    Info.estado = item.estado;
                }
            }
            catch (Exception)
            {
                return new tb_sucursal_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(tb_sucursal_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {


                    var addressG = new tb_sucursal();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.cod_sucursal = Info.cod_sucursal;
                    addressG.cod_establecimiento = Info.cod_establecimiento;
                    addressG.nom_sucursal = Info.nom_sucursal;
                    addressG.estado = true;


                    context.tb_sucursal.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(tb_sucursal_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(cot => cot.IdSucursal == Info.IdSucursal);

                    if (contact != null)
                    {

                        contact.cod_sucursal = Info.cod_sucursal;
                        contact.cod_establecimiento = Info.cod_establecimiento;
                        contact.nom_sucursal = Info.nom_sucursal;

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

        public Boolean AnularDB(tb_sucursal_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(cot => cot.IdSucursal == Info.IdSucursal);

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
