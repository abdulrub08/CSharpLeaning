use Assignment ;
Select Publishers.[Company Name] , Titles.Title , Titles.Subject 
from Publishers 
inner join    Titles 
on Publishers.PubID = Titles.PubID 
where Publishers.[Company Name]  in ('WAITE GROUP PR','ROBINS PR')order by (Titles.Subject)