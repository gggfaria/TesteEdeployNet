
function pesquisarCidade() {
    var filtro = $("#formBuscar").serialize();
    $("#divListaCidades").load("/Cidades/BuscarCidades", filtro, function () {

    });
}

function verPontuacao(cidade, estado) {
    var filtro = {
        Cidade: cidade,
        Estado: estado
    }

    $.post("/Pontuacoes/PontuacaoByCidadeEstado", filtro, function (data) {
        if (data.pontos != undefined)
            alert("A pontuação da cidade " + cidade + " é " + data.pontos);
        else
            alert("Erro");
    });
}