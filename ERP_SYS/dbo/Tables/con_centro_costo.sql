CREATE TABLE [dbo].[con_centro_costo] (
    [IdEmpresa]          INT           NOT NULL,
    [IdCentroCosto]      VARCHAR (50)  NOT NULL,
    [CodCentroCosto]     VARCHAR (50)  NOT NULL,
    [nom_CentroCosto]    VARCHAR (250) NOT NULL,
    [IdCentroCostoPadre] VARCHAR (50)  NULL,
    [EsMovimiento]       BIT           NOT NULL,
    [IdNivel]            INT           NOT NULL,
    [estado]             BIT           NOT NULL,
    [IdCtaCble]          VARCHAR (50)  NULL,
    [Fecha_Transac]      DATETIME      NULL,
    [IdUsuario]          VARCHAR (50)  NULL,
    [IdUsuarioUltMod]    VARCHAR (50)  NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltAnu]    VARCHAR (50)  NULL,
    [Fecha_UltAnu]       DATETIME      NULL,
    [MotivoAnulacion]    VARCHAR (150) NULL,
    [nom_pc]             VARCHAR (50)  NULL,
    [ip]                 VARCHAR (50)  NULL,
    CONSTRAINT [PK_con_centro_costo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCentroCosto] ASC)
);

