CREATE TABLE [dbo].[Notas] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Diario] INT            NOT NULL,
    [Aluno]  INT            NOT NULL,
    [Nota]   NUMERIC (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Nota_Diario] FOREIGN KEY ([Diario]) REFERENCES [dbo].[Diarios] ([Id]),
    CONSTRAINT [FK_Nota_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

