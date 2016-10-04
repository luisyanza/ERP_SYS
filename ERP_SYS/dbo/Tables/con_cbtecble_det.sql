CREATE TABLE [dbo].[con_cbtecble_det] (
    [IdEmpresa]           INT           NOT NULL,
    [IdTipoCbte]          INT           NOT NULL,
    [IdCbteCble]          NUMERIC (18)  NOT NULL,
    [secuencia]           INT           NOT NULL,
    [IdCtaCble]           VARCHAR (50)  NOT NULL,
    [IdCentroCosto]       VARCHAR (50)  NULL,
    [IdSub_centro_costo]  VARCHAR (50)  NULL,
    [dc_Valor]            FLOAT (53)    NOT NULL,
    [dc_Observacion]      VARCHAR (MAX) NOT NULL,
    [EstaConciliado]      BIT           NULL,
    [IdPunto_cargo]       INT           NULL,
    [IdPunto_cargo_grupo] INT           NULL,
    CONSTRAINT [PK_con_cbtecble_det_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoCbte] ASC, [IdCbteCble] ASC, [secuencia] ASC),
    CONSTRAINT [FK_con_cbtecble_det_con_cbtecble] FOREIGN KEY ([IdEmpresa], [IdTipoCbte], [IdCbteCble]) REFERENCES [dbo].[con_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble]),
    CONSTRAINT [FK_con_cbtecble_det_con_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto]) REFERENCES [dbo].[con_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_con_cbtecble_det_con_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[con_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_con_cbtecble_det_con_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[con_punto_cargo] ([IdEmpresa], [IdPunto_cargo]),
    CONSTRAINT [FK_con_cbtecble_det_con_punto_cargo_grupo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo_grupo]) REFERENCES [dbo].[con_punto_cargo_grupo] ([IdEmpresa], [IdPunto_cargo_grupo]),
    CONSTRAINT [FK_con_cbtecble_det_con_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdSub_centro_costo]) REFERENCES [dbo].[con_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdSub_centro_costo])
);

