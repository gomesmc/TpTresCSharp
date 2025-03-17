namespace Ex5
{
    internal class Program
    {
        public class Ingresso
        {
            private string nomeDoShow;
            private double preco;
            private int quantidadeDisponivel;
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
            public static void Main(String[] args)
            {
                Ingresso ingresso = new Ingresso();

                ingresso.SetNomeDoShow("Solomun");
                ingresso.SetPreco(200.0);
                ingresso.SetQuantidadeDisponivel(1000);

                Console.WriteLine("Primeiro Lote:");
                Console.WriteLine("Nome do show: " + ingresso.GetNomeDoShow());
                Console.WriteLine("Preço: " + ingresso.GetPreco());
                Console.WriteLine("Quantidade disponível: " + ingresso.GetQuantidadeDisponivel());

                ingresso.SetPreco(300.0);  
                ingresso.SetQuantidadeDisponivel(800);  

                Console.WriteLine("\nSegundo Lote: ");
                Console.WriteLine("Nome do show: " + ingresso.GetNomeDoShow());
                Console.WriteLine("Preço: " + ingresso.GetPreco());
                Console.WriteLine("Quantidade disponível: " + ingresso.GetQuantidadeDisponivel());
            }
        }
    }
}

//Os métodos Get e Set são úteis porque são uma forma de acessar e modificar os atributos de um objeto de forma organizada.

