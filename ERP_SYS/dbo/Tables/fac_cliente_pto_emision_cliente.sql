CREATE TABLE [dbo].[fac_cliente_pto_emision_cliente] (
    [IdEmpresa]      INT           NOT NULL,
    [IdCliente]      NUMERIC (18)  NOT NULL,
    [IdPuntoEmision] INT           NOT NULL,
    [cod_ptoemision] VARCHAR (50)  NOT NULL,
    [ruc]            VARCHAR (50)  NOT NULL,
    [direccion]      VARCHAR (250) NOT NULL,
    [telefono]       VARCHAR (50)  NOT NULL,
    [mail1]          VARCHAR (50)  NOT NULL,
    [mail2]          VARCHAR (50)  NOT NULL,
    [Estado]         BIT           NOT NULL,
    CONSTRAINT [PK_fac_cliente_pto_emision_cliente] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCliente] ASC, [IdPuntoEmision] ASC)
);

