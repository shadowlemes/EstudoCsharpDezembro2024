using System;
using Cadastro;
using RealizacaoDeCadastros;

namespace Inicio
{
    class Program
    {
        RealizacaoDeCadastrosSistema cadastrosSistema = new RealizacaoDeCadastrosSistema();

        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1 - Cadastro de colaboradores");
            Console.WriteLine("2 - Adicionar Colaboradores");
            Console.WriteLine("3 - Excluir Colaboradores");
            Console.WriteLine("4 - Editar Colaboradores");
            Console.WriteLine("0 - sair");

            short usuario = short.Parse(Console.ReadLine());

            switch (usuario)
            {
                case 1: Console.Clear(); RealizacaoDeCadastrosSistema.QuestionarioCadastro(); break;
                case 2: Console.WriteLine("Excluir Colaboradores");break;
                case 3: Console.WriteLine("Editar Colaboradores"); break;
                case 0: Console.WriteLine("sair"); break;
            }
            
        }
    }
}