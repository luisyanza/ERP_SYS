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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <returns></returns>
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        [OperationContract]
        List<fac_cliente_tipo_Info> Get_List_ClienteTipo(fac_cliente_tipo_Info Info);

        [OperationContract]
        fac_cliente_tipo_Info Get_Info_ClienteTipo(int idEmpresa, int Idtipo_cliente);

        [OperationContract]
        Boolean GrabarDBClienteTipo(fac_cliente_tipo_Info Info);

        [OperationContract]
        Boolean ModificarDBClienteTipo(fac_cliente_tipo_Info Info);

        [OperationContract]
        Boolean AnularDBClienteTipo(fac_cliente_tipo_Info Info);

    }
}
