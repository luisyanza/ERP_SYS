CREATE TABLE [dbo].[con_anio_fiscal_x_cuenta_utilidad] (
    [IdEmpresa]    INT          NOT NULL,
    [IdanioFiscal] INT          NOT NULL,
    [IdCtaCble]    VARCHAR (50) NOT NULL,
    [observacion]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_con_anio_fiscal_x_cuenta_utilidad] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdanioFiscal] ASC, [IdCtaCble] ASC),
    CONSTRAINT [FK_con_anio_fiscal_x_cuenta_utilidad_con_anio_fiscal] FOREIGN KEY ([IdanioFiscal]) REFERENCES [dbo].[con_anio_fiscal] ([IdanioFiscal]),
    CONSTRAINT [FK_con_anio_fiscal_x_cuenta_utilidad_con_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[con_plancta] ([IdEmpresa], [IdCtaCble])
);

