using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cotizacion_Data
    {
        public List<fac_cotizacion_Info> Get_List_cotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            List<fac_cotizacion_Info> ListInfo = new List<fac_cotizacion_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cotizacion
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cotizacion_Info(item.IdEmpresa,	item.IdSucursal,	item.IdPuntoVta,	item.IdCotizacion,	item.CodCotizacion,
                                                            item.IdCliente,	item.IdVendedor,	item.cc_fecha,	item.cc_diasPlazo,	item.cc_fechaVencimiento,
                                                            item.cc_observacion,	item.cc_tipopago,	item.cc_estado,	item.cc_dirigidoA,	item.IdUsuario,
                                                            item.Fecha_Transac,	item.IdUsuarioUltMod,	item.Fecha_UltMod,	item.IdUsuarioUltAnu,	item.Fecha_UltAnu,
                                                            item.MotivoAnu,	item.nom_pc,	item.ip));

                }

            }
            catch (Exception)
            {
                return new List<fac_cotizacion_Info>();
            }

            return ListInfo;
        }

        public fac_cotizacion_Info Get_Info_cotizacion(int IdEmpresa,int IdSucursal, int IdPuntoVta, decimal Idcotizacion)
        {
            fac_cotizacion_Info Info = new fac_cotizacion_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cotizacion
                              where q.IdCotizacion == Idcotizacion && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdCotizacion = item.IdCotizacion;
                    Info.CodCotizacion = item.CodCotizacion;
                    Info.IdCliente = item.IdCliente;
                    Info.IdVendedor = item.IdVendedor;
                    Info.cc_fecha = item.cc_fecha;
                    Info.cc_diasPlazo = item.cc_diasPlazo;
                    Info.cc_fechaVencimiento = item.cc_fechaVencimiento;
                    Info.cc_observacion = item.cc_observacion;
                    Info.cc_tipopago = item.cc_tipopago;
                    Info.cc_estado = item.cc_estado;
                    Info.cc_dirigidoA = item.cc_dirigidoA;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.MotivoAnu = item.MotivoAnu;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;

                }
            }
            catch (Exception)
            {
                return new fac_cotizacion_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_cotizacion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_cotizacion();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdPuntoVta = Info.IdPuntoVta;                    
                    addressG.IdCotizacion = Info.IdCotizacion = Get_Idcotizacion(Info.IdEmpresa, Info.IdSucursal , Info.IdPuntoVta );
                    if (Info.IdCotizacion == 0)
                        throw new System.ArgumentException("Error Idcotizacion no puede ser 0", "Grabar cotizacion");
                  addressG.IdCotizacion = Info.IdCotizacion;
                    addressG.CodCotizacion = Info.CodCotizacion;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdVendedor = Info.IdVendedor;
                    addressG.cc_fecha = Info.cc_fecha;
                    addressG.cc_diasPlazo = Info.cc_diasPlazo;
                    addressG.cc_fechaVencimiento = Info.cc_fechaVencimiento;
                    addressG.cc_observacion = Info.cc_observacion;
                    addressG.cc_tipopago = Info.cc_tipopago;
                    addressG.cc_estado = true; 
                    addressG.cc_dirigidoA = Info.cc_dirigidoA;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = Info.Fecha_Transac;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;

                    context.fac_cotizacion.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_cotizacion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cotizacion.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal == Info.IdSucursal &&
                                                                        cot.IdCotizacion == Info.IdCotizacion && cot.IdPuntoVta == Info.IdPuntoVta);

                    if (contact != null)
                    {
                        contact.CodCotizacion = Info.CodCotizacion;
                        contact.IdCliente = Info.IdCliente;
                        contact.IdVendedor = Info.IdVendedor;
                        contact.cc_fecha = Info.cc_fecha;
                        contact.cc_diasPlazo = Info.cc_diasPlazo;
                        contact.cc_fechaVencimiento = Info.cc_fechaVencimiento;
                        contact.cc_observacion = Info.cc_observacion;
                        contact.cc_tipopago = Info.cc_tipopago;
                        contact.cc_estado = Info.cc_estado;
                        contact.cc_dirigidoA = Info.cc_dirigidoA;
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

        public Boolean AnularDB(fac_cotizacion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_cotizacion.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal == Info.IdSucursal &&
                                                                        cot.IdCotizacion == Info.IdCotizacion && cot.IdPuntoVta == Info.IdPuntoVta );

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnu = Info.MotivoAnu;
                        contact.cc_estado = false;

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

        public decimal Get_Idcotizacion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            decimal Idcotizacion;
            try
            {
                Entities_Facturacion base_ = new Entities_Facturacion();

                var cotizacions = from Cl in base_.fac_cotizacion
                               where Cl.IdEmpresa == IdEmpresa && Cl.IdPuntoVta == IdPuntoVta && Cl.IdSucursal == IdSucursal 
                               select Cl;

                if (cotizacions.ToList().Count == 0)

                    return 1;

                else
                {
                    var select_ = (from T in base_.fac_cotizacion
                                   where T.IdEmpresa == IdEmpresa  && T.IdSucursal == IdSucursal && T.IdPuntoVta == IdPuntoVta 
                                   select T.IdCotizacion).Max();
                    Idcotizacion = select_ + 1;
                    return Idcotizacion;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }


    }
}
