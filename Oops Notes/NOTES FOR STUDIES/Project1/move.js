<script language="javascript" runat="server">
function back()
	{
     if(document.all.move.style.posLeft==10)
{
	document.all.move.style.posLeft=document.all.move.style.posLeft+8;    
         setTimeout("slide()",50); 
}
else {
document.all.move.style.posLeft=document.all.move.style.posLeft-8;    
         setTimeout("back()",50);
      }
	}

function slide()
  {
  if (document.all.move.style.posLeft<790)
    {
	
    document.all.move.style.posLeft=document.all.move.style.posLeft+8;
    setTimeout("slide()",50);
    
    }

 else{
   document.all.move.style.posLeft=document.all.move.style.posLeft-8;
   setTimeout("back()",50);

     }
 
  }
</script>// JavaScript Document