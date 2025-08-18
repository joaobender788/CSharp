using System;
class Program{

    static void Main(){

        //Exercício 6
        Console.WriteLine("Digite seu nome: ");
        String nome = Console.ReadLine();
        Console.WriteLine("Digite sua primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3)/3;

        if(media >= 7){
            Console.WriteLine($"{nome} está aprovado. Média: {media}.");
        }else{
            Console.WriteLine($"{nome} está reprovado. Média: {media}.");
        }  

        Console.WriteLine("Digite qualquer tecla para sair.");
        Console.ReadKey();
    }
}
