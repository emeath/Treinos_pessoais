using System;

namespace Treino_Perfil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Quem é voce?");

            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Onde você mora? ");
            string endereco = Console.ReadLine();

            int id = 1000;

            Console.Write("Qual é seu telefone de contato? ");
            long telefone = long.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, endereco, id, telefone);

            Console.WriteLine("De acordo com meus cálculos você é...");
            Console.WriteLine("Seu nome é {0}, você mora em {1} e seu telefone para contato é {2}. Na realização do seu cadastro associamos voce ao id {3}", pessoa.Nome, pessoa.Endereco, pessoa.Telefone, pessoa.Id);
        }
    }
}
