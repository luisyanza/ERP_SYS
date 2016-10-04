using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.General;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Bus.General
{
    public class tb_empresa_Bus
    {
        tb_empresa_Data oData = new tb_empresa_Data();

        public List<tb_empresa_Info> Get_List_Empresa()
        {

            try
            {
                return oData.Get_List_Empresa();
            }
            catch (Exception)
            {
                
                return new List<tb_empresa_Info>();
            }
        
        }

        public tb_empresa_Info Get_Info_Empresa(int IdEmpresa)
        {
            try
            {
                return oData.Get_Info_Empresa(IdEmpresa );
            }
            catch (Exception)
            {

                return new tb_empresa_Info();
            }
        }
        public Boolean GrabarDB(tb_empresa_Info Info)
        {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false ;
            }
        }

        public Boolean ModificarDB(tb_empresa_Info Info)
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
        public Boolean AnularDB(tb_empresa_Info Info)
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
