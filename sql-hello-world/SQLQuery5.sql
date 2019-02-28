select cust.Address + ' ' + cust.City + ' ' + cust.State + ' ' + cust.Country as mail
from Invoice inner join Customer as cust on Invoice.CustomerId = cust.CustomerId
where cust.Country = 'brazil'


select i.InvoiceId + ' ' + emp.FirstName
from 
	Invoice i inner join customer as cust on i.CustomerId = cust.CustomerId
	inner join employee as emp on cust.SupportRepId = emp.EmployeeId



select pl.Name, count(plt.trackid) as ct
from 
	track t inner join PlaylistTrack as plt on t.TrackId = plt.TrackId
	inner join Playlist as pl on plt.PlaylistId = pl.PlaylistId
	group by pl.Name