﻿--Select 'ZeVéio' as 'DogLoko' ,
--
--	SUM(Temp.totalVendas) as 'Total vendido',
--	Temp.MesVenda
--from(select 
--
--		(TipoDog) as 'tipo',
--		(TotalVendas) as 'totalVendas',
--		MONTH(DataVenda) as 'Mesvenda'
--
--	from TabelaDog 
--	group by TipoDog, TotalVendas, MONTH(DataVenda)) Temp
--
--group by Temp.Mesvenda
--order by [Total vendido] desc

--select ESTA AQUI ESTA CORRETA
--		(TipoDog) as 'tipo',
--		SUM(TotalVendas) as 'totalVendas',
--		MONTH(DataVenda) as 'Mesvenda'
--	from TabelaDog 
--	group by TipoDog, MONTH(DataVenda)
--	ORDER BY totalVendas desc;

--1 select 
--	TipoDog,
--	TotalVendas,
--	MONTH(DataVenda) as 'mes'
--from TabelaDog;

--2 select 
--	TipoDog,
--	SUM(TotalVendas), as 'Total Vendas'
--	MONTH(DataVenda) as 'mes'
--from TabelaDog;
--group by TipoDog, MONTH(DataVenda)

--3 select 
--	TipoDog,
--	SUM(TotalVendas), as 'Total Vendas'
--	MONTH(DataVenda) as 'mes'
--from TabelaDog;
--group by TipoDog, MONTH(DataVenda)
--order by 'Total Vendas' desc