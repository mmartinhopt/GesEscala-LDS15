using System.Diagnostics;

namespace GesEscala_LDS15
{
    public class EscalaPDF
    {
        private readonly IGeradorRelatorio geradorRelatorio;

        public EscalaPDF(IGeradorRelatorio geradorRelatorio)
        {
            this.geradorRelatorio = geradorRelatorio;
        }

        public void CriarPDF()
        {
            geradorRelatorio.GerarRelatorio();
        }

        public void AdicionarServicoFuncionario(Servico servico, Funcionario funcionario)
        {
            geradorRelatorio.AdicionarServicoFuncionario(servico, funcionario);
        }

        public void AbrirPDF()
        {
            Process.Start("explorer.exe", "EscalaServico.pdf");
        }
    }
}


