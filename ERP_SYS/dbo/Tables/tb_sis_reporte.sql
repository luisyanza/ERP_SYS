CREATE TABLE [dbo].[tb_sis_reporte] (
    [IdReporte]   VARCHAR (50)  NOT NULL,
    [cod_reporte] VARCHAR (50)  NOT NULL,
    [nom_reporte] VARCHAR (500) NOT NULL,
    [estado]      BIT           NOT NULL,
    CONSTRAINT [PK_tb_sis_reporte] PRIMARY KEY CLUSTERED ([IdReporte] ASC)
);

