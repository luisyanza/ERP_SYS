CREATE TABLE [dbo].[con_anio_fiscal] (
    [IdanioFiscal] INT  NOT NULL,
    [af_fechaIni]  DATE NOT NULL,
    [af_fechaFin]  DATE NOT NULL,
    [estado]       BIT  NOT NULL,
    CONSTRAINT [PK_con_anio_fiscal_1] PRIMARY KEY CLUSTERED ([IdanioFiscal] ASC)
);

