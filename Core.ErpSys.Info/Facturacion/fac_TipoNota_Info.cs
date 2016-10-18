using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_TipoNota_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoNota { get; set; }
        public string CodTipoNota { get; set; }
        public string Tipo { get; set; }
        public string nom_tipoNota { get; set; }
        public Boolean usado_x_sys { get; set; }
        public Boolean SeDeclara_como_imp { get; set; }
        public Boolean estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }

        public fac_TipoNota_Info()
        {

        }

        public fac_TipoNota_Info(int _IdEmpresa,	int _IdTipoNota,	string _CodTipoNota,	string _Tipo,	string _nom_tipoNota,
                                Boolean _usado_x_sys,	Boolean _SeDeclara_como_imp,	Boolean _estado,	string _IdUsuario,	DateTime _Fecha_Transac,
                                string _IdUsuarioUltMod,	DateTime? _Fecha_UltMod,	string _IdUsuarioUltAnu,	DateTime? _Fecha_UltAnu,	string _nom_pc,
                                string _ip,	string _MotiAnula)
        {
            IdEmpresa = _IdEmpresa;
            IdTipoNota = _IdTipoNota;
            CodTipoNota = _CodTipoNota;
            Tipo = _Tipo;
            nom_tipoNota = _nom_tipoNota;
            usado_x_sys = _usado_x_sys;
            SeDeclara_como_imp = _SeDeclara_como_imp;
            estado = _estado;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            nom_pc = _nom_pc;
            ip = _ip;
            MotiAnula = _MotiAnula;

        }
    }
}
