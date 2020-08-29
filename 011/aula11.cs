using System;

class Aula11{
    static void Main(){
        
        int[,] arrayNumeros = new int[3,3];

        arrayNumeros[0,0] = 20;
        arrayNumeros[0,1] = 40;
        arrayNumeros[0,2] = 50;

        arrayNumeros[1,0] = 60;
        arrayNumeros[1,1] = 70;
        arrayNumeros[1,2] = 60;

        for(int i = 0; i<3 ; i++ ){
          for(int j = 0; j<3; j++)
              Console.Write("{0} ",arrayNumeros[i,j]);
          Console.WriteLine("");
        }
    }

}