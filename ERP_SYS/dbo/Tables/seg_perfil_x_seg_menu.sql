CREATE TABLE [dbo].[seg_perfil_x_seg_menu] (
    [IdPerfil]    INT          NOT NULL,
    [IdMenu]      VARCHAR (50) NOT NULL,
    [observacion] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_seg_perfil_x_seg_menu] PRIMARY KEY CLUSTERED ([IdPerfil] ASC, [IdMenu] ASC),
    CONSTRAINT [FK_seg_perfil_x_seg_menu_seg_menu] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[seg_menu] ([IdMenu]),
    CONSTRAINT [FK_seg_perfil_x_seg_menu_seg_perfil] FOREIGN KEY ([IdPerfil]) REFERENCES [dbo].[seg_perfil] ([IdPerfil])
);



