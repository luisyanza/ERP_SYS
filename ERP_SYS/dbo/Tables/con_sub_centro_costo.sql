CREATE TABLE [dbo].[con_sub_centro_costo] (
    [IdEmpresa]           INT           NOT NULL,
    [IdCentroCosto]       VARCHAR (50)  NOT NULL,
    [IdSub_centro_costo]  VARCHAR (50)  NOT NULL,
    [cod_subcentroCosto]  VARCHAR (50)  NULL,
    [nom_sub_centrocosto] VARCHAR (150) NOT NULL,
    [estado]              BIT           NOT NULL,
    [IdCtaCble]           VARCHAR (50)  NULL,
    CONSTRAINT [PK_con_centro_costo_sub_centro_costo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCentroCosto] ASC, [IdSub_centro_costo] ASC)
);

