CREATE TABLE [dbo].[tb_empresa] (
    [IdEmpresa]   INT           NOT NULL,
    [cod_empresa] VARCHAR (50)  NOT NULL,
    [nom_empresa] VARCHAR (250) NOT NULL,
    [ruc_empresa] NCHAR (10)    NOT NULL,
    [estado]      BIT           NOT NULL,
    CONSTRAINT [PK_tb_empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

