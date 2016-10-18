using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_motivo_venta_Info
    {

        public int IdEmpresa { get; set; }
        public int IdMotivo_Vta { get; set; }
        public string codMotivo_Vta { get; set; }
        public string nom_motivo_vta { get; set; }
        public Boolean Estado { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public fac_motivo_venta_Info()
        {


        }

        public fac_motivo_venta_Info(int _IdEmpresa,	int _IdMotivo_Vta,	string _codMotivo_Vta,	string _nom_motivo_vta,	Boolean _Estado,
                                     DateTime? _FechaModificacion,	DateTime? _FechaCreacion,string _UsuarioModificacion,	
                                     string _UsuarioCreacion,	DateTime? _FechaAnulacion,	string _UsuarioAnulacion,	string _MotivoAnulacion)
        {
            IdEmpresa = _IdEmpresa;
            IdMotivo_Vta = _IdMotivo_Vta;
            codMotivo_Vta = _codMotivo_Vta;
            nom_motivo_vta = _nom_motivo_vta;
            Estado = _Estado;
            FechaModificacion = _FechaModificacion;
            FechaCreacion = _FechaCreacion;
            UsuarioModificacion = _UsuarioModificacion;
            UsuarioCreacion = _UsuarioCreacion;
            FechaAnulacion = _FechaAnulacion;
            UsuarioAnulacion = _UsuarioAnulacion;
            MotivoAnulacion = _MotivoAnulacion;

        }
    }
}
