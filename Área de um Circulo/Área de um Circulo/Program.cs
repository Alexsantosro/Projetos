using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_de_um_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis.

            float raio;
            
            // Programa principal.

            Console.WriteLine("Bem vindo ao sistema de calculo de àrea de um circulo");
            Console.WriteLine("Digite o raio do circulo em cm");

            raio = float.Parse(Console.ReadLine());

            float areacirculo = calculoraio(raio);

            Console.WriteLine("A Área total do circulo é:" + areacirculo + "cm");
            Console.ReadLine();
        }
        static float calculoraio(float raiocalculo)
        {
            float raio = Math.Abs(raiocalculo);
            float raiofinal = (raio * raio) * 3.14f;

            return raiofinal;
          
        }
    }
}
