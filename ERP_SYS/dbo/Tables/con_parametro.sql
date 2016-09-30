CREATE TABLE [dbo].[con_parametro] (
    [IdEmpresa]                      INT NOT NULL,
    [IdTipoCbte_SaldoInicial]        INT NULL,
    [IdTipoCbte_AsientoCierre_Anual] INT NULL,
    CONSTRAINT [PK_con_parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC)
);

