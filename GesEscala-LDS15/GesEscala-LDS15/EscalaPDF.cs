// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GesEscala_LDS15
{

    // Classe EscalaPDF que contém os métodos para gerar o PDF
    public class EscalaPDF
    {
        private readonly IGeradorRelatorio geradorRelatorio;
        private readonly Model model;

        public EscalaPDF(IGeradorRelatorio geradorRelatorio, Model model)
        {
            this.geradorRelatorio = geradorRelatorio;
            this.model = model;
        }

        // Método para criar o PDF
        public void CriarPDF(int n)
        {
            if (n == 1)
            {
                geradorRelatorio.GerarRelatorio(1);
            }
            if (n == 2)
            {
                geradorRelatorio.GerarRelatorio(2);
            }
            if (n == 3)
            {
                geradorRelatorio.GerarRelatorio(3);
            }
        }


        // Método para abrir o PDF gerado 1, funcionarios 2, servicos 3, escalas
        public void AbrirPDF(int relatorio)
        {
            if (relatorio == 1)
            {
                Process.Start("explorer.exe", "funcionarios.pdf");
            }
            if (relatorio == 2)
            {
                Process.Start("explorer.exe", "servicos.pdf");
            }
            if (relatorio == 3)
            {
                Process.Start("explorer.exe", "Escala_diaria.pdf");
            }
        }

        // Método para gerar um relatório da lista de funcionários
        public void GerarRelatorioFuncionarios(List<Funcionario> funcionarios)
        {
            try
            {
                foreach (Funcionario funcionario in funcionarios)
                {
                    geradorRelatorio.AdicionarFuncionario(funcionario);
                }
                CriarPDF(1);
                AbrirPDF(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório de funcionários: {ex.Message}");
            }
        }

        // Método para gerar um relatório da lista de serviços
        public void GerarRelatorioServicos()
        {
            try
            {
                List<Servico> listaServicos = new List<Servico>();
                model.GetListaServicos(ref listaServicos);

                foreach (Servico servico in listaServicos)
                {
                    geradorRelatorio.AdicionarServico(servico);
                }

                CriarPDF(2);
                AbrirPDF(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório de serviços: {ex.Message}");
            }
        }

        // Método para gerar um relatório da escala
        public void GerarRelatorioEscala(ref EscalaDeServicoDiaria escalaDiaria)
        {
            try
            {
                foreach (var servicoComFuncionarios in escalaDiaria.ServicosComFuncionarios)
                {
                    geradorRelatorio.AdicionarEscala(servicoComFuncionarios.Servico, servicoComFuncionarios.Funcionarios);
                }

                CriarPDF(3);
                AbrirPDF(3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório de escala: {ex.Message}");
            }
        }
    }
}
