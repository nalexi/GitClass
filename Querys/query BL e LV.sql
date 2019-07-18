--select 
--	LV.Id,
--	LV.Nome,
--	IIF(LV.Alocado, 'sim','Não') as 'Locado',
--	BL.Nome
--	from Biblioteca BL
--	inner join on Biblioteca.Id = Livro.Biblioteca

select 
		BL.Nome,
		COUNT(LV.id) as  'QuantidadeDeLivros'
	from Biblioteca BL
	inner join Livro LV on BL.id = LV.biblioteca
	--inner join Usuario US on LV.UsuInc = US.ID
	group by Bl.Nome 
