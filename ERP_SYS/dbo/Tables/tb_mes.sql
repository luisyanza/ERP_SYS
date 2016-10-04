CREATE TABLE [dbo].[tb_mes] (
    [IdMes]         INT          NOT NULL,
    [cod_mes]       VARCHAR (20) NOT NULL,
    [nom_mes]       VARCHAR (20) NOT NULL,
    [nom_mesIngles] VARCHAR (20) NULL,
    CONSTRAINT [PK_tb_mes] PRIMARY KEY CLUSTERED ([IdMes] ASC)
);

