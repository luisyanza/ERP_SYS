﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.General
{
    public class tb_impuesto_Info
    {
        public string IdImpuesto { get; set; }
        public string nom_Impuesto { get; set; }
        public string IdImpuesto_tipo { get; set; }

        public tb_impuesto_Info()
        {

        }
        public tb_impuesto_Info(string _IdImpuesto,	string _nom_Impuesto,	string _IdImpuesto_tipo)
        {
            IdImpuesto = _IdImpuesto;
            nom_Impuesto = _nom_Impuesto;
            IdImpuesto_tipo = _IdImpuesto_tipo;

        }
    }
}
