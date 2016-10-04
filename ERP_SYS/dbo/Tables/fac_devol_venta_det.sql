CREATE TABLE [dbo].[fac_devol_venta_det] (
    [IdEmpresa]             INT            NOT NULL,
    [IdSucursal]            INT            NOT NULL,
    [IdPuntoVta]            INT            NOT NULL,
    [IdDevolucion]          NUMERIC (18)   NOT NULL,
    [Secuencia]             INT            NOT NULL,
    [IdProducto]            NUMERIC (18)   NOT NULL,
    [dv_cantidad]           FLOAT (53)     NOT NULL,
    [dv_Precio]             FLOAT (53)     NOT NULL,
    [dv_PorDescUni]         FLOAT (53)     NOT NULL,
    [dv_ValordescUni]       FLOAT (53)     NOT NULL,
    [dv_PrecioFinal]        FLOAT (53)     NOT NULL,
    [dv_subtotal]           FLOAT (53)     NOT NULL,
    [dv_valor_impuesto_iva] FLOAT (53)     NOT NULL,
    [dv_costo_Uni]          FLOAT (53)     NOT NULL,
    [dv_detallexItems]      VARCHAR (1000) NOT NULL,
    [dv_por_impuesto_iva]   FLOAT (53)     NOT NULL,
    [IdImpuesto_Iva]        VARCHAR (20)   NOT NULL,
    [dv_total]              FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_fa_devol_venta_detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdDevolucion] ASC, [Secuencia] ASC)
);

