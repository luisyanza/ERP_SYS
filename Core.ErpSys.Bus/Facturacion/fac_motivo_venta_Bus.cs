using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_motivo_venta_Bus
    {

        fac_motivo_venta_Data oData = new fac_motivo_venta_Data();

        public List<fac_motivo_venta_Info> Get_List_MotivoVenta(fac_motivo_venta_Info Info)
        {
            try
            {
                return oData.Get_List_MotivoVenta(Info);
            }
            catch (Exception)
            {

                return new List<fac_motivo_venta_Info>();
            }

        }
        public fac_motivo_venta_Info Get_Info_MotivoVenta(int idEmpresa, int Idtipo_cliente)
        {
            try
            {
                return oData.Get_Info_MotivoVenta(idEmpresa, Idtipo_cliente);
            }
            catch (Exception)
            {

                return new fac_motivo_venta_Info();
            }
        }

        public Boolean GrabarDB(fac_motivo_venta_Info Info)
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
        public Boolean ModificarDB(fac_motivo_venta_Info Info)
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
        public Boolean AnularDB(fac_motivo_venta_Info Info)
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
