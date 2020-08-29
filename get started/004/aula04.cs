using System;

class Aula04{
    
    static int num = 10;

    static void Main(string[] args){
        int num =0;
        Console.WriteLine("Acessando a variável global num: " + num);
        Console.WriteLine("Chamada do método plu(1,20): "+  plus(1,20));
       
    }

    static int plus(int arg1, int arg2){
        return arg1 + arg2;
    }
}