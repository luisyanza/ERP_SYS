using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_Vendedor_Bus
    {
        fac_Vendedor_Data oData = new fac_Vendedor_Data();

        public List<fac_Vendedor_Info> Get_List_Vendedor(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_Vendedor(IdEmpresa);
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
                return oData.Get_Info_Vendedor(IdEmpresa, IdVendedor);
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
                return oData.GrabarDB(Info);
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
                return oData.ModificarDB(Info);
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
                return oData.AnularDB(Info);
            }
            catch (Exception)
            {

                return false; ;
            }
        }

    }
}
