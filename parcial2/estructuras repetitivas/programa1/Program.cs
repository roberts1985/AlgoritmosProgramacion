//Suma diez cantidades con while
using System;

namespace SumaMientras{
    class Program{
        static void Main(string[] args){
            int suma=0,num;

            for(int con=1;con<=10;con++){
                Console.Write("Escribe un número: ");
                num=int.Parse(Console.ReadLine());
                suma=suma+num;
            }
            Console.WriteLine($"La suma es: {suma}");
        }
    }
}