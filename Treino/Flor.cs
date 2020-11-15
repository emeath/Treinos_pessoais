using System;
using System.Collections.Generic;
using System.Text;

namespace Treino_Botanica
{
    class Flor
    {
        public string Nome { get; private set; }
        public string NomeCientifico { get; private set; }
        public string Habitat { get; private set; }
        public bool PossuiPropMedicinal { get; private set; }
        public string PropMedicinal { get; private set; }

        public Flor(string nome, 
            string nomeCientifico, 
            string habitat, 
            bool possuiPropMedicinal, 
            string propMedicinal)
        {
            Nome = nome;
            NomeCientifico = nomeCientifico;
            Habitat = habitat;
            PossuiPropMedicinal = possuiPropMedicinal;
            PropMedicinal = propMedicinal;
        }

        public override string ToString()
        {
            return $"Flor: {Nome}, " +
                $"{NomeCientifico}, " +
                $"{Habitat}, " +
                $"{PossuiPropMedicinal}, " +
                $"{PropMedicinal}"; 
        }
    }
}
