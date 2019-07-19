Select
	Tu.Disciplina,
	AL.Nome,
	--(SUM(NT.nota)/ COUNT(NT.Nota)) as 'Media',
	--
	--IIF((SUM(NT.nota)/ COUNT(NT.Nota)) >= 7, 'aprovado','Reprovado') as 'Situacao',
	--
	--IIF(COUNT(NT.Presenca) >= 3, 'aprovado','Reprovado') as 'Frequencia',
	--
	IIF((SUM(NT.nota)/ COUNT(NT.Nota)) >= 7 and 
	(COUNT(NT.Presenca) >= 3), 'aprovado','Reprovado') as 'Status'

	--IIF((((SUM(NT.nota)/ COUNT(NT.Nota)) >= 7 ) and
	--(SUM(iif(nt.presenca = 1, 100,null)) / count(Nt.presenca)) >= 75), 'aprovado','Reprovado') as 'Status'

	--(iif(nt.presenca = 1, 100,null)) / COUNT(NT.Presenca) as 'teste'
	--(SUM(NT.nota)/ COUNT(NT.Nota))  as 'teste'

	from Alunos AL
inner join Notas NT on AL.Id = NT.Aluno
inner join Turmas TU on TU.Id = Al.Turma

group by TU.Disciplina, Al.Nome

--select * from Alunos
--select * from notas
