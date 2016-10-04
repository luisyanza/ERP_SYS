CREATE TABLE [dbo].[con_plancta_nivel] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNivelCta]        INT           NOT NULL,
    [nv_NumDigitos]     INT           NOT NULL,
    [nom_nivelCta]      VARCHAR (50)  NOT NULL,
    [Estado]            BIT           NULL,
    [IdUsuario]         VARCHAR (20)  NULL,
    [Fecha_Transaccion] DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (20)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (20)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (100) NULL,
    CONSTRAINT [PK_con_nivel_cuenta] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNivelCta] ASC)
);

