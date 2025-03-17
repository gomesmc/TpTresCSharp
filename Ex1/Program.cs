using System.Security.Cryptography.X509Certificates;

namespace Ex1
{
    internal class Program
    {
        public class Carro
        {
            public String marca;
            public int ano;
            public bool carroLigado = false;

            public void AlterarInformacoesCarro(String novaMarca, int anoLancamento) 
            {
                this.marca = novaMarca;
                this.ano = anoLancamento;
            }

            public void mostrarInformacoes()
            {
                Console.WriteLine("Marca: {0} \nAno de lançamento: {1} \nCarro ligado: {2}",marca, ano, carroLigado);
            }

            public void modificarEstado()
            {
                if(carroLigado == true)
                {
                    Console.WriteLine("Carro ligou");
                }
                else
                {
                    Console.WriteLine("Carro continua desligado");
                }
            }
            static void Main(string[] args)
            {
                Carro meuCarro=new Carro();
                meuCarro.AlterarInformacoesCarro("Porsche", 1964);
                meuCarro.mostrarInformacoes();
                meuCarro.carroLigado=true;
                meuCarro.modificarEstado();
            }
        }
        
    }
}

/*Classe: Serve como molde para criarmos um objeto. Além disso contém os atributos e métodos -> Carro

 Objeto: É o que surge quando instancio uma classe -> meuCarro

 Atribtuos: São os dados/características do objeto os quais definem o estado do mesmo -> modelo (String) e ano (int)

 Métodos: São ações que o objeto pode realizar ->AlterarInformacoes(String novaMarca, int anoLancamento), modificarEstado(), Main(String[]args)
 */