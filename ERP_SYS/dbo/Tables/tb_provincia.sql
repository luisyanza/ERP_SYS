CREATE TABLE [dbo].[tb_provincia] (
    [IdProvincia]     VARCHAR (25)  NOT NULL,
    [Cod_Provincia]   VARCHAR (25)  NOT NULL,
    [nom_Provincia]   VARCHAR (50)  NOT NULL,
    [Estado]          BIT           NOT NULL,
    [IdPais]          VARCHAR (10)  NOT NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [MotivoAnula]     VARCHAR (100) NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    CONSTRAINT [PK_tb_provincia] PRIMARY KEY CLUSTERED ([IdProvincia] ASC)
);

