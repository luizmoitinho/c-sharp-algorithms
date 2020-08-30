using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****** INCIALIZANDO O JOGO ***********");
            Inimigo inimigo1 = new Inimigo("Hunter");
            Inimigo inimigo2 = new Inimigo("Fox");

            Console.WriteLine("\n# Inimigos ");
            System.Console.WriteLine(inimigo1.toString());
            System.Console.WriteLine(inimigo2.toString());

            Console.WriteLine("# Jogador");
            Jogador.iniciar("Luiz");
            System.Console.WriteLine(Jogador.toString());

            Console.WriteLine("\n @ Inimigos em estado de alerta! ");
            Inimigo.alerta=true;
            Console.WriteLine("\n# Inimigos ");
            System.Console.WriteLine(inimigo1.toString());
            System.Console.WriteLine(inimigo2.toString());



        }
    }


    class Inimigo{
        static public bool alerta;
        public string nome;

        public Inimigo(string nome){
            alerta = false;
            this.nome = nome;
        }

        public string toString(){
            return(
                "Nome   : " + this.nome + "\n" +
                "Alerta: " + alerta + "\n"
            );
        }
    }
    static public class Jogador
    {
    
        static public string nome;
        static public int energia;
        static public bool vida;

        //Cronstrutor da classe
        static public void iniciar()
        {   
            nome = "Sem nome";
            energia = 100;
            vida = true;
        }
       static public void iniciar(string n)
        {
            nome = n;
            energia = 100;
            vida = true;
        }

       static  public void iniciar(string n, int e, bool v)
        {
            nome = n;
            energia = e;
            vida = v;
        }


       static public string toString()
        {
            return (
                "Nome   : " + nome + "\n" +
                "Energia: " + energia + "% \n" +
                "Vivo   ? " + vida + "\n"
            );
        }

    }
}
