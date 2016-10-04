using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fa_cbteVta_Talonario_Info
    {
        private int p1;
        private int p2;
        private int p3;
        private string p4;
        private string p5;
        private string p6;
        private bool? nullable;

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public string num_CbteVta { get; set; }
        public string num_autorizacion { get; set; }
        public bool? usado { get; set; }

        public fa_cbteVta_Talonario_Info()
        {

        }

        public fa_cbteVta_Talonario_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, string _IdCbteVtaTipo, string _num_CbteVta, string _num_autorizacion, bool? _usado)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdPuntoVta = _IdPuntoVta;
            IdCbteVtaTipo = _IdCbteVtaTipo;
            num_CbteVta = _num_CbteVta;
            num_autorizacion = _num_autorizacion;
            usado = _usado;

        }

       
    }
}
