using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_motivo_venta_Data
    {

        public List<fac_motivo_venta_Info> Get_List_MotivoVenta(fac_motivo_venta_Info Info)
        {
            List<fac_motivo_venta_Info> ListInfo = new List<fac_motivo_venta_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_motivo_venta
                              where q.IdEmpresa == Info.IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_motivo_venta_Info(item.IdEmpresa, item.IdMotivo_Vta, item.codMotivo_Vta, item.nom_motivo_vta, item.Estado, item.FechaModificacion, item.FechaCreacion,
                                                            item.UsuarioModificacion,	item.UsuarioCreacion,	item.FechaAnulacion,	item.UsuarioAnulacion,	item.MotivoAnulacion));
                }

            }
            catch (Exception)
            {
                return new List<fac_motivo_venta_Info>();
            }

            return ListInfo;
        }

        public fac_motivo_venta_Info Get_Info_MotivoVenta(int idEmpresa, int IdMotivo_Vta)
        {
            fac_motivo_venta_Info Info = new fac_motivo_venta_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_motivo_venta
                              where q.IdEmpresa == idEmpresa && q.IdMotivo_Vta == IdMotivo_Vta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdMotivo_Vta = item.IdMotivo_Vta;
                    Info.codMotivo_Vta = item.codMotivo_Vta;
                    Info.nom_motivo_vta = item.nom_motivo_vta;
                    Info.Estado = item.Estado;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.UsuarioModificacion = item.UsuarioModificacion;
                    Info.UsuarioCreacion = item.UsuarioCreacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.UsuarioAnulacion = item.UsuarioAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;

                }
            }
            catch (Exception)
            {
                return new fac_motivo_venta_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_motivo_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_motivo_venta();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdMotivo_Vta = Info.IdMotivo_Vta;
                    addressG.codMotivo_Vta = Info.codMotivo_Vta;
                    addressG.nom_motivo_vta = Info.nom_motivo_vta;
                    addressG.FechaModificacion = Info.FechaModificacion;
                    addressG.FechaCreacion = Info.FechaCreacion;
                    addressG.UsuarioModificacion = Info.UsuarioModificacion;
                    addressG.UsuarioCreacion = Info.UsuarioCreacion;
                    addressG.FechaAnulacion = Info.FechaAnulacion;
                    addressG.UsuarioAnulacion = Info.UsuarioAnulacion;
                    addressG.MotivoAnulacion = Info.MotivoAnulacion;
                    addressG.Estado = true;

                    context.fac_motivo_venta.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_motivo_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_motivo_venta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdMotivo_Vta == Info.IdMotivo_Vta);

                    if (contact != null)
                    {
                        contact.codMotivo_Vta = Info.codMotivo_Vta;
                        contact.nom_motivo_vta = Info.nom_motivo_vta;
                        contact.FechaModificacion = Info.FechaModificacion;
                        contact.UsuarioModificacion = Info.UsuarioModificacion;

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

        public Boolean AnularDB(fac_motivo_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_motivo_venta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdMotivo_Vta == Info.IdMotivo_Vta);

                    if (contact != null)
                    {

                        contact.FechaAnulacion = Info.FechaAnulacion;
                        contact.UsuarioAnulacion = Info.UsuarioAnulacion;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
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
    }
}
