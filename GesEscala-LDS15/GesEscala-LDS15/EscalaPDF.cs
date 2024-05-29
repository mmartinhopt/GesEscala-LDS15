using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;

namespace GesEscala_LDS15
{
    class EscalaPDF
    {
        // Atributo para controlar a posição vertical do próximo texto a ser adicionado
        private double currentYPosition = 150; // Começa a adicionar texto a partir de 150 units para baixo

        public void CriarPDF()
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                GlobalFontSettings.FontResolver = new FontResolver();
                var font = new XFont("Arial", 20);

                textFormatter.Alignment = XParagraphAlignment.Center;
                graphics.DrawString("Escala de Serviço", font, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.TopCenter);
                doc.Save("EscalaServiço.pdf");
            }
        }

        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            using (var doc = PdfReader.Open("EscalaServiço.pdf", PdfDocumentOpenMode.Modify))
            {
                var page = doc.Pages[0];
                var graphics = XGraphics.FromPdfPage(page);
                var font = new XFont("Arial", 12);

                // Posiciona o texto do serviço
                graphics.DrawString($"Serviço: {servico.Sigla}", font, XBrushes.Black, new XRect(0, currentYPosition, page.Width, page.Height), XStringFormats.TopCenter);
                currentYPosition += 20; // Incrementa a posição para o próximo texto

                // Posiciona o texto do funcionário
                graphics.DrawString($"Funcionário: {funcionario.Nome}", font, XBrushes.Black, new XRect(0, currentYPosition, page.Width, page.Height), XStringFormats.TopCenter);
                currentYPosition += 20; // Incrementa a posição para o próximo texto

                doc.Save("EscalaServiço.pdf");
            }
        }

        public void AbrirPDF()
        {
            System.Diagnostics.Process.Start("explorer.exe", "EscalaServiço.pdf");
        }
    }
}

