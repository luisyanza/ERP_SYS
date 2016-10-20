using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_guia_remision_det_Bus
    {
        fac_guia_remision_det_Data Odata = new fac_guia_remision_det_Data();

        public List<fac_guia_remision_det_Info> Get_List_GuiaRemision(int IdEmpresa,int IdSucursal, int IdPtoVenta, decimal IdGuiaRemision)
        {
            try
            {
                return Odata.Get_List_GuiaRemision(IdEmpresa, IdSucursal,IdPtoVenta , IdGuiaRemision);

            }
            catch (Exception)
            {

                return new List<fac_guia_remision_det_Info>();
            }
        }

        public Boolean GrabarDB(List<fac_guia_remision_det_Info> List_Info)
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta, decimal IdGuiaRemision)
        {
            try
            {
                return Odata.EliminarDB(IdEmpresa, IdSucursal, IdPtoVenta, IdGuiaRemision);

            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool Validar_Corregir_Objeto(fac_guia_remision_Info Info, ref string MensajeError)
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
                foreach (fac_guia_remision_det_Info item in Info.List_detalle)
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

                  
                    if (item.IdProducto == 0)
                    {
                        MensajeError = "Cbte Detalle PK Producto no valido";
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
