using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cliente_tipo_Bus
    {
        fac_cliente_tipo_Data oData = new fac_cliente_tipo_Data();
        public List<fac_cliente_tipo_Info> Get_List_ClienteTipo(fac_cliente_tipo_Info Info)
        {
            try
            {
                return oData.Get_List_ClienteTipo(Info);
            }
            catch (Exception)
            {
                
                return new List<fac_cliente_tipo_Info>();
            }
        
        }
        public fac_cliente_tipo_Info Get_Info_ClienteTipo(int idEmpresa, int Idtipo_cliente)
        {
            try
            {
                return oData.Get_Info_ClienteTipo(idEmpresa, Idtipo_cliente);
            }
            catch (Exception)
            {

                return new fac_cliente_tipo_Info();
            }
        }

        public Boolean GrabarDB(fac_cliente_tipo_Info Info)
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
        public Boolean ModificarDB(fac_cliente_tipo_Info Info)
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
        public Boolean AnularDB(fac_cliente_tipo_Info Info)
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
