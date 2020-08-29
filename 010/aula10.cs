using System;

class Aula10{
    static void Main(){

        float nota1=0,nota2=0,nota3=0;
        Console.WriteLine("======= NOTAS DOS ALUNOS ===========");

        Console.Write("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3)/3;

        string statusAluno="";
        if(media>=6)
            statusAluno = "Aprovado";
        else if(media<6 && media >=5)
            statusAluno = "Recuperação";
        else
            statusAluno = "Reprovado";

        Console.Write("Situação do aluno: {0} com média {1}", statusAluno,media);

    }
}