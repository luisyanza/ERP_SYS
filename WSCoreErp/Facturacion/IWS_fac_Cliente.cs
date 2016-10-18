using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;


namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_fac_Cliente" in both code and config file together.
    [ServiceContract]
    public interface IWS_fac_Cliente
    {

        [OperationContract]
        List<fac_cliente_Info> Get_List_Cliente(int IdEmpresa);

        
        [OperationContract]
        fac_cliente_Info Get_Info_Cliente(int IdEmpresa, int IdCliente);


        [OperationContract]
        Boolean GrabarDB_Cliente(fac_cliente_Info Info, ref string MensajeError);


        [OperationContract]
        Boolean ModificarDB_Cliente(fac_cliente_Info Info, ref string MensajeError);

        
        [OperationContract]
        Boolean AnularDB_Cliente(fac_cliente_Info Info);


    }
}
