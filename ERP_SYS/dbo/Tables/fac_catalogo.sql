CREATE TABLE [dbo].[fac_catalogo] (
    [IdCatalogo]      VARCHAR (15)  NOT NULL,
    [cod_catalogo]    VARCHAR (50)  NOT NULL,
    [IdCatalogo_tipo] INT           NOT NULL,
    [nom_catalogo]    VARCHAR (50)  NOT NULL,
    [estado]          BIT           NOT NULL,
    [orden]           INT           NOT NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [FechaUltMod]     DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [MotiAnula]       VARCHAR (200) NULL,
    CONSTRAINT [PK_fa_catalogo_1] PRIMARY KEY CLUSTERED ([IdCatalogo] ASC)
);

