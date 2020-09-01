﻿using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Veloster","Prata");
            c1.ligar(); 
            System.Console.WriteLine("Dados do veículo");
            System.Console.WriteLine(c1.tostring());

        }   
    }

    //Classe base
    class Veiculo {
        private int velMax;
        private bool ligado;
        private int rodas;

        public void ligar(){
            this.setLigado(true);
        }
        public void desligar(){
            this.setLigado(false);
        }

        protected void setLigado(bool ligado){
            this.ligado = ligado;
        }

        protected bool getLigado(){
            return this.ligado;
        }

        
        protected int getVelMax(){
            return this.velMax;
        }

        public void setVelMax(int velMax){
            this.velMax = velMax;
        }

        protected int getRodas(){
            return this.rodas;
        }

        public void setRodas(int rodas){
            this.rodas = rodas;
        }

    }

    //Classe derivada (Carro) extends a classe base  (Veiculo)
    class Carro:Veiculo{
        private string nome;
        private string cor;
        
        public Carro(string nome, string cor){
            this.desligar();
            this.setRodas(4);
            this.setVelMax(120);
            this.setNome(nome);
            this.setCor(cor);

        }

        public string getCor(){
            return this.cor;
        }

        public void setCor(string cor){
            this.cor = cor;
        }


        public string getNome(){
            return this.nome;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public string tostring(){
            return(
                "Nome......: "+this.getNome() +"\n"+
                "Cor.......: "+this.getCor() +"\n"+
                "Vel.maxima: "+this.getVelMax() +"\n"+
                "Rodas.....: "+this.getRodas() +"\n" + 
                "Ligado....: "+this.getLigado() +"\n" 
            );
        }

    }
}
