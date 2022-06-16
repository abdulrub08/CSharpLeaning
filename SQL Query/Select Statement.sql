use LearningDB
Select * from Employee

Select top 10 * from Employee
--where ID > 10
--where ID >=10 And ID <=40
where Age between 10 and 40
order by Age desc

Select FirstName,Count(Firstname) from Employee
group by FirstName