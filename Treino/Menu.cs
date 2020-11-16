using System;
using System.Collections.Generic;
using System.Text;

namespace Treino_Botanica
{
    class Menu
    {
        public Livro livro { get; private set; }
        public bool SystemRunning { get; private set; }

        public Menu(Livro livro_controlar)
        {
            livro = livro_controlar;
            SystemRunning = true;
        }

        public void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Item");
            Console.WriteLine("3 - Deletar Item");
            Console.WriteLine("5 - Ver Itens");
            Console.WriteLine("7 - Sair");
            Console.WriteLine(); 
            Console.WriteLine(); 
            Console.WriteLine(); 
        }

        public void ReceberInput()
        {
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    
                    Console.Write("Nome Científico: ");
                    string nomeCientifico = Console.ReadLine();

                    Console.Write("Habitat: ");
                    string habitat = Console.ReadLine();

                    Console.Write("Esta Flor possui propriedade medicinal? ");
                    bool possuiPropMedicinal = bool.Parse(Console.ReadLine());

                    string propMedicinal = "NA";

                    if (possuiPropMedicinal)
                    {
                        Console.Write("Qual a propriedade medicinal? ");
                        propMedicinal = Console.ReadLine();
                    }
                 
                    livro.AdicionarRegistro(nome,
                                            nomeCientifico,
                                            habitat,
                                            possuiPropMedicinal,
                                            propMedicinal);
                    
                    break;

                case 5:

                    livro.MostrarRegistros();
                    break;

                case 7:
                    SystemRunning = false;
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
