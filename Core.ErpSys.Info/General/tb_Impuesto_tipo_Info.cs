using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_Impuesto_tipo_Info
    {
        public string IdImpuesto_tipo { get; set; }
        public string nom_Impuesto_tipo { get; set; }



        public tb_Impuesto_tipo_Info(string _IdImpuesto_tipo, string _nom_Impuesto_tipo)
        {
            IdImpuesto_tipo = _IdImpuesto_tipo;
            nom_Impuesto_tipo = _nom_Impuesto_tipo;

        }

        public tb_Impuesto_tipo_Info()
        {

        }
    }
}
