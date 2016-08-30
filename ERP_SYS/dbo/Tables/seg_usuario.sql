CREATE TABLE [dbo].[seg_usuario] (
    [IdUsuario]                                 VARCHAR (50)  NOT NULL,
    [nom_usuario]                               VARCHAR (150) NOT NULL,
    [contrasenia]                               VARCHAR (550) NOT NULL,
    [Estado]                                    BIT           NOT NULL,
    [IdPerfil]                                  INT           NULL,
    [Exigir_directivas_seguridad]               BIT           NOT NULL,
    [Exigir_expiracion_contrasenia]             BIT           NOT NULL,
    [usuario_debe_cambiar_contra_inicio_sesion] BIT           NOT NULL,
    [Fecha_expiracion_contrasenia]              DATE          NOT NULL,
    CONSTRAINT [PK_seg_usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);



