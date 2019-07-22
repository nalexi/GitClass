CREATE TABLE [dbo].[Estoques] (
    [Id]      INT      IDENTITY (1, 1) NOT NULL,
    [CarroId] INT      NOT NULL,
    [Ativo]   BIT      NOT NULL,
    [UsuInc]  INT      NOT NULL,
    [UsuAlt]  INT      NOT NULL,
    [DatInc]  DATETIME DEFAULT (getdate()) NOT NULL,
    [DatAlt]  DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Estoques_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Estoques_Usuarios_ALt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Estoques_Carros] FOREIGN KEY ([CarroId]) REFERENCES [dbo].[Carros] ([Id])
);

