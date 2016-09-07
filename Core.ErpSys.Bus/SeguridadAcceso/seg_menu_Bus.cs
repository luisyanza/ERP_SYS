using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.SeguridadAcceso;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class seg_menu_Bus
    {
        seg_menu_Data oData = new seg_menu_Data();

        public List<seg_menu_Info> Get_List_Menu() {

            try
            {
                return oData.Get_List_Menu();
            }
            catch (Exception)
            {
                return new List<seg_menu_Info>();
                
            }

        }
        public List<seg_menu_Info> Get_List_Menu(string IdUsuario)
        {

            try
            {
                return oData.Get_List_Menu(IdUsuario );
            }
            catch (Exception)
            {
                return new List<seg_menu_Info>();

            }

        }

        public seg_menu_Info Get_Info_Menu(string IdMenu)
        {

            try
            {
                return oData.Get_Info_Menu(IdMenu);
            }
            catch (Exception)
            {
                
                return new seg_menu_Info();
            }
        }

        public Boolean GrabarDB(seg_menu_Info Info)
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


        public Boolean ModificarDB(seg_menu_Info Info)
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
        public Boolean AnularDB(seg_menu_Info Info)
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
