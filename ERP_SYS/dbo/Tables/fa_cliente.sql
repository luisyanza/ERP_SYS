CREATE TABLE [dbo].[fa_cliente] (
    [IdEmpresa]     INT          NOT NULL,
    [IdCliente]     NUMERIC (18) NOT NULL,
    [IdPersona]     NUMERIC (18) NOT NULL,
    [IdTipoCliente] INT          NOT NULL,
    [estado]        BIT          NOT NULL,
    CONSTRAINT [PK_fa_cliente] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCliente] ASC),
    CONSTRAINT [FK_fa_cliente_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa]),
    CONSTRAINT [FK_fa_cliente_tb_persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[tb_persona] ([IdPersona])
);

