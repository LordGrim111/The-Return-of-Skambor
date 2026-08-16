using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2
{
    internal class Personagem
    {
        public double Hp;
        public double HpReset;
        public string Nome;
        public double Atk;
        public double Def;
        public double Lv;

        public Personagem( double vida, string nome, double atk, double def, double nivel)
        {
            Hp = vida;
            Nome = nome;
            Atk = atk;
            Def = def;
            Lv = nivel;
            HpReset = Hp;
        }

        public string Descrever()
        {
            return $"Nível {Lv}: Vida {Hp} - atk {Atk} - def {Def}";
        }

    }
}
