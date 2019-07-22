﻿CREATE TABLE [dbo].[Diarios] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Data]        DATETIME      DEFAULT (getdate()) NOT NULL,
    [Turma]       INT           NOT NULL,
    [Obs]         VARCHAR (100) NOT NULL,
    [Ativo]       BIT           NOT NULL,
    [UsuInc]      INT           NOT NULL,
    [UsuAlt]      INT           NOT NULL,
    [DatIncersao] DATETIME      NOT NULL,
    [DatAlt]      DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Diario_Turmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id]),
    CONSTRAINT [FK_Diario_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Diario_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

