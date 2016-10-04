using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
   public class fa_cbteVta_Bus
    {
       fa_cbteVta_Data Odata= new fa_cbteVta_Data();


       public Boolean GrabarDB(fa_cbteVta_Info Info)
       {

           try
           {
               bool Respuesta = false;
               string MensajeError = "";

               Respuesta = Validar_Corregir_Objeto(Info, ref MensajeError);

               if (Respuesta)
               {

                   Respuesta = Odata.GrabarDB(Info);
                   if (Respuesta == true)
                   {
                       fa_cbteVta_det_Bus Bus_deta = new fa_cbteVta_det_Bus();

                       Respuesta = Bus_deta.GrabarDB(Info.List_detalle);


                   }
                   else
                   {
                       Odata.EliminarDB(Info.IdEmpresa, Info.IdCbteVtaTipo, Info.IdCbteVta);
                   }
               }


               return Respuesta;

           }
           catch (Exception)
           {
               
               throw;
           }

       }

       public Boolean Validar_Corregir_Objeto(fa_cbteVta_Info Info,ref string MensajeError)
       {

           try
           {
               bool Respuesta = false;
               #region Validaciones

               if ( Info.IdEmpresa == 0 )
               {
                   Respuesta = false;
                   MensajeError = "PK no validado Empresa";
                   return Respuesta;
               }
                if ( Info.IdSucursal ==0 )
               {
                   Respuesta = false;
                   MensajeError = "PK no validados Sucursal,";
                   return Respuesta;
               }
               if ( String.IsNullOrEmpty(Info.IdCbteVtaTipo))
               {
                   Respuesta = false;
                   MensajeError = "PK no validado TipoCbteVta";
                   return Respuesta;
               }
               if (Info.IdPuntoVta == 0)
               {
                   Respuesta = false;
                   MensajeError = "PK no validado Punto Venta";
                   return Respuesta;               
               }
               if (Info.IdCliente == 0)
               {
                   Respuesta = false;
                   MensajeError = "PK no validado Cliente";
                   return Respuesta;
               }
               
               if (GetNumCbteVta(ref MensajeError))
               {
                   Respuesta = false;
               }
               
               #endregion

               #region Correcciones

                    Info.observacion = (Info.observacion == null) ? "" : Info.observacion;
               
               #endregion






               return Respuesta;

           }
           catch (Exception)
           {

               throw;
           }
       
       }

       private bool GetNumCbteVta(ref string Mensaje)
       {
           throw new NotImplementedException();
       }

    }
}
