using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio;
            Console.WriteLine("Digite nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio es: " + promedio);
            if (promedio >= 3)
            {
                Console.WriteLine("El estudiante ganó la asignatura");
            }
            else
            {
                Console.WriteLine("El estudiante perdió la asignatura");
            }
        }
    }
}using System;

        
    

