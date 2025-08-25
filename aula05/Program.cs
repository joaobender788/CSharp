using System;
public class Aluno{
    public String nome {get; set;}
    String matricula {get; set;}
    float nota1 {get; set;}
    float nota2 {get; set;}
    float media {get; set;}

    public void pedirDados(){
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o número da sua matrícula: ");
        matricula = Console.ReadLine();
        Console.WriteLine("Digite a nota 1: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2:");
        nota2 = float.Parse(Console.ReadLine());
    }

    public void calcularMedia(){
        media = (nota1 + nota2)/2;
    }

    public void exibirDados(){
        Console.WriteLine($"\nALuno: {nome}");
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Média: {media}");
        Console.Write("Situação: ");
    }

    public void apvRpv(){
        if(media >= 7){
            Console.WriteLine("Aprovado.");
        }else if(media<7 && media>=4){
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
