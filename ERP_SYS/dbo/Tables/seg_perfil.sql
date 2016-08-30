CREATE TABLE [dbo].[seg_perfil] (
    [IdPerfil]   INT          NOT NULL,
    [nom_perfil] VARCHAR (50) NOT NULL,
    [estado]     BIT          NOT NULL,
    CONSTRAINT [PK_seg_perfil] PRIMARY KEY CLUSTERED ([IdPerfil] ASC)
);

