﻿CREATE TABLE [dbo].[con_periodo_x_tb_modulo] (
    [IdEmpresa]        INT          NOT NULL,
    [IdPeriodo]        INT          NOT NULL,
    [IdModulo]         VARCHAR (20) NOT NULL,
    [Cerrado]          BIT          NOT NULL,
    [IdUsuario]        VARCHAR (50) NULL,
    [IdUsuarioUltModi] VARCHAR (50) NULL,
    [FechaTransac]     DATETIME     NULL,
    [FechaUltModi]     DATETIME     NULL,
    CONSTRAINT [PK_con_periodo_x_tb_modulo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [IdModulo] ASC)
);

