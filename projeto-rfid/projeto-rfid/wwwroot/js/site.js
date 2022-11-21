// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function aplicaFiltroConsultaAvancada() {

    var vNome_curso_fk = document.getElementById('nome_curso_fk').value;
    var vPeriodo_curso_fk = document.getElementById('periodo_curso_fk').value;
    $.ajax({
        url: "/aluno/ObtemDadosConsultaAvancada",
        data: { nome_curso_fk: vNome_curso_fk, periodo_curso_fk: vPeriodo_curso_fk },
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

function aplicaFiltroConsultaAvancadaPresenca() {
    var vNome_curso_fk = document.getElementById('nome_curso_fk').value;
    var vSemestre_curso_fk = document.getElementById('semestre_curso_fk').value;
    var vDataInicial = document.getElementById('dataInicial').value;
    var vDataFinal = document.getElementById('dataFinal').value;
    $.ajax({
        url: "/presenca/ObtemDadosConsultaAvancada",
        data: { nome_curso_fk: vNome_curso_fk, semestre_curso_fk: vSemestre_curso_fk, dataInicial: vDataInicial, dataFinal: vDataFinal },
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