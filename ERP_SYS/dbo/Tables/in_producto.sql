CREATE TABLE [dbo].[in_producto] (
    [IdEmpresa]    INT           NOT NULL,
    [IdProducto]   NUMERIC (18)  NOT NULL,
    [cod_producto] VARCHAR (50)  NOT NULL,
    [nom_producto] VARCHAR (550) NOT NULL,
    [IdCategoria]  VARCHAR (50)  NOT NULL,
    [estado]       BIT           NOT NULL,
    CONSTRAINT [PK_in_producto] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto] ASC)
);

