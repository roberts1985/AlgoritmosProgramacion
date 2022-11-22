using System;

namespace funcionRecursiva{
    class Program{
        static void Main(string[] args){
            cuenta_regresiva(7);
        }

        static void cuenta_regresiva(int n){
            if(n==0){
                Console.WriteLine("Boom!");
            }else{
                Console.WriteLine(n);
                cuenta_regresiva(n-1);
            }
        }
    }
}
