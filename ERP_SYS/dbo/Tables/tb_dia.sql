CREATE TABLE [dbo].[tb_dia] (
    [idDia]      TINYINT      NOT NULL,
    [nom_dia]    VARCHAR (25) NULL,
    [cod_dia]    VARCHAR (25) NULL,
    [nom_Ingles] VARCHAR (25) NULL,
    CONSTRAINT [PK_tb_dia] PRIMARY KEY CLUSTERED ([idDia] ASC)
);

