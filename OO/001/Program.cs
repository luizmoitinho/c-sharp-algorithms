using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            j1.nome = "fox";

            Console.WriteLine("Dados do jogador");
            j1.energia=90;
            Console.WriteLine(j1.toString());

        }
    }

    public class Jogador
    {

        public string nome;
        public int energia = 100;
        public bool vida = true;

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
