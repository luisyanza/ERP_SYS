CREATE TABLE [dbo].[fac_cbteVta_tipo] (
    [IdEmpresa]       INT           NOT NULL,
    [IdCbteVtaTipo]   VARCHAR (20)  NOT NULL,
    [nom_CbteVtaTipo] VARCHAR (150) NOT NULL,
    [estado]          BIT           NOT NULL,
    CONSTRAINT [PK_fac_cbteVta_tipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteVtaTipo] ASC)
);

