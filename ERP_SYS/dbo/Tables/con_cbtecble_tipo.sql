CREATE TABLE [dbo].[con_cbtecble_tipo] (
    [IdEmpresa]       INT            NOT NULL,
    [IdTipoCbte]      INT            NOT NULL,
    [CodTipoCbte]     VARCHAR (50)   NOT NULL,
    [nom_tipocbte]    VARCHAR (50)   CONSTRAINT [DF__con_tipo_c__TipoC__114A936A] DEFAULT (NULL) NOT NULL,
    [estado]          BIT            CONSTRAINT [DF__con_tipo_c__Estad__123EB7A3] DEFAULT (NULL) NOT NULL,
    [usado_x_conta]   BIT            CONSTRAINT [DF__con_tipo_c__Inter__1332DBDC] DEFAULT (NULL) NOT NULL,
    [IdTipoCbte_Anul] INT            NULL,
    [IdUsuario]       VARCHAR (20)   NULL,
    [Fecha_Transac]   DATETIME       NULL,
    [IdUsuarioUltMod] VARCHAR (20)   NULL,
    [Fecha_UltMod]    DATETIME       NULL,
    [IdUsuarioUltAnu] VARCHAR (20)   NULL,
    [Fecha_UltAnu]    DATETIME       NULL,
    [MotiAnula]       VARCHAR (1000) NULL,
    CONSTRAINT [PK_con_cbtecble_tipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoCbte] ASC)
);

