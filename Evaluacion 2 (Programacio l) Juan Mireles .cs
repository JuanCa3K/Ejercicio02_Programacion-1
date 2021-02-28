using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string vinculo = "";
            int edad = 0;
            double altura = 0;


            //Enunciado

            Console.WriteLine("¡BIENVENIDOS! a ExTreMe ParK JM. ");

            Console.WriteLine("El parque de atracciones mas extremo del mundo ");

            Console.WriteLine("Para ingresar a nuestras instalaciones, es neceserio cumplir con lo siguiente: ");

            Console.WriteLine("---------------------------");

            Console.WriteLine("* Ser mayor de 18 años");

            Console.WriteLine("* Tener una altura mayor a 150 centimetros");

            Console.WriteLine("* IMPORTANTE, este parque no es apto para cardiacos");

            Console.WriteLine("---------------------------");

            //Parametros

            Console.WriteLine("Por favor ingrese su edad:");
            vinculo = Console.ReadLine();
            edad = Convert.ToInt32(vinculo);

            //edad

            if (edad <= 17)
            {
                Console.WriteLine("Lo sentimos, no tienes la edad necesaria para ingresar a -ExTreMe ParK JM-");
            }
            else
            {


            Console.WriteLine("---------------------------");


            Console.WriteLine("Por favor, ingrese su altura (en centimetros)");
            vinculo = Console.ReadLine();
            altura = Convert.ToDouble(vinculo);

            //altura

            if (altura <= 149)
            {
            Console.WriteLine("Lo sentimos, no tienes la altura necesaria para ingresar a -ExTreMe ParK JM-");
            }
            else
            {
            Console.WriteLine("");
            Console.WriteLine("¡ENHORABUENA! cuentas con todo lo necesario para ingresar al parque");
            Console.WriteLine("");
            Console.WriteLine("Disfruta al MAXIMO de todas nuestras instalaciones, Pasala ¡SUPER!");

            //Fin del algoritmo

                }
            }
        }
    }
}
