using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
       
            String player1 = "", player2 = "";

            Console.WriteLine("****** INCIALIZANDO O JOGO ***********");
            System.Console.Write("Nome do player 1: ");
            player1 =System.Console.ReadLine();
            System.Console.Write("Nome do player 2: ");
            player2 =System.Console.ReadLine();


            Jogador j1 = new Jogador(player1);
            Jogador j2 = new Jogador(player2);
            
            Console.WriteLine("Player 1");
            Console.WriteLine(j1.toString());
            Console.WriteLine("Player 2");
            Console.WriteLine(j2.toString());

        }
    }

    public class Jogador
    {

        public string nome;
        public int energia;
        public bool vida;
        
        //Cronstrutor da classe
        public Jogador(string nome){
            this.nome = nome;
            this.energia = 100;
            this.vida = true;
        }
        
        //Cronstrutor da classe
        ~Jogador(){
            System.Console.WriteLine("Jogador {0} foi destuido!",this.nome);
        }

        public string toString()
        {
            return (
                "Nome   : " + this.nome + "\n" +
                "Energia: " + this.energia + "% \n" +
                "Vivo   ? " + this.vida + "\n"
            );
        }

    }
}
