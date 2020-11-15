using System;

namespace Treino_Botanica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Livro l = new Livro();

            l.MostrarRegistros();
            Console.WriteLine(l.QuantidadeRegistros);

            l.AdicionarRegistro("Rosa Branca", "Rosa x alba", "Germany", true,
                "propriedades adstringentes, calmantes, laxativas, anti-inflamatórias e depurativas");

            l.MostrarRegistros();
            Console.WriteLine(l.QuantidadeRegistros);

            Menu menu = new Menu(l);

            while(menu.SystemRunning)
            {
                menu.DisplayOptions();
                menu.ReceberInput();
            }
        }
    }
}
