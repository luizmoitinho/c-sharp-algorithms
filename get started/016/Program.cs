using System;

namespace _016
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 2;
            int quociente, resto;
            quociente = divide(num1,num2, out resto);
            Console.WriteLine("Quociente: {0} | Resto: {1}",quociente,resto);
        }

        static int divide(int dividendo, int divisor, out int resto){
            int quociente;
            quociente = dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }
    }
}
