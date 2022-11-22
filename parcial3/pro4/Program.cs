
using System;

namespace factorialRecursivo{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(factorial(4));
        }

        static int factorial(int n){
            if(n==0 || n==1){
                return 1;
            }else{
                return n*factorial(n-1);
            }
        }
    }
}