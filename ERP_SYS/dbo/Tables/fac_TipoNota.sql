CREATE TABLE [dbo].[fac_TipoNota] (
    [IdEmpresa]          INT           NOT NULL,
    [IdTipoNota]         INT           NOT NULL,
    [CodTipoNota]        VARCHAR (50)  NOT NULL,
    [Tipo]               CHAR (1)      NOT NULL,
    [nom_tipoNota]       VARCHAR (350) NOT NULL,
    [usado_x_sys]        BIT           NOT NULL,
    [SeDeclara_como_imp] BIT           NOT NULL,
    [estado]             BIT           NOT NULL,
    [IdUsuario]          VARCHAR (20)  NOT NULL,
    [Fecha_Transac]      DATETIME      NOT NULL,
    [IdUsuarioUltMod]    VARCHAR (20)  NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltAnu]    VARCHAR (20)  NULL,
    [Fecha_UltAnu]       DATETIME      NULL,
    [nom_pc]             VARCHAR (50)  NULL,
    [ip]                 VARCHAR (25)  NULL,
    [MotiAnula]          VARCHAR (200) NULL,
    CONSTRAINT [PK_fa_TipoNota] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoNota] ASC)
);

