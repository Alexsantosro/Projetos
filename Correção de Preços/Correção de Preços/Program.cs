using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_de_Preços
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delaração de variaveis iniciais.

            float Chocolate;
            float Refrigerante;
            float Bolo;
            float Sorvete;
            float Pão;

            //Captura dos Valores iniciais dos itens.

            Console.WriteLine("Digite o preço do chocolate");
            Chocolate = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do refrigerante");
            Refrigerante = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do bolo");
            Bolo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do sorvete");
            Sorvete = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do pão");
            Pão = float.Parse(Console.ReadLine());

            // Declarando Variaveis Calculadas

            float ChocolateFinal;
            float RefrigeranteFinal;
            float BoloFinal;
            float SorveteFinal;
            float PãoFinal;

            ChocolateFinal = PrecoFinal(Chocolate);
            RefrigeranteFinal = PrecoFinal(Refrigerante);
            BoloFinal = PrecoFinal(Bolo);
            SorveteFinal = PrecoFinal(Sorvete);
            PãoFinal = PrecoFinal(Pão);

            Console.WriteLine("Preço Final do Chocolate é:" +  ChocolateFinal);
            Console.WriteLine("Preço Final do Refrigerante é:" +  RefrigeranteFinal);
            Console.WriteLine("Preço Final do Bolo é:" +  BoloFinal);
            Console.WriteLine("Preço Final do Sorvete é:" +  SorveteFinal);
            Console.WriteLine("Preço Final do Pão é:" + PãoFinal);
            Console.ReadLine();
        }

        static float PrecoFinal(float acrescimo)
        {
            float PrecoAjustado = Math.Abs(acrescimo);
           
            float PreçoFinal = PrecoAjustado * 1.25f;

            return PreçoFinal;
       }


    }
}
