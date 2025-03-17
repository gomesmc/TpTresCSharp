﻿namespace Ex04
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
            Console.WriteLine("Show: " + nomeDoShow);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Quantidade disponível: " + quantidadeDisponivel);
        }
    }
}
namespace Ex04
{
    public class AppIngresso
    {
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