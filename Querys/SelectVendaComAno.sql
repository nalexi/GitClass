Select 
	Modelo,
	Ano,
	SUM(NumeroDeVenda)/COUNT(DataVenda) as 'media',
	YEAR(datavenda) as 'ano'
	from TabelaCarros
	Where YEAR(DataVenda) = 2015
	GROUP BY modelo, ano, YEAR(DataVenda);

