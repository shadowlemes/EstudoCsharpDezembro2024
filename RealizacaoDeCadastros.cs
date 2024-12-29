using System;
using Cadastro;
using Inicio;

namespace RealizacaoDeCadastros
{
    class RealizacaoDeCadastrosSistema
    {
        public static void QuestionarioCadastro()
        {
            string nome = string.Empty;
            string sobrenome = string.Empty;
            string cidade = string.Empty;
            char sexo = '\0';
            int anoNascimento = 0;

            Console.WriteLine("Sistema de cadastro\n");

            while (true)
            {
                try
                {
                    Console.Write("Primeiro nome: ");
                    nome = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new ArgumentException("O nome não pode ser vazio.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}. Tente novamente.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Sobrenome: ");
                    sobrenome = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(sobrenome))
                    {
                        throw new ArgumentException("O sobrenome não pode ser vazio.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}. Tente novamente.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Cidade: ");
                    cidade = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(cidade))
                    {
                        throw new ArgumentException("A cidade não pode ser vazia.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}. Tente novamente.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Sexo (M/F): ");
                    sexo = char.Parse(Console.ReadLine()!.ToUpper());
                    if (sexo != 'M' && sexo != 'F')
                    {
                        throw new ArgumentException("Sexo inválido. Digite 'M' para Masculino ou 'F' para Feminino.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}. Tente novamente.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Ano de Nascimento: ");
                    anoNascimento = int.Parse(Console.ReadLine()!);
                    if (anoNascimento < 1900 || anoNascimento > DateTime.Now.Year)
                    {
                        throw new ArgumentException("Ano de nascimento inválido. Digite um ano entre 1900 e o ano atual.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}. Tente novamente.");
                }
            }
            try
            {
                CadastroPessoa objetoCadastroPessoa = new CadastroPessoa(nome, sobrenome, cidade, sexo, anoNascimento);
                objetoCadastroPessoa.ExibirCadastro();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar cadastro: {ex.Message}");
            }
        }
    }
}
