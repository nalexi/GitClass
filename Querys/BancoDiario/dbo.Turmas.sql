CREATE TABLE [dbo].[Turmas] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (100) NULL,
    [Obs]         VARCHAR (250) NULL,
    [Ativo]       BIT           NOT NULL,
    [UsuInc]      INT           NOT NULL,
    [UsuAlt]      INT           NOT NULL,
    [DatIncersao] DATETIME      NOT NULL,
    [DatAlt]      DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Turmas_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Turmas_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

