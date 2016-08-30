CREATE TABLE [dbo].[seg_menu_x_seg_usuario] (
    [IdMenu]      VARCHAR (50) NOT NULL,
    [IdUsuario]   VARCHAR (50) NOT NULL,
    [observacion] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_seg_menu_x_seg_usuario] PRIMARY KEY CLUSTERED ([IdMenu] ASC, [IdUsuario] ASC),
    CONSTRAINT [FK_seg_menu_x_seg_usuario_seg_menu] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[seg_menu] ([IdMenu]),
    CONSTRAINT [FK_seg_menu_x_seg_usuario_seg_usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[seg_usuario] ([IdUsuario])
);



