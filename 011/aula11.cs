using System;

class Aula11{
    static void Main(){
        
        int[] arrayNumeros = new int[5];

        arrayNumeros[0] = 20;
        arrayNumeros[1] = 40;
        arrayNumeros[2] = 50;
        arrayNumeros[3] = 60;
        arrayNumeros[4] = 70;

        for(int i =0; i<5 ; i++ )
            Console.Write("{0} ", arrayNumeros[i]);
    }

}