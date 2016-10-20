﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
   public class fac_cbteVta_Bus
    {
       fac_cbteVta_Data Odata= new fac_cbteVta_Data();

       public List<fac_cbteVta_Info> Get_List_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta)
       {
           try
           {
               return Odata.Get_List_CbteVta(IdEmpresa, IdSucursal, IdPuntoVta);
           }
           catch (Exception)
           {

               return new List<fac_cbteVta_Info>(); ;
           }
       }

       public fac_cbteVta_Info Get_Info_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdCbteVta)
       {
           try
           {
               fac_cbteVta_Info Info = new fac_cbteVta_Info();
               Info = Odata.Get_Info_CbteVta(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVta);
               if (Info.IdEmpresa > 0)
               {
                   fac_cbteVta_det_Bus oBusDet = new fac_cbteVta_det_Bus();
                   Info.List_detalle = oBusDet.Get_List_CbteVta(IdEmpresa, IdCbteVta);
               }
               return Info;
           }
           catch (Exception)
           {

               return new fac_cbteVta_Info();
           }
       }

       public Boolean GrabarDB(fac_cbteVta_Info Info)
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
                       fac_cbteVta_det_Bus Bus_deta = new fac_cbteVta_det_Bus();

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
               
               return false ;
           }

       }

       public Boolean Validar_Corregir_Objeto(fac_cbteVta_Info Info,ref string MensajeError)
       {

           try
           {
               bool Respuesta = false;
               #region Validaciones

               if ( Info.IdEmpresa == 0 )
               {
                   MensajeError = "PK no validado Empresa";
                   return Respuesta;
               }
                if ( Info.IdSucursal ==0 )
               {
                   MensajeError = "PK no validados Sucursal,";
                   return Respuesta;
               }
               if ( String.IsNullOrEmpty(Info.IdCbteVtaTipo))
               {
                   MensajeError = "PK no validado TipoCbteVta";
                   return Respuesta;
               }
               if (Info.IdPuntoVta == 0)
               {
                   MensajeError = "PK no validado Punto Venta";
                   return Respuesta;               
               }
               if (Info.IdCliente == 0)
               {
                   MensajeError = "PK no validado Cliente";
                   return Respuesta;
               }
                       
               if (GetNumCbteVta(ref MensajeError))
               {
                   Respuesta = false;
               }

               if (Info.List_detalle.Count < 1)
               {
                   MensajeError = "El comprobante no tiene detalle.";
                   return false;
               }
               
               fac_cbteVta_det_Bus BusDet = new fac_cbteVta_det_Bus();
               Respuesta = BusDet.Validar_Corregir_Objeto(Info, ref MensajeError);
               
               if (Respuesta == false)
                   return false;

               #endregion

               #region Correcciones

                    Info.vt_Observacion = (Info.vt_Observacion == null) ? "" : Info.vt_Observacion;
               
               #endregion                           

               return Respuesta;

           }
           catch (Exception)
           {

               return false;
           }
       
       }

       public Boolean GetNumCbteVta(ref string Mensaje)
       {
           throw new NotImplementedException();
       }

    }
}
