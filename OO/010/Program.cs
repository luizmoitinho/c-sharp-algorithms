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

        public string info(){
            return(
                "Marca....:"+this.marca+"\n"+
                "Modelo...:"+this.modelo+"\n"+
                "Cor......:"+this.cor+"\n"+
                "Ano......:"+this.ano+"\n"
            );
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structs\n");
            Carro c1 = new Carro("Fiat","grand sien","branco",2017);
             System.Console.WriteLine(c1.info());

        }
    }
}
