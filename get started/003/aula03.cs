using System;


class Aula03{
    static void Main(string[] args){

        //Variavel de 8 bits, armazena valores entre 0 e 255. (2^8) - 1 
        byte n1=1;

        //Tipos primitivos
        int valor    = 0;
        float altura = 1.96f;
        char letra  = 'c';

        //Tipos referencia
        string nome  = "Luiz Carlos Costa Moitinho";

        /*operador => var
        * 1) var => não especifica o tipo da variável. O tipo é feito em tempo e compilação do programa.
        * 2) Uma vez uma variável declarada com var, ela não pode ter seu tipo alterado
        *       ex: var valor =10;
        *           valor = 'luiz';
        */       
    
        var aux = nome;
        Console.WriteLine("\nValor da variável aux: "+aux);
        
        Console.WriteLine("__________________________________________________\n");

        int num1 = 10, num2 = 2;
        Console.WriteLine("O valor da operação: " + num1 + " * " + num2 + " = " + num1*num2);
    }

}