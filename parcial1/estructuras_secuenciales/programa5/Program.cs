//Venta de pozol
using System;

namespace VentaPozol{
    class Program{
        static void Main(string[] args){
            decimal gramos_producidos, kilos, pago_recibido;

            Console.Write("Ingresa los gramos producidos: ");
            gramos_producidos=decimal.Parse(Console.ReadLine());
            kilos=gramos_producidos*0.0001m;
            pago_recibido=kilos*25;
            Console.WriteLine($"El pago recibido es: {pago_recibido}");
        }
    }
}