CREATE TABLE [dbo].[tb_catalogo] (
    [IdCatalogo]      VARCHAR (50)  NOT NULL,
    [nom_catalogo]    VARCHAR (150) NOT NULL,
    [estado]          BIT           NOT NULL,
    [IdCatalogo_tipo] VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_tb_catalogo] PRIMARY KEY CLUSTERED ([IdCatalogo] ASC)
);

