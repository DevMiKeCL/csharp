using System;

namespace Lesson01
{
    class switch_Statement
    {
        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Operador desconocido");
                    return;
            }
            Console.WriteLine("Resultado es : {0}", result);
            return;
        }
        public static void TestSwitchFallThrough()
        {
            DateTime dt = DateTime.Today;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("hoy es un dia de semana");
                    break;
                default:
                    Console.WriteLine("Hoy es fin de semana");
                    break;
            }
        }
    }
}
