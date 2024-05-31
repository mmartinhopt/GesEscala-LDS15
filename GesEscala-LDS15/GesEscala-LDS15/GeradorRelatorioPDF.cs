using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System.Collections.Generic;
using PdfSharp.Fonts;

namespace GesEscala_LDS15
{
    public class GeradorRelatorioPDF : IGeradorRelatorio
    {
        private List<(Servico, Funcionario)> dados = new List<(Servico, Funcionario)>();
        private string filePath = "EscalaServico.pdf";

        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            dados.Add((servico, funcionario));
        }

        public void GerarRelatorio()
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

                foreach (var (servico, funcionario) in dados)
                {
                    textFormatter.Alignment = XParagraphAlignment.Left;
                    graphics.DrawString($"Serviço: {servico.Sigla}", fontConteudo, XBrushes.Black, new XRect(50, currentYPosition, page.Width - 100, page.Height), XStringFormats.TopLeft);
                    currentYPosition += 20;
                    graphics.DrawString($"Funcionário: {funcionario.Nome}", fontConteudo, XBrushes.Black, new XRect(50, currentYPosition, page.Width - 100, page.Height), XStringFormats.TopLeft);
                    currentYPosition += 30;
                }

                doc.Save(filePath);
            }
        }
    }
}

