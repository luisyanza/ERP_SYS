CREATE TABLE [dbo].[tb_persona] (
    [IdPersona]       NUMERIC (18)  NOT NULL,
    [cod_persona]     VARCHAR (50)  NOT NULL,
    [nombre]          VARCHAR (550) NOT NULL,
    [apellido]        VARCHAR (550) NOT NULL,
    [razon_social]    VARCHAR (550) NOT NULL,
    [IdTipoDocumento] VARCHAR (50)  NOT NULL,
    [Num_documento]   VARCHAR (50)  NOT NULL,
    [IdTipoPersona]   VARCHAR (50)  NOT NULL,
    [estado]          BIT           NOT NULL,
    CONSTRAINT [PK_tb_persona] PRIMARY KEY CLUSTERED ([IdPersona] ASC)
);

