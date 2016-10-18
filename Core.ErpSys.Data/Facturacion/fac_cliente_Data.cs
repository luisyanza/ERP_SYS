using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cliente_Data
    {
        public List<fac_cliente_Info> Get_List_Cliente(int IdEmpresa)
        {
            List<fac_cliente_Info> ListInfo = new List<fac_cliente_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente
                              where q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cliente_Info(item.IdEmpresa, item.IdCliente, item.cod_cliente, item.IdPersona, item.IdSucursal, item.Idtipo_cliente, item.IdTipoCredito,
                                                        item.cl_Cat_crediticia, item.cl_plazo, item.cl_porc_descuento, item.IdCtaCble_cxc, item.IdCtaCble_Anti, item.IdCtaCble_cxc_Credito,
                                                        item.Observacion, item.IdCiudad, item.cl_Cupo, item.IdClienteRelacionado, item.cat_IdActividadComercial, item.Estado,
                                                        item.IdParroquia, item.IdUsuario, item.Fecha_Transac, item.IdUsuarioUltMod, item.Fecha_UltMod, item.IdUsuarioUltAnu, item.Fecha_UltAnu,
                                                        item.nom_pc, item.ip));

                }

            }
            catch (Exception)
            {
                return new List<fac_cliente_Info>();
            }

            return ListInfo;
        }

        public fac_cliente_Info Get_Info_Cliente(int IdEmpresa, decimal  IdCliente)
        {
            fac_cliente_Info Info = new fac_cliente_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cliente
                              where q.IdCliente == IdCliente && q.IdEmpresa == IdEmpresa
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.cod_cliente = item.cod_cliente;
                    Info.IdPersona = item.IdPersona;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Idtipo_cliente = item.Idtipo_cliente;
                    Info.IdTipoCredito = item.IdTipoCredito;
                    Info.cl_Cat_crediticia = item.cl_Cat_crediticia;
                    Info.cl_plazo = item.cl_plazo;
                    Info.cl_porc_descuento = item.cl_porc_descuento;
                    Info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                    Info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                    Info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;
                    Info.Observacion = item.Observacion;
                    Info.IdCiudad = item.IdCiudad;
                    Info.cl_Cupo = item.cl_Cupo;
                    Info.IdClienteRelacionado = item.IdClienteRelacionado;
                    Info.cat_IdActividadComercial = item.cat_IdActividadComercial;
                    Info.Estado = item.Estado;
                    Info.IdParroquia = item.IdParroquia;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;


                }
            }
            catch (Exception)
            {
                return new fac_cliente_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_cliente();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdCliente = Info.IdCliente = Get_IdCliente(Info.IdEmpresa);
                    if (Info.IdCliente == 0)
                        throw new System.ArgumentException("Error IdCliente no puede ser 0", "Grabar Cliente");
                    addressG.cod_cliente = Info.cod_cliente;
                    addressG.IdPersona = Info.IdPersona;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.Idtipo_cliente = Info.Idtipo_cliente;
                    addressG.IdTipoCredito = Info.IdTipoCredito;
                    addressG.cl_Cat_crediticia = Info.cl_Cat_crediticia;
                    addressG.cl_plazo = Info.cl_plazo;
                    addressG.cl_porc_descuento = Info.cl_porc_descuento;
                    addressG.IdCtaCble_cxc = Info.IdCtaCble_cxc;
                    addressG.IdCtaCble_Anti = Info.IdCtaCble_Anti;
                    addressG.IdCtaCble_cxc_Credito = Info.IdCtaCble_cxc_Credito;
                    addressG.Observacion = Info.Observacion;
                    addressG.IdCiudad = Info.IdCiudad;
                    addressG.cl_Cupo = Info.cl_Cupo;
                    addressG.IdClienteRelacionado = Info.IdClienteRelacionado;
                    addressG.cat_IdActividadComercial = Info.cat_IdActividadComercial;
                    addressG.Estado = true;
                    addressG.IdParroquia = Info.IdParroquia;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = DateTime.Now;
                    addressG.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    addressG.Fecha_UltMod = Info.Fecha_UltMod;
                    addressG.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    addressG.Fecha_UltAnu = Info.Fecha_UltAnu;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;
                    context.fac_cliente.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdCliente == Info.IdCliente);

                    if (contact != null)
                    {

                       contact.cod_cliente = Info.cod_cliente;
                        contact.IdPersona = Info.IdPersona;
                        contact.IdSucursal = Info.IdSucursal;
                        contact.Idtipo_cliente = Info.Idtipo_cliente;
                        contact.IdTipoCredito = Info.IdTipoCredito;
                        contact.cl_Cat_crediticia = Info.cl_Cat_crediticia;
                        contact.cl_plazo = Info.cl_plazo;
                        contact.cl_porc_descuento = Info.cl_porc_descuento;
                        contact.IdCtaCble_cxc = Info.IdCtaCble_cxc;
                        contact.IdCtaCble_Anti = Info.IdCtaCble_Anti;
                        contact.IdCtaCble_cxc_Credito = Info.IdCtaCble_cxc_Credito;
                        contact.Observacion = Info.Observacion;
                        contact.IdCiudad = Info.IdCiudad;
                        contact.cl_Cupo = Info.cl_Cupo;
                        contact.IdClienteRelacionado = Info.IdClienteRelacionado;
                        contact.cat_IdActividadComercial = Info.cat_IdActividadComercial;
                        contact.IdParroquia = Info.IdParroquia;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
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

        public Boolean AnularDB(fac_cliente_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cliente.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdCliente == Info.IdCliente);

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

        public decimal  Get_IdCliente(int IdEmpresa)
        {
            decimal  IdCliente;
            try
            {                
                Entities_Facturacion base_ = new Entities_Facturacion();

                var clientes = from Cl in base_.fac_cliente
                        where Cl.IdEmpresa == IdEmpresa
                        select Cl;

                if (clientes.ToList().Count == 0)
                    
                    return 1;

                else
                {
                    var select_ = (from T in base_.fac_cliente
                                   where T.IdEmpresa == IdEmpresa
                                   select T.IdCliente).Max();
                    IdCliente = select_ + 1;
                    return IdCliente;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

    }
}
