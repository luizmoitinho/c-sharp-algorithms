using System;

namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num);
            Console.Write("Valor dobrado: {0}",num);
        }
    
        static void dobrar(ref int valor){
            valor *= 2;
        }
    }

}
