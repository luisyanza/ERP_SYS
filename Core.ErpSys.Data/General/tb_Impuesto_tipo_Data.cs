using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Data.General
{
    public class tb_Impuesto_tipo_Data
    {
        public List<tb_Impuesto_tipo_Info> Get_List_ImpuestoTipo()
        {
            List<tb_Impuesto_tipo_Info> ListInfo = new List<tb_Impuesto_tipo_Info>();
            try
            {
                Entities_General oBase = new Entities_General();

                IQueryable<tb_Impuesto_tipo> selectq = from q in oBase.tb_Impuesto_tipo
                                                       select q;

                foreach (tb_Impuesto_tipo item in selectq)
                {
                    ListInfo.Add(new tb_Impuesto_tipo_Info(item.IdImpuesto_tipo, item.nom_Impuesto_tipo));

                }

            }
            catch (Exception)
            {

                return new List<tb_Impuesto_tipo_Info>();
            }
            return ListInfo;

        }
        public Boolean GrabarDB(tb_Impuesto_tipo_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var addressG = new tb_Impuesto_tipo();
                    addressG.IdImpuesto_tipo = Info.IdImpuesto_tipo;
                    addressG.nom_Impuesto_tipo = Info.nom_Impuesto_tipo;
                    context.tb_Impuesto_tipo.Add(addressG);
                    context.SaveChanges();
                    
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public Boolean ModificarDB(tb_Impuesto_tipo_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General()){

                    tb_Impuesto_tipo contact = context.tb_Impuesto_tipo.First(cot => cot.IdImpuesto_tipo == Info.IdImpuesto_tipo);

                    if (contact != null)
                    {

                        contact.nom_Impuesto_tipo = Info.nom_Impuesto_tipo;

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
