using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_Catalogo_Info
    {
        
        public string IdCatalogo { get; set; }
        public string nom_catalogo { get; set; }
        public bool estado { get; set; }
        public string IdCatalogo_tipo { get; set; }

        public tb_Catalogo_Info()
        {

        }

        public tb_Catalogo_Info(string _IdCatalogo, string _nom_catalogo, bool _estado, string _IdCatalogo_tipo)
        {
            // TODO: Complete member initialization
            this.IdCatalogo = _IdCatalogo;
            this.nom_catalogo = _nom_catalogo;
            this.estado = _estado;
            this.IdCatalogo_tipo = _IdCatalogo_tipo;
        }
    }
}
