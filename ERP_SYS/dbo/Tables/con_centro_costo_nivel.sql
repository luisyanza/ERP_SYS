CREATE TABLE [dbo].[con_centro_costo_nivel] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNivel]           INT           NOT NULL,
    [nom_nivel]         VARCHAR (50)  NOT NULL,
    [num_digitos]       INT           NOT NULL,
    [Estado]            BIT           NULL,
    [IdUsuario]         VARCHAR (50)  NULL,
    [Fecha_Transaccion] DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (50)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (50)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (100) NULL,
    CONSTRAINT [PK_con_centro_costo_nivel] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNivel] ASC)
);

