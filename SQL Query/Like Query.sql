/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [empno],[ename],[job],[mgr],[hiredate],[sal],[comm],[dept]
  FROM [DbEmployee].[dbo].[emp]
--where emp.ename='POLK'
where emp.ename like 'J_____N'

