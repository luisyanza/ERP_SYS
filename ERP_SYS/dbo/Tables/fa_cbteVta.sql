CREATE TABLE [dbo].[fa_cbteVta] (
    [IdEmpresa]     INT           NOT NULL,
    [IdCbteVtaTipo] VARCHAR (20)  NOT NULL,
    [IdCbteVta]     NUMERIC (18)  NOT NULL,
    [num_CbteVta]   VARCHAR (150) NULL,
    [IdSucursal]    INT           NOT NULL,
    [IdPuntoVta]    INT           NOT NULL,
    [IdCliente]     NUMERIC (18)  NOT NULL,
    [estado]        BIT           NOT NULL,
    [observacion]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_fa_cbteVta] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteVtaTipo] ASC, [IdCbteVta] ASC),
    CONSTRAINT [FK_fa_cbteVta_fa_cbteVta_Talonario] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdPuntoVta], [IdCbteVtaTipo], [num_CbteVta]) REFERENCES [dbo].[fa_cbteVta_Talonario] ([IdEmpresa], [IdSucursal], [IdPuntoVta], [IdCbteVtaTipo], [num_CbteVta]),
    CONSTRAINT [FK_fa_cbteVta_fa_cbteVta_tipo] FOREIGN KEY ([IdEmpresa], [IdCbteVtaTipo]) REFERENCES [dbo].[fa_cbteVta_tipo] ([IdEmpresa], [IdCbteVtaTipo]),
    CONSTRAINT [FK_fa_cbteVta_fa_cliente] FOREIGN KEY ([IdEmpresa], [IdCliente]) REFERENCES [dbo].[fa_cliente] ([IdEmpresa], [IdCliente]),
    CONSTRAINT [FK_fa_cbteVta_tb_puntoVta] FOREIGN KEY ([IdEmpresa], [IdPuntoVta], [IdSucursal]) REFERENCES [dbo].[tb_puntoVta] ([IdEmpresa], [IdPuntoVta], [IdSucursal])
);

