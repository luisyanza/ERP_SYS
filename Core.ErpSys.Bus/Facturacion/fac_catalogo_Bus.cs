using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_catalogo_Bus
    {
        fac_catalogo_Data oData = new fac_catalogo_Data();
        public List<fac_catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                return oData.Get_List_Catalogo();
            }
            catch (Exception)
            {

                return new List<fac_catalogo_Info>();
            }
        
        }
        public List<fac_catalogo_Info> Get_List_Catalogo(int IdCatalogo_tipo)
        {
            try
            {
                return oData.Get_List_Catalogo(IdCatalogo_tipo);
            }
            catch (Exception)
            {

                return new List<fac_catalogo_Info>();
            }      
        }
        public Boolean ModificarDB(fac_catalogo_Info Info)
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

        public Boolean AnularDB(fac_catalogo_Info Info)
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
