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
        List<fac_catalogo_Info> Get_List_Catalogo();

        [OperationContract]
        List<fac_catalogo_Info> Get_List_Catalogo(int IdCatalogo_tipo);

        [OperationContract]
        Boolean ModificarDBCatalogo(fac_catalogo_Info Info);

        [OperationContract]
        Boolean AnularDBCatalogo(fac_catalogo_Info Info);


        /// <summary>
        /// fac_formaPago_Bus
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_formaPago_Info> Get_List_FormaPago(fac_formaPago_Info Info);

        [OperationContract]
        Boolean GrabarDBFormaPago(fac_formaPago_Info Info);

        [OperationContract]
        Boolean ModificarDBFormaPago(fac_formaPago_Info Info);

        /// <summary>
        /// fac_motivo_venta
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_motivo_venta_Info> Get_List_MotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        fac_motivo_venta_Info Get_Info_MotivoVenta(int idEmpresa, int Idtipo_cliente);

        [OperationContract]
        Boolean GrabarDBMotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        Boolean ModificarDBMotivoVenta(fac_motivo_venta_Info Info);

        [OperationContract]
        Boolean AnularDBMotivoVenta(fac_motivo_venta_Info Info);

        /// <summary>
        /// fac_parametro
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <returns></returns>
        [OperationContract]
        fac_parametro_Info Get_Parametros(int IdEmpresa);

        [OperationContract]
        Boolean GrabarDBParametros(fac_parametro_Info Info);

        [OperationContract]
        Boolean ModificarDBParametros(fac_parametro_Info Info);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion(fac_pedido_estadoAprobacion_Info Info);

        [OperationContract]
        Boolean GrabarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info);

        [OperationContract]
        Boolean ModificarDBPedEstApr(fac_pedido_estadoAprobacion_Info Info);



        [OperationContract]
        Boolean GrabarDBPedFormPago(List<fac_pedido_x_formaPago_Info> List_Info);

        [OperationContract]
        Boolean EliminarDBPedFormPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago);

        [OperationContract]
        List<fac_pedido_x_formaPago_Info> Get_List_Pedido_x_FormaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_TerminoPago_Info> Get_List_TerminoPago(fac_TerminoPago_Info Info);
                
        [OperationContract]
        Boolean GrabarDBTermPago(fac_TerminoPago_Info Info);
        
        [OperationContract]
        Boolean ModificarDBTermPago(fac_TerminoPago_Info Info);
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdTerminoPago"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTerminoPago);
                
        [OperationContract]
        Boolean GrabarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info);
        
        [OperationContract]
        Boolean ModificarDBTermPagoDist(fac_TerminoPago_Distribucion_Info Info);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_TipoNota_Info> Get_List_TipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        fac_TipoNota_Info Get_Info_TipoNota(int idEmpresa, int IdTipoNota);

        [OperationContract]
        Boolean GrabarDBTipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        Boolean ModificarDBTipoNota(fac_TipoNota_Info Info);

        [OperationContract]
        Boolean AnularDBTipoNota(fac_TipoNota_Info Info);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <param name="IdSucursal"></param>
        /// <param name="IdTipoNota"></param>
        /// <returns></returns>
        [OperationContract]
        fac_TipoNota_x_tbsucursal_Info Get_Info_TipoNota_Sucursal(int IdEmpresa, int IdSucursal, int IdTipoNota);

        [OperationContract]
        Boolean GrabarDBTipoNota_Suc(fac_TipoNota_x_tbsucursal_Info Info);

    }
}
