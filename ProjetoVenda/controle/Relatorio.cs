using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota()
        {
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
                        coluna.Item().AlignCenter().Text("Mercadinho da Esquina").Bold();
                        coluna.Item().AlignCenter().Text("Rua das Flores - 7070 - Sorocaba/SP").FontSize(5);
                        coluna.Item().LineHorizontal(0.5f);

                    });

                    //conteúdo da página
                    pagina.Content();

                    //repete em todas as paginas
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text("Data: 23/11/2026 negrito").Bold();
                        coluna.Item().Text("Data: 23/11/2026 sublinhado").Underline();
                        coluna.Item().Text("Compre mais itálico").Italic();
                        coluna.Item().Text("todos os produtos são de propcedência duvidosa").FontSize(1);


                    });


                });
            });
            return documento;

        }

        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog
            {
                Title = "Salvar Document",
                FileName = "nota.pdf",
                Filter = "(PDF)|*.pdf|(PNG)|*.png"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);
            }

            
           
            //documento.GeneratePdf("C:\\Users\\anderson.rsbarbosa\\Downloads\\nota.pdf");

        }

    }
}
