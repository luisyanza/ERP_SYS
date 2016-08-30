CREATE TABLE [dbo].[seg_usuario_sesion] (
    [IdRegistro] DECIMAL (18) NOT NULL,
    [IdUsuario]  VARCHAR (50) NOT NULL,
    [fecha_hora] DATETIME     NOT NULL,
    [tipo]       VARCHAR (50) NOT NULL,
    [ip]         VARCHAR (50) NULL,
    [equipo]     VARCHAR (50) NULL,
    CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED ([IdRegistro] ASC),
    CONSTRAINT [FK_seg_usuario_sesion_seg_usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[seg_usuario] ([IdUsuario])
);

