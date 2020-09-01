using System;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.aceleracao(10);
            System.Console.WriteLine(carro1.toString());
        }

        abstract class Veiculo{
            protected int velocidadeMax;
            protected int velocidadeAtual;
            protected bool ligado;

            public Veiculo(){
                this.ligado = false;
                this.velocidadeAtual = 0;
            }

            public void setLigado(bool ligado){
                this.ligado = ligado;
            }
            abstract public void aceleracao(int acelaracao);
            
        }
        class Carro:Veiculo{

            public Carro():base(){
                this.velocidadeMax = 120;
            }

            override public void aceleracao(int acelaracao){
                this.velocidadeAtual += acelaracao;
            }

            public string toString(){
                return(
                    "Vel. maxima....: "+ this.velocidadeMax +"\n"+
                    "Vel. atual.....: "+ this.velocidadeAtual +"\n"+
                    "Ligado.........: "+ (this.ligado ? "Sim" : "Não" ) +"\n"

                );
            }
        }
    }
}
