// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System.Collections.Generic;
using PdfSharp.Fonts;
using System;

namespace GesEscala_LDS15
{
    // Classe GeradorRelatorioPDF - Implementa a interface IGeradorRelatorio
    public class GeradorRelatorioPDF : IGeradorRelatorio 
    {
        // Atributos
        private List<(Servico, Funcionario)> dados = new List<(Servico, Funcionario)>();
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private List<Servico> servicos = new List<Servico>();
        private List<(Servico, List<Funcionario>)> escalas = new List<(Servico, List<Funcionario>)>();

        // Construtor - Define o FontResolver
        public GeradorRelatorioPDF()
        {
            if (GlobalFontSettings.FontResolver == null)
            {
                GlobalFontSettings.FontResolver = new FontResolver();
            }
        }

        // Método para adicionar escala
        public void AdicionarEscala(Servico servico, List<Funcionario> funcionarios)
        {
            escalas.Add((servico, funcionarios));
        }

        // Método para adicionar funcionário
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        // Método para adicionar serviço
        public void AdicionarServico(Servico servico)
        {
            servicos.Add(servico);
        }

        // Método para adicionar serviço e funcionário
        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            dados.Add((servico, funcionario));
        }

        // Método para gerar o relatório
        public void GerarRelatorio(int numero_relatorio)
        {
            if (numero_relatorio == 1)
            {
                GerarRelatorioFuncionarios(funcionarios); // Relatório de funcionários
            }
            else if (numero_relatorio == 2)
            {
                GerarRelatorioServicos(servicos); // Relatório de serviços
            }
            else if (numero_relatorio == 3)
            {
                GerarRelatorioEscalas(escalas); // Relatório da escala
            }

            // Limpar listas após a geração do relatório
            LimparDados();
        }

        // Método para limpar todas as listas de dados
        private void LimparDados()
        {
            dados.Clear();
            funcionarios.Clear();
            servicos.Clear();
            escalas.Clear();
        }

        // Método para gerar o relatório de serviços
        public void GerarRelatorioServicos(List<Servico> servicos)
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                var fontTitulo = new XFont("Arial", 20);
                var fontConteudo = new XFont("Arial", 12);
                double currentYPosition = 100;

                textFormatter.Alignment = XParagraphAlignment.Center;
                graphics.DrawString("Lista de Serviços", fontTitulo, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.TopCenter);

                // Define as larguras das colunas
                int idColumnWidth = 50;
                int nomeColumnWidth = 120;
                int descricaoColumnWidth = 180;
                int siglaColumnWidth = 50;
                int horaInicioColumnWidth = 80;
                int horaFimColumnWidth = 80;

                // Cabeçalho
                graphics.DrawString("ID", fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, idColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Nome", fontConteudo, XBrushes.Black, new XRect(90, currentYPosition, nomeColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Descrição", fontConteudo, XBrushes.Black, new XRect(210, currentYPosition, descricaoColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Sigla", fontConteudo, XBrushes.Black, new XRect(400, currentYPosition, siglaColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Hora Início", fontConteudo, XBrushes.Black, new XRect(460, currentYPosition, horaInicioColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Hora Fim", fontConteudo, XBrushes.Black, new XRect(540, currentYPosition, horaFimColumnWidth, page.Height), XStringFormats.TopLeft);
                currentYPosition += 20;
                graphics.DrawLine(XPens.Black, 40, currentYPosition, page.Width - 40, currentYPosition);  // Draw a line under headers

                // Desenha os dados dos serviços
                foreach (Servico servico in servicos)
                {
                    currentYPosition += 25;  // Espaçamento entre linhas
                    graphics.DrawString(servico.ID.ToString(), fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, idColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(servico.Nome, fontConteudo, XBrushes.Black, new XRect(90, currentYPosition, nomeColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(servico.Descricao, fontConteudo, XBrushes.Black, new XRect(210, currentYPosition, descricaoColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(servico.Sigla, fontConteudo, XBrushes.Black, new XRect(400, currentYPosition, siglaColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(servico.HoraInicio, fontConteudo, XBrushes.Black, new XRect(460, currentYPosition, horaInicioColumnWidth, page.Height), XStringFormats.TopLeft);
                    graphics.DrawString(servico.HoraFim, fontConteudo, XBrushes.Black, new XRect(540, currentYPosition, horaFimColumnWidth, page.Height), XStringFormats.TopLeft);
                }

                // Guarda o documento
                doc.Save("servicos.pdf");
            }
        }

        // Método para gerar o relatório de funcionários
        public void GerarRelatorioFuncionarios(List<Funcionario> funcionarios)
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
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
                int contactColumnLabelWidth = Convert.ToInt32(page.Width - (50 + 100 + 100 + 100));

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

                // Guarda o documento
                doc.Save("funcionarios.pdf");
            }
        }

        // Método para gerar o relatório da escala
        public void GerarRelatorioEscalas(List<(Servico, List<Funcionario>)> escalas)
        {
            using (var doc = new PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                var fontTitulo = new XFont("Arial", 20);
                var fontConteudo = new XFont("Arial", 12);
                double currentYPosition = 100;
                textFormatter.Alignment = XParagraphAlignment.Center;
                graphics.DrawString("Escala de Serviço", fontTitulo, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.TopCenter);

                // Define as larguras das colunas
                int servicoColumnWidth = 100;
                int siglaColumnWidth = 50;
                int horaInicioColumnWidth = 70;
                int horaFimColumnWidth = 70;
                int numeroColumnWidth = 50;
                int nomeColumnWidth = 100;
                int apelidoColumnWidth = 100;

                // Cabeçalho
                graphics.DrawString("Serviço", fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, servicoColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Sigla", fontConteudo, XBrushes.Black, new XRect(140, currentYPosition, siglaColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Hora Início", fontConteudo, XBrushes.Black, new XRect(190, currentYPosition, horaInicioColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Hora Fim", fontConteudo, XBrushes.Black, new XRect(260, currentYPosition, horaFimColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Número", fontConteudo, XBrushes.Black, new XRect(330, currentYPosition, numeroColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Nome", fontConteudo, XBrushes.Black, new XRect(380, currentYPosition, nomeColumnWidth, page.Height), XStringFormats.TopLeft);
                graphics.DrawString("Apelido", fontConteudo, XBrushes.Black, new XRect(480, currentYPosition, apelidoColumnWidth, page.Height), XStringFormats.TopLeft);
                currentYPosition += 20;
                graphics.DrawLine(XPens.Black, 40, currentYPosition, page.Width - 40, currentYPosition);  // Draw a line under headers

                // Desenha os dados das escalas
                foreach (var escala in escalas)
                {
                    var servico = escala.Item1;
                    var funcionarios = escala.Item2;

                    foreach (var funcionario in funcionarios)
                    {
                        currentYPosition += 25;  // Espaçamento entre linhas
                        graphics.DrawString(servico.Nome, fontConteudo, XBrushes.Black, new XRect(40, currentYPosition, servicoColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(servico.Sigla, fontConteudo, XBrushes.Black, new XRect(140, currentYPosition, siglaColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(servico.HoraInicio, fontConteudo, XBrushes.Black, new XRect(190, currentYPosition, horaInicioColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(servico.HoraFim, fontConteudo, XBrushes.Black, new XRect(260, currentYPosition, horaFimColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(funcionario.Numero.ToString(), fontConteudo, XBrushes.Black, new XRect(330, currentYPosition, numeroColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(funcionario.Nome, fontConteudo, XBrushes.Black, new XRect(380, currentYPosition, nomeColumnWidth, page.Height), XStringFormats.TopLeft);
                        graphics.DrawString(funcionario.Apelido, fontConteudo, XBrushes.Black, new XRect(480, currentYPosition, apelidoColumnWidth, page.Height), XStringFormats.TopLeft);
                    }

                    currentYPosition += 30;  // Espaçamento adicional entre serviços
                    graphics.DrawLine(XPens.Black, 40, currentYPosition, page.Width - 40, currentYPosition);  // Draw a line under each service section
                    currentYPosition += 10;  // Espaçamento adicional após a linha
                }

                // Guarda o documento
                doc.Save("Escala_diaria.pdf");
            }
        }
    }
}
