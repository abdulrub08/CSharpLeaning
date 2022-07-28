use practiceapp;
create table demoaudit
(
whenchanged Datetime,
tablename char(20),
operation char(6)
)