using System;

namespace Cadastro
{
    class CadastroPessoa // início da criação do objeto, passar atributos, construtor e método
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cidade { get; set; }
        public char Sexo { get; set; }
        public int AnoNascimento { get; set; }
            
    public CadastroPessoa(string nome, string sobrenome, string cidade, char sexo, int anoNascimento)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException("Campo não pode ser vazio");
            if (string.IsNullOrWhiteSpace(sobrenome)) throw new ArgumentNullException("Campo não pode ser vazio");
            if (string.IsNullOrWhiteSpace(cidade)) throw new ArgumentNullException("Campo não pode ser vazio");
            while (!char.TryParse(Console.ReadLine(), out sexo) || (sexo !=  'M' && sexo != 'F')) 
            {
                Console.WriteLine("Sexo inválido. Digite 'M' para Masculino ou 'F' para Feminino.");

            }
            while (!int.TryParse(Console.ReadLine(), out anoNascimento))
            {
                Console.WriteLine("Por favor, insira um ano de nascimento válido.");
            }
            Nome = nome;
            Sobrenome = sobrenome;                
            Cidade = cidade;
            Sexo = sexo;
            AnoNascimento = anoNascimento;
        }

    public void ExibirCadastro()
        {
            Console.Clear();
            Console.WriteLine("Cadastro realizado");
            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Ano Nascimento: {AnoNascimento}");
            Console.WriteLine($"Registrado ás {DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy")}");
        }
    }
}
