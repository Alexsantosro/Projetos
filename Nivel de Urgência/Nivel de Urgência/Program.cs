using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_de_Urgência
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a variavel 
         int urg;

            //Capturando o nivel de urgência
            Console.WriteLine("Digite o nivel de urgência do pedido");
            urg = int.Parse(Console.ReadLine());

            //Condições

            if (urg <= 3 && urg >= 0)
            {
                Console.WriteLine("Nivel de Urgencia Baixo");
            }
            else if (urg >= 4 && urg <= 6)
            {
                Console.WriteLine("Nivel de Urgencia Medio");
            }
            else if (urg >= 7 && urg <= 9)
            {
                Console.WriteLine("Nivel de urgência Alto");
            }
            else if (urg > 9)
            {
                Console.WriteLine("Nìvel de urgênca Grave");
            }
            Console.ReadLine();
        }
    }
}
