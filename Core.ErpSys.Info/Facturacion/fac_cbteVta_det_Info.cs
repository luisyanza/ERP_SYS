using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
   public class fac_cbteVta_det_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public decimal IdCbteVta { get; set; }
        public int secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string observacion_det { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double por_descuento { get; set; }
        public double valor_descuento { get; set; }
        public double precio_final { get; set; }
        public double subtotal { get; set; }
        public double valor_impuesto_iva { get; set; }
        public double por_impuesto_iva { get; set; }
        public string IdImpuesto_Iva { get; set; }
        public double total { get; set; }
        public int IdPunto_Cargo { get; set; }
        public int IdPunto_cargo_grupo { get; set; }
        public string IdImpuesto_Ice { get; set; }
        public double valor_impuesto_ice { get; set; }
        public double por_impuesto_ice { get; set; }

        public fac_cbteVta_det_Info()
        {

        }
        public fac_cbteVta_det_Info(int _IdEmpresa,	string _IdCbteVtaTipo,	decimal _IdCbteVta,	int _secuencia,	decimal _IdProducto,	string _observacion_det,
                                    double _cantidad,double _precio,	double _por_descuento,	double _valor_descuento,	double _precio_final,	double _subtotal,	
                                    double _valor_impuesto_iva, double _por_impuesto_iva,	string _IdImpuesto_Iva,	double _total,	int _IdPunto_Cargo,	
                                    int _IdPunto_cargo_grupo, string _IdImpuesto_Ice, double _valor_impuesto_ice,	double _por_impuesto_ice)
        {
            IdEmpresa = _IdEmpresa;
            IdCbteVtaTipo = _IdCbteVtaTipo;
            IdCbteVta = _IdCbteVta;
            secuencia = _secuencia;
            IdProducto = _IdProducto;
            observacion_det = _observacion_det;
            cantidad = _cantidad;
            precio = _precio;
            por_descuento = _por_descuento;
            valor_descuento = _valor_descuento;
            precio_final = _precio_final;
            subtotal = _subtotal;
            valor_impuesto_iva = _valor_impuesto_iva;
            por_impuesto_iva = _por_impuesto_iva;
            IdImpuesto_Iva = _IdImpuesto_Iva;
            total = _total;
            IdPunto_Cargo = _IdPunto_Cargo;
            IdPunto_cargo_grupo = _IdPunto_cargo_grupo;
            IdImpuesto_Ice = _IdImpuesto_Ice;
            valor_impuesto_ice = _valor_impuesto_ice;
            por_impuesto_ice = _por_impuesto_ice;

        }




    }
}
