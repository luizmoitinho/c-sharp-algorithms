using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Base Ref; 
            Derivada1 d1 = new Derivada1();
            Derivada2 d2 = new Derivada2();
            System.Console.WriteLine("\n\nInstancia de Derivada 1");
            Ref = d1;
            Ref.info();
            System.Console.WriteLine("\n\nInstancia de Derivada 2");
            Ref = d2;
            Ref.info();
           
        }
    }

    class Base{
        public Base(){
            System.Console.WriteLine("Construtor da classe base.");
        }

        virtual public void info(){}
    }

    class Derivada1:Base{
        public Derivada1(){
             System.Console.WriteLine("Construtor da classe derivada 1.");
        }

        override public void info(){
            System.Console.WriteLine("Derivada1");
        }

    }

    class Derivada2:Derivada1{
        public Derivada2(){
             System.Console.WriteLine("Construtor da classe derivada 2.");
        }

        override public void info(){
            System.Console.WriteLine("Derivada2");
        }

    }

}
