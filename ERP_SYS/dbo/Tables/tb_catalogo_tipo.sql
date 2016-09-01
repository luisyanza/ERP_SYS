CREATE TABLE [dbo].[tb_catalogo_tipo] (
    [IdCatalogo_tipo]   VARCHAR (50)  NOT NULL,
    [nom_catalogo_tipo] VARCHAR (150) NOT NULL,
    [estado]            BIT           NOT NULL,
    CONSTRAINT [PK_tb_catalogo_tipo] PRIMARY KEY CLUSTERED ([IdCatalogo_tipo] ASC)
);

