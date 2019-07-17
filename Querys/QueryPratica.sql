select 
Nome,
Materia,
((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) as 'Media',
IIF(((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) >= 5, 'aprovado','reprovado')as 'Status'
from Diario1 where id = 3;

--insert into Diario1
--(Nome, Materia, Nota1, Nota2 ,Nota3 ,Nota4, Nota5 ,Nota6)
--Values
--('Raul','facil', 8,6,8,8,6,9)
--go
--select * from Diario1