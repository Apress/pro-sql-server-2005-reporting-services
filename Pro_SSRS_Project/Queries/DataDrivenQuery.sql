Select Distinct EmployeeTblid, Email,HWUserLogin,ActivityDate from Employee Inner Join Activity On Employee.EmployeeTblid = Activity.ProviderID Where
Email is not null and ActivityDate Between Getdate() and GetDate() + 1