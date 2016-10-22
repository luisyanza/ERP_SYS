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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_fac_Catalogos" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_fac_Catalogos.svc or WS_fac_Catalogos.svc.cs at the Solution Explorer and start debugging.
    public class WS_fac_Catalogos : IWS_fac_Catalogos
    {
        /// <summary>
        /// fac_catalogo
        /// </summary>
        fac_catalogo_Bus oBusCatalog = new fac_catalogo_Bus();
        public List<fac_catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                return oBusCatalog.Get_List_Catalogo();
            }
            catch (Exception)
            {

                return new List<fac_catalogo_Info>();
            }

        }

        public List<fac_catalogo_Info> Get_List_Catalogo(int IdCatalogo_tipo)
        {
            try
            {
                return oBusCatalog.Get_List_Catalogo(IdCatalogo_tipo);
            }
            catch (Exception)
            {

                return new List<fac_catalogo_Info>();
            }
        }

        public Boolean ModificarDBCatalogo(fac_catalogo_Info Info)
        {
            try
            {
                return oBusCatalog.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBCatalogo(fac_catalogo_Info Info)
        {
            try
            {
                return oBusCatalog.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }

        }

        /// <summary>
        /// fac_formaPago_Bus
        /// </summary>
        fac_formaPago_Bus oBusFormaPago = new fac_formaPago_Bus();

        public List<fac_formaPago_Info> Get_List_FormaPago(fac_formaPago_Info Info)
        {
            try
            {
                return oBusFormaPago.Get_List_FormaPago(Info);
            }
            catch (Exception)
            {

                return new List<fac_formaPago_Info>();
            }

        }

        public Boolean GrabarDBFormaPago(fac_formaPago_Info Info)
        {
            try
            {
                return oBusFormaPago.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBFormaPago(fac_formaPago_Info Info)
        {
            try
            {
                return oBusFormaPago.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// fac_motivo_venta
        /// </summary>
        fac_motivo_venta_Bus oBusMotivoVenta = new fac_motivo_venta_Bus();

        public List<fac_motivo_venta_Info> Get_List_MotivoVenta(fac_motivo_venta_Info Info)
        {
            try
            {
                return oBusMotivoVenta.Get_List_MotivoVenta(Info);
            }
            catch (Exception)
            {

                return new List<fac_motivo_venta_Info>();
            }

        }

        public fac_motivo_venta_Info Get_Info_MotivoVenta(int idEmpresa, int Idtipo_cliente)
        {
            try
            {
                return oBusMotivoVenta.Get_Info_MotivoVenta(idEmpresa, Idtipo_cliente);
            }
            catch (Exception)
            {

                return new fac_motivo_venta_Info();
            }
        }

        public Boolean GrabarDBMotivoVenta(fac_motivo_venta_Info Info)
        {
            try
            {
                return oBusMotivoVenta.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBMotivoVenta(fac_motivo_venta_Info Info)
        {
            try
            {
                return oBusMotivoVenta.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBMotivoVenta(fac_motivo_venta_Info Info)
        {
            try
            {
                return oBusMotivoVenta.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// fac_parametro
        /// </summary>
        fac_parametro_Bus oBusParametro = new fac_parametro_Bus();

        public fac_parametro_Info Get_Parametros(int IdEmpresa)
        {

            try
            {
                return oBusParametro.Get_Parametros(IdEmpresa);
            }
            catch (Exception)
            {

                return new fac_parametro_Info();
            }
        }

        public Boolean GrabarDBParametros(fac_parametro_Info Info)
        {
            try
            {
                return oBusParametro.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBParametros(fac_parametro_Info Info)
        {
            try
            {
                return oBusParametro.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_pedido_estadoAprobacion_Bus oBusEA = new fac_pedido_estadoAprobacion_Bus();
        public List<fac_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oBusEA.Get_List_EstadoAprobacion(Info);
            }
            catch (Exception)
            {

                return new List<fac_pedido_estadoAprobacion_Info>();
            }

        }

        public Boolean GrabarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oBusEA.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oBusEA.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_pedido_x_formaPago_Bus oBusPedFormPago = new fac_pedido_x_formaPago_Bus();
        public Boolean GrabarDBPedFormPago(List<fac_pedido_x_formaPago_Info> List_Info)
        {
            return oBusPedFormPago.GrabarDB(List_Info);
        }

        public Boolean EliminarDBPedFormPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {
            return oBusPedFormPago.EliminarDB(IdEmpresa, IdSucursal, IdBodega, IdPedido, IdTipoFormaPago);
        }

        public List<fac_pedido_x_formaPago_Info> Get_List_Pedido_x_FormaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {
            return oBusPedFormPago.Get_List_Pedido_x_FormaPago(IdEmpresa, IdSucursal, IdBodega, IdPedido, IdTipoFormaPago);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        fac_TerminoPago_Bus oBusTerminoPago = new fac_TerminoPago_Bus();
        public List<fac_TerminoPago_Info> Get_List_TerminoPago(fac_TerminoPago_Info Info)
        {
            try
            {
                return oBusTerminoPago.Get_List_TerminoPago(Info);
            }
            catch (Exception)
            {

                return new List<fac_TerminoPago_Info>();
            }

        }

        public Boolean GrabarDBTermPago(fac_TerminoPago_Info Info)
        {
            try
            {
                return oBusTerminoPago.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBTermPago(fac_TerminoPago_Info Info)
        {
            try
            {
                return oBusTerminoPago.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        fac_TerminoPago_Distribucion_Bus oBusTermPagoDist = new fac_TerminoPago_Distribucion_Bus();
        public List<fac_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTerminoPago)
        {
            try
            {
                return oBusTermPagoDist.Get_List_TerminoPago_Distribucion(IdTerminoPago);
            }
            catch (Exception)
            {

                return new List<fac_TerminoPago_Distribucion_Info>();
            }

        }

        public Boolean GrabarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info)
        {
            try
            {
                return oBusTermPagoDist.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info)
        {
            try
            {
                return oBusTermPagoDist.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        fac_TipoNota_Bus oBusTipoNota = new fac_TipoNota_Bus();
        public List<fac_TipoNota_Info> Get_List_TipoNota(fac_TipoNota_Info Info)
        {
            try
            {
                return oBusTipoNota.Get_List_TipoNota(Info);
            }
            catch (Exception)
            {

                return new List<fac_TipoNota_Info>();
            }

        }

        public fac_TipoNota_Info Get_Info_TipoNota(int idEmpresa, int IdTipoNota)
        {
            try
            {
                return oBusTipoNota.Get_Info_TipoNota(idEmpresa, IdTipoNota);
            }
            catch (Exception)
            {

                return new fac_TipoNota_Info();
            }
        }

        public Boolean GrabarDBTipoNota(fac_TipoNota_Info Info)
        {
            try
            {
                return oBusTipoNota.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBTipoNota(fac_TipoNota_Info Info)
        {
            try
            {
                return oBusTipoNota.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBTipoNota(fac_TipoNota_Info Info)
        {
            try
            {
                return oBusTipoNota.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_TipoNota_x_tbsucursal_Bus oBusTipoNota_Suc = new fac_TipoNota_x_tbsucursal_Bus();
        public fac_TipoNota_x_tbsucursal_Info Get_Info_TipoNota_Sucursal(int IdEmpresa, int IdSucursal, int IdTipoNota)
        {
            try
            {
                return oBusTipoNota_Suc.Get_Info_TipoNota_Sucursal(IdEmpresa, IdSucursal, IdTipoNota);
            }
            catch (Exception)
            {

                return new fac_TipoNota_x_tbsucursal_Info();
            }

        }

        public Boolean GrabarDBTipoNota_Suc(fac_TipoNota_x_tbsucursal_Info Info)
        {
            try
            {
                return oBusTipoNota_Suc.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
