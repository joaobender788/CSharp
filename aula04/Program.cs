using System;

public class Aluno{
    String nome;
    String matricula;
    float nota1;
    float nota2;

    public pedirDados(){
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o número da sua matrícula: ");
        matricula = Console.ReadLine();
        Console.WriteLine("Digite a nota 1: ");
        nota1 = parseFloat(Console.ReadLine());
        Console.WriteLine("Digite a nota 2:");
        nota1 = parseFloat(Console.ReadLine());
    }

    public calcularMedia(){
        float media = (nota1 + nota2)/2;
    }

    public apvRpv(){
        if(media >= 7){
            Console.WriteLine("Você está aprovado.");
        }else if(media<7 && media>=4){
            Console.WriteLine("Você está de recuperação.");
        }else{
            Console.WriteLine("Você está reprovado.")
        }
    }
}

class Program{
    public void Main(){
        
    }
}
