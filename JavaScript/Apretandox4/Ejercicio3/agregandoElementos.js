

const agregarElemento = () => {

    let palabras = $('#visor').val();
    $('#desplegable').append(`<option value="${palabras}">${palabras}</option>`);
    $('#visor').val(""); 
   
    
}

const eliminarElemento = () => {

    let palabras = $('#visor').val();
    $(`#desplegable > [value="${palabras}"]`).remove();
    $('#visor').val(""); 
    
   
   
}

