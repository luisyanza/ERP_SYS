using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;


namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWS_fac_Vendedor" in both code and config file together.
    [ServiceContract]
    public interface IWS_fac_Vendedor
    {
        [OperationContract]
        List<fac_Vendedor_Info> Get_List_Vendedor(int IdEmpresa);

        [OperationContract]
        fac_Vendedor_Info Get_Info_Vendedor(int IdEmpresa, decimal IdVendedor);

        [OperationContract]
        Boolean GrabarDB(fac_Vendedor_Info Info);

        [OperationContract]
        Boolean ModificarDB(fac_Vendedor_Info Info);

        [OperationContract]
        Boolean AnularDB(fac_Vendedor_Info Info);

    }
}
