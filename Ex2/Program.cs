using System.Security.Cryptography.X509Certificates;

namespace Ex2
{
    internal class Program
    {

        public class Ingresso
        {
            public string nomeDoShow;
            public double preco;
            public int quantidadeDisponivel;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
/*
O atributo Ingresso é importante porque controlar a entrada de pessoas no show e manter a segurança
O atributo preço é importante para a receita da banda/artista
O atributo quantidadeDisponivel é importante para medir o sucesso da banda pela quantidade de ingressos vendidos
 */