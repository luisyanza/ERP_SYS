CREATE TABLE [dbo].[fac_TipoNota_x_tbsucursal] (
    [IdEmpresa]  INT          NOT NULL,
    [IdSucursal] INT          NOT NULL,
    [IdTipoNota] INT          NOT NULL,
    [IdCtaCble]  VARCHAR (50) NULL,
    CONSTRAINT [PK_fa_TipoNota_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdTipoNota] ASC)
);

