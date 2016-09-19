CREATE TABLE [dbo].[tb_puntoVta] (
    [IdEmpresa]    INT           NOT NULL,
    [IdPuntoVta]   INT           NOT NULL,
    [IdSucursal]   INT           NOT NULL,
    [cod_puntoVta] VARCHAR (50)  NOT NULL,
    [nom_puntoVta] VARCHAR (250) NOT NULL,
    [estado]       BIT           NOT NULL,
    CONSTRAINT [PK_tb_puntoVta_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPuntoVta] ASC, [IdSucursal] ASC),
    CONSTRAINT [FK_tb_puntoVta_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);

