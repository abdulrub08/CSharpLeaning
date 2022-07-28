use Assignment ;
select * from myxml 
where data.exist('state/city[@name="Bhopal"]')=1;