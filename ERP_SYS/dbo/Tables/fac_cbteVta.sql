CREATE TABLE [dbo].[fac_cbteVta] (
    [IdEmpresa]          INT           NOT NULL,
    [IdCbteVtaTipo]      VARCHAR (20)  NOT NULL,
    [IdCbteVta]          NUMERIC (18)  NOT NULL,
    [CodCbteVta]         VARCHAR (50)  NOT NULL,
    [num_CbteVta]        VARCHAR (150) NULL,
    [IdSucursal]         INT           NOT NULL,
    [IdPuntoVta]         INT           NOT NULL,
    [IdTipoNota]         INT           NULL,
    [IdCaja]             INT           NULL,
    [IdCliente]          NUMERIC (18)  NOT NULL,
    [estado]             BIT           NOT NULL,
    [vt_Observacion]     VARCHAR (MAX) NOT NULL,
    [Fecha_Autorizacion] DATETIME      NULL,
    [num_autorizacion]   VARCHAR (150) NULL,
    [vt_plazo]           INT           NOT NULL,
    [vt_fecha_venc]      DATETIME      NULL,
    [vt_fecha]           DATETIME      NULL,
    CONSTRAINT [PK_fac_cbteVta] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteVtaTipo] ASC, [IdCbteVta] ASC)
);

