using System;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro veloster = new Carro("Veloster M1");
            System.Console.WriteLine("Dados do carro");
            System.Console.WriteLine(veloster.toString());
            System.Console.WriteLine("===================================");
            const int tamanhoPista = 20;
            System.Console.WriteLine("Teste de velocidade");
            for(int i=1; i < tamanhoPista; i++ ){
                veloster.acelerar(i);
            }
            System.Console.WriteLine("\n# Linha de chegada!!! Desacelerando\n");
            for(int i = veloster.getVelocidadeMaxima(); i >= 0 ; i-- ){
                veloster.frear();
            }

        }
    }

    /*
    * Sealed => Não pode ser herdada.
    *
    */

    abstract class Veiculo{

        abstract public void acelerar(int acelerar);
        abstract public void frear();


    }

    sealed class Carro : Veiculo{
        private int velocidadeAtual;
        private int velocidadeMaxima;
        private string nome;

        public Carro(string nome){
            this.nome = nome;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = 120;
        }

        
        public void setVelocidadeMax(int velocidadeMax){
            this.velocidadeMaxima =  velocidadeMax;
        }
        public int getVelocidadeMaxima(){
            return this.velocidadeMaxima;
        }
        
        public void setVelocidadeAtual(int velocidadeAtual){
            this.velocidadeAtual =  velocidadeAtual;
        }
        public int getVelocidadeAtual(){
            return this.velocidadeAtual;
        }


        public void setNome(string nome){
            this.nome =  nome;
        }
        public string getNome(){
            return this.nome;
        }

        override public void acelerar(int acelerar){
            if(acelerar>0 && this.getVelocidadeAtual() <=120){
                if(acelerar + this.getVelocidadeAtual() >= 120)
                    this.setVelocidadeAtual(120);
                else
                    this.setVelocidadeAtual(this.getVelocidadeAtual() + acelerar);
                System.Console.WriteLine("Acelerando...");    
                System.Console.WriteLine("Velocidade atual: {0}", this.getVelocidadeAtual());       
            }


        }

        override public void frear(){
            if(this.getVelocidadeAtual()-2>0){
                System.Console.WriteLine("Reduzindo a velocidade em -2");
                System.Console.WriteLine("Velocidade atual: {0}", this.getVelocidadeAtual());  
                this.setVelocidadeAtual(this.getVelocidadeAtual()-2);
            }
           
        }

        public string toString(){
            return(
                "Nome..........: "+ this.nome +"\n"+
                "Vel. atual....: "+ this.velocidadeMaxima +"\n"+
                "Vel. Máxima...: "+ this.velocidadeMaxima +"\n"
            );
        }
        
    }
}
