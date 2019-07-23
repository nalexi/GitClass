--1 Trazer somente as marcas que Felipe cadastrou
select Nome from Marcas where UsuInc = 1; 

--2 Trazer somente as marcas que Giomar cadastrou
select Nome from Marcas where UsuInc = 2; 

--3 Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select COUNT(Nome) as 'Marcas' from Marcas where UsuInc = 1 order by 'Marcas' desc; 

--4 Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select COUNT(Nome) as 'Marcas' from Marcas where UsuInc = 2 order by 'Marcas' asc; 

--5 Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select COUNT(Nome) as 'Marcas' from Marcas; 

--6 Trazer somente os carros que Felipe cadastrou
Select modelo from Carros where UsuInc = 1;

--7 Trazer somente os carros que Giomar cadastrou
Select modelo from Carros where UsuInc = 2;

--8 Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
Select COUNT(Modelo) as 'Quantidade F' from Carros where UsuInc = 1 order by 'Quantidade F' desc;

--9 Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
Select Count(Modelo) as 'Quantidade G' from Carros Where UsuInc =2 order by 'Quantidade G' asc;

--10 Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select count(Modelo) 'total' from carros;

--11 Trazer somente os carros das marcas que Felipe cadastrou
select C.Modelo as 'carros', M.Nome as 'Marcas' from Carros C inner join Marcas M on C.Marca = M.Id where M.UsuInc = 1;

--12 Trazer somente os carros das marcas que Giomar cadastrou
Select C.Modelo as 'Carro', M.Nome as 'MOdelo' from Carros C inner join Marcas M on C.Marca = M.Id where M.UsuInc = 2;

--13 Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select Count(C.Modelo) as 'Qtde Carro' from Carros C inner join Marcas M on C.Marca = M.Id where M.UsuInc = 1 order by 'Qtde Carro' desc;

--14 Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select COUNT(C.Modelo) as 'Qtde de Carros' from Carros C inner join Marcas M on C.Marca = M.Id where M.UsuInc = 2 order by 'Qtde de Carros' asc;

--15 Trazer o valor total de vendas 2019 isolado
Select Sum(Valor * Quantidade) as 'Total vendas' from Vendas where YEAR(DatInc) = 2019;

--16 Trazer a quantidade total de vendas 2019 isolado
Select Sum(Quantidade) as 'Total vendas' from Vendas where YEAR(DatInc) = 2019;

--17 Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select Sum(valor * quantidade) as 'Valor Total', YEAR(Datinc) as 'Ano'	from vendas group by YEAR(DatInc) order by  'Valor Total' desc;

--18 Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select sum(quantidade) as 'total', YEAR(DatInc) as 'Ano' from Vendas group by YEAR(DatInc) order by 'total' desc;

--19 Trazer o mês de cada ano que retornou a maior quantidade de vendas - Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select YEAR(DatInc) as 'Ano', MONTH(DatInc) 'Mes',SUM(Quantidade) 'quantidade vendas' 
	from Vendas
	group by MONTH(DatInc), YEAR(DatInc)
	order by 'quantidade vendas' desc;

--20 Trazer o mês de cada ano que retornou o maior valor de vendas - Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select YEAR(DatInc) as 'Ano', Month(DatInc) as 'Mes', Sum(valor * quantidade) as 'Total Vendas' from vendas group by YEAR(DatInc),Month(DatInc) order by 'Total Vendas' desc;

--21 Trazer o valor total de vendas que Felipe realizou
select SUM(valor * quantidade) as 'Total' from Vendas where UsuInc = 1;

--22 Trazer o valor total de vendas que Giomar realizou
select sum(valor * quantidade) as 'total' from Vendas where UsuInc =2;  

--23 Trazer a quantidade total de vendas que Felipe realizou
select sum(quantidade) as 'qtde total' from Vendas where UsuInc = 1;

--24 Trazer a quantidade de vendas que Giomar realizou
select SUM(quantidade) as 'Qtde Total' from Vendas where UsuInc = 2;

--25 Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(quantidade) as 'Qtde Total' from vendas where UsuInc between 1 and 2 order by 'Qtde Total' desc;

--26 Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(Valor * quantidade) as 'Valor' from vendas where UsuInc between 1 and 2 order by 'Valor' desc;

--27 Trazer a marca mais vendida de todos os anos - Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
Select
	SUM(V.quantidade * V.Valor) as 'Valor',
	YEAR(V.DatInc) as 'Ano',
	M.Nome as 'Marca'
	from Vendas V inner Join Carros C on C.Id = V.Carro
	inner join Marcas M on M.id = C.Marca
	group by YEAR(V.DatInc), M.Nome order by 'Valor' desc; 

--Trazer o valor total da marca mais vendida de todos os anos
select
	SUM(V.quantidade * V.Valor) as 'Valor',
	M.Nome
	from Vendas V inner join Carros C on C.Id = V.Carro
	inner join Marcas M on C.Marca = M.id
	group by M.Nome
	order by 'Valor' desc;

--Trazer a quantidade do carro mais vendido de todos os anos
select
	SUM(quantidade) as 'qtde',
	C.Modelo
	from Vendas V inner join Carros C on C.Id = V.Carro
	group by C.Modelo
	order by 'qtde' desc;

--Trazer o valor do carro mais vendido de todos os anos
select 
	SUM(valor * quantidade) as 'Valor',
	C.Modelo
	from Vendas V inner join Carros C on C.Id = V.Carro
	group by C.Modelo
	order by 'Valor' desc;



