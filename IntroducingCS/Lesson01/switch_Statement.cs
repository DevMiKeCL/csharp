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
    }
}
