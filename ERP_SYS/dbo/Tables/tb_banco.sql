CREATE TABLE [dbo].[tb_banco] (
    [IdBanco]                   INT           NOT NULL,
    [nom_banco]                 VARCHAR (100) NOT NULL,
    [Estado]                    BIT           NOT NULL,
    [CodigoLegal]               VARCHAR (10)  NOT NULL,
    [TieneFormatoTransferencia] BIT           NOT NULL,
    CONSTRAINT [PK_tb_banco] PRIMARY KEY CLUSTERED ([IdBanco] ASC)
);

