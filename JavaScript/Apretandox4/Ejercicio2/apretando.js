let imagen = true; 

const ocultarElemento = () => {


    

    if(imagen){
        imagen=false;
        $('#imagen').hide();
        $('button').text('Mostrar');
    }else{
        $('#imagen').show();
        $('button').text('Ocultar Imagen');
        imagen=true;
    }
}

