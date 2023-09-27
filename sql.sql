SELECT EmployeeID,FirstName,LastName,d.[Name] FROM Employees as e
JOIN Departments AS d on 
e.EmployeeID =e.DepartmentID
 WHERE d.Name = 'Sales'
 ORDER BY EmployeeID