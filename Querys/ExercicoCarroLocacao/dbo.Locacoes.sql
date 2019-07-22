CREATE TABLE [dbo].[Locacoes] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [Carro]     INT      NOT NULL,
    [Cliente]   INT      NOT NULL,
    [Devolucao] DATE     NOT NULL,
    [Alugado]   BIT      NOT NULL,
    [UsuInc]    INT      NOT NULL,
    [UsuAlt]    INT      NOT NULL,
    [DatInc]    DATETIME DEFAULT (getdate()) NOT NULL,
    [DatAlt]    DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [FK_Locacao_Carros] FOREIGN KEY ([Carro]) REFERENCES [dbo].[Carros] ([Id]),
    CONSTRAINT [FK_Locacao_ClienteLoc] FOREIGN KEY ([Cliente]) REFERENCES [dbo].[Clientes] ([Id]),
    CONSTRAINT [FK_Locacao_UsuInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Locacao_UsuAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

