//Números primos con while
using System;

namespace Primos{
    class Program{
        static void Main(string[] args){
            int con=1, n, conCeros=0;
            Console.Write("Escribe el valor de n: ");
            n=int.Parse(Console.ReadLine());
            while(con<=n){
                if(n%con==0){
                    conCeros++;
                }
                con++;
            }
            if(conCeros==2){
                Console.WriteLine("El número es primo...");
            }else{
                Console.WriteLine("El número no es primo...");
            }
        }
    }
}
