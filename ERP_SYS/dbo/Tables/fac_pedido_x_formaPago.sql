CREATE TABLE [dbo].[fac_pedido_x_formaPago] (
    [IdEmpresa]        INT          NOT NULL,
    [IdSucursal]       INT          NOT NULL,
    [IdBodega]         INT          NOT NULL,
    [IdPedido]         NUMERIC (18) NOT NULL,
    [IdTipoFormaPago]  VARCHAR (20) NOT NULL,
    [Secuencia]        INT          NOT NULL,
    [Fecha]            DATE         NOT NULL,
    [Fecha_vct]        DATE         NOT NULL,
    [Dias_Plazo]       INT          NOT NULL,
    [Por_Distribucion] FLOAT (53)   NOT NULL,
    [Valor]            FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_fa_pedido_x_formaPago] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdPedido] ASC, [IdTipoFormaPago] ASC, [Secuencia] ASC)
);

