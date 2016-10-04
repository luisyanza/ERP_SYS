using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
   public class fa_cbteVta_det_Bus
    {

       fa_cbteVta_det_Data Odata = new fa_cbteVta_det_Data();

       public Boolean GrabarDB(List<fa_cbteVta_det_Info> List_Info)
       {
           try
           {
               return Odata.GrabarDB(List_Info);

              
           }
           catch (Exception)
           {
               return false;
           }

           return true;

       }
    }
}
