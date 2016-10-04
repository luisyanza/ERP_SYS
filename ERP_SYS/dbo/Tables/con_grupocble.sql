CREATE TABLE [dbo].[con_grupocble] (
    [IdGrupoCble]          VARCHAR (5)  NOT NULL,
    [nom_GrupoCble]        VARCHAR (50) CONSTRAINT [DF__con_grupoc__Grupo__07C12930] DEFAULT (NULL) NOT NULL,
    [orden]                INT          CONSTRAINT [DF__con_grupoc__Orden__08B54D69] DEFAULT (NULL) NOT NULL,
    [gc_estado_financiero] CHAR (2)     NOT NULL,
    [gc_signo_operacion]   INT          NULL,
    [estado]               BIT          NOT NULL,
    [IdGrupo_Mayor]        VARCHAR (50) NULL,
    CONSTRAINT [PK__con_grupo__D1E02FAB05D8E0BE] PRIMARY KEY CLUSTERED ([IdGrupoCble] ASC)
);

