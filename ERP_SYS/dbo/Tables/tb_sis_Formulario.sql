CREATE TABLE [dbo].[tb_sis_Formulario] (
    [IdForm]   VARCHAR (50)  NOT NULL,
    [nom_form] VARCHAR (150) NOT NULL,
    [estado]   BIT           NOT NULL,
    [titulo]   VARCHAR (50)  NULL,
    CONSTRAINT [PK_tb_sis_Formulario] PRIMARY KEY CLUSTERED ([IdForm] ASC)
);

