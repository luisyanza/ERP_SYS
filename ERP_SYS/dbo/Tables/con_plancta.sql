﻿CREATE TABLE [dbo].[con_plancta] (
    [IdEmpresa]         INT           NOT NULL,
    [IdCtaCble]         VARCHAR (50)  NOT NULL,
    [cod_cuenta]        VARCHAR (50)  NULL,
    [nom_Cuenta]        VARCHAR (150) NOT NULL,
    [IdCtaCblePadre]    VARCHAR (20)  NULL,
    [Naturaleza]        CHAR (1)      NOT NULL,
    [IdNivelCta]        INT           NOT NULL,
    [IdGrupoCble]       VARCHAR (5)   NOT NULL,
    [IdTipoCtaCble]     VARCHAR (10)  NOT NULL,
    [estado]            BIT           NOT NULL,
    [EsMovimiento]      BIT           NOT NULL,
    [Es_flujo_efectivo] BIT           NULL,
    [Fecha_Transac]     DATETIME      NULL,
    [IdUsuario]         VARCHAR (50)  NULL,
    [IdUsuarioUltMod]   VARCHAR (50)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (50)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (150) NULL,
    [nom_pc]            VARCHAR (50)  NULL,
    [ip]                VARCHAR (50)  NULL,
    [IdTipo_Gasto]      INT           NULL,
    CONSTRAINT [PK__con_planc__86F41E99182C9B23] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCtaCble] ASC)
);
