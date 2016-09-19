CREATE TABLE [dbo].[tb_sucursal] (
    [IdEmpresa]           INT          NOT NULL,
    [IdSucursal]          INT          NOT NULL,
    [cod_sucursal]        VARCHAR (50) NOT NULL,
    [cod_establecimiento] VARCHAR (50) NOT NULL,
    [nom_sucursal]        VARCHAR (50) NOT NULL,
    [estado]              BIT          NOT NULL,
    CONSTRAINT [PK_tb_sucursal] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC),
    CONSTRAINT [FK_tb_sucursal_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

