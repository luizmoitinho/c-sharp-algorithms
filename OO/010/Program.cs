using System;

namespace _010
{


    struct  Carro
    {
        public string marca;
        public string modelo;
        public string cor;
        public int ano;
        
        public Carro(string marca, string modelo, string cor, int ano){
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structs\n");
            Carro c1 = new Carro("Fiat","grand sien","branco",2017);
            System.Console.WriteLine("Marca..: {0}",c1.marca);
            System.Console.WriteLine("Modelo.: {0}",c1.modelo);
            System.Console.WriteLine("Cor....: {0}",c1.cor);
            System.Console.WriteLine("Ano....: {0}",c1.ano);

        }
    }
}
