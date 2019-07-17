select aluno,	
		Idade,
		IIF(Ativo = 1, 'ativo', 'inativo') as 'Status'

	from AulaCsharp
where Id in 
		(select Id from AulaCsharp where Idade >30)
order by Id desc