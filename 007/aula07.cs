using System;


class Aula07{
    static void Main(){
        int valor1,valor2,soma;

        Console.Write("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());  

        Console.Write("A soma do de {0} + {1} é igual a {2}",valor1,valor2, valor1+valor2);

    }
}