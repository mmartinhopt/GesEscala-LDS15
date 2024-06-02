// Universidade Aberta
// Licenciatura em Engenharia Informática
// Laboratório de Desenvolvimento de Software
// Projeto: GesEscala
// Grupo: 15 - ByteBrigade (Ricardo Sanches, Marco Martinho, Marcelo Bregieira, António Vieira, José Campos)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    // Classe View - Responsável pela interação com o utilizador e obter os inputs

    public class View
    {
        // Atributos
        private Model model;
        private FormMain janela;
        private List<Funcionario> listaFuncionariosView = null;
        private EscalaDeServicoDiaria escalaDiaria = null;
        private List<Servico> listaServicosView = null;

        // Eventos Funcionarios
        public delegate void PedidoListaFuncionarios(ref List<Funcionario> listaFuncionarios);
        public event PedidoListaFuncionarios PrecisoDeFuncionarios;
        public delegate void EventNovoFuncionario(Funcionario novoFuncionario);
        public delegate void EventRemFuncionario(int id_funcionario);
        public event EventNovoFuncionario RegistoNovoFuncionario;
        public event EventRemFuncionario RemoverFuncionario;
        public delegate void EventImprimirFuncionarios();
        public event EventImprimirFuncionarios GerarPdfFuncionarios;
        public delegate void EventImprimirServicos();
        public event EventImprimirServicos GerarPdfServicos;
        public delegate void EventImprimirEscala(string data);
        public event EventImprimirEscala GerarPdfEscala;

        //Eventos Servicos
        public delegate void PedidoListaServicos(ref List<Servico> listaServicos);
        public event PedidoListaServicos PrecisoDeServicos;

        //Eventos Escalas
        public delegate void PedidoEscalaDiaria(ref EscalaDeServicoDiaria escalaDiaria, DateTime data);
        public event PedidoEscalaDiaria PrecisoDeEscalaDiaria;
        public delegate void EventoNovaEscala(List<(Servico, Funcionario)> novaEscala, DateTime data);
        public event EventoNovaEscala RegistoNovaEscala;


        public delegate void EventNovoServico(Servico novoServico);
        public event EventNovoServico RegistoNovoServico;
        public delegate void EventRemServico(int id_servico);
        public event EventRemServico RemoverServico;


        // Construtor
        internal View(Model m)
        {
            model = m;
        }

        // Métodos
        
        // Método para iniciar a interface gráfica
        public void IniciarInterface()
        {
            // Apresenta o Form inicial FormMain
            janela = new FormMain();
            janela.View = this;
            janela.ShowDialog();
        }

        public void NovoFuncionario(Funcionario novoFuncionario)
        {
            RegistoNovoFuncionario(novoFuncionario);
        }
        public void pdfFuncionarios()
        {
            GerarPdfFuncionarios?.Invoke();
        }
        public void pdfServicos()
        {
            GerarPdfServicos?.Invoke();
        }
     
        public void RemFuncionario(int id_funcionario)
        {
            RemoverFuncionario?.Invoke(id_funcionario);

        }

        public void AtualizarListaFuncionarios(object sender, EventArgs e)
        {
            PrecisoDeFuncionarios(ref listaFuncionariosView);
            PopularFuncionarios();
        }

        public void NovoServico(Servico novoServico)
        {
            RegistoNovoServico?.Invoke(novoServico);
        }
        public void RemServico(int id_servico)
        {
            RemoverServico?.Invoke(id_servico);
        }

        void PopularFuncionarios()
        {
            janela.PopularFuncionarios(ref listaFuncionariosView);
        }

        public void PrecisoDeListaFuncionarios(ref List<Funcionario> listaFuncionariosView)
        {
            PrecisoDeFuncionarios(ref listaFuncionariosView);
            janela.AtualizaListaFuncionarios(ref listaFuncionariosView);
        }

        public void PrecisoDeListaServicos(ref List<Servico> listaServicosView)
        {
            PrecisoDeServicos(ref listaServicosView);
            janela.AtualizarListaServicos(ref listaServicosView);
        }

        public void PrecisoEscalas(ref EscalaDeServicoDiaria escalaDiaria, DateTime data)
        {
            PrecisoDeEscalaDiaria(ref escalaDiaria, data);
            janela.PopularEscalados(ref escalaDiaria);
        }

        public void NovaEscala(List<(Servico, Funcionario)> novaEscala, DateTime data)
        {
            RegistoNovaEscala(novaEscala, data);
        }
        public void GerarEscala(string data)
        {
            GerarPdfEscala?.Invoke(data);
        }

        public void Encerrar()
        {
            //Implementar.
        }
    }
}
