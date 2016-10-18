using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cliente_tipo_Data
    {        
        public List<fac_cliente_tipo_Info> Get_List_ClienteTipo(fac_cliente_tipo_Info Info)
        {
            List<fac_cliente_tipo_Info> ListInfo = new List<fac_cliente_tipo_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente_tipo
                              where q.IdEmpresa == Info.IdEmpresa 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cliente_tipo_Info(item.IdEmpresa,	item.Idtipo_cliente,	item.nom_tip_cliente,	item.IdCtaCble_CXC_Con,	item.IdCtaCble_CXC_Cred,	
                                                           item.IdCtaCble_CXC_Anticipo,	item.IdUsuario, item.Fecha_Transac,	item.IdUsuarioUltMod,	item.Fecha_UltMod,	
                                                           item.IdUsuarioUltAnu,	item.Fecha_UltAnu,	item.MotivoAnula,item.nom_pc,	item.ip,	item.estado));
                }

            }   
            catch (Exception)
            {
                return new List<fac_cliente_tipo_Info>();
            }

            return ListInfo;
        }

        public fac_cliente_tipo_Info Get_Info_ClienteTipo(int idEmpresa, int Idtipo_cliente)
        {
            fac_cliente_tipo_Info Info = new fac_cliente_tipo_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente_tipo
                              where q.IdEmpresa == idEmpresa && q.Idtipo_cliente == Idtipo_cliente
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.Idtipo_cliente = item.Idtipo_cliente;
                    Info.nom_tip_cliente = item.nom_tip_cliente;
                    Info.IdCtaCble_CXC_Con = item.IdCtaCble_CXC_Con;
                    Info.IdCtaCble_CXC_Cred = item.IdCtaCble_CXC_Cred;
                    Info.IdCtaCble_CXC_Anticipo = item.IdCtaCble_CXC_Anticipo;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.MotivoAnula = item.MotivoAnula;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;
                    Info.estado = item.estado;


                }
            }
            catch (Exception)
            {
                return new fac_cliente_tipo_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_cliente_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_cliente_tipo();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.Idtipo_cliente = Info.Idtipo_cliente;
                    addressG.nom_tip_cliente = Info.nom_tip_cliente;
                    addressG.IdCtaCble_CXC_Con = Info.IdCtaCble_CXC_Con;
                    addressG.IdCtaCble_CXC_Cred = Info.IdCtaCble_CXC_Cred;
                    addressG.IdCtaCble_CXC_Anticipo = Info.IdCtaCble_CXC_Anticipo;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = DateTime.Now;
                    addressG.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    addressG.Fecha_UltMod = Info.Fecha_UltMod;
                    addressG.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    addressG.Fecha_UltAnu = Info.Fecha_UltAnu;
                    addressG.MotivoAnula = Info.MotivoAnula;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;
                    addressG.estado = true;

                    context.fac_cliente_tipo.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_cliente_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente_tipo.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.Idtipo_cliente == Info.Idtipo_cliente);

                    if (contact != null)
                    {
                        contact.nom_tip_cliente = Info.nom_tip_cliente;
                        contact.IdCtaCble_CXC_Con = Info.IdCtaCble_CXC_Con;
                        contact.IdCtaCble_CXC_Cred = Info.IdCtaCble_CXC_Cred;
                        contact.IdCtaCble_CXC_Anticipo = Info.IdCtaCble_CXC_Anticipo;
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

        public Boolean AnularDB(fac_cliente_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente_tipo.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.Idtipo_cliente == Info.Idtipo_cliente);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnula = Info.MotivoAnula;
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
