CREATE TABLE [dbo].[fac_orden_pedido_det] (
    [IdEmpresa]             INT           NOT NULL,
    [IdSucursal]            INT           NOT NULL,
    [IdPuntoVta]            INT           NOT NULL,
    [IdPedido]              NUMERIC (18)  NOT NULL,
    [Secuencial]            INT           NOT NULL,
    [IdProducto]            NUMERIC (18)  NOT NULL,
    [dp_cantidad]           FLOAT (53)    NOT NULL,
    [dp_precio]             FLOAT (53)    NOT NULL,
    [dp_Porc_descuento]     FLOAT (53)    NOT NULL,
    [cp_valor_desUni]       FLOAT (53)    NOT NULL,
    [cp_PrecioFinal]        FLOAT (53)    NOT NULL,
    [dp_subtotal]           FLOAT (53)    NOT NULL,
    [dp_valor_impuesto_iva] FLOAT (53)    NOT NULL,
    [dp_detallexItems]      VARCHAR (250) NOT NULL,
    [dp_por_impuesto_iva]   FLOAT (53)    NOT NULL,
    [IdImpuesto_Iva]        VARCHAR (20)  NOT NULL,
    [IdImpuesto_Ice]        VARCHAR (20)  NOT NULL,
    [valor_impuesto_ice]    FLOAT (53)    NOT NULL,
    [por_impuesto_ice]      FLOAT (53)    NOT NULL,
    [dp_total]              FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_pedido_detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdPedido] ASC, [Secuencial] ASC)
);

