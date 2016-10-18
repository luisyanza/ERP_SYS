using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cliente_contactos_Data
    {
        public List<fac_cliente_contactos_Info> Get_List_Contactos(int IdEmpresa, decimal  IdCliente)
        {
            try
            {
                List<fac_cliente_contactos_Info> ListInfo = new List<fac_cliente_contactos_Info>();
                Entities_Facturacion oBase = new Entities_Facturacion();

                var selectq = from q in oBase.fac_cliente_contactos
                              where q.IdEmpresa_cli == IdEmpresa && q.IdCliente == IdCliente
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cliente_contactos_Info(item.IdEmpresa_cli, item.IdCliente, item.IdEmpresa_cont, item.IdContacto, item.observacion));
                }
                return ListInfo;
            }
            catch (Exception)
            {

                return new List<fac_cliente_contactos_Info>();
            }
        }
        public fac_cliente_contactos_Info Get_Info_Contactos(int IdEmpresa, decimal  IdCliente, int IdEmpresa_cont, decimal  IdContacto)
        {
            fac_cliente_contactos_Info Info = new fac_cliente_contactos_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente_contactos
                              where q.IdCliente == IdCliente && q.IdEmpresa_cli == IdEmpresa && q.IdEmpresa_cont == IdEmpresa_cont && q.IdContacto == IdContacto
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa_cli = item.IdEmpresa_cli;
                    Info.IdCliente = item.IdCliente;
                    Info.IdEmpresa_cont = item.IdEmpresa_cont;
                    Info.IdContacto = item.IdContacto;
                    Info.observacion = item.observacion;

                }
            }
            catch (Exception)
            {
                return new fac_cliente_contactos_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_cliente_contactos_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    
                    var addressG = new fac_cliente_contactos();
                    addressG.IdEmpresa_cli = Info.IdEmpresa_cli;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdEmpresa_cont = Info.IdEmpresa_cont;
                    addressG.IdContacto = Info.IdContacto;
                    addressG.observacion = Info.observacion;
                    context.fac_cliente_contactos.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_cliente_contactos_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente_contactos.FirstOrDefault(cot => cot.IdCliente == Info.IdCliente);

                    if (contact != null)
                    {
                        contact.IdEmpresa_cli = Info.IdEmpresa_cli;
                        contact.IdCliente = Info.IdCliente;
                        contact.IdEmpresa_cont = Info.IdEmpresa_cont;
                        contact.IdContacto = Info.IdContacto;
                        contact.observacion = Info.observacion;
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
