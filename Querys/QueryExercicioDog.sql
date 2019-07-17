--select 
--	TipoDog,
--	TotalVendas,
--	COunt(MONTH(dataVenda)) as 'data venda'
--from TabelaDog
--group by TipoDog, TotalVendas, MONTH(DataVenda)





select 

	TipoDog,
	TotalVendas,
	(MONTH(DataVenda)) as 'soma vendas',

	DataVenda

from TabelaDog
group by TipoDog, TotalVendas, DataVenda