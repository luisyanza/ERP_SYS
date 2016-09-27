using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;


namespace Core.ErpSys.Data.General
{
    public class tb_impuesto_Data
    {
        public List<tb_impuesto_Info> Get_List_Impuesto(tb_impuesto_Info Info)
        {
            List<tb_impuesto_Info> ListInfo = new List<tb_impuesto_Info>();
            try
            {
                Entities_General oBase = new Entities_General();

                var selectq = from q in oBase.tb_impuesto
                              where q.IdImpuesto_tipo == Info.IdImpuesto_tipo
                              select q;

                foreach (var item in selectq )
                {
                    ListInfo.Add(new tb_impuesto_Info(item.IdImpuesto, item.nom_Impuesto_tipo, item.IdImpuesto_tipo));

                }
            }
            catch (Exception)
            {

                return new List<tb_impuesto_Info>();
            }
            return ListInfo;
        
        }

        public Boolean GrabarDB(tb_impuesto_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var addressG = new tb_impuesto(); 
                    addressG.IdImpuesto = Info.IdImpuesto;
                    addressG.nom_Impuesto = Info.nom_Impuesto;
                    addressG.IdImpuesto_tipo = Info.IdImpuesto_tipo;

                    context.tb_impuesto.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public Boolean ModificarDB(tb_impuesto_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {

                    tb_impuesto contact = context.tb_impuesto.First(cot => cot.IdImpuesto== Info.IdImpuesto && cot.IdImpuesto_tipo == Info.IdImpuesto_tipo);

                    if (contact != null)
                    {

                        contact.nom_Impuesto = Info.nom_Impuesto;

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
