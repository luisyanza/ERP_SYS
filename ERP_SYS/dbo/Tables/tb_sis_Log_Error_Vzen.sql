CREATE TABLE [dbo].[tb_sis_Log_Error_Vzen] (
    [Id]          NUMERIC (18)   IDENTITY (1, 1) NOT NULL,
    [Fecha_Trans] DATETIME       CONSTRAINT [DF_tb_sis_Log_Error_Vzen_Fecha_Trans] DEFAULT (getdate()) NULL,
    [Detalle]     NVARCHAR (MAX) NULL,
    [Tipo]        NVARCHAR (MAX) NULL,
    [Clase]       NVARCHAR (MAX) NULL,
    [Pantalla]    NVARCHAR (MAX) NULL,
    [Asamble]     NVARCHAR (MAX) NULL,
    [Usuario]     VARCHAR (50)   NULL,
    [Ip]          VARCHAR (50)   NULL,
    [PC]          VARCHAR (50)   NULL,
    CONSTRAINT [PK_tb_sis_Log_Error_Vzen] PRIMARY KEY CLUSTERED ([Id] ASC)
);

