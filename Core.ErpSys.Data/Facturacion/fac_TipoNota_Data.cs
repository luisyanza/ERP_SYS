using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_TipoNota_Data
    {
        public List<fac_TipoNota_Info> Get_List_TipoNota(fac_TipoNota_Info Info)
        {
            List<fac_TipoNota_Info> ListInfo = new List<fac_TipoNota_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_TipoNota
                              where q.IdEmpresa == Info.IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_TipoNota_Info(item.IdEmpresa,	item.IdTipoNota,	item.CodTipoNota,	item.Tipo,	item.nom_tipoNota,
                                                        item.usado_x_sys,	item.SeDeclara_como_imp,	item.estado,	item.IdUsuario,	item.Fecha_Transac,
                                                        item.IdUsuarioUltMod,	item.Fecha_UltMod,	item.IdUsuarioUltAnu,	item.Fecha_UltAnu,	item.nom_pc,
                                                        item.ip,	item.MotiAnula));
                }
            }
            catch (Exception)
            {
                return new List<fac_TipoNota_Info>();
            }

            return ListInfo;
        }

        public fac_TipoNota_Info Get_Info_TipoNota(int idEmpresa, int IdTipoNota)
        {
            fac_TipoNota_Info Info = new fac_TipoNota_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_TipoNota
                              where q.IdEmpresa == idEmpresa && q.IdTipoNota == IdTipoNota
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdTipoNota = item.IdTipoNota;
                    Info.CodTipoNota = item.CodTipoNota;
                    Info.Tipo = item.Tipo;
                    Info.nom_tipoNota = item.nom_tipoNota;
                    Info.usado_x_sys = item.usado_x_sys;
                    Info.SeDeclara_como_imp = item.SeDeclara_como_imp;
                    Info.estado = item.estado;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;
                    Info.MotiAnula = item.MotiAnula;


                }
            }
            catch (Exception)
            {
                return new fac_TipoNota_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_TipoNota_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_TipoNota();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdTipoNota = Info.IdTipoNota;
                    addressG.CodTipoNota = Info.CodTipoNota;
                    addressG.Tipo = Info.Tipo;
                    addressG.nom_tipoNota = Info.nom_tipoNota;
                    addressG.usado_x_sys = Info.usado_x_sys;
                    addressG.SeDeclara_como_imp = Info.SeDeclara_como_imp;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = DateTime.Now;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;
                    addressG.estado = true;

                    context.fac_TipoNota.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_TipoNota_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_TipoNota.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdTipoNota == Info.IdTipoNota);

                    if (contact != null)
                    {
                        contact.CodTipoNota = Info.CodTipoNota;
                        contact.Tipo = Info.Tipo;
                        contact.nom_tipoNota = Info.nom_tipoNota;
                        contact.usado_x_sys = Info.usado_x_sys;
                        contact.SeDeclara_como_imp = Info.SeDeclara_como_imp;
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

        public Boolean AnularDB(fac_TipoNota_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_TipoNota.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdTipoNota == Info.IdTipoNota);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotiAnula = Info.MotiAnula;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
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
