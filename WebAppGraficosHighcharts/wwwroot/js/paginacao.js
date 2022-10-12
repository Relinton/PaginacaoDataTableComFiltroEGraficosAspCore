$(document).ready(function () {
    $('#tabela-paginacao').DataTable(configuracaoPadraoDatatables);
    AtivarDataTableComGraficoRelacaoServidores(valor, ano, mes);
});