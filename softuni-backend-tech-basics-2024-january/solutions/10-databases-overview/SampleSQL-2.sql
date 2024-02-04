--SELECT * FROM Employees

--SELECT TOP(12) EmployeeID, FirstName, LastName, AddressID FROM Employees

--SELECT EmployeeID, FirstName, LastName, JobTitle 
--FROM Employees 
--WHERE JobTitle = 'Design Engineer'

--SELECT * FROM Projects WHERE Name = 'Introduction to SQL Course'

--INSERT INTO Projects(Name, StartDate)
--     VALUES ('Introduction to SQL Course', '1/1/2006')

--UPDATE Projects
--SET EndDate = '8/31/2006'
--WHERE StartDate = '1/1/2006'

--DELETE FROM Projects
--WHERE StartDate = '1/1/2006'

--SELECT * FROM Departments

--SELECT dep.DepartmentId AS ID, dep.Name AS 'Full name', dep.ManagerID
--FROM Departments AS dep

SELECT FirstName + ' ' + LastName AS 'Full Name', EmployeeID AS [No.]
FROM Employees

SELECT e.FirstName, e.LastName, d.Name AS 'Department Name' 
FROM Employees AS e JOIN Departments AS d ON e.DepartmentID = d.DepartmentID