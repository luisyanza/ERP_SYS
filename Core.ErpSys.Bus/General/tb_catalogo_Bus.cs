using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;
using Core.ErpSys.Data.General;

namespace Core.ErpSys.Bus.General
{
    public class tb_catalogo_Bus
    {
        tb_catalogo_Data oData = new tb_catalogo_Data();
        public List<tb_catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                return oData.Get_List_Catalogo();
            }
            catch (Exception)
            {
                return new List<tb_catalogo_Info>();
            }
        }
        public List<tb_catalogo_Info> Get_List_Catalogo(string IdCatalogo_tipo)
        {
            try
            {
                return oData.Get_List_Catalogo(IdCatalogo_tipo);
            }
            catch (Exception)
            {
                return new List<tb_catalogo_Info>();
            }
        }
        public Boolean ModificarDB(tb_catalogo_Info Info) {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {
                
                return false ;
            }
        }
        public Boolean AnularDB(tb_catalogo_Info Info)
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
