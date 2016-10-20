using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_guia_remision_Data
    {
        public Boolean GrabarDB(fac_guia_remision_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {

                    var addressG = new fac_guia_remision();

                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdPuntoVta = Info.IdPuntoVta;
                    addressG.IdGuiaRemision = Info.IdGuiaRemision;
                    addressG.CodGuiaRemision = Info.CodGuiaRemision;
                    addressG.num_CbteVta = Info.num_CbteVta;
                    addressG.num_autorizacion = Info.num_autorizacion;
                    addressG.Fecha_Autorizacion = Info.Fecha_Autorizacion;
                    addressG.IdCliente = Info.IdCliente;
                    addressG.IdVendedor = Info.IdVendedor;
                    addressG.IdTransportista = Info.IdTransportista;
                    addressG.gi_fecha = Info.gi_fecha;
                    addressG.gi_plazo = Info.gi_plazo;
                    addressG.gi_fech_venc = Info.gi_fech_venc;
                    addressG.gi_Observacion = Info.gi_Observacion;
                    addressG.gi_TotalKilos = Info.gi_TotalKilos;
                    addressG.gi_TotalQuintales = Info.gi_TotalQuintales;
                    addressG.estado = Info.estado;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.Fecha_Transac = Info.Fecha_Transac;
                    addressG.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    addressG.Fecha_UltMod = Info.Fecha_UltMod;
                    addressG.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    addressG.Fecha_UltAnu = Info.Fecha_UltAnu;
                    addressG.nom_pc = Info.nom_pc;
                    addressG.ip = Info.ip;
                    addressG.MotiAnula = Info.MotiAnula;
                    addressG.Impreso = Info.Impreso;
                    addressG.IdPeriodo = Info.IdPeriodo;
                    addressG.gi_FechaIniTraslado = Info.gi_FechaIniTraslado;
                    addressG.gi_FechaFinTraslado = Info.gi_FechaFinTraslado;
                    addressG.placa = Info.placa;
                    addressG.ruta = Info.ruta;
                    addressG.Direccion_Origen = Info.Direccion_Origen;
                    addressG.Direccion_Destino = Info.Direccion_Destino;

                    context.fac_guia_remision.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta, decimal IdGuiaRemision)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_guia_remision.First(cot => cot.IdGuiaRemision == IdGuiaRemision && cot.IdSucursal == IdSucursal 
                                                                    && cot.IdPuntoVta == IdPtoVenta  && cot.IdEmpresa == IdEmpresa);

                    if (contact != null)
                    {
                        context.fac_guia_remision.Remove(contact);

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

        public decimal Get_IdGuiaRemision(int IdEmpresa, int IdSucursal, int IdPtoVenta)
        {
            decimal IdGuiaRemision;
            try
            {

                Entities_Facturacion base_ = new Entities_Facturacion();

                var select = from Cl in base_.fac_guia_remision
                              where Cl.IdEmpresa == IdEmpresa && Cl.IdSucursal == IdSucursal && IdPtoVenta == Cl.IdPuntoVta 
                              select Cl;

                if (select.ToList().Count == 0)

                    return 1;

                else
                {
                    var selectq = (from T in base_.fac_guia_remision
                                  where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal  && T.IdPuntoVta == IdPtoVenta 
                                  select T.IdGuiaRemision).Max();
                    IdGuiaRemision = selectq + 1;
                    return IdGuiaRemision;
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public List<fac_guia_remision_Info> Get_List_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            List<fac_guia_remision_Info> ListInfo = new List<fac_guia_remision_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_guia_remision
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_guia_remision_Info(item.IdEmpresa,item.IdSucursal,item.IdPuntoVta,item.IdGuiaRemision,item.CodGuiaRemision,
                                                            item.num_CbteVta,item.num_autorizacion,item.Fecha_Autorizacion,item.IdCliente,item.IdVendedor,
                                                            item.IdTransportista,item.gi_fecha,item.gi_plazo,item.gi_fech_venc,item.gi_Observacion,
                                                            item.gi_TotalKilos,item.gi_TotalQuintales,item.estado,item.IdUsuario,item.Fecha_Transac,
                                                            item.IdUsuarioUltMod,item.Fecha_UltMod,item.IdUsuarioUltAnu,item.Fecha_UltAnu,item.nom_pc,
                                                            item.ip,item.MotiAnula,item.Impreso,item.IdPeriodo,item.gi_FechaIniTraslado,item.gi_FechaFinTraslado, 
                                                            item.placa, item.ruta, item.Direccion_Origen, item.Direccion_Destino ));

                }

            }
            catch (Exception)
            {
                return new List<fac_guia_remision_Info>();
            }

            return ListInfo;
        }

        public fac_guia_remision_Info Get_Info_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdGuiaRemision)
        {
            fac_guia_remision_Info Info = new fac_guia_remision_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_guia_remision
                              where q.IdGuiaRemision == IdGuiaRemision && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.CodGuiaRemision = item.CodGuiaRemision;
                    Info.num_CbteVta = item.num_CbteVta;
                    Info.num_autorizacion = item.num_autorizacion;
                    Info.Fecha_Autorizacion = item.Fecha_Autorizacion;
                    Info.IdCliente = item.IdCliente;
                    Info.IdVendedor = item.IdVendedor;
                    Info.IdTransportista = item.IdTransportista;
                    Info.gi_fecha = item.gi_fecha;
                    Info.gi_plazo = item.gi_plazo;
                    Info.gi_fech_venc = item.gi_fech_venc;
                    Info.gi_Observacion = item.gi_Observacion;
                    Info.gi_TotalKilos = item.gi_TotalKilos;
                    Info.gi_TotalQuintales = item.gi_TotalQuintales;
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
                    Info.Impreso = item.Impreso;
                    Info.IdPeriodo = item.IdPeriodo;
                    Info.gi_FechaIniTraslado = item.gi_FechaIniTraslado;
                    Info.gi_FechaFinTraslado = item.gi_FechaFinTraslado;
                    Info.placa = item.placa;
                    Info.ruta = item.ruta;
                    Info.Direccion_Origen = item.Direccion_Origen;
                    Info.Direccion_Destino = item.Direccion_Destino;

                }
            }
            catch (Exception)
            {
                return new fac_guia_remision_Info();
            }

            return Info;

        }


    }
}
