using System;

namespace _017
{
    class Program
    {
        static void Main(string[] args)
        {
           soma(1,2,3);
        }

        static void soma(params int[] n)
        {
            int res = 0;
            foreach(int elem in n)
                res += elem;
            
           Console.WriteLine("Valor total da soma: {0}",res);
            
        }
    }
}
