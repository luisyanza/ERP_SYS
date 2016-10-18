using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_catalogo_Info
    {
        
        public string IdCatalogo { get; set; }
        public string cod_catalogo { get; set; }
        public int IdCatalogo_tipo { get; set; }
        public string nom_catalogo { get; set; }
        public Boolean estado { get; set; }
        public int orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }


        public fac_catalogo_Info()
        {

        }
        public fac_catalogo_Info(string _IdCatalogo, string _cod_catalogo, int _IdCatalogo_tipo, string _nom_catalogo, Boolean _estado, int _orden, string _IdUsuario,
                                    string _IdUsuarioUltMod, DateTime? _FechaUltMod, string _nom_pc, string _ip, string _IdUsuarioUltAnu, DateTime? _Fecha_UltAnu, string _MotiAnula)
        {
            IdCatalogo = _IdCatalogo;
            cod_catalogo = _cod_catalogo;
            IdCatalogo_tipo = _IdCatalogo_tipo;
            nom_catalogo = _nom_catalogo;
            estado = _estado;
            orden = _orden;
            IdUsuario = _IdUsuario;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            FechaUltMod = _FechaUltMod;
            nom_pc = _nom_pc;
            ip = _ip;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            MotiAnula = _MotiAnula;

        }

        public fac_catalogo_Info(string _IdCatalogo, string _nom_catalogo, bool _estado, int _IdCatalogo_tipo)
        {
            // TODO: Complete member initialization
            this.IdCatalogo = _IdCatalogo;
            this.nom_catalogo  = _nom_catalogo;
            this.estado = _estado;
            this.IdCatalogo_tipo = _IdCatalogo_tipo;
        }
    }
}
