using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos calculo = new Calculos(10,30);

            Console.WriteLine("{0} + {1} = {2}",calculo.valor1,calculo.valor2,calculo.Soma());
        }
    }

    class Calculos{
        public int valor1;
        public int valor2;

        public Calculos(int valor1, int valor2){
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public int Soma(){
            return this.valor1+this.valor2;
        }
    }
}
