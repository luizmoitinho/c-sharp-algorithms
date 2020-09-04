using System;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }

    public interface Veiculo{

        void ligar();
        
        void desligar();
        void acelerar();


    }
    
    public interface Combate{

        void disparar();


    }

    class Carro: Veiculo, Combate{

        private bool ligado;
        private int velAtual;
        private int municao;

        public Carro(){
            this.ligado = false;
            this.velAtual = 0;
            this.municao = 100;
        }

        public void acelerar(){
            this.velAtual += 2;
        }

        public void ligar(){
            this.ligado = true;
        }

        public void desligar(){
            this.ligado = false;
        }

        public bool getLigado(){
            return this.ligado;
        }

        public void disparar(){
            System.Console.WriteLine("---->>>");
            this.municao--;
        }


    }


}
