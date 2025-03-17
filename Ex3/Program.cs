namespace Ex3
{
    internal class Program
    {
        public class Ingresso
        {
            public string nomeDoShow;
            public double preco;
            public int quantidadeDisponivel;

            public void AlterarPreco(double novoPreco)
            {
                this.preco = novoPreco;
            }

            public void AlterarQuantidade(int novaQuantidade)
            {
                this.quantidadeDisponivel = novaQuantidade;
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine("Nome do Show: " + nomeDoShow);
                Console.WriteLine("Preço: R$ " + preco);
                Console.WriteLine("Quantidade Disponível: " + quantidadeDisponivel);
            }
        }

        static void Main(string[] args)
        {
            Ingresso ingresso = new Ingresso();

            ingresso.nomeDoShow = "Solomun";
            ingresso.preco = 200;
            ingresso.quantidadeDisponivel = 1000;

            ingresso.ExibirInformacoes();
        }
    }
}
