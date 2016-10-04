using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Inventario;
using Core.ErpSys.Data.Inventario;

namespace Core.ErpSys.Bus.Inventario
{
    public class in_producto_Bus
    {
        in_producto_Data oData = new in_producto_Data();

        public List<in_producto_Info> Get_List_Producto(int IdEmpresa)
        {

            try
            {
                return oData.Get_List_Producto(IdEmpresa);
            }
            catch (Exception)
            {

                return new List<in_producto_Info>();
            }

        }

        public in_producto_Info Get_Info_Producto(int IdEmpresa,int IdProducto)
        {
            try
            {
                return oData.Get_Info_Producto(IdEmpresa,IdProducto);
            }
            catch (Exception)
            {

                return new in_producto_Info();
            }
        }
        public Boolean GrabarDB(in_producto_Info Info)
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

        public Boolean ModificarDB(in_producto_Info Info)
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
        public Boolean AnularDB(in_producto_Info Info)
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
