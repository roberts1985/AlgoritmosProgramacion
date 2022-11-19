using System;

namespace Primo {
    class Program {
        static void Main(string[] args){
            int con=2, n, ban=0;

            Console.Write("Escribe el valor de n: ");
            n=int.Parse(Console.ReadLine());
            while(con<n){
                if(n%con==0){
                    ban=1;
                    break;
                }
                con++;
            }
            if(ban==1){
                Console.WriteLine("No es primo...");
            }else{
                Console.WriteLine("Es primo...");
            }
        }
    }
}