using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2
{
    internal class Prota
    {
        public double hp;
        public string nome;
        public double atk;
        public double def;

        public Prota(double vida, string nome, double atk, double def)
        {
            this.hp = vida;
            this.nome = nome;
            this.atk = atk;
            this.def = def;
        }

        public string Descrever()
        {
            return $"Vida {hp}, nome {nome}, atk {atk}, def {def}";
        }
    }
}
