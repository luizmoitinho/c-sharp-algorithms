using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Get value of terminal");
            if(args.GetLength(0)>0)
                Console.WriteLine("Vaor informado: "+args.GetValue(0));
            else
                Console.WriteLine("Por favor, informe um segundo parâmetro, ex: program Luiz");
           
            
        }
    }
}
