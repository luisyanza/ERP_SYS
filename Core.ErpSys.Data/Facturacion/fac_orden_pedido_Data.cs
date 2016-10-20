using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
    public class fac_orden_pedido_Data
    {
        public Boolean GrabarDB(fac_orden_pedido_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {

                    var addressG = new fac_orden_pedido();

                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdPuntoVta = Info.IdPuntoVta;
                    addressG.IdPedido = Info.IdPedido;
                    addressG.CodPedido = Info.CodPedido;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdVendedor = Info.IdVendedor;
                    addressG.cp_fecha = Info.cp_fecha;
                    addressG.cp_diasPlazo = Info.cp_diasPlazo;
                    addressG.cp_fechaVenc = Info.cp_fechaVenc;
                    addressG.cp_observacion = Info.cp_observacion;
                    addressG.cp_tipopago = Info.cp_tipopago;
                    addressG.Estado = Info.Estado;
                    addressG.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = Info.Fecha_Transac;
                    addressG.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    addressG.Fecha_UltMod = Info.Fecha_UltMod;
                    addressG.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    addressG.Fecha_UltAnu = Info.Fecha_UltAnu;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;
                    addressG.MotivoAnulacion = Info.MotivoAnulacion;
                    addressG.Entregado = Info.Entregado;
                    context.fac_orden_pedido.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta, decimal IdPedido)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_orden_pedido.First(ped => ped.IdPedido == IdPedido && ped.IdSucursal == IdSucursal
                                                                    && ped.IdPuntoVta == IdPtoVenta && ped.IdEmpresa == IdEmpresa);

                    if (contact != null)
                    {
                        context.fac_orden_pedido.Remove(contact);

                    }
                    respuesta = true;
                }
                return respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public decimal Get_IdPedido(int IdEmpresa, int IdSucursal, int IdPtoVenta)
        {
            decimal IdPedido;
            try
            {

                Entities_Facturacion base_ = new Entities_Facturacion();

                var select = from Cl in base_.fac_orden_pedido
                             where Cl.IdEmpresa == IdEmpresa && Cl.IdSucursal == IdSucursal && IdPtoVenta == Cl.IdPuntoVta
                             select Cl;

                if (select.ToList().Count == 0)

                    return 1;

                else
                {
                    var selectq = (from T in base_.fac_orden_pedido
                                   where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal && T.IdPuntoVta == IdPtoVenta
                                   select T.IdPedido).Max();
                    IdPedido = selectq + 1;
                    return IdPedido;
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public List<fac_orden_pedido_Info> Get_List_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            List<fac_orden_pedido_Info> ListInfo = new List<fac_orden_pedido_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_orden_pedido
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_orden_pedido_Info(item.IdEmpresa,item.IdSucursal,item.IdPuntoVta,item.IdPedido,item.CodPedido,
                                                            item.IdCliente,item.IdVendedor,item.cp_fecha,item.cp_diasPlazo,item.cp_fechaVenc,
                                                            item.cp_observacion,item.cp_tipopago,item.Estado,item.IdEstadoAprobacion,item.IdUsuario,
                                                            item.Fecha_Transac,item.IdUsuarioUltMod,item.Fecha_UltMod,item.IdUsuarioUltAnu,item.Fecha_UltAnu,
                                                            item.nom_pc,item.ip,item.MotivoAnulacion,item.Entregado));

                }

            }
            catch (Exception)
            {
                return new List<fac_orden_pedido_Info>();
            }

            return ListInfo;
        }

        public fac_orden_pedido_Info Get_Info_OrdenPedido(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdPedido)
        {
            fac_orden_pedido_Info Info = new fac_orden_pedido_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_orden_pedido
                              where q.IdPedido == IdPedido && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdPedido = item.IdPedido;
                    Info.CodPedido = item.CodPedido;
                    Info.IdCliente = item.IdCliente;
                    Info.IdVendedor = item.IdVendedor;
                    Info.cp_fecha = item.cp_fecha;
                    Info.cp_diasPlazo = item.cp_diasPlazo;
                    Info.cp_fechaVenc = item.cp_fechaVenc;
                    Info.cp_observacion = item.cp_observacion;
                    Info.cp_tipopago = item.cp_tipopago;
                    Info.Estado = item.Estado;
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.Entregado = item.Entregado;

                }
            }
            catch (Exception)
            {
                return new fac_orden_pedido_Info();
            }

            return Info;

        }

    }
}
