//Negativo, positivo o cero
using System;

namespace Numero{
    class Program {
        static void Main(string[] args){
            int numero;

            Console.Write("Escribe un número: ");
            numero=int.Parse(Console.ReadLine());

            if(numero==0){
                Console.WriteLine("Es cero...");
            }else if(numero>0){
                Console.WriteLine("Es positivo...");
            }else{
                Console.WriteLine("Es negativo...");
            }
        }
    }
}