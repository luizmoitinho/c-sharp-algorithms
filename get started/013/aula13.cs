using System;


class Aula13{
    static void Main( ){
        
        int [] vetor1 = new int[5];
        int [] vetor2 = new int[5];
        int [] vetor3 = new int[5];
        int [,] matriz = new int[2,5]{ {11,212,10,42,41}, {65,36,398,2474,14} };

        initializeAray(vetor1);
        Console.WriteLine("Elementos do vetor1");
        showArray(vetor1);
   
        Console.WriteLine("BinarySearch\n");
        int search = 5;
        int pos = Array.BinarySearch(vetor1,search);
        Console.WriteLine("Valor {0} está na posição {1} ", search, pos);
        Console.WriteLine("_____________________________________________\n");

        Console.WriteLine("Copy\n");
        Array.Copy(vetor1,vetor2, vetor1.Length);
         showArray(vetor2);
        Console.WriteLine("_____________________________________________");


    }

    static void initializeAray(int[] array){
        Random  random = new Random();
        for(int i=0 ; i < array.Length ; i++ )
           array[i] = random.Next(0,5);
    }

    static void showArray(int[] array){
        foreach(int elem in array)
            Console.Write("{0} ", elem);
        Console.WriteLine("");
    }




}