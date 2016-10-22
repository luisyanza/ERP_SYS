using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_fac_Catalogos" in both code and config file together.
    [ServiceContract]
    public interface IWS_fac_Catalogos
    {
        /// <summary>
        /// fac_catalogo
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        public List<fac_catalogo_Info> Get_List_Catalogo();

        [OperationContract]
        public List<fac_catalogo_Info> Get_List_Catalogo(int IdCatalogo_tipo);

        [OperationContract]
        public Boolean ModificarDBCatalogo(fac_catalogo_Info Info);

        [OperationContract]
        public Boolean AnularDBCatalogo(fac_catalogo_Info Info);


        /// <summary>
        /// fac_formaPago_Bus
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_formaPago_Info> Get_List_FormaPago(fac_formaPago_Info Info);

        [OperationContract]
        public Boolean GrabarDBFormaPago(fac_formaPago_Info Info);

        [OperationContract]
        public Boolean ModificarDBFormaPago(fac_formaPago_Info Info);

        /// <summary>
        /// fac_motivo_venta
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_motivo_venta_Info> Get_List_MotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        public fac_motivo_venta_Info Get_Info_MotivoVenta(int idEmpresa, int Idtipo_cliente);

        [OperationContract]
        public Boolean GrabarDBMotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        public Boolean ModificarDBMotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        public Boolean AnularDBMotivoVenta(fac_motivo_venta_Info Info);

        /// <summary>
        /// fac_parametro
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <returns></returns>
        [OperationContract]
        public fac_parametro_Info Get_Parametros(int IdEmpresa);

        [OperationContract]
        public Boolean GrabarDBParametros(fac_parametro_Info Info);

        [OperationContract]
        public Boolean ModificarDBParametros(fac_parametro_Info Info);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion(fac_pedido_estadoAprobacion_Info Info);

        [OperationContract]
        public Boolean GrabarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info);

        [OperationContract]
        public Boolean ModificarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info);



        [OperationContract]
        public Boolean GrabarDBPedFormPago(List<fac_pedido_x_formaPago_Info> List_Info);

        [OperationContract]
        public Boolean EliminarDBPedFormPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago);

        [OperationContract]
        public List<fac_pedido_x_formaPago_Info> Get_List_Pedido_x_FormaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_TerminoPago_Info> Get_List_TerminoPago(fac_TerminoPago_Info Info);
                
        [OperationContract]
        public Boolean GrabarDBTermPago(fac_TerminoPago_Info Info);
        
        [OperationContract]
        public Boolean ModificarDBTermPago(fac_TerminoPago_Info Info);
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdTerminoPago"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTerminoPago);
                
        [OperationContract]
        public Boolean GrabarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info);
        
        [OperationContract]
        public Boolean ModificarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        public List<fac_TipoNota_Info> Get_List_TipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        public fac_TipoNota_Info Get_Info_TipoNota(int idEmpresa, int IdTipoNota);

        [OperationContract]
        public Boolean GrabarDBTipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        public Boolean ModificarDBTipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        public Boolean AnularDBTipoNota(fac_TipoNota_Info Info);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <param name="IdSucursal"></param>
        /// <param name="IdTipoNota"></param>
        /// <returns></returns>
        [OperationContract]
        public fac_TipoNota_x_tbsucursal_Info Get_Info_TipoNota_Sucursal(int IdEmpresa, int IdSucursal, int IdTipoNota);

        [OperationContract]
        public Boolean GrabarDBTipoNota_Suc(fac_TipoNota_x_tbsucursal_Info Info);

    }
}
