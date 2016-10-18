using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
   public  class fac_cliente_pto_emision_cliente_Data
    {
       public List<fac_cliente_pto_emision_cliente_Info> Get_List_Cliente_pto_emision_cliente(int IdEmpresa, decimal IdCliente)
        {
            List<fac_cliente_pto_emision_cliente_Info> ListInfo = new List<fac_cliente_pto_emision_cliente_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente_pto_emision_cliente
                              where q.IdEmpresa == IdEmpresa && q.IdCliente == IdCliente 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cliente_pto_emision_cliente_Info(item.IdEmpresa, item.IdCliente, item.IdPuntoEmision, item.cod_ptoemision, item.ruc,
                        item.direccion, item.telefono, item.mail1, item.mail2, item.Estado));

                }

            }
            catch (Exception)
            {
                return new List<fac_cliente_pto_emision_cliente_Info>();
            }

            return ListInfo;
        }

       public fac_cliente_pto_emision_cliente_Info Get_Info_Cliente_pto_emision_cliente(int IdEmpresa, decimal IdCliente, int IdPuntoEmision)
        {
            fac_cliente_pto_emision_cliente_Info Info = new fac_cliente_pto_emision_cliente_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente_pto_emision_cliente 
                              where q.IdCliente == IdCliente && q.IdEmpresa == IdEmpresa && q.IdPuntoEmision == IdPuntoEmision 
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdPuntoEmision = item.IdPuntoEmision;
                    Info.cod_ptoemision = item.cod_ptoemision;
                    Info.ruc = item.ruc;
                    Info.direccion = item.direccion;
                    Info.telefono = item.telefono;
                    Info.mail1 = item.mail1;
                    Info.mail2 = item.mail2;
                    Info.Estado = item.Estado;

                }
            }
            catch (Exception)
            {
                return new fac_cliente_pto_emision_cliente_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_cliente_pto_emision_cliente ();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdPuntoEmision = Info.IdPuntoEmision;
                    addressG.cod_ptoemision = Info.cod_ptoemision;
                    addressG.ruc = Info.ruc;
                    addressG.direccion = Info.direccion;
                    addressG.telefono = Info.telefono;
                    addressG.mail1 = Info.mail1;
                    addressG.mail2 = Info.mail2;
                    addressG.Estado = true;
                    context.fac_cliente_pto_emision_cliente.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente_pto_emision_cliente.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa &&
                                                                                cot.IdCliente == Info.IdCliente && cot.IdPuntoEmision == Info.IdPuntoEmision);

                    if (contact != null)
                    {

                        contact.cod_ptoemision = Info.cod_ptoemision;
                        contact.ruc = Info.ruc;
                        contact.direccion = Info.direccion;
                        contact.telefono = Info.telefono;
                        contact.mail1 = Info.mail1;
                        contact.mail2 = Info.mail2;


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

        public Boolean AnularDB(fac_cliente_pto_emision_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente_pto_emision_cliente.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa &&
                                                                                cot.IdCliente == Info.IdCliente && cot.IdPuntoEmision == Info.IdPuntoEmision);

                    if (contact != null)
                    {

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
