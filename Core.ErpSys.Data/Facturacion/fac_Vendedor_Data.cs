using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_Vendedor_Data
    {
        public List<fac_Vendedor_Info> Get_List_Vendedor(int IdEmpresa)
        {
            List<fac_Vendedor_Info> ListInfo = new List<fac_Vendedor_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_Vendedor
                              where q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_Vendedor_Info(item.IdEmpresa,	item.IdVendedor,	item.IdEmpleado,	item.cod_vendedor,	item.nom_vendedor,
                                                        item.Estado,	item.ve_cedula,	item.IdUsuario,	item.Fecha_Transac,	item.IdUsuarioUltMod,
                                                        item.Fecha_UltMod,	item.IdUsuarioUltAnu,	item.Fecha_UltAnu,	item.nom_pc,	item.ip, item.MotivoAnula));

                }

            }
            catch (Exception)
            {
                return new List<fac_Vendedor_Info>();
            }

            return ListInfo;
        }

        public fac_Vendedor_Info Get_Info_Vendedor(int IdEmpresa, decimal IdVendedor)
        {
            fac_Vendedor_Info Info = new fac_Vendedor_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_Vendedor
                              where q.IdVendedor == IdVendedor && q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdVendedor = item.IdVendedor;
                    Info.IdEmpleado = item.IdEmpleado;
                    Info.cod_vendedor = item.cod_vendedor;
                    Info.nom_vendedor = item.nom_vendedor;
                    Info.Estado = item.Estado;
                    Info.ve_cedula = item.ve_cedula;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;
                    Info.MotivoAnula = item.MotivoAnula;

                }
            }
            catch (Exception)
            {
                return new fac_Vendedor_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_Vendedor_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_Vendedor();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdVendedor = Info.IdVendedor = Get_IdVendedor(Info.IdEmpresa);
                    if (Info.IdVendedor == 0)
                        throw new System.ArgumentException("Error IdVendedor no puede ser 0", "Grabar Vendedor");
                    addressG.IdEmpresa = Info.IdEmpresa;
                   addressG.IdEmpleado = Info.IdEmpleado;
                    addressG.cod_vendedor = Info.cod_vendedor;
                    addressG.nom_vendedor = Info.nom_vendedor;
                    addressG.Estado = true;
                    addressG.ve_cedula = Info.ve_cedula;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = Info.Fecha_Transac;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;

                    context.fac_Vendedor.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_Vendedor_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_Vendedor.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdVendedor == Info.IdVendedor);

                    if (contact != null)
                    {

                        contact.IdEmpleado = Info.IdEmpleado;
                        contact.cod_vendedor = Info.cod_vendedor;
                        contact.nom_vendedor = Info.nom_vendedor;
                        contact.ve_cedula = Info.ve_cedula;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;

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

        public Boolean AnularDB(fac_Vendedor_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_Vendedor.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdVendedor == Info.IdVendedor);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        contact.MotivoAnula = Info.MotivoAnula;
                        contact.Estado = false;

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

        public int  Get_IdVendedor(int IdEmpresa)
        {
            int  IdVendedor;
            try
            {
                Entities_Facturacion base_ = new Entities_Facturacion();

                var Vendedors = from Cl in base_.fac_Vendedor
                               where Cl.IdEmpresa == IdEmpresa
                               select Cl;

                if (Vendedors.ToList().Count == 0)

                    return 1;

                else
                {
                    var select_ = (from T in base_.fac_Vendedor
                                   where T.IdEmpresa == IdEmpresa
                                   select T.IdVendedor).Max();
                    IdVendedor = select_ + 1;
                    return IdVendedor;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
