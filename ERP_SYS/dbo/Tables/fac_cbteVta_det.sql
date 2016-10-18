CREATE TABLE [dbo].[fac_cbteVta_det] (
    [IdEmpresa]             INT           NOT NULL,
    [IdCbteVtaTipo]         VARCHAR (20)  NOT NULL,
    [IdCbteVta]             NUMERIC (18)  NOT NULL,
    [secuencia]             INT           NOT NULL,
    [IdProducto]            NUMERIC (18)  NOT NULL,
    [vt_observacion_det]    VARCHAR (MAX) NOT NULL,
    [vt_cantidad]           FLOAT (53)    NOT NULL,
    [vt_precio]             FLOAT (53)    NOT NULL,
    [vt_por_descuento]      FLOAT (53)    NOT NULL,
    [vt_valor_descuento]    FLOAT (53)    NOT NULL,
    [vt_precio_final]       FLOAT (53)    NOT NULL,
    [vt_subtotal]           FLOAT (53)    NOT NULL,
    [vt_valor_impuesto_iva] FLOAT (53)    NOT NULL,
    [vt_por_impuesto_iva]   FLOAT (53)    NOT NULL,
    [IdImpuesto_Iva]        VARCHAR (20)  NOT NULL,
    [vt_total]              FLOAT (53)    NOT NULL,
    [IdPunto_Cargo]         INT           NULL,
    [IdPunto_cargo_grupo]   INT           NULL,
    [IdImpuesto_Ice]        VARCHAR (20)  NULL,
    [vt_valor_impuesto_ice] FLOAT (53)    NULL,
    [vt_por_impuesto_ice]   FLOAT (53)    NULL,
    CONSTRAINT [PK_fac_cbteVta_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteVtaTipo] ASC, [IdCbteVta] ASC, [secuencia] ASC)
);



