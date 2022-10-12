function AtivarDataTableComGraficoFuncionarios(valor = '') {
    valor = valor || '1'

    let table = $('#tabela-funcionarios').DataTable();

    let dadosDaTabela = ObterDadosDaTabela(table);

    dadosDaTabela[0].length > 0 ?
        $('#grafico-funcionarios').show() :
        $('#grafico-funcionarios').hide();

    const textosDoGrafico = {
        1: {
            tituloGrafico: `Gráfico - Relação dos funcionários por Empresa`,
            nome: "Empresa",
            xAxis: "Empresas",
            yAxis: "Funcionários"
        },
        2: {
            tituloGrafico: `Gráfico - Relação de Funcionários por Cargo`,
            nome: "Cargo",
            xAxis: "Cargos",
            yAxis: "Funcionários"
        },
        3: {
            tituloGrafico: `Gráfico - Relação de Funcionários por Contrato`,
            nome: "Contrato",
            xAxis: "Contratos",
            yAxis: "Funcionários"
        }
    }
    //end
    CriarGraficosHighcharts(dadosDaTabela, valor);

    ConfigurarAtualizacaoDoGraficoPorFiltroDaTabela(table)

    function ObterDadosDaTabela(tabela) {

        const dadosArray = [],
            empresaCargoOuContrato = [],
            qtdDeFuncionarios = []

        tabela.rows({ search: "applied" }).every(function () {
            const dados = this.data();

            empresaCargoOuContrato.push(dados[0])
            qtdDeFuncionarios.push(dados[1])
        })
        dadosArray.push(empresaCargoOuContrato, qtdDeFuncionarios.map(Number));

        return dadosArray
    }


    function CriarGraficosHighcharts(data) {
        const texto = textosDoGrafico[valor]

        const cores = {
            corPrimary: '#0071A7',
            corSuccess: '#2E9A41'
        }

        var series = [];

        series = [
            {
                name: texto.nome,
                colorByPoint: true,

                data: data[1]
            }
        ]
        Highcharts.setOptions({
            lang: {
                numericSymbols: ['mil', ' milhões']
            }
        });
        const chart = Highcharts.chart('grafico-funcionarios', {
            chart: {
                type: 'column'
            },
            title: {
                text: texto.tituloGrafico
            },
            xAxis: {
                categories: data[0]
            },
            yAxis: {
                title: {
                    text: `<b>${texto.yAxis}</b>`
                }
            },
            legend: {
                enabled: false
            },
            plotOptions: {
                column: {
                    borderWidth: 0,
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            tooltip: {
                headerFormat: `<span style="font-size:11px">${texto.nome}</span><br>`,
                pointFormat: `<span style="color:{point.color}">{point.name}</span>: <b>{point.y}</b><br/>`
            },
            series: series,
        });
    }
    let draw = false;
    function ConfigurarAtualizacaoDoGraficoPorFiltroDaTabela(tabela, valor) {

        tabela.on("page", () => {
            draw = true;
        });

        tabela.on("draw", () => {
            if (draw) draw = false
            else {
                let dadosDaTabela = ObterDadosDaTabela(tabela);
                CriarGraficosHighcharts(dadosDaTabela, valor);
            }
        })
    }
}