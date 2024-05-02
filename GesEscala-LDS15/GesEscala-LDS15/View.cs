using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public class View
    {
        private Model model;
        private FormMain janela;

        public View(Model m)
        {
            model = m;
            // Inscrição nos eventos
            model.ConfiguracaoInicialSaved += ApresentarConfiguracaoInicial;
            model.DadosMesUpdated += ApresentarDadosMes;
            model.DiaSelecionadoUpdated += ApresentarDiaSelecionado;
            model.ServicoSelecionadoUpdated += ApresentarServicoSelecionado;
            model.EscalaPDFGenerated += ApresentarEscalaPDF;
        }
        
        // Método para ativar a interface
        // A interface inicial poderá ter duas formas
        // 1ª - Janela de configuração inicial
        // 2ª - Janela de visualização da escala em uso

        public void MostrarMenuConfiguracaoInicial()
        {
            // Implementar lógica para solicitar informações iniciais
            FormConfiguracaoInicial form = new FormConfiguracaoInicial(model);
            form.ShowDialog();
        }

        public void MostrarOpcoesConfiguracao()
        {
            // Implementar lógica para mostrar as opções de alterar configuração ou escalar
            FormOpcoesConfiguracao form = new FormOpcoesConfiguracao();
            form.ShowDialog();
        }


        // Métodos para apresentar mensagens
        private void ApresentarConfiguracaoInicial(string message)
        {
            MessageBox.Show(message);
        }

        private void ApresentarDadosMes(string message)
        {
            MessageBox.Show(message);
        }

        private void ApresentarDiaSelecionado(string message)
        {
            MessageBox.Show(message);
        }

        private void ApresentarServicoSelecionado(string message)
        {
            MessageBox.Show(message);
        }

        private void ApresentarEscalaPDF(string message)
        {
            MessageBox.Show(message);
        }

        public void Encerrar()
        {
            janela.Encerrar();
        }
    }
}
