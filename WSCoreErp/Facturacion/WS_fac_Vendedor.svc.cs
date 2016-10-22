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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_fac_Vendedor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_fac_Vendedor.svc or WS_fac_Vendedor.svc.cs at the Solution Explorer and start debugging.
    public class WS_fac_Vendedor : IWS_fac_Vendedor
    {
        fac_Vendedor_Bus oBus = new fac_Vendedor_Bus();

        public List<fac_Vendedor_Info> Get_List_Vendedor(int IdEmpresa)
        {
            try
            {
                return oBus.Get_List_Vendedor(IdEmpresa);
            }
            catch (Exception)
            {

                return new List<fac_Vendedor_Info>(); ;
            }
        }

        public fac_Vendedor_Info Get_Info_Vendedor(int IdEmpresa, decimal IdVendedor)
        {
            try
            {
                return oBus.Get_Info_Vendedor(IdEmpresa, IdVendedor);
            }
            catch (Exception)
            {

                return new fac_Vendedor_Info();
            }
        }

        public Boolean GrabarDB(fac_Vendedor_Info Info)
        {
            try
            {
                return oBus.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false; ;
            }
        }

        public Boolean ModificarDB(fac_Vendedor_Info Info)
        {
            try
            {
                return oBus.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false; ;
            }
        }

        public Boolean AnularDB(fac_Vendedor_Info Info)
        {
            try
            {
                return oBus.AnularDB(Info);
            }
            catch (Exception)
            {

                return false; ;
            }
        }
    }
}
