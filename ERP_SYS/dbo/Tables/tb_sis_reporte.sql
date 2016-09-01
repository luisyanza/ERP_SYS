CREATE TABLE [dbo].[tb_sis_reporte] (
    [IdReporte]                VARCHAR (50)    NOT NULL,
    [Nom_reporte]              VARCHAR (150)   NOT NULL,
    [Nom_Corto_reporte]        VARCHAR (150)   NOT NULL,
    [IdModulo]                 VARCHAR (20)    NOT NULL,
    [VistaRpt]                 VARCHAR (50)    NOT NULL,
    [Formulario]               VARCHAR (50)    NOT NULL,
    [Class_NomReporte]         VARCHAR (50)    NOT NULL,
    [nom_Asembly]              VARCHAR (50)    NOT NULL,
    [Orden]                    INT             NOT NULL,
    [Observacion]              TEXT            NOT NULL,
    [imagen]                   IMAGE           NOT NULL,
    [VersionActual]            INT             NOT NULL,
    [Tipo_Balance]             VARCHAR (10)    NOT NULL,
    [SQuery]                   VARCHAR (MAX)   NOT NULL,
    [Class_Info]               VARCHAR (50)    NOT NULL,
    [Class_Bus]                VARCHAR (50)    NOT NULL,
    [Class_Data]               VARCHAR (50)    NOT NULL,
    [IdGrupo_Reporte]          INT             NOT NULL,
    [se_Muestra_Admin_Reporte] BIT             NOT NULL,
    [Estado]                   BIT             NOT NULL,
    [Store_proce_rpt]          VARCHAR (50)    NOT NULL,
    [Disenio_reporte]          VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_tb_sis_reporte] PRIMARY KEY CLUSTERED ([IdReporte] ASC)
);



