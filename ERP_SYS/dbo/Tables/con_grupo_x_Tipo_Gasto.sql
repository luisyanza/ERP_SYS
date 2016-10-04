CREATE TABLE [dbo].[con_grupo_x_Tipo_Gasto] (
    [IdEmpresa]          INT          NOT NULL,
    [IdTipo_Gasto]       INT          NOT NULL,
    [IdTipo_Gasto_Padre] INT          NULL,
    [nom_tipo_Gasto]     VARCHAR (50) NOT NULL,
    [estado]             BIT          NOT NULL,
    [nivel]              INT          NOT NULL,
    [orden]              INT          NOT NULL,
    CONSTRAINT [PK_con_Grupo_x_Tipo_Gasto] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Gasto] ASC)
);

