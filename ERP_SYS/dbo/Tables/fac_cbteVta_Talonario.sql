CREATE TABLE [dbo].[fac_cbteVta_Talonario] (
    [IdEmpresa]        INT           NOT NULL,
    [IdSucursal]       INT           NOT NULL,
    [IdPuntoVta]       INT           NOT NULL,
    [IdCbteVtaTipo]    VARCHAR (20)  NOT NULL,
    [num_CbteVta]      VARCHAR (150) NOT NULL,
    [num_autorizacion] VARCHAR (150) NULL,
    CONSTRAINT [PK_fac_talonario_cbte] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdPuntoVta] ASC, [IdCbteVtaTipo] ASC, [num_CbteVta] ASC)
);

