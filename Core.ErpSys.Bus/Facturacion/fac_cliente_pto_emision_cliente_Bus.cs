using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cliente_pto_emision_cliente_Bus
    {
        fac_cliente_pto_emision_cliente_Data oData = new fac_cliente_pto_emision_cliente_Data();
        public List<fac_cliente_pto_emision_cliente_Info> Get_List_Cliente_pto_emision_cliente(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return oData.Get_List_Cliente_pto_emision_cliente(IdEmpresa, IdCliente);
            }
            catch (Exception)
            {

                return new List<fac_cliente_pto_emision_cliente_Info>(); ;
            }
        }

        public fac_cliente_pto_emision_cliente_Info Get_Info_Cliente_pto_emision_cliente(int IdEmpresa, decimal IdCliente, int IdPuntoEmision)
        {
            try
            {
                return oData.Get_Info_Cliente_pto_emision_cliente(IdEmpresa,IdCliente,IdPuntoEmision);
            }
            catch (Exception)
            {

                return new fac_cliente_pto_emision_cliente_Info(); ;
            }
        }

        public Boolean GrabarDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public Boolean ModificarDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                return oData.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
