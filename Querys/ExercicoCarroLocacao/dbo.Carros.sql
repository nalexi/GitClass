CREATE TABLE [dbo].[Carros] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Veiculo] VARCHAR (100) NOT NULL,
    [Obs]     VARCHAR (250) NULL,
    [Ativo]   BIT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DatInc]  DATETIME      NOT NULL,
    [DatAlt]  DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Carros_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Carros_Usuarios_ALt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

