using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;
namespace Core.ErpSys.Data.General
{
    public class tb_empresa_Data
    {
        public List<tb_empresa_Info> Get_List_Empresa()
        {
            List<tb_empresa_Info> ListInfo = new List<tb_empresa_Info>();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_empresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new tb_empresa_Info(item.IdEmpresa, item.cod_empresa, item.nom_empresa, item.ruc_empresa, item.estado));
                }

            }
            catch (Exception)
            {
                return new List<tb_empresa_Info>();
            }

            return ListInfo;
        }

        public tb_empresa_Info Get_Info_Empresa(int IdEmpresa)
        {
            tb_empresa_Info Info = new tb_empresa_Info();

            try
            {

                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_empresa
                              where q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.cod_empresa = item.cod_empresa;
                    Info.nom_empresa = item.nom_empresa;
                    Info.ruc_empresa = item.ruc_empresa;
                    Info.estado = item.estado;

                }
            }
            catch (Exception)
            {
                return new tb_empresa_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(tb_empresa_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {


                    var addressG = new tb_empresa();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.cod_empresa = Info.cod_empresa;
                    addressG.nom_empresa = Info.nom_empresa;
                    addressG.ruc_empresa = Info.ruc_empresa;
                    addressG.estado = true;

                    context.tb_empresa.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(tb_empresa_Info Info)
        {
            try
            {
                using (Entities_General  context = new Entities_General ())
                {
                    var contact = context.tb_empresa.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {

                        contact.cod_empresa = Info.cod_empresa;
                        contact.nom_empresa = Info.nom_empresa;
                        contact.ruc_empresa = Info.ruc_empresa;

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

        public Boolean AnularDB(tb_empresa_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var contact = context.tb_empresa.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa);

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
