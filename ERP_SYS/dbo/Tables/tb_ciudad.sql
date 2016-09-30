CREATE TABLE [dbo].[tb_ciudad] (
    [IdCiudad]        VARCHAR (25)  NOT NULL,
    [Cod_Ciudad]      VARCHAR (25)  NOT NULL,
    [nom_ciudad]      VARCHAR (50)  NOT NULL,
    [Estado]          BIT           NOT NULL,
    [IdProvincia]     VARCHAR (25)  NOT NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [MotivoAnula]     VARCHAR (100) NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    CONSTRAINT [PK_tb_ciudad] PRIMARY KEY CLUSTERED ([IdCiudad] ASC)
);

