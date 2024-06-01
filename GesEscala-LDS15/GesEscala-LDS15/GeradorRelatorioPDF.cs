using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System.Collections.Generic;
using PdfSharp.Fonts;
using System;

namespace GesEscala_LDS15
{
    public class GeradorRelatorioPDF : IGeradorRelatorio
    {
        private List<(Servico, Funcionario)> dados = new List<(Servico, Funcionario)>();
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private List<Servico> servicos = new List<Servico>();
        private List<Dictionary<string, object>> escalas = new List<Dictionary<string, object>>();


        public void AdicionarEscala(Dictionary<string, object> escala)
        {
            throw new NotImplementedException();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario); 
        }

        public void AdicionarServico(Servico servico)
        {
            servicos.Add(servico);
        }

        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            dados.Add((servico, funcionario));
        }

        public void GerarRelatorio(int numero_relatorio)
        {
            if (numero_relatorio == 1)
            {
                GerarRelatorioFuncionarios(funcionarios);
            }
            if (numero_relatorio == 2)
            {
                GerarRelatorioEscalas(servicos);
            }

        }

        public void GerarRelatorioEscalas(List<Servico> servicos)
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                GlobalFontSettings.FontResolver = new FontResolver();
                var fontTitulo = new XFont("Arial", 20);
                var fontConteudo = new XFont("Arial", 12);
                double currentYPosition = 100;

                textFormatter.Alignment = XParagraphAlignment.Center;
                graphics.DrawString("Escala de Serviço", fontTitulo, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.TopCenter);

                foreach (Servico servico in servicos)
                {
                    textFormatter.Alignment = XParagraphAlignment.Left;
                    graphics.DrawString($"Serviço: {servico.Sigla}", fontConteudo, XBrushes.Black, new XRect(50, currentYPosition, page.Width - 100, page.Height), XStringFormats.TopLeft);
                    currentYPosition += 20;

                }

                doc.Save("servicos.pdf");
            }
        }


        public void GerarRelatorioFuncionarios(List<Funcionario> funcionarios)
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                GlobalFontSettings.FontResolver = new FontResolver();
                var fontTitulo = new XFont("Arial", 20);
                var fontConteudo = new XFont("Arial", 12);
                double currentYPosition = 100;

                textFormatter.Alignment = XParagraphAlignment.Center;
                graphics.DrawString("Lista de Funcionários", fontTitulo, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.TopCenter);

                // Define as larguras das colunas
                int numColumnWidth = 50;
                int nameColumnWidth = 150;
                int surnameColumnWidth = 150;
                int addressColumnWidth = 250;
                int contactColumnLabelWidth = Convert.ToInt32( page.Width - (50 + 100 + 100 + 100));

                // Cabeçalho
                graphics.DrawString("Número", fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, numColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Nome", fontConteudo, XBrushes.Black, new XRect(90, currentYPosition, nameColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Apelido", fontConteudo, XBrushes.Black, new XRect(240, currentYPosition, surnameColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Morada", fontConteudo, XBrushes.Black, new XRect(390, currentYPosition, addressColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Contacto", fontConteudo, XBrushes.Black, new XRect(640, currentYPosition, contactColumnLabelWidth, page.Height), XStringFormats.TopLeft);
                currentYPosition += 20;
                graphics.DrawLine(XPens.Black, 40, currentYPosition, page.Width - 40, currentYPosition);  // Draw a line under headers

                // Desenha os dados dos funcionários
                foreach (Funcionario func in funcionarios)
                {
                    currentYPosition += 25;  // Espaçamento entre linhas
                    graphics.DrawString(func.Numero.ToString(), fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, numColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(func.Nome, fontConteudo, XBrushes.Black, new XRect(90, currentYPosition, nameColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(func.Apelido, fontConteudo, XBrushes.Black, new XRect(240, currentYPosition, surnameColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(func.Morada, fontConteudo, XBrushes.Black, new XRect(390, currentYPosition, addressColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(func.Contacto.ToString(), fontConteudo, XBrushes.Black, new XRect(640, currentYPosition, contactColumnLabelWidth, page.Height), XStringFormats.TopLeft);
                }

                // Salva o documento
                doc.Save("funcionarios.pdf");
            }
        }
    }
}