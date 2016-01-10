$(document).ready(function () {

    $("input[type=button]").click(function (event) {

        //if (ValidarObrigatorios()) {
        //    var acao = $(this).attr("value");
        //    if (acao == "Enviar") {
        //        if (ValidarSenha()) {
        //            Gravar($('#apelido').val(), $('#email').val(), $('#senha'));
        //        }
        //    }
        //}
        Gravar($('#apelido').val(), $('#email').val(), $('#senha').val());

    });

});

function ValidarObrigatorios() {

    if ($('#apelido').val() == "") {
        alert('Apelido campo obrigatório!');
    } else if ($('#email').val() == "") {
        alert('E-mail campo obrigatório!');
    } else if ($('#senha').val() == "") {
        alert('Senha campo obrigatório!');
    } else if ($('#Confirmarsenha').val() == "") {
        alert('Confirmar senha campo obrigatório!');
    }
}
    
function ValidarSenha() {

    if ($('#senha').val() != $('#Confirmarsenha').val()) {
        alert('Senhas diferentes!');
    }
}

function Gravar(apelido, email, senha ) {
    var _data = JSON.stringify({ apelido: apelido, email: email, senha: senha });
    $.ajax({
        type: "POST",
        url: "Home/CadastrarGamer",
        data: _data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            //$("#Result").text(msg.d);
            alert(msg.Retorno);
        },
        failure: function (response) {
            alert(response.Retorno);
        }
    });



}