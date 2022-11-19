//Compumax
using System;

namespace CompuMax{
    class Program{
        static void Main(string[] args){
            decimal precio_equipo, descuento, precio_final;

            Console.Write("Escribe el precio del equipo: ");
            precio_equipo=decimal.Parse(Console.ReadLine());
            if(precio_equipo>15500m){
                descuento=precio_equipo*0.16m;
            }else{
                descuento=precio_equipo*0.07m;
            }
            precio_final=precio_equipo-descuento;
            Console.WriteLine($"El precio final del equipo es: {precio_final}");
            Console.WriteLine($"El descuento es de {descuento} pesos");
        }
    }
}
