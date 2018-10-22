//Pega elemento por ID
$("#lblifo").text(); // obj estáticos

//obj dinâmico / val()

$("#btnOK").click(function () {
    alert($("#lblifo").text());

    var texto = $("#txtTexto").val();

    alert(texto);
});

$("#lblifo").click(function () {
    var cor = $(this).attr("cor");

    if (cor == "v") {
        $(this).removeClass("vermelho");
        $(this).addClass("verder");
        $(this).attr("cor", "verde");
    } else {
        $(this).removeClass("verder");
        $(this).addClass("vermelho");
        $(this).attr("cor", "v");
    }  
});


$("#btnCurtir").click(function () {
    var curtir = $(this).attr("curtir");

    if (curtir == "l") {
        $(this).html("<i class='fa fa-thumbs-up fa-5x icone azul'></i>");
        $(this).attr("curtir", "d");
    } else {
        $(this).html("<i class='fa fa-thumbs-down fa-5x icone vermelho'></i>");
        $(this).attr("curtir", "l");
    }
});