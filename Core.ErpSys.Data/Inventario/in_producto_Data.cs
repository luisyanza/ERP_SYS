using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Inventario;

namespace Core.ErpSys.Data.Inventario
{
    public class in_producto_Data
    {
        public List<in_producto_Info> Get_List_Producto(int IdEmpresa)
        {
            List<in_producto_Info> ListInfo = new List<in_producto_Info>();

            try
            {

                Entities_Inventario OBase = new Entities_Inventario();

                var selectq = from q in OBase.in_producto
                              where q.IdEmpresa == IdEmpresa 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new in_producto_Info(item.IdEmpresa, item.IdProducto, item.cod_producto, item.nom_producto, item.IdCategoria, item.estado));
                }

            }
            catch (Exception)
            {
                return new List<in_producto_Info>();
            }

            return ListInfo;
        }

        public in_producto_Info Get_Info_Producto(int IdEmpresa, int IdProducto)
        {
            in_producto_Info Info = new in_producto_Info();

            try
            {

                Entities_Inventario OBase = new Entities_Inventario();

                var selectq = from q in OBase.in_producto
                              where q.IdProducto == IdProducto && q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProducto = item.IdProducto;
                    Info.cod_producto = item.cod_producto;
                    Info.nom_producto = item.nom_producto;
                    Info.IdCategoria = item.IdCategoria;
                    Info.estado = item.estado;


                }
            }
            catch (Exception)
            {
                return new in_producto_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(in_producto_Info Info)
        {
            try
            {
                using (Entities_Inventario context = new Entities_Inventario())
                {


                    var addressG = new in_producto();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdProducto = Info.IdProducto;
                    addressG.cod_producto = Info.cod_producto;
                    addressG.nom_producto = Info.nom_producto;
                    addressG.IdCategoria = Info.IdCategoria;
                    addressG.estado = true;
                    context.in_producto.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(in_producto_Info Info)
        {
            try
            {
                using (Entities_Inventario context = new Entities_Inventario())
                {
                    var contact = context.in_producto.FirstOrDefault(cot => cot.IdProducto == Info.IdProducto);

                    if (contact != null)
                    {

                        contact.cod_producto = Info.cod_producto;
                        contact.nom_producto = Info.nom_producto;
                        contact.IdCategoria = Info.IdCategoria;
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

        public Boolean AnularDB(in_producto_Info Info)
        {
            try
            {
                using (Entities_Inventario context = new Entities_Inventario())
                {
                    var contact = context.in_producto.FirstOrDefault(cot => cot.IdProducto == Info.IdProducto);

                    if (contact != null)
                    {

                        contact.estado = false;

                        context.SaveChanges();
                    }
                    else
                        return false;

                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }
    }
}
