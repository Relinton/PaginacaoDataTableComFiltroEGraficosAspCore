$(document).ready(() => {
    let valor = ''
    $("#form-filtro-funcionarios").on('submit', (e) => {
        Filtrar(e, valor);
    })
    $('#TipoDeConsulta').change(() => {
        valor = $('#TipoDeConsulta').val();
    })
    $("#form-filtro-funcionarios").submit();
});

function Filtrar(e, valor) {
    const loader = '<div class="alert alert-info text-center"><i class="fa-solid fa-circle-notch fa-spin" aria-hidden="true"></i> carregando</div';
    const mensagemErro = '<div class="alert alert-warning text-center"><i class="fa fa-exclamation-circle" aria-hidden="true"></i> houve um problema ao carregar os dados</div>'

    $('grafico-funcionarios').attr('hidden', '');

    $('#tabela-partial').html(loader)

    e.preventDefault();

    $.ajax({
        type: "Post",
        data: new FormData(e.currentTarget),
        enctype: 'multipart/form-data',
        cache: false,
        contentType: false,
        processData: false,
        async: true,
        url: $(e.currentTarget).attr("action"),
        success: (response) => {
            $('#grafico-funcionarios').removeAttr('hidden', '');

            $('#tabela-partial').html(response);

            AtivarDataTableComGraficoFuncionarios(valor);
        },
        error: (data) => {
            $('#tabela-partial').html(mensagemErro);
        }
    })
}