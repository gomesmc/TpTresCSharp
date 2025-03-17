/*Questões 7, 8 e 9*/


namespace Ex7
{
    internal class Program
    {
        public class Matricula
        {
            private string nomeDoAluno;
            private string curso;
            private int numeroMatricula;
            private string situacao;
            private string dataInicial;

            public Matricula(string nome, string curso, int numeroMatricula, string dataInicial)
            {
                nomeDoAluno = nome;
                this.curso = curso;
                this.numeroMatricula = numeroMatricula;
                this.situacao = "Ativa";  
                this.dataInicial = dataInicial;
            }

            public void Trancar()
            {
                situacao = "Trancada";
            }
            public void Reativar()
            {
                situacao = "Ativa";
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine("Nome do Aluno: "+ nomeDoAluno);
                Console.WriteLine("Curso: "+ curso);
                Console.WriteLine("Número da Matrícula: " + numeroMatricula);
                Console.WriteLine("Situação: "+situacao);
                Console.WriteLine("Data Inicial da Matrícula: "+dataInicial);
            }
        }

        static void Main(string[] args)
        {
            Matricula matricula = new Matricula("Maria Clara Gomes", "Análise e Desenvolvimento de Sistemas", 123456, "15/03/2025");

            Console.WriteLine("Informações iniciais da matrícula:");
            matricula.ExibirInformacoes();
            matricula.Trancar();

            Console.WriteLine("\nInformações após trancar matrícula:");
            matricula.ExibirInformacoes();
            matricula.Reativar();

            Console.WriteLine("\nInformações após reativar matrícula:");
            matricula.ExibirInformacoes();
        }
    }
}
