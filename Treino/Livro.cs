using System;
using System.Collections.Generic;
using System.Text;

namespace Treino_Botanica
{
    class Livro
    {
        public int _quantidadeRegistros;
        public List<Flor> Flores { get; set; }

        public Livro()
        {
            Flores = new List<Flor>();
        }

        public int QuantidadeRegistros
        {
            get
            {
                _quantidadeRegistros = Flores.Count;
                return _quantidadeRegistros;
            }
        }

        public void AdicionarRegistro(string nome, string nomeCientifico,
                                        string habitat, bool possuiPropMedicinal,
                                        string propMedicinal)
        {
            Flores.Add(new Flor(nome, nomeCientifico, habitat, possuiPropMedicinal, propMedicinal));
        }

        public void MostrarRegistros()
        {
            foreach (Flor f in Flores)
            {
                Console.WriteLine(f);
            }
        }
    }
}
