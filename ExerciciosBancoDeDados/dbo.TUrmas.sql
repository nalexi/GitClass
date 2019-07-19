CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Disciplina] VARCHAR(100) NOT NULL,
    [DataInicio] DATE NOT NULL,
    [DataFim] DATE NOT NULL,
    [Observacao] varCHAR(300) NULL, 
    [Ativo] BIT NOT NULL, 


    

)
