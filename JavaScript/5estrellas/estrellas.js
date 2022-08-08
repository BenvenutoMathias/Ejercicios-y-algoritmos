$(function(){
    
$('div #imagen').on({

     mouseenter: function(){
         
         $(this).attr('src', 'imagen2.png');
        
    }, 
    mouseleave: function(){
       
        $(this).attr('src', 'imagen1.png');
        
      
    }, 
    click: function(){
        
        $(this).attr('src', 'imagen3.png');
        
    },
    
});

});