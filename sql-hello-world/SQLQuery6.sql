select *
from Album al right join Artist as ar on al.ArtistId = ar.ArtistId
where al.AlbumId is null

select *
from artist as t
where t.ArtistId not in (
	select ArtistId
	from Album
	where AlbumId in (
		select AlbumId
		from track 
		where GenreId in (
			select GenreId
			from Genre
			where Name = 'Latin'
		)
	)
)

select *
from track as t
where t.MediaTypeId in (
	select MediaTypeId
	from MediaType
	where MediaTypeId != 4
)
order by t.Milliseconds desc



insert into Employee (EmployeeId,LastName,FirstName,Title) values (000,'rubio','storm', 'Big Boss')
insert into Employee (EmployeeId,LastName,FirstName,Title) values (100,'rubioooo','stormoooo', 'Bigger Boss')

insert into track (TrackId,name, UnitPrice, MediaTypeId,Milliseconds) values ((select max(genreid) from track) +1,'storms song',100,2,20)
insert into track (TrackId,name, UnitPrice, MediaTypeId,Milliseconds) values ((select max(genreid) from track)+1,'storms song',100, 2,20)

select * 
from Customer

update Customer
set FirstName = 'Robert '
where FirstName = 'Aaron '

update Customer
set LastName = 'Walter '
where LastName = 'Mitchell' 

select *
from Customer
where FirstName = 'robert'


delete from Employee
where EmployeeId = 0

delete from Customer
where FirstName = 'Robert' and LastName = 'walter'

delete from Invoice
where CustomerId = 32


delete from InvoiceLine
where InvoiceId = 50
delete from InvoiceLine
where InvoiceId = 61
delete from InvoiceLine
where InvoiceId = 116
delete from InvoiceLine
where InvoiceId = 245
delete from InvoiceLine
where InvoiceId = 268
delete from InvoiceLine
where InvoiceId = 290
delete from InvoiceLine
where InvoiceId = 342

select *
from Invoice
where CustomerId = 32




