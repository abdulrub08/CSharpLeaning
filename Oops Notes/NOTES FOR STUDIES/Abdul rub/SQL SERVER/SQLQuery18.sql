use Assignment ;
create table myxml
(
  id int identity (1,1) primary key,
  data xml not null
);