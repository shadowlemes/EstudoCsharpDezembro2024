using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Perguntas();
    }
    static void Perguntas()
    {
        string nome;
        int ano = 0;
        int data = DateTime.Now.Year;       
        Console.Write("Insira seu nome: ");
        nome = Console.ReadLine()!;
        Console.Clear();
        Console.Write("Qual sua data de nascimento? ");
        ano = int.Parse(Console.ReadLine()!);
        int calculoIdade = data - ano;
        Console.Clear();
    }
}
