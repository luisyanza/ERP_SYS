CREATE TABLE [dbo].[con_cbtecble_Plantilla_det] (
    [IdEmpresa]                      INT           NOT NULL,
    [IdTipoCbte]                     INT           NOT NULL,
    [IdPlantilla]                    NUMERIC (18)  NOT NULL,
    [secuencia]                      INT           NOT NULL,
    [IdCtaCble]                      VARCHAR (50)  NOT NULL,
    [IdCentroCosto]                  VARCHAR (50)  NULL,
    [dc_Valor]                       FLOAT (53)    NOT NULL,
    [dc_Observacion]                 VARCHAR (750) NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (50)  NULL,
    [IdPunto_cargo]                  INT           NULL,
    [IdPunto_cargo_grupo]            INT           NULL,
    CONSTRAINT [PK_con_cbtecble_Plantilla_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoCbte] ASC, [IdPlantilla] ASC, [secuencia] ASC),
    CONSTRAINT [FK_con_cbtecble_Plantilla_det_con_cbtecble_Plantilla] FOREIGN KEY ([IdEmpresa], [IdTipoCbte], [IdPlantilla]) REFERENCES [dbo].[con_cbtecble_Plantilla] ([IdEmpresa], [IdTipoCbte], [IdPlantilla]),
    CONSTRAINT [FK_con_cbtecble_Plantilla_det_con_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto]) REFERENCES [dbo].[con_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_con_cbtecble_Plantilla_det_con_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[con_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_con_cbtecble_Plantilla_det_con_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[con_punto_cargo] ([IdEmpresa], [IdPunto_cargo]),
    CONSTRAINT [FK_con_cbtecble_Plantilla_det_con_punto_cargo_grupo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo_grupo]) REFERENCES [dbo].[con_punto_cargo_grupo] ([IdEmpresa], [IdPunto_cargo_grupo])
);

