using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_um_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
        
        float BaseTriangulo;
        float AlturaTriangulo;


        Console.WriteLine("Bem vindo ao programa para calculo da área de um triangulo");

        Console.WriteLine("Digite a base do trinagulo em cm");
        BaseTriangulo = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do Trinagulo em cm");
        AlturaTriangulo = float.Parse(Console.ReadLine());

            float AreaFinal = AreaTriangulo(BaseTriangulo, AlturaTriangulo);

            Console.WriteLine("A área total do triangulo é:" + AreaFinal + "cm²");
            Console.ReadLine();
        }

        static float AreaTriangulo(float a, float b)
        {
            float BaseT = Math.Abs(a);
            float AlturaT = Math.Abs(b);

            float AreaFinal = (BaseT * AlturaT) / 2;

            return AreaFinal;
        }

    }
}
