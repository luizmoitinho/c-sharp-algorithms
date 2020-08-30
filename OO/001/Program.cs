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
                j2.setEnergia(-110);
                Console.WriteLine(j1.getNome());
                Console.WriteLine(j1.toString());
                Console.WriteLine(j2.getNome());
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
                j2.setEnergia(100);
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
        
        private string nome;
        private int energia;
        private bool vida;


        public string getNome(){
            return this.nome;
        }
        public void setNome(int energia){
            this.energia = energia;
        }

        public int getEnergia(){
            return this.energia;
        }
        public void setEnergia(int energia){
            
            if(energia < 0){
                if(this.getEnergia() + energia < 0)
                    this.energia = 0;
                else
                    this.energia += energia;

            }
            else{
                  if(this.getEnergia() + energia > 100)
                    this.energia = 100;
                else
                    this.energia += energia;
            }

        }


        public bool getVida(){
            return this.vida;
        }
        public void setVida(bool vida){
            this.vida = vida;
        }


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
            System.Console.WriteLine("Jogador \"{0}\" foi destruido!", this.nome);
        }

        public string toString()
        {
            return (
                "Nome   : " + this.getNome() + "\n" +
                "Energia: " + this.getEnergia() + "% \n" +
                "Vivo   ? " + this.getVida() + "\n"
            );
        }

    }
}
