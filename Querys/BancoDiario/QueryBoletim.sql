--select
--	TR.Nome as 'turma',
--	AL.Aluno
--From Turmas Tr
--	Inner Join TurmaAlunos TA on TR.Id = TA.Turma
--	inner join Alunos AL on TA.Aluno = AL.id; --Traz alunos da turma
--
--select 
--	D.[Data],
--	--A.Aluno,
--	SUM(N.Nota) as 'media',
--	count(p.Id) as 'Presencas'
--from Diarios D
--	inner join TurmaAlunos TR on D.Turma = TR.Turma
--	--Inner join Turmas T on TR.Turma = T.Id
--	--inner join Alunos A on Tr.Aluno = A.Id
--	left join Presenca P on D.Id = P.Diario and TR.Aluno = P.Aluno
--	left join Notas N on Tr.Aluno = N.Aluno and d.Id = N.Diario
--group by D.[Data], N.Nota
--
--Select 
--	D.[Data],
--	TR.Aluno,
--	ISNULL(N.Nota,0) as 'nota',
--	IIF(ISNULL(P.Id) >0, 'Presente', 'Ausente') as 'Presencas'
--from Diarios D inner join TurmaAlunos TR on D.Turma = TR.Turma
--	left join Presenca P on D.Id = P.Diario and TR.Aluno = P.Aluno
--	left join Notas N on Tr.Aluno = N.Aluno and d.Id = N.Diario
--
Select 
	
	A.Aluno,
	SUM(N.Nota) / COUNT(D.[Data])
	
	from Alunos A 
	inner join TurmaAlunos TR on A.Id = TR.Aluno
	inner join Diarios D  on TR.Turma = D.Turma
	left join Notas N on D.Id = N.Diario and A.Id = N.Aluno
where TR.Turma = 1
group by A.Aluno




