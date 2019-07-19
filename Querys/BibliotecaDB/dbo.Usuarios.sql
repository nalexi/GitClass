CREATE TABLE [dbo].[Usuarios] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Login]  VARCHAR (50)  NOT NULL,
    [Senha]  VARCHAR (50)  NOT NULL,
    [Email]  VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      DEFAULT (getdate()) NOT NULL,
    [DatAlt] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

