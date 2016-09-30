CREATE TABLE [dbo].[fac_catalogo_tipo] (
    [IdCatalogo_tipo]   INT          NOT NULL,
    [nom_Catalogo_tipo] VARCHAR (50) NOT NULL,
    [estado]            BIT          NOT NULL,
    CONSTRAINT [PK_fa_catalogo_tipo] PRIMARY KEY CLUSTERED ([IdCatalogo_tipo] ASC)
);

