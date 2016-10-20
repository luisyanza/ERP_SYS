using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cotizacion_Bus
    {
        
        fac_cotizacion_Data oData = new fac_cotizacion_Data ();

        public List<fac_cotizacion_Info> Get_List_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return oData.Get_List_cotizacion(IdEmpresa, IdSucursal, IdPuntoVta);
            }
            catch (Exception)
            {

                return new List<fac_cotizacion_Info>(); ;
            }
        }

        public fac_cotizacion_Info Get_Info_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal Idcotizacion)
        {
            try
            {
                fac_cotizacion_Info Info = new fac_cotizacion_Info();
                Info= oData.Get_Info_cotizacion(IdEmpresa, IdSucursal, IdPuntoVta, Idcotizacion);
                if (Info.IdEmpresa > 0)
                {
                    fac_cotizacion_det_Bus OBusDet = new fac_cotizacion_det_Bus();
                    Info.ListDetalle = OBusDet.Get_List_CotizacionDet(IdEmpresa, IdSucursal, IdPuntoVta, Idcotizacion);
                
                }
                return Info;
            }
            catch (Exception)
            {
                
                return new fac_cotizacion_Info();
            }
        }

        public Boolean GrabarDB(fac_cotizacion_Info Info)
        {

            try
            {
               

                bool Respuesta = false;
                string MensajeError = "";

                Respuesta = Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Respuesta)
                {

                    Respuesta = oData.GrabarDB(Info);
                    if (Respuesta == true)
                    {
                        fac_cotizacion_det_Bus Bus_deta = new fac_cotizacion_det_Bus();

                        Respuesta = Bus_deta.GrabarDB(Info.ListDetalle);

                    }
                   
                }


                return Respuesta;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        private bool Validar_Corregir_Objeto(fac_cotizacion_Info Info, ref string MensajeError)
        {
            try
            {
                bool Respuesta = false;
                #region Validaciones

                if (Info.IdEmpresa == 0)
                {
                    MensajeError = "PK no validado Empresa";
                    return Respuesta;
                }
                if (Info.IdSucursal == 0)
                {
                    MensajeError = "PK no validados Sucursal,";
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

               

                if (Info.ListDetalle.Count < 1)
                {
                    MensajeError = "La Cotizacion debe tener al menos un item.";
                    return false;
                }

                fac_cotizacion_det_Bus BusDet = new fac_cotizacion_det_Bus();
                Respuesta = BusDet.Validar_Corregir_Objeto(Info, ref MensajeError); 

                if (Respuesta == false)
                    return false;

                #endregion

                #region Correcciones

                Info.cc_observacion = (Info.cc_observacion == null) ? "" : Info.cc_observacion;

                #endregion

                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDB(fac_cotizacion_Info Info)
        {

            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean AnularDB(fac_cotizacion_Info Info)
        {

            try
            {
                return oData.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
