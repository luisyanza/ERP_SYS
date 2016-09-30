CREATE TABLE [dbo].[fac_cliente_tipo] (
    [IdEmpresa]              INT           NOT NULL,
    [Idtipo_cliente]         INT           NOT NULL,
    [nom_tip_cliente]        VARCHAR (50)  NOT NULL,
    [IdCtaCble_CXC_Con]      VARCHAR (50)  NULL,
    [IdCtaCble_CXC_Cred]     VARCHAR (50)  NULL,
    [IdCtaCble_CXC_Anticipo] VARCHAR (50)  NULL,
    [IdUsuario]              VARCHAR (20)  NULL,
    [Fecha_Transac]          DATETIME      NULL,
    [IdUsuarioUltMod]        VARCHAR (20)  NULL,
    [Fecha_UltMod]           DATETIME      NULL,
    [IdUsuarioUltAnu]        VARCHAR (20)  NULL,
    [Fecha_UltAnu]           DATETIME      NULL,
    [MotivoAnula]            VARCHAR (100) NULL,
    [nom_pc]                 VARCHAR (50)  NULL,
    [ip]                     VARCHAR (25)  NULL,
    [estado]                 BIT           NOT NULL,
    CONSTRAINT [PK_fa_cliente_tipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [Idtipo_cliente] ASC)
);

