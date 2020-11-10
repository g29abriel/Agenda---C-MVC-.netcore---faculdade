// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validarHorario() {
    let inicio = document.getElementById("inicio").value;
    let fim = document.getElementById("fim").value;

    if (inicio > fim) {
        event.preventDefault();
        return Document.event(alert("O inicio deve ser maior que o fim!"));
    }
}

function validarDia() {
    let dia = document.getElementById("dia").value;
    
    if (dia < retornaDataHoraAtual()) {
        event.preventDefault();
        return Document.event(alert("A data deve ser maior que o dia atual!"));
    }
}

function retornaDataHoraAtual() {
    /*var dataAtual = new Date();
    var data = dataAtual.getFullYear() + "-" + (dataAtual.getMonth() + 1) + "-" + dataAtual.getDate();
    return data;*/
    var dataAtual = new Date();
    var dia = dataAtual.getDate();

    if (dia < 10) dia = ("0" + dia);

    var data = dataAtual.getFullYear() + "-" + (dataAtual.getMonth() + 1) + "-" + dia;
    return data;

}
function validarCampos() {
    validarHorario();
    validarDia();

}
