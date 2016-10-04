CREATE TABLE [dbo].[fac_pedido_estadoAprobacion] (
    [IdEstadoAprobacion] CHAR (1)     NOT NULL,
    [Descripcion]        VARCHAR (50) NOT NULL,
    [Estado]             CHAR (1)     NOT NULL,
    [posicion]           INT          NOT NULL,
    CONSTRAINT [PK_fa_pedido_estadoAprobacion] PRIMARY KEY CLUSTERED ([IdEstadoAprobacion] ASC)
);

