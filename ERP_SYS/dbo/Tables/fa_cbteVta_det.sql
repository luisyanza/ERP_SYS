CREATE TABLE [dbo].[fa_cbteVta_det] (
    [IdEmpresa]          INT           NOT NULL,
    [IdCbteVtaTipo]      VARCHAR (20)  NOT NULL,
    [IdCbteVta]          NUMERIC (18)  NOT NULL,
    [secuencia]          INT           NOT NULL,
    [IdProducto]         NUMERIC (18)  NOT NULL,
    [observacion_det]    VARCHAR (MAX) NOT NULL,
    [cantidad]           FLOAT (53)    NOT NULL,
    [precio]             FLOAT (53)    NOT NULL,
    [por_descuento]      FLOAT (53)    NOT NULL,
    [valor_descuento]    FLOAT (53)    NOT NULL,
    [precio_final]       FLOAT (53)    NOT NULL,
    [subtotal]           FLOAT (53)    NOT NULL,
    [valor_impuesto_iva] FLOAT (53)    NOT NULL,
    [por_impuesto_iva]   FLOAT (53)    NOT NULL,
    [IdImpuesto_Iva]     VARCHAR (20)  NOT NULL,
    [total]              FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_cbteVta_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteVtaTipo] ASC, [IdCbteVta] ASC, [secuencia] ASC),
    CONSTRAINT [FK_fa_cbteVta_det_fa_cbteVta] FOREIGN KEY ([IdEmpresa], [IdCbteVtaTipo], [IdCbteVta]) REFERENCES [dbo].[fa_cbteVta] ([IdEmpresa], [IdCbteVtaTipo], [IdCbteVta]),
    CONSTRAINT [FK_fa_cbteVta_det_in_producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_producto] ([IdEmpresa], [IdProducto]),
    CONSTRAINT [FK_fa_cbteVta_det_tb_impuesto] FOREIGN KEY ([IdImpuesto_Iva]) REFERENCES [dbo].[tb_impuesto] ([IdImpuesto])
);

