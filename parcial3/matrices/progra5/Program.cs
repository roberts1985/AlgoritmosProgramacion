using System;

namespace tablaMultiplicar {
    class Program{
        static void Main(string[] args){
            int[,] tabla = new int[10,10];

            llenaTabla(tabla);
            imprimirTabla(tabla);
        }

        static void imprimirTabla(int[,] matriz){
            for(int i=0;i<10;i++){
                for(int j=0;j<10;j++){
                    Console.Write($"{matriz[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void llenaTabla(int[,] matriz){
            for(int i=0;i<10;i++){
                for(int j=0;j<10;j++){
                    matriz[i,j] = (i+1)*(j+1);
                }
            }
        }
    }
}
