﻿CREATE TABLE [dbo].[fac_cotizacion] (
    [IdEmpresa]           INT            NOT NULL,
    [IdSucursal]          INT            NOT NULL,
    [IdPuntoVta]          INT            NOT NULL,
    [IdCotizacion]        NUMERIC (18)   NOT NULL,
    [CodCotizacion]       VARCHAR (20)   NOT NULL,
    [IdCliente]           NUMERIC (18)   NOT NULL,
    [IdVendedor]          INT            NOT NULL,
    [cc_fecha]            DATETIME       NOT NULL,
    [cc_diasPlazo]        SMALLINT       NOT NULL,
    [cc_fechaVencimiento] DATETIME       NOT NULL,
    [cc_observacion]      VARCHAR (1000) NOT NULL,
    [cc_tipopago]         CHAR (3)       NOT NULL,
    [cc_estado]           BIT            NOT NULL,
    [cc_dirigidoA]        VARCHAR (1000) NOT NULL,
    [IdUsuario]           VARCHAR (50)   NOT NULL,
    [Fecha_Transac]       DATETIME       NOT NULL,
    [IdUsuarioUltMod]     VARCHAR (20)   NULL,
    [Fecha_UltMod]        DATETIME       NULL,
    [IdUsuarioUltAnu]     VARCHAR (20)   NULL,
    [Fecha_UltAnu]        DATETIME       NULL,
    [MotivoAnu]           VARCHAR (150)  NULL,
    [nom_pc]              VARCHAR (50)   NOT NULL,
    [ip]                  NCHAR (25)     NOT NULL,
    CONSTRAINT [PK_fa_cotizacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdCotizacion] ASC)
);

