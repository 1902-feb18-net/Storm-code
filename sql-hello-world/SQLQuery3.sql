select FirstName + ' ' + + LastName AS "full name", CustomerID, Country
from dbo.Customer
where not country = 'USA'


select FirstName + ' ' +  LastName AS "full name", CustomerID, Country
from dbo.Customer
where country = 'Brazil'


select distinct BillingCountry
from dbo.Invoice


select  sum(Total) AS Sales
from dbo.Invoice
where InvoiceDate >= '2009' and InvoiceDate < '2010'
group by year(InvoiceDate)

