using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Bus.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSFactura" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSFactura.svc or WSFactura.svc.cs at the Solution Explorer and start debugging.
    public class WSFactura : IWS_fa_Factura
    {
        fa_cbteVta_Talonario_Bus oBusTalon = new fa_cbteVta_Talonario_Bus();
        public fa_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
           
                return oBusTalon.Get_NumCbteVta_Talonario(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVtaTipo);
           
        }


        public List<fa_cbteVta_Talonario_Info> GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            
                return oBusTalon.GrabarDBTalonario(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango, Rango);
           
        }
    }
}
