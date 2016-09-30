CREATE TABLE [dbo].[con_periodo] (
    [IdEmpresa]    INT           NOT NULL,
    [IdPeriodo]    INT           NOT NULL,
    [IdanioFiscal] INT           NOT NULL,
    [IdMes]        INT           NOT NULL,
    [pe_FechaIni]  SMALLDATETIME NOT NULL,
    [pe_FechaFin]  SMALLDATETIME NOT NULL,
    [esta_cerrado] BIT           NOT NULL,
    [estado]       BIT           NOT NULL,
    CONSTRAINT [PK_con_periodo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC),
    CONSTRAINT [FK_con_periodo_tb_mes] FOREIGN KEY ([IdMes]) REFERENCES [dbo].[tb_mes] ([IdMes])
);

