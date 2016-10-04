CREATE TABLE [dbo].[con_cbtecble_Reversado] (
    [IdEmpresa]      INT          NOT NULL,
    [IdTipoCbte]     INT          NOT NULL,
    [IdCbteCble]     NUMERIC (18) NOT NULL,
    [IdEmpresa_Anu]  INT          NOT NULL,
    [IdTipoCbte_Anu] INT          NOT NULL,
    [IdCbteCble_Anu] NUMERIC (18) NOT NULL,
    [observacion]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_con_cbtecble_Anulados] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoCbte] ASC, [IdCbteCble] ASC, [IdEmpresa_Anu] ASC, [IdTipoCbte_Anu] ASC, [IdCbteCble_Anu] ASC),
    CONSTRAINT [FK_con_cbtecble_Reversado_con_cbtecble] FOREIGN KEY ([IdEmpresa], [IdTipoCbte], [IdCbteCble]) REFERENCES [dbo].[con_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble]),
    CONSTRAINT [FK_con_cbtecble_Reversado_con_cbtecble1] FOREIGN KEY ([IdEmpresa_Anu], [IdTipoCbte_Anu], [IdCbteCble_Anu]) REFERENCES [dbo].[con_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble])
);

