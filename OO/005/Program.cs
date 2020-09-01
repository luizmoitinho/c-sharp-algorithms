using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m = new Moto("Yamaha",110);
            System.Console.WriteLine("Dados da moto");
            System.Console.WriteLine(m.tostring());
            
    }

    class Veiculo{
        public int velAtual;
        private int velMax;
        protected bool ligado;

        public Veiculo(int velMax){
            this.velAtual = 0;
            this.velMax = velMax;
            this.ligado = false;   

        }

        public bool getLigado(){
            return this.ligado;
        }
        public int getVelMax(){
            return this.velMax;
        }

    }

    class Moto:Veiculo{
        public string nome;

        public Moto(string nome, int vm):base(vm){
            this.nome = nome;
            this.ligado = true;
        }

        public string tostring(){
            return(
                "Nome......: "+this.nome +"\n"+
                "Vel.atual.: "+this.velAtual +"\n"+
                "Vel.maxima: "+this.getVelMax() +"\n"+
                "Ligado....: "+ ( this.ligado? "Sim" : "Não" ) +"\n" 
            );
        }

    }
}
