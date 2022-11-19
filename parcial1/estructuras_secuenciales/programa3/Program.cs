//Determina el área y el perímetro de un rectángulo
using System;

namespace rectangulo{
    class Program{
        static void Main(string[] args){
            decimal bbase, altura, area, perimetro; 

            Console.Write("Escribe la base del rectángulo: ");
            bbase=decimal.Parse(Console.ReadLine());
            Console.Write("Escribe la altura del rectángulo: ");
            altura=decimal.Parse(Console.ReadLine());
            area=bbase*altura;
            perimetro=2*bbase+2*altura;
            Console.WriteLine($"El área del rectángulo es: {area}");
            Console.WriteLine($"El perímetro es: {perimetro}");
        }
    }
}