CREATE TABLE [dbo].[tb_persona] (
    [IdPersona]                  NUMERIC (18)  NOT NULL,
    [cod_persona]                VARCHAR (50)  NOT NULL,
    [pe_nombreCompleto]          VARCHAR (550) NOT NULL,
    [pe_nombre]                  VARCHAR (550) NOT NULL,
    [pe_apellido]                VARCHAR (550) NOT NULL,
    [pe_razon_social]            VARCHAR (550) NOT NULL,
    [IdTipoDocumento]            VARCHAR (50)  NOT NULL,
    [Num_documento]              VARCHAR (50)  NOT NULL,
    [IdTipoPersona]              VARCHAR (50)  NOT NULL,
    [estado]                     BIT           NOT NULL,
    [pe_Naturaleza_cat]          VARCHAR (50)  NOT NULL,
    [pe_sexo]                    NCHAR (10)    NOT NULL,
    [IdEstadoCivil_cat]          NCHAR (10)    NOT NULL,
    [pe_fechaNacimiento]         DATE          NOT NULL,
    [pe_correo]                  VARCHAR (50)  NOT NULL,
    [pe_correo1]                 VARCHAR (50)  NOT NULL,
    [pe_correo2]                 VARCHAR (50)  NOT NULL,
    [pe_telef_Casa]              VARCHAR (50)  NOT NULL,
    [pe_telef_Trab]              VARCHAR (50)  NOT NULL,
    [pe_telef_Contacto]          VARCHAR (50)  NOT NULL,
    [pe_direccion]               VARCHAR (50)  NOT NULL,
    [pe_fax]                     NCHAR (10)    NOT NULL,
    [pe_casilla]                 NCHAR (10)    NOT NULL,
    [IdTipoCta_acreditacion_cat] VARCHAR (50)  NULL,
    [num_cta_acreditacion]       VARCHAR (50)  NULL,
    [IdBanco_acreditacion]       INT           NULL,
    CONSTRAINT [PK_tb_persona] PRIMARY KEY CLUSTERED ([IdPersona] ASC)
);



