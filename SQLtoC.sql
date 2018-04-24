Use AdventureWorks2012

-- Drop Login AdvWorks2012
-- Drop User AdvWorks2012

Go
Create Login AdvWorks2012
	With Password = '1942'

Go

Create User AdvWorks2012 For Login AdvWorks2012;
 
Go

Alter Role db_datareader Add Member [AdvWorks2012]
Go

Alter Role db_datawriter Add Member [AdvWorks2012]
Go

Deny Select On Schema :: HumanResources To AdvWorks2012; 
Deny Insert On Schema :: HumanResources To AdvWorks2012;
Deny Update On Schema :: HumanResources To AdvWorks2012;
Deny Delete On Schema :: HumanResources To AdvWorks2012;
Deny Insert On Schema :: Person To AdvWorks2012;
Deny Update On Schema :: Person To AdvWorks2012;
Deny Delete On Schema :: Person To AdvWorks2012;



Go
Create Proc spSalesOrderDts
(
@CustomerID int
)
As

Select SalesOrderID 'Sales Order ID', Concat(P.FirstName, ' ', P.LastName) 'Sales Person' , OrderDate 'Order Date', ShipDate 'Ship Date', City, Sp.Name 'State', TotalDue 'Total Due On Order'
From Sales.SalesOrderHeader SOH
Inner Join Person.[Address] A
On A.AddressID = SOH.ShipToAddressID
Inner Join Sales.SalesPerson SSP
On SOH.SalesPersonID = SSP.BusinessEntityID
Inner Join Person.Person P
On P.BusinessEntityID = SSP.BusinessEntityID
Inner Join Person.StateProvince SP
On SP.StateProvinceID = A.StateProvinceID
Where CustomerID = @CustomerID

Go
Create Proc spActiveCustomers
As
Select CustomerID 'Customer ID', Concat(FirstName, ' ', LastName) 'Customer'
From Sales.Customer C
Inner Join Person.Person P
On P.BusinessEntityID = C.PersonID


