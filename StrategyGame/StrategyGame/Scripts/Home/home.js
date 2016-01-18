$(document).ready(function () {

    $("input[type=button]").click(function (event) {

        if ($('#apelido').val() == "") {
            alert('Apelido campo obrigatório!');
        } else if ($('#email').val() == "") {
            alert('E-mail campo obrigatório!');
        } else if ($('#senha').val() == "") {
            alert('Senha campo obrigatório!');
        } else {
            var acao = $(this).attr("value");
            if (acao == "Enviar") {
                    Gravar($('#apelido').val(), $('#email').val(), $('#senha').val());
            };
        }
            
    });

});

function Gravar(apelido, email, senha ) {
    var _data = JSON.stringify({ apelido: apelido, email: email, senha: senha });
    $.ajax({
        type: "POST",
        url: "Home/CadastrarGamer",
        data: _data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {

            if (msg.Retorno == "C") {
                alert("Gamer cadastrado com sucesso!");
            } else {
                alert("E-mail já cadastrado. Digite outro por favor.");
            }

            if (msg.Retorno != "Existe") {
                $('#apelido').val('');
                $('#email').val('');
                $('#senha').val('');
            }
        },
        failure: function (response) {
            alert(response.Retorno);
        }
    });



}