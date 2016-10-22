using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWSFactura" in both code and config file together.
    [ServiceContract]
    public interface IWS_fac_Factura
    {
        [OperationContract]
        fac_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo);
 
        [OperationContract]
        Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango);


        [OperationContract]
        bool AnularDBCbteVtaTipo(fac_cbteVta_tipo_Info Info);

        [OperationContract]
        fac_cbteVta_Info Get_Info_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdCbteVta);

        [OperationContract]
        List<fac_cbteVta_Info> Get_List_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta);

        [OperationContract]
        List<fac_cbteVta_tipo_Info> Get_List_CbteVtaTipo();

        
        [OperationContract]
        bool GetNumCbteVta(ref string Mensaje);

        [OperationContract]
        bool GrabarDBCbteVta(fac_cbteVta_Info Info);

        [OperationContract]
        bool GrabarDBCbteVtaTipo(fac_cbteVta_tipo_Info Info);

       
        [OperationContract]
        bool ModificarDBCbteVtaTipo(fac_cbteVta_tipo_Info Info);
    }
}
