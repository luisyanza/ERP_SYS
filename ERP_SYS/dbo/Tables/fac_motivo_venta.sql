CREATE TABLE [dbo].[fac_motivo_venta] (
    [IdEmpresa]           INT           NOT NULL,
    [IdMotivo_Vta]        INT           NOT NULL,
    [codMotivo_Vta]       VARCHAR (50)  NOT NULL,
    [nom_motivo_vta]      VARCHAR (250) NOT NULL,
    [Estado]              BIT           NOT NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaCreacion]       DATETIME      NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [MotivoAnulacion]     VARCHAR (100) NULL,
    CONSTRAINT [PK_fa_motivo_venta] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdMotivo_Vta] ASC)
);

