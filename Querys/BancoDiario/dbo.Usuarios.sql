CREATE TABLE [dbo].[Usuarios] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (100) NOT NULL,
    [Ativo]       BIT           NOT NULL,
    [UsuInclusao] INT           NOT NULL,
    [UsuAlt]      INT           NOT NULL,
    [DatIncersao] DATETIME      NOT NULL,
    [DatAlt]      DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

