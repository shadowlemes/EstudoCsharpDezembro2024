using System;
using RealizacaoDeCadastros;
using Inicio;


namespace Cadastro
{
    class CadastroPessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Cidade { get; private set; }
        public char Sexo { get; private set; }
        public int AnoNascimento { get; private set; }

        public CadastroPessoa(string nome, string sobrenome, string cidade, char sexo, int anoNascimento)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(sobrenome)) throw new ArgumentException("Sobrenome não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(cidade)) throw new ArgumentException("Cidade não pode ser vazia.");
            if (sexo != 'M' && sexo != 'F') throw new ArgumentException("Sexo deve ser 'M' ou 'F'.");
            if (anoNascimento < 1900 || anoNascimento > DateTime.Now.Year) throw new ArgumentException("Ano de nascimento inválido.");

            Nome = nome;
            Sobrenome = sobrenome;
            Cidade = cidade;
            Sexo = sexo;
            AnoNascimento = anoNascimento;
        }

        public void ExibirCadastro()
        {
            Console.Clear();
            Console.WriteLine("Cadastro realizado com sucesso!\n");
            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Ano de Nascimento: {AnoNascimento}");
            Console.WriteLine($"Registrado às {DateTime.Now:HH:mm:ss dd/MM/yyyy}");
        }
    }
}
