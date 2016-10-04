using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
   public class fa_cbteVta_det_Data
    {

        public Boolean GrabarDB(List<fa_cbteVta_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {

                    foreach (var item in List_Info)
                    {

                        var addressG = new fa_cbteVta_det();


                        context.fa_cbteVta_det.Add(addressG);
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
