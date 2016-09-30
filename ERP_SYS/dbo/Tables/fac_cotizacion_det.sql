CREATE TABLE [dbo].[fac_cotizacion_det] (
    [IdEmpresa]             INT           NOT NULL,
    [IdSucursal]            INT           NOT NULL,
    [IdPuntoVta]            INT           NOT NULL,
    [IdCotizacion]          NUMERIC (18)  NOT NULL,
    [Secuencial]            INT           NOT NULL,
    [IdProducto]            NUMERIC (18)  NOT NULL,
    [dc_cantidad]           FLOAT (53)    NOT NULL,
    [dc_precio]             FLOAT (53)    NOT NULL,
    [dc_por_desUni]         FLOAT (53)    NOT NULL,
    [dc_valor_desUni]       FLOAT (53)    NOT NULL,
    [dc_precioFinal]        FLOAT (53)    NOT NULL,
    [dc_subtotal]           FLOAT (53)    NOT NULL,
    [dc_valor_impuesto_iva] FLOAT (53)    NOT NULL,
    [dc_detallexItems]      VARCHAR (500) NOT NULL,
    [dc_por_impuesto_iva]   FLOAT (53)    NOT NULL,
    [IdImpuesto_Iva]        VARCHAR (20)  NOT NULL,
    [dc_total]              FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_cotizacion_detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdCotizacion] ASC, [Secuencial] ASC)
);

