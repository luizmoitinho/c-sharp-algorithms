using System;


class Aula08{
    enum DiasSemana{Domingo,Segunda, Terça, Quarta,Quinta, Sexta,Sábado}
    
    static void Main(){

        DiasSemana ds = (DiasSemana) 3;
        Console.WriteLine(ds);

        int dsInt = (int) DiasSemana.Sexta;
        Console.Write(dsInt);

    }
}