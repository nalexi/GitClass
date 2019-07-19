CREATE TABLE [dbo].[Aluno] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (100) NOT NULL,
    [Turma] int NOT NULL, 
    [Ativo] BIT NOT NULL, 

    CONSTRAINT [FK_Aluno_Turma] 
	FOREIGN KEY ([Turma])
	REFERENCES [Turmas]([Id]),
    
);
