function aplicaFiltroConsultaAvancada() {
    var vDescricao = document.getElementById('nome').value;
    $.ajax({
        url: "/jogo/ObtemDadosConsulta",
        data: { nome: vNome },
        success: function (dados) {
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultadoConsulta').innerHTML = dados;
            }
        },
    });

}