using System;
class Program
{
    static void Main()
    {
        //Exercicio 1
        Console.Write ("Digite seu nome: ");
        String nome = Console.ReadLine();
        Console.WriteLine ($"Olá, {nome}! Bem vindo ao C#");

        //Exercicio 2
        Console.Write ("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write ("DIgite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        int soma = n1 + n2;
        Console.WriteLine ($"Olá, {nome}! A soma de {n1} + {n2} é igual a {soma}");

        //Exercicio 3
        Console.Write ("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if(idade >= 18){
            Console.WriteLine ("Você é maior de idade");
        }else{
            Console.WriteLine ("Você é menor de idade");
        }
    }
    
}
