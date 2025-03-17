/* Questões 10,11,12*/

namespace Ex10
{
    internal class Program
    {
        public class Circulo
        {
            public double raio;

            public Circulo(double raio)
            {
                this.raio = raio;
            }

            public double CalcularArea()
            {
                return Math.PI * (raio * raio);
            }
        }

        public class Esfera
        {
            public double raio;

            public Esfera(double raio)
            {
                this.raio = raio;
            }

            public double CalcularVolume()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            }
            public class TestaFiguras
            {
                static void Main(string[] args)
                {
                    Circulo circulo = new Circulo(3.0); 
                    Esfera esfera = new Esfera(5.0);   

                    Console.WriteLine("Área do Círculo com raio 3.0: " + string.Format("{0:F2}", circulo.CalcularArea()));

                    Console.WriteLine("Volume da Esfera com raio 5.0: " + string.Format("{0:F2}", esfera.CalcularVolume()));
                }
            }
        }
    }
}