using System;
using System.Globalization;

public class Aluno{
    public string Nome {get; set;}
    public string Matricula {get; set;}
    public float Nota1 {get; set;}
    public float Nota2 {get; set;}
    public float Media {get; set;}

    public void pedirDados(){
        Console.WriteLine("Digite seu nome: ");
        Nome = Console.ReadLine();
        Console.WriteLine("Digite o número da sua matrícula: ");
        Matricula = Console.ReadLine();
        Console.WriteLine("Digite a nota 1: ");
        Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a nota 2:");
        Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }

    public void calcularMedia(){
        Media = (Nota1 + Nota2)/2;
    }

    public void exibirDados(){
        Console.WriteLine($"\nAluno: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Média: {Media}");
        Console.Write("Situação: ");
    }

    public void apvRpv(){
        if(Media >= 7){
            Console.WriteLine("Aprovado.");
        }else if(Media<7 && Media>=4){
            Console.WriteLine("Recuperação.");
        }else{
            Console.WriteLine("Reprovado.");
        }
    }
}

class Program{
    public static void Main(){
        Aluno aluno = new Aluno();
        
        aluno.pedirDados();
        aluno.calcularMedia();
        aluno.exibirDados();
        aluno.apvRpv();
    }
}

        aluno.calcularMedia();
        aluno.exibirDados();
        aluno.apvRpv();
    }
}
