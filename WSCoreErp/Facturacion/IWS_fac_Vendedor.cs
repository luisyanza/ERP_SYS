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
        public List<fac_Vendedor_Info> Get_List_Vendedor(int IdEmpresa);
        
        [OperationContract]
        public fac_Vendedor_Info Get_Info_Vendedor(int IdEmpresa, decimal IdVendedor);

        [OperationContract]
        public Boolean GrabarDB(fac_Vendedor_Info Info);
        
        [OperationContract]
         public Boolean ModificarDB(fac_Vendedor_Info Info);

        [OperationContract]
        public Boolean AnularDB(fac_Vendedor_Info Info);

    }
}
