using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;


namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cbteVta_det_Bus
    {

        fac_cbteVta_det_Data Odata = new fac_cbteVta_det_Data();

        public Boolean GrabarDB(List<fac_cbteVta_det_Info> List_Info)
        {
            try
            {
                return Odata.GrabarDB(List_Info);


            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean EliminarDB(int IdEmpresa, string IdTipoCbteVta, decimal IdCbte)
        {
            try
            {
                return Odata.EliminarDB(IdEmpresa, IdTipoCbteVta, IdCbte);

            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool Validar_Corregir_Objeto(fac_cbteVta_Info Info, ref string MensajeError)
        {
            try
            {
                bool Respuesta = false;
                #region Validaciones
                if (Info.List_detalle.Count < 1)
                {
                    MensajeError = "El comprobante no tiene detalle.";
                    return false;
                }
                foreach (fac_cbteVta_det_Info item in Info.List_detalle)
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

                    if (string.IsNullOrEmpty(item.IdCbteVtaTipo))
                    {
                        if (string.IsNullOrEmpty(Info.IdCbteVtaTipo))
                        {
                            MensajeError = "Cbte Detalle PK TipoCbteVta no valido";
                            return false;
                        }
                        else
                            item.IdCbteVtaTipo = Info.IdCbteVtaTipo;
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
                #region Correcciones

                    item.observacion_det = (item.observacion_det == null) ? "" : item.observacion_det;

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
