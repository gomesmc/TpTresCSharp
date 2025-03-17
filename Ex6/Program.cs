namespace Ex6
{
    internal class Program
    {
        public class Ingresso
        {
            private string nomeDoShow;
            private double preco;
            private int quantidadeDisponivel;

            public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
            {
                this.nomeDoShow = nomeDoShow;
                this.preco = preco;
                this.quantidadeDisponivel = quantidadeDisponivel;
            }

            public string GetNomeDoShow()
            {
                return nomeDoShow;
            }

            public void SetNomeDoShow(string novoNome)
            {
                nomeDoShow = novoNome;
            }

            public double GetPreco()
            {
                return preco;
            }

            public void SetPreco(double novoPreco)
            {
                preco = novoPreco;
            }

            public int GetQuantidadeDisponivel()
            {
                return quantidadeDisponivel;
            }

            public void SetQuantidadeDisponivel(int novaQuantidade)
            {
                quantidadeDisponivel = novaQuantidade;
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine("Show: " + nomeDoShow);
                Console.WriteLine("Preço: " + preco);
                Console.WriteLine("Quantidade disponível: " + quantidadeDisponivel);
            }
 
        }
        static void Main(string[] args)
        {
            Ingresso ingresso = new Ingresso("Solomun", 200, 1000);
            Console.WriteLine("Primeiro lote:");
            ingresso.ExibirInformacoes();

            ingresso.SetPreco(250.0);
            ingresso.SetQuantidadeDisponivel(800);

            Console.WriteLine("\nSegundo lote:");
            ingresso.ExibirInformacoes();
        }
    }
}
/* O uso de construtor facilita a criação de objetos porque ao definir todos os valores necessários desde o início,
melhora a legibilidade do código e facilita manutenção. Também evita a necessidade de chamar vários métodos Set separadamente, 
o que pode resultar em problemas durante a inicialização. */