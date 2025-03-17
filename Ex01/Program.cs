/*Classe: Serve como molde para criarmos um objeto. Além disso contém os atributos e métodos

 Objeto: É o que surge quando instancio uma classe

 Atribtuos: São os dados/características do objeto os quais definem o estado do mesmo

 Métodos: São ações que o objeto pode realizar
 */
namespace Ex01
{

    namespace TpTres
    {
        internal class Ex01
        {
            public class Carro
            {
                public String marca;
                public int ano;
                public bool carroLigado = false;

                public void AlterarCarro(String novaMarca, int anoLancamento)
                {
                    this.marca = novaMarca;
                    this.ano = anoLancamento;
                }

                public static void Main(String[] args)
                {
                    Carro meuCarro = new Carro();
                    meuCarro.AlterarCarro("Porsche", 1964);
                    meuCarro.mostarInformacoes();
                }
                public void mostarInformacoes()
                {
                    Console.WriteLine("Marca: {0} \nAno: {1]\nCarro está ligado? {2}", marca, ano, carroLigado);
                }
            }
        }
    }
}
    
