CREATE TABLE [dbo].[fac_guia_remision_det] (
    [IdEmpresa]          INT            NOT NULL,
    [IdSucursal]         INT            NOT NULL,
    [IdPuntoVta]         INT            NOT NULL,
    [IdGuiaRemision]     NUMERIC (18)   NOT NULL,
    [Secuencia]          INT            NOT NULL,
    [IdProducto]         NUMERIC (18)   NOT NULL,
    [gi_cantidad]        FLOAT (53)     NOT NULL,
    [gi_Precio]          FLOAT (53)     NOT NULL,
    [gi_PorDescUnitario] FLOAT (53)     NOT NULL,
    [gi_DescUnitario]    FLOAT (53)     NOT NULL,
    [gi_PrecioFinal]     FLOAT (53)     NOT NULL,
    [gi_Subtotal]        FLOAT (53)     NOT NULL,
    [gi_iva]             FLOAT (53)     NOT NULL,
    [gi_total]           FLOAT (53)     NOT NULL,
    [gi_costo]           FLOAT (53)     NOT NULL,
    [gi_tieneIVA]        CHAR (1)       NULL,
    [gi_detallexItems]   VARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_fa_guia_remision_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdGuiaRemision] ASC, [Secuencia] ASC)
);

