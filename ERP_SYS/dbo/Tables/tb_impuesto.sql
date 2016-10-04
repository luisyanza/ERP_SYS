CREATE TABLE [dbo].[tb_impuesto] (
    [IdImpuesto]        VARCHAR (20) NOT NULL,
    [nom_Impuesto_tipo] VARCHAR (50) NOT NULL,
    [IdImpuesto_tipo]   VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_tb_impuesto] PRIMARY KEY CLUSTERED ([IdImpuesto] ASC),
    CONSTRAINT [FK_tb_impuesto_tb_Impuesto_tipo] FOREIGN KEY ([IdImpuesto_tipo]) REFERENCES [dbo].[tb_Impuesto_tipo] ([IdImpuesto_tipo])
);

