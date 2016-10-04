CREATE TABLE [dbo].[con_tipo_ctacble] (
    [IdTipoCtaCble]   VARCHAR (10)  NOT NULL,
    [nom_TipoCtaCble] VARCHAR (150) NOT NULL,
    [estado]          BIT           NOT NULL,
    CONSTRAINT [PK_con_tipo_cta_cble] PRIMARY KEY CLUSTERED ([IdTipoCtaCble] ASC)
);

