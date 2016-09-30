CREATE TABLE [dbo].[con_punto_cargo_grupo] (
    [IdEmpresa]             INT           NOT NULL,
    [IdPunto_cargo_grupo]   INT           NOT NULL,
    [cod_Punto_cargo_grupo] VARCHAR (25)  NOT NULL,
    [nom_punto_cargo_grupo] VARCHAR (150) NOT NULL,
    [estado]                BIT           NOT NULL,
    [IdCtaCble]             VARCHAR (50)  NULL,
    CONSTRAINT [PK_con_punto_cargo_grupo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPunto_cargo_grupo] ASC)
);

