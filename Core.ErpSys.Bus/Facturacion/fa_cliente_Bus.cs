using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fa_cliente_Bus
    {

        fa_cliente_Data oData = new fa_cliente_Data();

        public List<fa_cliente_Info> Get_List_Cliente(int IdEmpresa)
        {

            try
            {
                return oData.Get_List_Cliente(IdEmpresa);
            }
            catch (Exception)
            {

                return new List<fa_cliente_Info>();
            }

        }

        public fa_cliente_Info Get_Info_Cliente(int IdEmpresa, int IdCliente)
        {
            try
            {
                return oData.Get_Info_Cliente(IdEmpresa, IdCliente);
            }
            catch (Exception)
            {

                return new fa_cliente_Info();
            }
        }
        public Boolean GrabarDB(fa_cliente_Info Info)
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

        public Boolean ModificarDB(fa_cliente_Info Info)
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
        public Boolean AnularDB(fa_cliente_Info Info)
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
