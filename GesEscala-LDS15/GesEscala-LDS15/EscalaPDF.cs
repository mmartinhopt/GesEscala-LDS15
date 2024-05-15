using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    class EscalaPDF
    {
        // Método para criar o PDF com o titulo "Escala de Serviço"
        public void CriarPDF()
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                GlobalFontSettings.FontResolver = new FontResolver();
                var font = new PdfSharp.Drawing.XFont("Arial", 20);

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                graphics.DrawString("Escala de Serviço", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 50, page.Width, page.Height), PdfSharp.Drawing.XStringFormats.TopCenter);
                doc.Save("EscalaServiço.pdf");

            }
        }
        // Método que recebe o serviço e o funcionário e adiciona ao PDF
        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            using (var doc = PdfSharp.Pdf.IO.PdfReader.Open("EscalaServiço.pdf", PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify))
            {
                var page = doc.Pages[0];
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);

                // Define a fonte para o texto do serviço e funcionário
                var font = new PdfSharp.Drawing.XFont("Arial", 12);

                // Define o texto do serviço mais abaixo no documento
                graphics.DrawString($"Serviço: {servico.Sigla}", font, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(0, 150, page.Width, page.Height), PdfSharp.Drawing.XStringFormats.TopCenter);

                // Define o texto do funcionário ainda mais abaixo
                graphics.DrawString($"Funcionário: {funcionario.Nome}", font, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(0, 170, page.Width, page.Height), PdfSharp.Drawing.XStringFormats.TopCenter);

                doc.Save("EscalaServiço.pdf");
            }
        }


        // Método para abrir o PDF
        public void AbrirPDF()
        {
            System.Diagnostics.Process.Start("explorer.exe", "EscalaServiço.pdf");
        }



    }
}
