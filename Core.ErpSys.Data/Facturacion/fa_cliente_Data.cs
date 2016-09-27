using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fa_cliente_Data
    {
        public List<fa_cliente_Info> Get_List_Cliente(int IdEmpresa)
        {
            List<fa_cliente_Info> ListInfo = new List<fa_cliente_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fa_cliente
                              where q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fa_cliente_Info(item.IdEmpresa,	item.IdCliente,	item.IdPersona,	item.IdTipoCliente,	item.estado));
                }

            }
            catch (Exception)
            {
                return new List<fa_cliente_Info>();
            }

            return ListInfo;
        }

        public fa_cliente_Info Get_Info_Cliente(int IdEmpresa, int IdCliente)
        {
            fa_cliente_Info Info = new fa_cliente_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fa_cliente
                              where q.IdCliente == IdCliente && q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdPersona = item.IdPersona;
                    Info.IdTipoCliente = item.IdTipoCliente;
                    Info.estado = item.estado;

                }
            }
            catch (Exception)
            {
                return new fa_cliente_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fa_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fa_cliente();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdPersona = Info.IdPersona;
                    addressG.IdTipoCliente = Info.IdTipoCliente;
                    addressG.estado = true;
                    context.fa_cliente.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fa_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fa_cliente.FirstOrDefault(cot => cot.IdCliente == Info.IdCliente);

                    if (contact != null)
                    {

                        contact.IdTipoCliente = Info.IdTipoCliente;

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

        public Boolean AnularDB(fa_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fa_cliente.FirstOrDefault(cot => cot.IdCliente == Info.IdCliente);

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
