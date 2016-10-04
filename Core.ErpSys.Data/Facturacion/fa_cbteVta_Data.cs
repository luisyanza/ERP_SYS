using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
   public class fa_cbteVta_Data
    {

       public Boolean GrabarDB(fa_cbteVta_Info Info)
       {
           try
           {
               using (Entities_Facturacion context = new Entities_Facturacion())
               {


                   var addressG = new fa_cbteVta();

                   addressG.IdEmpresa = Info.IdEmpresa;
                   addressG.IdCbteVtaTipo = Info.IdCbteVtaTipo;
                   addressG.IdCbteVta = Info.IdCbteVta = Get_IdCbteVta(Info.IdEmpresa, Info.IdCbteVtaTipo);


                   context.fa_cbteVta.Add(addressG);
                   context.SaveChanges();

               }
           }
           catch (Exception)
           {
               return false;
           }

           return true;

       }

       public Boolean EliminarDB(int IdEmpresa,string IdTipoCbteVta,decimal IdCbte)
       {
           try
           {
               bool respuesta = false;


               return respuesta;
           }
           catch (Exception)
           {
               return false;
           }

           return true;

       }

       public decimal Get_IdCbteVta(int IdEmpresa, string IdTipoCbteVta)
       {
           try
           {

               return 1;
           }
           catch (Exception ex)
           {
               
               throw;
           }
       }

      



    }
}
