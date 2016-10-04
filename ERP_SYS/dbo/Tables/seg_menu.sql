CREATE TABLE [dbo].[seg_menu] (
    [IdMenu]       VARCHAR (50)  NOT NULL,
    [cod_menu]     VARCHAR (50)  NOT NULL,
    [nom_menu]     VARCHAR (500) NOT NULL,
    [IdMenuPadre]  VARCHAR (50)  NULL,
    [estado]       BIT           NOT NULL,
    [posicion]     INT           NULL,
    [nivel]        INT           NULL,
    [path_web]     VARCHAR (500) NOT NULL,
    [nom_webform]  VARCHAR (500) NOT NULL,
    [observacion]  VARCHAR (500) NOT NULL,
    [IdFormulario] VARCHAR (50)  NULL,
    [IdReporte]    VARCHAR (50)  NULL,
    [esFormulario] BIT           NULL,
    [esReporte]    BIT           NULL,
    CONSTRAINT [PK_seg_menu] PRIMARY KEY CLUSTERED ([IdMenu] ASC)
);



