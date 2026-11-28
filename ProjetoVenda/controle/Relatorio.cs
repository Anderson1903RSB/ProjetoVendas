using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Text;
using ProjetoVenda.modelo;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;

            var documento = Document.Create(conteudo => { // criando o documento

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font => font.FontSize(10));

                    //repete em todas as paginas
                    pagina.Header().Column(coluna => {
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().PaddingBottom(10).Text("Mercadinho da Esquina").Bold();
                        coluna.Item().AlignCenter().Text("Rua das Flores - 7070 - Sorocaba/SP").FontSize(5);
                        coluna.Item().LineHorizontal(0.5f);

                    });

                    //conteúdo da página
                    pagina.Content().Column(coluna =>
                    {
                        coluna.Item().Row(linha =>
                        {
                            linha.ConstantItem(20).Text("Item").FontSize(8);
                            linha.RelativeItem(3).Text("Descrição").FontSize(8);
                            linha.ConstantItem(20).Text("qtd").FontSize(8);
                            linha.RelativeItem().Text("Preço").FontSize(8);
                            linha.RelativeItem().Text("Total").FontSize(8).AlignRight();
                        });
                        coluna.Item().LineHorizontal(0.5f);

                        //os itens descritos
                        for (int i = 0; i < itens.Count; i++)
                        {
                            Item item = itens[i];

                            coluna.Item().Row(linha => {
                                linha.ConstantItem(20).Text($"{i + 1}").FontSize(8);
                                linha.RelativeItem(3).Text(item.nomeProduto).FontSize(8);
                                linha.ConstantItem(20).Text($"{item.quantidade}").FontSize(8);
                                linha.RelativeItem().Text($"{item.precoReal:c2}").FontSize(8);
                                linha.RelativeItem().Text($"{item.subTotal:c2}").FontSize(8).AlignRight();
                            });
                        }
                        coluna.Item().LineHorizontal(0.5f);
                        decimal total = itens.Sum(item => item.subTotal);

                        coluna.Item().Row(linha =>
                        {
                            
                            linha.RelativeItem().Text("Total").FontSize(8);
                            linha.RelativeItem().Text($"{total:c2}").FontSize(8).AlignRight();
                        });

                    });

                    //repete em todas as paginas
                    //Rodapé
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text($"Data: {data: dd/MM/yyy HH:mm:ss} ").Bold();
                        coluna.Item().Text("Data: 23/11/2026 sublinhado").Underline();
                        coluna.Item().Text("Compre mais itálico").Italic();
                        coluna.Item().Text("todos os produtos são de propcedência duvidosa").FontSize(1);


                    });


                });
            });
            return documento;

        }

        private void resumo(IContainer conteudo, List<Venda> listaDeVenda)
        {
            int quantidadeDeVendas = listaDeVenda.Count();
            Venda? maiorVenda = listaDeVenda.OrderByDescending(venda=>venda.total).FirstOrDefault();
            Venda? menorVenda = listaDeVenda.OrderBy(venda=> venda.total).FirstOrDefault();
            conteudo.Column(coluna =>
            {
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Padding(8)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .DefaultTextStyle(e=>e.FontColor(Colors.White))
                .Text("RESUMO GERAL");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"Maior Venda:{maiorVenda.total:c2}");
                    linha.RelativeItem().Text($"Menor Venda:{menorVenda.total:c2}");
                    linha.RelativeItem().Text($"Total de Vendas:{quantidadeDeVendas}");
                });
            });
        }

        private void rankFuncionario(IContainer conteudo, List<Venda> listaDeVenda)
        {
            var funcionarios = listaDeVenda.GroupBy(venda => new { 
                venda.cod_funcionario,
                venda.nomefuncionario
            }).Select(grupo=>new
            {
                cod_funcionario = grupo.Key.cod_funcionario,
                nome = grupo.Key.nomefuncionario,
                quantidadeVendas = grupo.Count(),
                total = grupo.Sum(venda=>venda.total)
            }).OrderByDescending(funcionario=>funcionario.total).ToList();


            conteudo.Column(coluna =>
            {
                coluna.Spacing(20);
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Padding(8)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("RANKING DOS FUNCIONARIOS");

                coluna.Spacing(10);

                coluna.Item().Table(tabela => {
                    tabela.ColumnsDefinition(coluna =>
                    {
                        coluna.ConstantColumn(30);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn(2);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn();
                    });
                    tabela.Header(cabecalho =>
                    {
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("#");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("cod");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("nome");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("QTD");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("Total").AlignRight();
                    });
                    int pos = 1;
                    foreach(var funcionario in funcionarios)
                    {
                        tabela.Cell().Text($"{pos}");
                        tabela.Cell().Text($"{funcionario.cod_funcionario}");
                        tabela.Cell().Text($"{funcionario.nome}");
                        tabela.Cell().Text($"{funcionario.quantidadeVendas}");
                        tabela.Cell().Text($"{funcionario.total:C2}").AlignRight(); ;
                        pos++;
                    }
                });
               
            });
        }

        private void demonstrativo(IContainer conteudo, List<Venda> listaDeVenda)
        {
            decimal totalVendido = listaDeVenda.Sum(venda => venda.total);
            conteudo.Column(coluna =>
            {
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Padding(8)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("DEMONSTRATIVO DE VENDAS (DRE)");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"Faturamento:").FontSize(16);
                    linha.RelativeItem().Text($"{totalVendido:c2}").AlignRight().FontSize(16);
                });
            });
        }

        public Document gerarRelatorioMensal(List<Venda> listaDeVendas)

        {

            DateTime data = DateTime.Now;
            DateTime dataInicial = listaDeVendas.Min(venda => venda.data);
            DateTime dataFinal = listaDeVendas.Max(venda => venda.data);

            // criando o documento

            var documento = Document.Create(conteudo => {

                conteudo.Page(pagina =>

                {

                    pagina.Size(PageSizes.A4);

                    pagina.Margin(10);

                    pagina.DefaultTextStyle(estilo => estilo.FontSize(12));
                    //cabeçalho
                    pagina.Header().Column(coluna =>

                    {

                        coluna.Item().Text("Relatório Mensal").AlignCenter().FontSize(18);

                        coluna.Item().Text("Mercadinho da Esquina");

                        coluna.Item().Text($"Período: {dataInicial:dd/MM/yyy} a {dataFinal:dd/MM/yyyy}");

                        coluna.Item().LineHorizontal(1f);

                    });

                    // conteúdo principal

                    pagina.Content().Column(coluna =>

                    {
                        //resumo
                        coluna.Item().Element(conteudo =>resumo (conteudo, listaDeVendas));

                        //RANKING FUNCIONARIO
                        coluna.Item().Element(conteudo => rankFuncionario(conteudo, listaDeVendas));

                        //DEMONSTRATIVO
                        coluna.Item().Element(conteudo => demonstrativo(conteudo, listaDeVendas));

                    });
                    //rodapé
                    pagina.Footer().Column(coluna =>

                    {

                        coluna.Item().LineHorizontal(1f);

                        coluna.Item().Row(linha =>

                        {

                            linha.RelativeItem().Text($"Gerado em: {data:dd/MM/yyyy}");

                            linha.RelativeItem().AlignRight().Text(texto =>

                            {

                                texto.Span("Pagina ");

                                texto.CurrentPageNumber();

                                texto.Span(" de ");

                                texto.TotalPages();

                            });

                        });

                    });


                });

            });

            return documento;

        }




        public void salvarPdf(Document documento)
        {
            // var dialogo = new SaveFileDialog
            //{
            //   Title = "Salvar Document",
            //  FileName = "nota.pdf",
            //    Filter = "(PDF)|*.pdf|(PNG)|*.png"
            // };
            // if (dialogo.ShowDialog() == DialogResult.OK)
            // {
            //    var documento = gerarNota();
            //     documento.GeneratePdf(dialogo.FileName);
            //}
            string pasta = Path.GetTempPath();
            string nomeArquivo = $"nota_{Guid.NewGuid()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo);

            documento.GeneratePdf(caminho);

            //Abre o documento
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });


            
           
            //documento.GeneratePdf("C:\\Users\\anderson.rsbarbosa\\Downloads\\nota.pdf");

        }

    }
}
