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
            System.Console.WriteLine("Teste de velocidade");
            for(int i=1; veloster.vAtual < veloster.vMax; i++ ){
                veloster.acelerar(i);
               
            }
            System.Console.WriteLine("\n# Linha de chegada!!! Desacelerando\n");
            for(int i = veloster.vMax; i >= 0 ; i-- ){
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

        private int[] marchas = new int[5]{1,2,3,4,5};
        public int marchaAtual{
            get{
                if(this.velocidadeAtual<=15)
                   return marchas[0];

                else if(this.velocidadeAtual <=45 )
                   return marchas[1];

                else if(this.velocidadeAtual < 80 )
                   return marchas[2];

                 else if(this.velocidadeAtual >=80 && this.velocidadeAtual > 99 )
                    return marchas[3];

                else
                    return marchas[4];
                
            } 
            set{} 
        }


        public int vAtual { get{
            return velocidadeAtual;
            } 
            set{
                this.velocidadeAtual = value;
            } 
        }
        public int vMax{ 
            get {
                return this.velocidadeMaxima;
            } 
            set{
                this.velocidadeMaxima = value;
            }
        }
        private string nome;

        public Carro(string nome){
            this.nome = nome;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = 120;
        }

        
        override public void acelerar(int acelerar){
            if(acelerar>0 && vAtual <=120){
                if(acelerar + vAtual >= 120)
                    vAtual = 120;
                else
                    vAtual = vAtual + acelerar;
                System.Console.WriteLine("Acelerando......VrUUUuuuMMmm");    
                System.Console.WriteLine("Marcha..........: {0}", marchaAtual);       
                System.Console.WriteLine("Velocidade atual: {0}", vAtual);  
            }


        }

        override public void frear(){
            if(vAtual-2>=0){
                System.Console.WriteLine("Reduzindo a velocidade em -2");
                System.Console.WriteLine("Velocidade atual: {0}", vAtual);  
                vAtual = vAtual-2;
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
