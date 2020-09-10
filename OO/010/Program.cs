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
            Carro[] arrayCarros = new Carro[3];
            
            arrayCarros[0].modelo="HRV";
            arrayCarros[0].cor="Prata";

            arrayCarros[1].modelo="Golf";
            arrayCarros[1].cor="Azul";

            arrayCarros[2].modelo="Fiat argo";
            arrayCarros[2].cor="Preto";
            

            foreach(Carro c in arrayCarros)
                System.Console.WriteLine(c.info());


        }
    }
}
