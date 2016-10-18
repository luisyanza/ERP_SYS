using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_devol_venta_Data
    {
        public List<fac_devol_venta_Info> Get_List_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            List<fac_devol_venta_Info> ListInfo = new List<fac_devol_venta_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_devol_venta
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_devol_venta_Info(item.IdEmpresa,item.IdSucursal,item.IdPuntoVta,item.IdDevolucion,item.CodDevolucion,
                                                            item.IdNota,item.IdCliente,item.IdVendedor,item.IdCbteVta,item.dv_fecha,
                                                            item.Estado,item.dv_Observacion,item.IdUsuario,item.MotivoAnulacion,item.mvInv_IdEmpresa,
                                                            item.mvInv_IdSucursal,item.mvInv_IdBodega,item.mvInv_IdMovi_inven_tipo,item.mvInv_IdNumMovi,item.mvInv_IdEmpresa_x_Anu,
                                                            item.mvInv_IdSucursal_x_Anu,item.mvInv_IdBodega_x_Anu,item.mvInv_IdMovi_inven_tipo_x_Anu,item.mvInv_IdNumMovi_x_Anu));

                }

            }
            catch (Exception)
            {
                return new List<fac_devol_venta_Info>();
            }

            return ListInfo;
        }

        public fac_devol_venta_Info Get_Info_Devolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdDevolucion)
        {
            fac_devol_venta_Info Info = new fac_devol_venta_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_devol_venta
                              where q.IdDevolucion == IdDevolucion && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdDevolucion = item.IdDevolucion;
                    Info.CodDevolucion = item.CodDevolucion;
                    Info.IdNota = item.IdNota;
                    Info.IdCliente = item.IdCliente;
                    Info.IdVendedor = item.IdVendedor;
                    Info.IdCbteVta = item.IdCbteVta;
                    Info.dv_fecha = item.dv_fecha;
                    Info.Estado = item.Estado;
                    Info.dv_Observacion = item.dv_Observacion;
                    Info.IdUsuario = item.IdUsuario;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.mvInv_IdEmpresa = item.mvInv_IdEmpresa;
                    Info.mvInv_IdSucursal = item.mvInv_IdSucursal;
                    Info.mvInv_IdBodega = item.mvInv_IdBodega;
                    Info.mvInv_IdMovi_inven_tipo = item.mvInv_IdMovi_inven_tipo;
                    Info.mvInv_IdNumMovi = item.mvInv_IdNumMovi;
                    Info.mvInv_IdEmpresa_x_Anu = item.mvInv_IdEmpresa_x_Anu;
                    Info.mvInv_IdSucursal_x_Anu = item.mvInv_IdSucursal_x_Anu;
                    Info.mvInv_IdBodega_x_Anu = item.mvInv_IdBodega_x_Anu;
                    Info.mvInv_IdMovi_inven_tipo_x_Anu = item.mvInv_IdMovi_inven_tipo_x_Anu;
                    Info.mvInv_IdNumMovi_x_Anu = item.mvInv_IdNumMovi_x_Anu;

                }
            }
            catch (Exception)
            {
                return new fac_devol_venta_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(fac_devol_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_devol_venta();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdPuntoVta = Info.IdPuntoVta;
                    addressG.IdDevolucion = Info.IdDevolucion = Get_IdDevolucion(Info.IdEmpresa, Info.IdSucursal, Info.IdPuntoVta);
                    if (Info.IdDevolucion == 0)
                        throw new System.ArgumentException("Error IdDevolucion no puede ser 0", "Grabar Devolucion");

                    addressG.IdNota = Info.IdNota;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdVendedor = Info.IdVendedor;
                    addressG.IdCbteVta = Info.IdCbteVta;
                    addressG.dv_fecha = Info.dv_fecha;
                    addressG.Estado = Info.Estado;
                    addressG.dv_Observacion = Info.dv_Observacion;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.MotivoAnulacion = Info.MotivoAnulacion;
                    addressG.mvInv_IdEmpresa = Info.mvInv_IdEmpresa;
                    addressG.mvInv_IdSucursal = Info.mvInv_IdSucursal;
                    addressG.mvInv_IdBodega = Info.mvInv_IdBodega;
                    addressG.mvInv_IdMovi_inven_tipo = Info.mvInv_IdMovi_inven_tipo;
                    addressG.mvInv_IdNumMovi = Info.mvInv_IdNumMovi;
                    addressG.mvInv_IdEmpresa_x_Anu = Info.mvInv_IdEmpresa_x_Anu;
                    addressG.mvInv_IdSucursal_x_Anu = Info.mvInv_IdSucursal_x_Anu;
                    addressG.mvInv_IdBodega_x_Anu = Info.mvInv_IdBodega_x_Anu;
                    addressG.mvInv_IdMovi_inven_tipo_x_Anu = Info.mvInv_IdMovi_inven_tipo_x_Anu;
                    addressG.mvInv_IdNumMovi_x_Anu = Info.mvInv_IdNumMovi_x_Anu;


                    context.fac_devol_venta.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_devol_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_devol_venta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal == Info.IdSucursal &&
                                                                        cot.IdDevolucion == Info.IdDevolucion && cot.IdPuntoVta == Info.IdPuntoVta);

                    if (contact != null)
                    {
                        contact.CodDevolucion = Info.CodDevolucion;
                        contact.IdNota = Info.IdNota;
                        contact.IdCliente = Info.IdCliente;
                        contact.IdVendedor = Info.IdVendedor;
                        contact.IdCbteVta = Info.IdCbteVta;
                        contact.dv_fecha = Info.dv_fecha;
                        contact.Estado = Info.Estado;
                        contact.dv_Observacion = Info.dv_Observacion;
                        contact.IdUsuario = Info.IdUsuario;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.mvInv_IdEmpresa = Info.mvInv_IdEmpresa;
                        contact.mvInv_IdSucursal = Info.mvInv_IdSucursal;
                        contact.mvInv_IdBodega = Info.mvInv_IdBodega;
                        contact.mvInv_IdMovi_inven_tipo = Info.mvInv_IdMovi_inven_tipo;
                        contact.mvInv_IdNumMovi = Info.mvInv_IdNumMovi;
                        contact.mvInv_IdEmpresa_x_Anu = Info.mvInv_IdEmpresa_x_Anu;
                        contact.mvInv_IdSucursal_x_Anu = Info.mvInv_IdSucursal_x_Anu;
                        contact.mvInv_IdBodega_x_Anu = Info.mvInv_IdBodega_x_Anu;
                        contact.mvInv_IdMovi_inven_tipo_x_Anu = Info.mvInv_IdMovi_inven_tipo_x_Anu;
                        contact.mvInv_IdNumMovi_x_Anu = Info.mvInv_IdNumMovi_x_Anu;


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

        public Boolean AnularDB(fac_devol_venta_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_devol_venta.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.IdSucursal == Info.IdSucursal &&
                                                                        cot.IdDevolucion == Info.IdDevolucion && cot.IdPuntoVta == Info.IdPuntoVta);

                    if (contact != null)
                    { 
                        contact.Estado  = false;

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

        public decimal Get_IdDevolucion(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            decimal IdDevolucion;
            try
            {
                Entities_Facturacion base_ = new Entities_Facturacion();

                var Devolucions = from Cl in base_.fac_devol_venta
                                  where Cl.IdEmpresa == IdEmpresa && Cl.IdPuntoVta == IdPuntoVta && Cl.IdSucursal == IdSucursal
                                  select Cl;

                if (Devolucions.ToList().Count == 0)

                    return 1;

                else
                {
                    var select_ = (from T in base_.fac_devol_venta
                                   where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal && T.IdPuntoVta == IdPuntoVta
                                   select T.IdDevolucion).Max();
                    IdDevolucion = select_ + 1;
                    return IdDevolucion;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

    }
}
