//Cálculo del promedio de n números...
using System;

namespace Promedio {
    class Program{
        static void Main(string[] args){
            decimal suma=0m, promedio, m; 
            int n;
            Console.Write("Ingresa el valor de n: ");
            n=int.Parse(Console.ReadLine());
            for(int con=1;con<=n;con++){
                Console.Write($"Escribe el valor {con}: ");
                m=decimal.Parse(Console.ReadLine());
                suma=suma+m;
            }
            promedio=suma/n;
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
