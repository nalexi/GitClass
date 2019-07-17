select
	Nome,
	Materia,
	(SUM(Nota)/ COUNT(Nota)) as 'Media', --soma as notas, conta as provas e faz a media delas
	COUNT(Nota) as 'provas' -- conta e nomeia o numero de provas realizadas
from NotaALuno
GROUP BY Nome, Materia -- agrupa por identificadores comuns
order by Nome asc