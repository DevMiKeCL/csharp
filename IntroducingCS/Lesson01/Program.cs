using System;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            comparacion();
        }
        public static void comparacion()
        {
            int number1 = 10;
            int number2 = 20;
            if (number2 > number1)
            {
                Console.WriteLine("Numero 2 es mayor a Numero 1");
            }
            else
            {
                Console.WriteLine("numero 1 es mayor a numero 2");
            }
        }
    }
}
