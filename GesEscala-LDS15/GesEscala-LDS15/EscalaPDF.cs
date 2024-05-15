using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEscala_LDS15
{
    class EscalaPDF
    {
        // Método para criar o PDF
        public void CriarPDF()
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                GlobalFontSettings.FontResolver = new FontResolver();
                var font = new PdfSharp.Drawing.XFont("Arial", 20);

                textFormatter.DrawString("Escala de Serviço", font, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(240, 80, page.Width, page.Height), PdfSharp.Drawing.XStringFormats.TopLeft);

                doc.Save("Escala.pdf");
                System.Diagnostics.Process.Start("explorer.exe", "Escala.pdf");

            }
        }
        
    }
}
