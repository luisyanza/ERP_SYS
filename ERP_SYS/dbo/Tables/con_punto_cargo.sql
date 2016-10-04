CREATE TABLE [dbo].[con_punto_cargo] (
    [IdEmpresa]           INT           NOT NULL,
    [IdPunto_cargo]       INT           NOT NULL,
    [codPunto_cargo]      VARCHAR (20)  NOT NULL,
    [nom_punto_cargo]     VARCHAR (250) NOT NULL,
    [Estado]              BIT           NOT NULL,
    [IdPunto_cargo_grupo] INT           NULL,
    CONSTRAINT [PK_con_punto_cargo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPunto_cargo] ASC)
);

