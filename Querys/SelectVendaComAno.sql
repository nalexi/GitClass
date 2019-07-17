Select 'Carros' as 'Carros',
	SUM(Temp.Media) as 'Vendas',
	Temp.AnoVenda
from(select
	Modelo,
	Ano,
	SUM(NumeroDeVenda)/COUNT(DataVenda) as 'media',
	YEAR(datavenda) as 'anoVenda'
	from TabelaCarros
	GROUP BY modelo, ano, YEAR(DataVenda)) Temp
group by Temp.anoVenda

