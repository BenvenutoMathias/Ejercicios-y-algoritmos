let color = true;

const marcar = (num) => {

    let visor = $('#visor').val(num);
    if(color){
    color=false;
    $('#visor').css("background-color", "yellow");
    }else{
    color=true;
    $('#visor').css("background-color", "white");
    $(visor).val('');
    }
       
}