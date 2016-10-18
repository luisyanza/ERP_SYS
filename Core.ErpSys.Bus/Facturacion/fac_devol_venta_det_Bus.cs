using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_devol_venta_det_Bus
    {

        fac_devol_venta_det_Data oData = new fac_devol_venta_det_Data();
        public Boolean GrabarDB(List<fac_devol_venta_det_Info> List_Info)
        {
            try
            {
                return oData.GrabarDB(List_Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta, decimal IdDevolucion)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdSucursal, IdPtoVenta, IdDevolucion);
            }
            catch (Exception)
            {

                return false;
            }

        }

        internal bool Validar_Corregir_Objeto(fac_devol_venta_Info Info, ref string MensajeError)
        {
            try
            {
                bool Respuesta = false;
                #region Validaciones
                if (Info.ListDetalle.Count < 1)
                {
                    MensajeError = "La cotización no tiene detalle.";
                    return false;
                }
                foreach (fac_devol_venta_det_Info item in Info.ListDetalle)
                {
                    if (item.IdEmpresa == 0)
                    {
                        if (Info.IdEmpresa == 0)
                        {
                            MensajeError = "Cbte Detalle PK Empresa no valido";
                            return false;
                        }
                        else
                        {
                            item.IdEmpresa = Info.IdEmpresa;
                        }
                    }
                    if (item.IdSucursal == 0)
                    {
                        if (Info.IdSucursal == 0)
                        {
                            MensajeError = "Cbte Detalle PK Sucursal no valido";
                            return false;
                        }
                        else
                        {
                            item.IdEmpresa = Info.IdEmpresa;
                        }
                    }
                    if (item.IdPuntoVta == 0)
                    {
                        if (Info.IdPuntoVta == 0)
                        {
                            MensajeError = "Cbte Detalle PK Punto Venta no valido";
                            return false;
                        }
                        else
                        {
                            item.IdEmpresa = Info.IdEmpresa;
                        }
                    }
                    if (item.IdProducto == 0)
                    {
                        MensajeError = "Cbte Detalle PK Producto no valido";
                        return false;
                    }
                    if (string.IsNullOrEmpty(item.IdImpuesto_Iva))
                    {
                        MensajeError = "Cbte Detalle PK IdImpuesto_Iva no valido";
                        return false;
                    }


                #endregion


                }
                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
