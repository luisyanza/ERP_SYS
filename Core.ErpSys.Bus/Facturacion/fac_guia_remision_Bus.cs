using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_guia_remision_Bus
    {

        fac_guia_remision_Data Odata = new fac_guia_remision_Data();

        public List<fac_guia_remision_Info> Get_List_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return Odata.Get_List_GuiaRemision(IdEmpresa, IdSucursal, IdPuntoVta);
            }
            catch (Exception)
            {

                return new List<fac_guia_remision_Info>(); ;
            }
        }

        public fac_guia_remision_Info Get_Info_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdGuiaRemision)
        {
            try
            {
                fac_guia_remision_Info Info = new fac_guia_remision_Info();
                Info = Odata.Get_Info_GuiaRemision(IdEmpresa, IdSucursal, IdPuntoVta, IdGuiaRemision);
                if (Info.IdEmpresa > 0)
                {
                    fac_guia_remision_det_Bus oBusDet = new fac_guia_remision_det_Bus();
                    Info.List_detalle = oBusDet.Get_List_GuiaRemision(IdEmpresa, IdSucursal,IdPuntoVta, IdGuiaRemision);
                }
                return Info;
            }
            catch (Exception)
            {

                return new fac_guia_remision_Info();
            }
        }

        public Boolean GrabarDB(fac_guia_remision_Info Info)
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
                        fac_guia_remision_det_Bus Bus_deta = new fac_guia_remision_det_Bus();

                        Respuesta = Bus_deta.GrabarDB(Info.List_detalle);


                    }
                    else
                    {
                        Odata.EliminarDB(Info.IdEmpresa, Info.IdSucursal,Info.IdPuntoVta  , Info.IdGuiaRemision);
                    }
                }


                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean Validar_Corregir_Objeto(fac_guia_remision_Info Info, ref string MensajeError)
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

                if (GetNumGuiaRemision(ref MensajeError))
                {
                    Respuesta = false;
                }

                if (Info.List_detalle.Count < 1)
                {
                    MensajeError = "El comprobante no tiene detalle.";
                    return false;
                }

                fac_guia_remision_det_Bus BusDet = new fac_guia_remision_det_Bus();
                Respuesta = BusDet.Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Respuesta == false)
                    return false;

                #endregion

                #region Correcciones

                Info.gi_Observacion = (Info.gi_Observacion == null) ? "" : Info.gi_Observacion;

                #endregion

                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean GetNumGuiaRemision(ref string Mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
