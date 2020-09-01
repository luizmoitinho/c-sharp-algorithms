using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivada2 d2 = new Derivada2();

        }
    }

    class Base{
        public Base(){
            System.Console.WriteLine("Construtor da classe base.");
        }
    }

    class Derivada1:Base{
        public Derivada1(){
             System.Console.WriteLine("Construtor da classe derivada 1.");
        }

    }

    class Derivada2:Derivada1{
        public Derivada2(){
             System.Console.WriteLine("Construtor da classe derivada 2.");
        }

    }

}
