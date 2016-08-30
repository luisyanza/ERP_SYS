using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Sistemas;


namespace Core.ErpSys.Data.Sistemas
{
   public class tb_sis_reporte_Data
    {
       public List<tb_sis_reporte_Info> Get_List_Reporte()
       {
          List<tb_sis_reporte_Info> ListInfo= new List<tb_sis_reporte_Info>();


          Entities_Sistemas OBase = new Entities_Sistemas();

          var selectq = from q in OBase.tb_sis_reporte
                        select q;

          foreach (var item in selectq)
          {
              ListInfo.Add(new tb_sis_reporte_Info(item.IdReporte, item.nom_reporte));
          }

            
           
          return ListInfo;

       }

       public List<tb_sis_reporte_Info> Get_List_Reporte(DateTime fechaIni, DateTime fechaFin)
       {
           List<tb_sis_reporte_Info> ListInfo = new List<tb_sis_reporte_Info>();


           Entities_Sistemas OBase = new Entities_Sistemas();

           var selectq = from q in OBase.tb_sis_reporte
                         select q;

           foreach (var item in selectq)
           {
               ListInfo.Add(new tb_sis_reporte_Info(item.IdReporte, item.nom_reporte));
           }



           return ListInfo;

       }

       public tb_sis_reporte_Info Get_Info_Reporte(string IdReporte)
       {

           tb_sis_reporte_Info Info = new tb_sis_reporte_Info();


           Entities_Sistemas OBase = new Entities_Sistemas();

           var selectq = from q in OBase.tb_sis_reporte
                         where q.IdReporte == IdReporte
                         select q;

           foreach (var item in selectq)
           {
               Info.IdReporte = item.IdReporte;
               Info.nom_reporte = item.nom_reporte;
           }


           return Info;

       }

       public Boolean GrabarDB(tb_sis_reporte_Info Info)
       {

           using (Entities_Sistemas context = new Entities_Sistemas())
           {
               Entities_Sistemas fact = new Entities_Sistemas();

               var addressG = new tb_sis_reporte();
               addressG.IdReporte = Info.IdReporte;
               addressG.nom_reporte = Info.nom_reporte;
               addressG.cod_reporte = "";
               addressG.estado = true;
               context.tb_sis_reporte.Add(addressG);
               context.SaveChanges();


               
           }
           return true;
       
       }

       public Boolean ModificarDB(tb_sis_reporte_Info Info)
       {
           using (Entities_Sistemas context = new Entities_Sistemas())
           {
               var contact = context.tb_sis_reporte.FirstOrDefault(cot => cot.IdReporte == Info.IdReporte);

               if (contact != null)
               {
                   contact.nom_reporte = Info.nom_reporte;

                   context.SaveChanges();
               }
           }
           return true;

       }

       public Boolean AnularDB(tb_sis_reporte_Info Info)
       {
           using (Entities_Sistemas context = new Entities_Sistemas())
           {
               var contact = context.tb_sis_reporte.FirstOrDefault(cot => cot.IdReporte == Info.IdReporte);
               if (contact != null)
               {
                   contact.estado = false;

                  
                   context.SaveChanges();
               }
           }
           return true;

       }


    }
}
