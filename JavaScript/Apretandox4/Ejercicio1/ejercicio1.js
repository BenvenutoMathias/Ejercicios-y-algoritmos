$(document).ready(function () {
    /* $('h1').show(1000); */

    $('button').addClass('btn').addClass('btn-primary');


    
})



let oscuro = true;
   
 const oscurecer = () => {



     if(oscuro){
    oscuro=false;
     $('body').css('background-color', 'black').css('color', 'white');
     
     
        $( 'button' ).text( 'Aclarar' );

      

     }else{

         
        $( 'button' ).text( 'Oscurecer' );
        

        $('body').css('background-color', 'white').css('color', 'black');
        oscuro=true;

       

     }
 }
