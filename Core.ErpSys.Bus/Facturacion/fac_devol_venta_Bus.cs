using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_devol_venta_Bus
    {
        fac_devol_venta_Data oData = new fac_devol_venta_Data();

        public List<fac_devol_venta_Info> Get_List_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return oData.Get_List_Devolucion(IdEmpresa, IdSucursal, IdPuntoVta);
            }
            catch (Exception)
            {

                return new List<fac_devol_venta_Info>(); ;
            }
        }
        public fac_devol_venta_Info Get_Info_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdDevolucion)
        {
            try
            {
                return oData.Get_Info_Devolucion(IdEmpresa, IdSucursal, IdPuntoVta, IdDevolucion);
            }
            catch (Exception)
            {

                return new fac_devol_venta_Info();
            }
        }
        public Boolean GrabarDB(fac_devol_venta_Info Info)
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
                        fac_devol_venta_det_Bus Bus_deta = new fac_devol_venta_det_Bus();

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

        private bool Validar_Corregir_Objeto(fac_devol_venta_Info Info, ref string MensajeError)
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
                    MensajeError = "La Devolucion debe tener al menos un item.";
                    return false;
                }

                fac_devol_venta_det_Bus BusDet = new fac_devol_venta_det_Bus();
                Respuesta = BusDet.Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Respuesta == false)
                    return false;

                #endregion

                #region Correcciones

                Info.dv_Observacion = (Info.dv_Observacion == null) ? "" : Info.dv_Observacion;

                #endregion

                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDB(fac_devol_venta_Info Info)
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
        public Boolean AnularDB(fac_devol_venta_Info Info)
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
