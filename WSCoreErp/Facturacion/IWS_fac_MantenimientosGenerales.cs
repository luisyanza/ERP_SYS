using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_fac_MantenimientosGenerales" in both code and config file together.
    [ServiceContract]
    public interface IWS_fac_MantenimientosGenerales
    {

        [OperationContract]
        Boolean AnularDBCotizacion(fac_cotizacion_Info Info);

        [OperationContract]
        Boolean AnularDBDevolVta(fac_devol_venta_Info Info);

        [OperationContract]
        fac_cotizacion_Info Get_Info_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal Idcotizacion);

        [OperationContract]
        fac_devol_venta_Info Get_Info_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdDevolucion);
        
        [OperationContract]
        fac_guia_remision_Info Get_Info_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdGuiaRemision);

        [OperationContract]
        fac_orden_pedido_Info Get_Info_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdPedido);

        [OperationContract]
        List<fac_cotizacion_Info> Get_List_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta);

        [OperationContract]
        List<fac_devol_venta_Info> Get_List_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta);

        [OperationContract]
        List<fac_guia_remision_Info> Get_List_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta);

        [OperationContract]
        List<fac_orden_pedido_Info> Get_List_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta);

        [OperationContract]
        Boolean GetNumGuiaRemision(ref string Mensaje);

        [OperationContract]
        Boolean GrabarDBCotizacion(fac_cotizacion_Info Info);


        [OperationContract]
        Boolean GrabarDBDevolVta(fac_devol_venta_Info Info);

        [OperationContract]
        Boolean GrabarDBGuiaRemision(fac_guia_remision_Info Info);

        [OperationContract]
        Boolean GrabarDBOrdenPedido(fac_orden_pedido_Info Info);

        [OperationContract]
        Boolean ModificarDBCotizacion(fac_cotizacion_Info Info);

        [OperationContract]
        Boolean ModificarDBDevolVta(fac_devol_venta_Info Info);

    }
}
