--cross join.

select *
from Employee as e1 cross join Employee as e2


select *
from Track inner join genre on track.GenreId = Genre.GenreId

select *
from track right join Genre on track.GenreId = Genre.GenreId



select ar.name + ' ' + t.Name 
from track as t
	inner join Album as al on t.AlbumId = al.AlbumId
	inner join Artist as ar on al.AlbumId = ar.ArtistId
	inner join Genre as g on t.GenreId = g.GenreId
where g.Name = 'rock'

select emp.FirstName + ' ' + emp.lastname
from Employee as emp 
	left outer join Employee as mgr on emp.ReportsTo = mgr.EmployeeId



