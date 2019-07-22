
-- relatorio mais locado anual
Select 
	LC.Carro as 'id',
	CA.Veiculo as 'Nome',
	Count(LC.Carro) as 'quantidade veiculos',
	YEAR(LC.Devolucao) as 'ano Devolucao'
from Locacoes LC inner join Carros CA on LC.Carro = CA.Id
group by YEAR(LC.Devolucao), LC.Carro, Ca.Veiculo
order by  'quantidade veiculos' desc


-- relatorio mes
Select 
	--LC.Carro as 'id',
	--CA.Veiculo as 'Nome',
	--Cast(year(LC.Devolucao)as CHAR(4)) +'/' + RIGHT('0' + CAST(MONTH(lc.Devolucao) as varchar(2)),2) as 'data',

	Count(LC.Carro) as 'Vezes Alugado',
	MONTH(LC.Devolucao) as 'Mes Devolucao',
	YEAR(LC.Devolucao) as 'ano'
from Locacoes LC inner join Carros CA on LC.Carro = CA.Id 
group by MONTH(LC.Devolucao), YEAR(LC.Devolucao) --,Ca.Veiculo,LC.Carro,, CA.
order by  'ano' asc


--relatorio anual
select
	year(Devolucao) as 'Ano',
	COUNT(LC.Alugado) as 'Vezes alugado'
From Locacoes LC 
group by YEAR(Devolucao)




