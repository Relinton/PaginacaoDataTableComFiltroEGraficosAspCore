function AtivarDataTableComGrafico() {

    let table = $("#tabela-receitas").DataTable(configuracaoPadraoDatatables);

    let dadosDaTabela = ObterDadosDaTabela(table);

    let incluirReceitaPrevista = dadosDaTabela[2].length > 0 ? true : false;

    dadosDaTabela[0].length > 0 ?
        $('#grafico-receitas').show() :
        $('#grafico-receitas').hide();


    CriarGraficoHighcharts(dadosDaTabela, incluirReceitaPrevista);

    ConfigurarAtualizacaoDoGraficoPorFiltroDaTabela(table, incluirReceitaPrevista);

    function ObterDadosDaTabela(tabela) {
        var dadosArray = [],
            referencia = [],
            valorArrecadado = [],
            valorPrevisto = [];

        // loop table rows
        tabela.rows({ search: "applied" }).every(function () {
            var dados = this.data();

            //console.log(dados[1]);
            //console.log(dados[2]);
            //console.log(dados[3]);

            referencia.push(dados[1]);

            valorArrecadado.push(parseFloat(dados[2].replace("R$ ", "").replace(/\./g, "").replace(",", ".")));

            if (dados[3] !== undefined) {
                valorPrevisto.push(parseFloat(dados[3].replace("R$ ", "").replace(/\./g, "").replace(",", ".")));
            }
        });

        // store all data in dataArray
        dadosArray.push(referencia, valorArrecadado, valorPrevisto);

        return dadosArray;
    }

    function CriarGraficoHighcharts(data, incluirReceitaPrevista) {

        const corPrimary = '#0071A7';
        const corSuccess = '#2E9A41';

        var series = [];

        if (incluirReceitaPrevista) {
            series = [
                {
                    name: "Receita",
                    color: corPrimary,
                    type: "column",
                    data: data[1]
                },
                {
                    name: "Receita prevista",
                    color: corSuccess,
                    type: "column",
                    data: data[2]
                }
            ]
        }
        else {
            series = [
                {
                    name: "Receita",
                    color: corPrimary,
                    type: "column",
                    data: data[1]
                }
            ]
        }


        const chart = Highcharts.chart('grafico-receitas', {
            chart: {
                type: 'column'
            },
            title: {
                text: 'Gráfico de receitas'
            },
            tooltip: {
                formatter: function () {

                    var valorFormatadoBRL = this.y.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });

                    return valorFormatadoBRL;
                }
            },
            xAxis: {
                categories: data[0],
                title: {
                    text: 'Referência'
                }
            },
            yAxis: {
                title: {
                    text: 'Reais'
                },
                labels: {
                    formatter: function () {
                        return this.value.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' })
                    }
                }
            },
            series: series,
        });
    }

    let draw = false;

    function ConfigurarAtualizacaoDoGraficoPorFiltroDaTabela(tabela, incluirReceitaPrevista) {
        // listen for page clicks
        tabela.on("page", () => {
            draw = true;
        });

        // listen for updates and adjust the chart accordingly
        tabela.on("draw", () => {
            if (draw) {
                draw = false;
            } else {
                let dadosDaTabela = ObterDadosDaTabela(tabela);
                CriarGraficoHighcharts(dadosDaTabela, incluirReceitaPrevista);
            }
        });
    }
}