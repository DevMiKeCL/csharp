using System;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            comparacion();
            compara(30);
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
        public static void compara(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("El numero es menor que 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("El numero es menor que 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("el numero es menor que 30");
            }
            else
            {
                Console.WriteLine("el numero es mayor o igual a 30");
            }
        }
    }
}
