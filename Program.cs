using System;
using Cadastro;

namespace Inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de cadastro\n");
            Console.Write("Primeiro nome:");
            string nome = Console.ReadLine()!;
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine()!;
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine()!;
            Console.Write("Sexo: ");
            char sexo = char.Parse(Console.ReadLine()!);
            Console.Write("Ano Nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine()!);



            CadastroPessoa objetoCadastroPessoa = new CadastroPessoa(nome, sobrenome, cidade,sexo, anoNascimento);
            objetoCadastroPessoa.ExibirCadastro();
        }        
    }
}