use Adventureworks
go


--task1
select FirstName, LastName
from person.person
where Title IS NOT NULL

---task2
select FirstName, LastName
from person.person
where FirstName like '%a%' and LastName like '%a%'

--task3
select curr.CurrencyCode,Name
from Sales.Currency curr, Sales.CountryRegionCurrency  cregc

--task4
select * into HR_Dept
from HumanResources.Department
select * from HR_Dept

--task5
create table task_tbl1
(
sno int identity(1,1),
fname varchar(20),lname varchar(20),DOB date,city varchar(20)
)

declare @var int
set @var =1
while @var<=20
begin
insert task_tbl1
values('Ram','Sita','08/05/2001','Chennai')
set @var = @var+1
end
select * from task_tbl1

--task6
select prsn.BusinessEntityID, AddressTypeID
from HumanResources.Department dept
join Person.BusinessEntityAddress prsn 
on dept.DepartmentID = prsn.BusinessEntityID

--task7
select distinct GroupName
from HumanResources.Department

--task8
select sum(ListPrice), sum(pch.StandardCost), ProductSubcategoryID
from Production.ProductCostHistory pch 
join Production.Product prod
on pch.ProductID = prod.ProductID
group by ProductSubcategoryID

--task9
select DATEDIFF(year, StartDate, EndDate) Role
from HumanResources.EmployeeDepartmentHistory

--task11
select max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

--task12 
select dept.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate
from HumanResources.Department dept 
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task13
create view NameAge as
Select dept.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dept
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task 14  
select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee

--task15
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory emppay join
HumanResources.Department dept
on emppay.BusinessEntityID = dept.DepartmentID
group by Name

--task16
select FirstName,MiddleName,Title,AddressTypeID,buis.BusinessEntityID
from Person.Person per
left join Person.BusinessEntityAddress buis
on per.BusinessEntityID=buis.BusinessEntityID
where Title is not null 

--task17
select ProductID,prodloc.LocationID,Shelf
from Production.ProductInventory prodinv
join Production.Location prodloc
on prodinv.LocationID=prodloc.LocationID
where ProductID>=300 and ProductID<=350 and prodloc.LocationID=50 or Shelf='E'

--task18
select Shelf,Name,prodinv.LocationID
from Production.ProductInventory prodinv
join Production.Location prodloc
on prodinv.LocationID=prodloc.LocationID

--task19
select AddressID,AddressLine1,AddressLine2,stprov.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince stprov
join Person.Address p_add
on stprov.StateProvinceID=p_add.StateProvinceID

--task20
select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader soh
join Sales.SalesTerritory st_ter
on st_ter.TerritoryID=soh.TerritoryID
join Sales.CountryRegionCurrency crc
on crc.CountryRegionCode=st_ter.CountryRegionCode
group by CurrencyCode



