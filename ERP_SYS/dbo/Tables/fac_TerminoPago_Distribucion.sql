CREATE TABLE [dbo].[fac_TerminoPago_Distribucion] (
    [IdTerminoPago]    VARCHAR (20) NOT NULL,
    [Secuencia]        INT          NOT NULL,
    [Num_Dias_Vcto]    INT          NOT NULL,
    [Por_distribucion] FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_fa_factura_tipo_formaPago_Distribucion] PRIMARY KEY CLUSTERED ([IdTerminoPago] ASC, [Secuencia] ASC)
);

