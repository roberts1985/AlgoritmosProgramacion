//Serie Fibonacci con while
using System;

namespace Fibo{
    class Program{
        static void Main(string[] args){
            int p1=1, p2=1, n, suma, con=3;

            Console.Write("Ingresa el número de elementos de la serie: ");
            n=int.Parse(Console.ReadLine());
            Console.Write($"{p1}, {p2}");

            while(con<=n){
                suma=p1+p2;
                Console.Write($", {suma}");
                p1=p2;
                p2=suma;
                con++;
            }
        }
    }
}
