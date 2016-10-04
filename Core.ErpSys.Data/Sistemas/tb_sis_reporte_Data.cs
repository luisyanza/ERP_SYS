using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Sistemas;


namespace Core.ErpSys.Data.Sistemas
{
    public class tb_sis_reporte_Data
    {
        public List<tb_sis_reporte_Info> Get_List_Reporte()
        {
            List<tb_sis_reporte_Info> ListInfo = new List<tb_sis_reporte_Info>();


            Entities_Sistemas OBase = new Entities_Sistemas();

            var selectq = from q in OBase.tb_sis_reporte
                          select q;

            foreach (var item in selectq)
            {
                ListInfo.Add(new tb_sis_reporte_Info(item.IdReporte,
                                                      item.Nom_reporte,
                                                      item.Nom_Corto_reporte,
                                                      item.IdModulo,
                                                      item.VistaRpt,
                                                      item.Formulario,
                                                      item.Class_NomReporte,
                                                      item.nom_Asembly,
                                                      item.Orden,
                                                      item.Observacion,
                                                      item.imagen,
                                                      item.VersionActual,
                                                      item.Tipo_Balance,
                                                      item.SQuery,
                                                      item.Class_Info,
                                                      item.Class_Bus,
                                                      item.Class_Data,
                                                      item.IdGrupo_Reporte,
                                                      item.se_Muestra_Admin_Reporte,
                                                      item.Estado,
                                                      item.Store_proce_rpt,
                                                      item.Disenio_reporte
                                                      ));
            }

            return ListInfo;

        }

        public tb_sis_reporte_Info Get_Info_Reporte(string IdReporte)
        {

            tb_sis_reporte_Info Info = new tb_sis_reporte_Info();


            Entities_Sistemas OBase = new Entities_Sistemas();

            var selectq = from q in OBase.tb_sis_reporte
                          where q.IdReporte == IdReporte
                          select q;

            foreach (var item in selectq)
            {
                Info.IdReporte = item.IdReporte;
                Info.Nom_reporte = item.Nom_reporte;
                Info.Nom_Corto_reporte = item.Nom_Corto_reporte;
                Info.IdModulo = item.IdModulo;
                Info.VistaRpt = item.VistaRpt;
                Info.Formulario = item.Formulario;
                Info.Class_NomReporte = item.Class_NomReporte;
                Info.nom_Asembly = item.nom_Asembly;
                Info.Orden = item.Orden;
                Info.Observacion = item.Observacion;
                Info.imagen = item.imagen;
                Info.VersionActual = item.VersionActual;
                Info.Tipo_Balance = item.Tipo_Balance;
                Info.SQuery = item.SQuery;
                Info.Class_Info = item.Class_Info;
                Info.Class_Bus = item.Class_Bus;
                Info.Class_Data = item.Class_Data;
                Info.IdGrupo_Reporte = item.IdGrupo_Reporte;
                Info.se_Muestra_Admin_Reporte = item.se_Muestra_Admin_Reporte;
                Info.Estado = item.Estado;
                Info.Store_proce_rpt = item.Store_proce_rpt;
                Info.Disenio_reporte = item.Disenio_reporte;

            }


            return Info;

        }

        public Boolean GrabarDB(tb_sis_reporte_Info Info)
        {

            using (Entities_Sistemas context = new Entities_Sistemas())
            {
                var reporte = new tb_sis_reporte();
                reporte.IdReporte = Info.IdReporte;
                reporte.Nom_reporte = Info.Nom_reporte;
                reporte.Nom_Corto_reporte = Info.Nom_Corto_reporte;
                reporte.IdModulo = Info.IdModulo;
                reporte.VistaRpt = Info.VistaRpt;
                reporte.Formulario = Info.Formulario;
                reporte.Class_NomReporte = Info.Class_NomReporte;
                reporte.nom_Asembly = Info.nom_Asembly;
                reporte.Orden = Info.Orden;
                reporte.Observacion = Info.Observacion;
                reporte.imagen = Info.imagen;
                reporte.VersionActual = Info.VersionActual;
                reporte.Tipo_Balance = Info.Tipo_Balance;
                reporte.SQuery = Info.SQuery;
                reporte.Class_Info = Info.Class_Info;
                reporte.Class_Bus = Info.Class_Bus;
                reporte.Class_Data = Info.Class_Data;
                reporte.IdGrupo_Reporte = Info.IdGrupo_Reporte;
                reporte.se_Muestra_Admin_Reporte = Info.se_Muestra_Admin_Reporte;
                reporte.Estado = true;
                reporte.Store_proce_rpt = Info.Store_proce_rpt;
                reporte.Disenio_reporte = Info.Disenio_reporte;
                context.tb_sis_reporte.Add(reporte);
                context.SaveChanges();



            }
            return true;

        }

        public Boolean ModificarDB(tb_sis_reporte_Info Info)
        {
            using (Entities_Sistemas context = new Entities_Sistemas())
            {
                var reporte = context.tb_sis_reporte.FirstOrDefault(cot => cot.IdReporte == Info.IdReporte);

                if (reporte != null)
                {
                    reporte.Nom_reporte = Info.Nom_reporte;
                    reporte.Nom_Corto_reporte = Info.Nom_Corto_reporte;
                    reporte.IdModulo = Info.IdModulo;
                    reporte.VistaRpt = Info.VistaRpt;
                    reporte.Formulario = Info.Formulario;
                    reporte.Class_NomReporte = Info.Class_NomReporte;
                    reporte.nom_Asembly = Info.nom_Asembly;
                    reporte.Orden = Info.Orden;
                    reporte.Observacion = Info.Observacion;
                    reporte.imagen = Info.imagen;
                    reporte.VersionActual = Info.VersionActual;
                    reporte.Tipo_Balance = Info.Tipo_Balance;
                    reporte.SQuery = Info.SQuery;
                    reporte.Class_Info = Info.Class_Info;
                    reporte.Class_Bus = Info.Class_Bus;
                    reporte.Class_Data = Info.Class_Data;
                    reporte.IdGrupo_Reporte = Info.IdGrupo_Reporte;
                    reporte.se_Muestra_Admin_Reporte = Info.se_Muestra_Admin_Reporte;
                    reporte.Store_proce_rpt = Info.Store_proce_rpt;
                    reporte.Disenio_reporte = Info.Disenio_reporte;
                    context.SaveChanges();
                }
            }
            return true;

        }

        public Boolean AnularDB(tb_sis_reporte_Info Info)
        {
            using (Entities_Sistemas context = new Entities_Sistemas())
            {
                var reporte = context.tb_sis_reporte.FirstOrDefault(cot => cot.IdReporte == Info.IdReporte);
                if (reporte != null)
                {
                    reporte.Estado = false;

                    context.SaveChanges();
                }
            }
            return true;

        }
    }
}

