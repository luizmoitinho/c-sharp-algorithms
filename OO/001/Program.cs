using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {

            String player1 = "", player2 = "";
            int opcao=1;
            Jogador j1;
            Jogador j2;

            Console.WriteLine("****** INCIALIZANDO O JOGO ***********");
            System.Console.WriteLine("[1] - Jogo rápido");
            System.Console.WriteLine("[2] - Carreira (dupla)");
            System.Console.Write("Opção: ");
            opcao = Convert.ToInt32(System.Console.ReadLine());

            if(opcao == 1){

                j1 = new Jogador();
                j2 = new Jogador();

                Console.WriteLine(j1.nome);
                Console.WriteLine(j1.toString());
                Console.WriteLine(j2.nome);
                Console.WriteLine(j2.toString());

            }else if(opcao == 2){
                System.Console.Write("Nome do player 1: ");
                player1 = System.Console.ReadLine();
                System.Console.Write("Nome do player 2: ");
                player2 = System.Console.ReadLine();

                j1 = new Jogador(player1);
                j2 = new Jogador(player2);

                Console.WriteLine("Player 1");
                Console.WriteLine(j1.toString());
                Console.WriteLine("Player 2");
                Console.WriteLine(j2.toString());

            }else{
                System.Console.WriteLine("GAME OVER :/! Não existe essa modalidade de jogo ainda.");
            }



        }
    }

    public class Jogador
    {
        private Random random = new Random();
        
        public string nome;
        public int energia;
        public bool vida;

        //Cronstrutor da classe
        public Jogador()
        {   
            this.nome = "Sem nome";
            this.energia = 100;
            this.vida = true;
        }
        public Jogador(string nome)
        {
            this.nome = nome;
            this.energia = 100;
            this.vida = true;
        }

        public Jogador(string nome, int energia, bool vida)
        {
            this.nome = nome;
            this.energia = energia;
            this.vida = vida;
        }


        //Cronstrutor da classe
        ~Jogador()
        {
            System.Console.WriteLine("Jogador \"{0}\" foi destuido!", this.nome);
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
