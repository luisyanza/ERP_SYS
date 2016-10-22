using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Bus.Facturacion;
using Core.ErpSys.Info.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_fac_MantenimientosGenerales" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_fac_MantenimientosGenerales.svc or WS_fac_MantenimientosGenerales.svc.cs at the Solution Explorer and start debugging.
    public class WS_fac_MantenimientosGenerales : IWS_fac_MantenimientosGenerales
    {

        /// <summary>
        /// 
        /// </summary>
        fac_cotizacion_Bus oBusCotizacion = new fac_cotizacion_Bus();

        public List<fac_cotizacion_Info> Get_List_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return oBusCotizacion.Get_List_cotizacion(IdEmpresa, IdSucursal, IdPuntoVta);
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
                return oBusCotizacion.Get_Info_cotizacion(IdEmpresa, IdSucursal, IdPuntoVta, Idcotizacion);
            }
            catch (Exception)
            {

                return new fac_cotizacion_Info();
            }
        }

        public Boolean GrabarDBCotizacion(fac_cotizacion_Info Info)
        {

            try
            {


               return oBusCotizacion.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBCotizacion(fac_cotizacion_Info Info)
        {

            try
            {
                return oBusCotizacion.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBCotizacion(fac_cotizacion_Info Info)
        {

            try
            {
                return oBusCotizacion.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_devol_venta_Bus oBusDevolVta = new fac_devol_venta_Bus();

        public List<fac_devol_venta_Info> Get_List_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return oBusDevolVta.Get_List_Devolucion(IdEmpresa, IdSucursal, IdPuntoVta);
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
               return oBusDevolVta.Get_Info_Devolucion(IdEmpresa,IdSucursal,IdPuntoVta,IdDevolucion);

            }
            catch (Exception)
            {

                return new fac_devol_venta_Info();
            }
        }
        
        public Boolean GrabarDBDevolVta(fac_devol_venta_Info Info)
        {

            try
            {

                return oBusDevolVta.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBDevolVta(fac_devol_venta_Info Info)
        {

            try
            {
                return oBusDevolVta.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBDevolVta(fac_devol_venta_Info Info)
        {

            try
            {
                return oBusDevolVta.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_guia_remision_Bus OBusGuiaRemision = new fac_guia_remision_Bus();

        public List<fac_guia_remision_Info> Get_List_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return OBusGuiaRemision.Get_List_GuiaRemision(IdEmpresa, IdSucursal, IdPuntoVta);
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
                return OBusGuiaRemision.Get_Info_GuiaRemision(IdEmpresa, IdSucursal, IdPuntoVta, IdGuiaRemision);
            }
            catch (Exception)
            {

                return new fac_guia_remision_Info();
            }
        }

        public Boolean GrabarDBGuiaRemision(fac_guia_remision_Info Info)
        {

            try
            {
                return OBusGuiaRemision.GrabarDB(Info);

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean GetNumGuiaRemision(ref string Mensaje)
        {
            return OBusGuiaRemision.GetNumGuiaRemision(ref Mensaje);
        }

        /// <summary>
        /// 
        /// </summary>
        fac_orden_pedido_Bus OBusOrdenPedido = new fac_orden_pedido_Bus();

        public List<fac_orden_pedido_Info> Get_List_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return OBusOrdenPedido.Get_List_OrdenPedido(IdEmpresa, IdSucursal, IdPuntoVta);
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
                return OBusOrdenPedido.Get_Info_OrdenPedido(IdEmpresa, IdSucursal, IdPuntoVta, IdPedido);
            }
            catch (Exception)
            {

                return new fac_orden_pedido_Info();
            }
        }

        public Boolean GrabarDBOrdenPedido(fac_orden_pedido_Info Info)
        {

            try
            {
                return OBusOrdenPedido.GrabarDB(Info);

            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
