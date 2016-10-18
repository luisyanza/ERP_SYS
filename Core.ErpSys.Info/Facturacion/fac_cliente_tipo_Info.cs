using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_cliente_tipo_Info
    {

        public int IdEmpresa { get; set; }
        public int Idtipo_cliente { get; set; }
        public string nom_tip_cliente { get; set; }
        public string IdCtaCble_CXC_Con { get; set; }
        public string IdCtaCble_CXC_Cred { get; set; }
        public string IdCtaCble_CXC_Anticipo { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Boolean estado { get; set; }

        public fac_cliente_tipo_Info()
        {


        }
        public fac_cliente_tipo_Info(int _IdEmpresa,	int _Idtipo_cliente,	string _nom_tip_cliente,	string _IdCtaCble_CXC_Con,	
                                    string _IdCtaCble_CXC_Cred,	string _IdCtaCble_CXC_Anticipo,	string _IdUsuario, DateTime? _Fecha_Transac,	
                                    string _IdUsuarioUltMod,	DateTime? _Fecha_UltMod,	string _IdUsuarioUltAnu,	DateTime? _Fecha_UltAnu,	
                                    string _MotivoAnula, string _nom_pc,	string _ip,	Boolean _estado)
        {
            IdEmpresa = _IdEmpresa;
            Idtipo_cliente = _Idtipo_cliente;
            nom_tip_cliente = _nom_tip_cliente;
            IdCtaCble_CXC_Con = _IdCtaCble_CXC_Con;
            IdCtaCble_CXC_Cred = _IdCtaCble_CXC_Cred;
            IdCtaCble_CXC_Anticipo = _IdCtaCble_CXC_Anticipo;
            IdUsuario = _IdUsuario;
            Fecha_Transac = _Fecha_Transac;
            IdUsuarioUltMod = _IdUsuarioUltMod;
            Fecha_UltMod = _Fecha_UltMod;
            IdUsuarioUltAnu = _IdUsuarioUltAnu;
            Fecha_UltAnu = _Fecha_UltAnu;
            MotivoAnula = _MotivoAnula;
            nom_pc = _nom_pc;
            ip = _ip;
            estado = _estado;

        }
    }
}
