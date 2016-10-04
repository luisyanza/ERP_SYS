CREATE TABLE [dbo].[fac_Vendedor] (
    [IdEmpresa]       INT           NOT NULL,
    [IdVendedor]      INT           NOT NULL,
    [IdEmpleado]      NUMERIC (18)  NULL,
    [cod_vendedor]    VARCHAR (50)  NULL,
    [nom_vendedor]    NCHAR (200)   NULL,
    [Estado]          BIT           NOT NULL,
    [ve_cedula]       VARCHAR (20)  NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [MotivoAnula]     VARCHAR (200) NULL,
    CONSTRAINT [PK_fa_vendedor] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdVendedor] ASC)
);

