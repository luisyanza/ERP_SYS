﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_Vendedor_Info
    {

        public int IdEmpresa { get; set; }
        public int IdVendedor { get; set; }
        public decimal? IdEmpleado { get; set; }
        public string cod_vendedor { get; set; }
        public string nom_vendedor { get; set; }
        public Boolean Estado { get; set; }
        public string ve_cedula { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnula { get; set; }

        public fac_Vendedor_Info()
        {

        }

        public fac_Vendedor_Info(int _IdEmpresa, int _IdVendedor, decimal? _IdEmpleado, string _cod_vendedor, string _nom_vendedor, Boolean _Estado, string _ve_cedula,
                                string _IdUsuario, DateTime? _Fecha_Transac, string _IdUsuarioUltMod, DateTime? _Fecha_UltMod, string _IdUsuarioUltAnu, DateTime? _Fecha_UltAnu,
                                string _nom_pc, string _ip, string _MotivoAnula)
        {
            IdEmpresa = _IdEmpresa;
            IdVendedor = _IdVendedor;
            IdEmpleado = _IdEmpleado;
            cod_vendedor = _cod_vendedor;
            nom_vendedor = _nom_vendedor;
            Estado = _Estado;
            ve_cedula = _ve_cedula;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            nom_pc = _nom_pc;
            ip = _ip;
            MotivoAnula = _MotivoAnula;

        }
    }
}
