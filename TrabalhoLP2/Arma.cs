using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2
{
    internal class Arma
    {
        public string cajado = "Demetrius";
        public string espada = "Royal Guardian";
        public double dano_e = 130;
        public double dano = 100;
        public int encantamento;
        public double moeda;
        
        public string mercado(int e, double m)
        {
            encantamento = e;
            moeda = m;
            return $"Você recebeu {moeda}";
        }
    }
}
