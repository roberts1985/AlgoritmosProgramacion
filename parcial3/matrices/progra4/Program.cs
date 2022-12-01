using System;

namespace buscaElemento {
    class Program {
        static void Main(string[] args){
            int m,n,elemento, resultado;

            Console.Write("Escribe el valor de m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Escribe el valor de n: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m,n];
            llenaMatriz(matriz,m,n);
            Console.Write("Escribe el elemento a buscar: ");
            elemento = int.Parse(Console.ReadLine());
            resultado=contarOcurrencias(matriz,m,n,elemento);
            Console.WriteLine($"Las ocurrencias del elemento son: {resultado}");
        }

        static int contarOcurrencias(int[,] matriz,int m, int n, int elemento){
            int con = 0;

            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    if(matriz[i,j]==elemento){
                        con++;
                    }
                }
            }

            return con;
        }

        static void llenaMatriz(int[,] matriz,int m, int n){
            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    Console.Write($"Escribe el valor de matriz[{i},{j}]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }
    }
}
