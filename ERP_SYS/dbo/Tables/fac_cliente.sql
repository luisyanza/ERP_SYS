﻿CREATE TABLE [dbo].[fac_cliente] (
    [IdEmpresa]                INT            NOT NULL,
    [IdCliente]                NUMERIC (18)   NOT NULL,
    [cod_cliente]              VARCHAR (50)   NOT NULL,
    [IdPersona]                NUMERIC (18)   NOT NULL,
    [IdSucursal]               INT            NOT NULL,
    [Idtipo_cliente]           INT            NOT NULL,
    [IdTipoCredito]            VARCHAR (3)    NOT NULL,
    [cl_Cat_crediticia]        CHAR (1)       NOT NULL,
    [cl_plazo]                 INT            NOT NULL,
    [cl_porc_descuento]        FLOAT (53)     NOT NULL,
    [IdCtaCble_cxc]            VARCHAR (50)   NULL,
    [IdCtaCble_Anti]           VARCHAR (50)   NULL,
    [IdCtaCble_cxc_Credito]    VARCHAR (50)   NULL,
    [Observacion]              VARCHAR (1000) NOT NULL,
    [IdCiudad]                 VARCHAR (25)   NOT NULL,
    [cl_Cupo]                  FLOAT (53)     NOT NULL,
    [IdClienteRelacionado]     NUMERIC (10)   NULL,
    [cat_IdActividadComercial] VARCHAR (15)   NOT NULL,
    [Estado]                   BIT            NOT NULL,
    [IdParroquia]              VARCHAR (25)   NULL,
    [IdUsuario]                VARCHAR (20)   NOT NULL,
    [Fecha_Transac]            DATETIME       NOT NULL,
    [IdUsuarioUltMod]          VARCHAR (20)   NULL,
    [Fecha_UltMod]             DATETIME       NULL,
    [IdUsuarioUltAnu]          VARCHAR (20)   NULL,
    [Fecha_UltAnu]             DATETIME       NULL,
    [nom_pc]                   VARCHAR (20)   NOT NULL,
    [ip]                       VARCHAR (25)   NOT NULL,
    CONSTRAINT [PK_fa_cliente] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCliente] ASC)
);

