using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_orden_pedido_Bus
    {
        fac_orden_pedido_Data Odata = new fac_orden_pedido_Data();

        public List<fac_orden_pedido_Info> Get_List_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return Odata.Get_List_OrdenPedido(IdEmpresa, IdSucursal, IdPuntoVta);
            }
            catch (Exception)
            {

                return new List<fac_orden_pedido_Info>(); ;
            }
        }

        public fac_orden_pedido_Info Get_Info_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdPedido)
        {
            try
            {
                fac_orden_pedido_Info Info = new fac_orden_pedido_Info();
                Info = Odata.Get_Info_OrdenPedido(IdEmpresa, IdSucursal, IdPuntoVta, IdPedido);
                if (Info.IdEmpresa > 0)
                {
                    fac_orden_pedido_det_Bus oBusDet = new fac_orden_pedido_det_Bus();
                    Info.List_detalle = oBusDet.Get_List_OrdenPedidoDet(IdEmpresa, IdSucursal, IdPuntoVta, IdPedido);
                }
                return Info;
            }
            catch (Exception)
            {

                return new fac_orden_pedido_Info();
            }
        }

        public Boolean GrabarDB(fac_orden_pedido_Info Info)
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
                        fac_orden_pedido_det_Bus Bus_deta = new fac_orden_pedido_det_Bus();

                        Respuesta = Bus_deta.GrabarDB(Info.List_detalle);


                    }
                    else
                    {
                        Odata.EliminarDB(Info.IdEmpresa, Info.IdSucursal, Info.IdPuntoVta, Info.IdPedido);
                    }
                }


                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean Validar_Corregir_Objeto(fac_orden_pedido_Info Info, ref string MensajeError)
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

                

                if (Info.List_detalle.Count < 1)
                {
                    MensajeError = "El comprobante no tiene detalle.";
                    return false;
                }

                fac_orden_pedido_det_Bus BusDet = new fac_orden_pedido_det_Bus();
                Respuesta = BusDet.Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Respuesta == false)
                    return false;

                #endregion

                #region Correcciones

                Info.cp_observacion = (Info.cp_observacion  == null) ? "" : Info.cp_observacion ;

                #endregion

                return Respuesta;

            }
            catch (Exception)                
            {

                return false;
            }

        }

      
    }
}
