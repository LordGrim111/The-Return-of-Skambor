using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2
{
    class Contas
    {
        public double hp;
        public double atk;
        public double def;
        public double poder;
        public static double Vida_Prota(double lv, bool amuleto_hp) // calculo de vida do prota 
        {
            if (lv <= 3)
            {
                double hp = lv * 18.0 + 7.0;
                return Math.Round(hp);
            }
            else if (lv > 3 && lv <= 7)
            {
                if (amuleto_hp == false)  //Colocar o amuleto_hp = true dps após derrotar o Kent 
                {
                    double hp = 25.0 + 50.0 * Math.Log2(lv - 2);
                    return Math.Round(hp);
                }
                else
                {
                    double hp = 25.0 + 50.0 * Math.Log2(lv);
                    return Math.Round(hp);
                }
            }
            else if (lv > 7 && lv <= 9)
            {
                double hp = 25.0 + 50.0 * Math.Log2(lv);
                return Math.Round(hp);
            }
            else
            {
                double hp = 25.0 + 50.0 * Math.Log2(lv);
                return 2 * Math.Round(hp);
            }
        }

        public static double Vida_Inimigo(double lv) // calculo de vida do inimigo. Diogo depois da uma olhada para ver se as contas estão certas, vou botar ramdom a vida para menos 4
        {
            if (lv <= 3)
            {
                Random vida = new Random();
                double hp = lv * 18.0 + 7.0;
                double hp1 = hp - 4;
                int hp2 = Convert.ToInt32(hp);//25
                int hp3 = Convert.ToInt32(hp1);//21
                double vidas = vida.Next(hp3, hp2);
                return Math.Round(vidas);
            }
            else if (lv > 3 && lv < 8)
            {
                Random vida = new Random();
                double hp = 25.0 + 50.0 * Math.Log2(lv - 2);
                double hp1 = hp - 4;
                int hp2 = Convert.ToInt32(hp);
                int hp3 = Convert.ToInt32(hp1);
                double vidas = vida.Next(hp3, hp2);
                return Math.Round(vidas);
            }
            else
            {
                Random vida = new Random();
                double hp = 25.0 + 50.0 * Math.Log2(lv);
                double hp1 = hp - 4;
                int hp2 = Convert.ToInt32(hp);
                int hp3 = Convert.ToInt32(hp1);
                double vidas = vida.Next(hp3, hp2);
                return Math.Round(vidas);
            }
        }

        public static double Ataque(double lv) //calculo de ataque do prota e do inimigo
        {
            double atk = 30 + 35 * Math.Log2(lv);
            return Math.Round(atk);
        }

        public static double Defesa(double lv) //calculo de defesa tanto do prota quanto do inimigo
        {
            double def = 30 + 20 * Math.Log10(lv);
            return Math.Round(def);
        }

        public static double Dano(double lv, double atk, double def, double poder) //Esse é o caculo de dano para o prota
        {

            Random rand = new Random();
            double min = 0.85;
            double max = 1;
            double random = min + (rand.NextDouble() * (max - min));
            double dano = (((2 * lv + 10) / 250.0) * (atk / def) * poder + 2.0);// * random;
            double dano1 = dano + 2; //9
            double dano2 = dano - 2; //5
            int dano3 = Convert.ToInt32(dano1);
            int dano4 = Convert.ToInt32(dano2);
            double danos = rand.Next(dano4, dano3); //5 a 9
            return Math.Round(danos);
        }

        public static double Dano_Inimigo(double lv, double atk, double def, double poder) //Esse é o calculo para ver quanto de dano o inimigo vai dar
        {

            Random rand = new Random();
            double min = 0.85;
            double max = 1;
            double random = min + (rand.NextDouble() * (max - min));
            double dano = (((2 * lv + 10) / 250.0) * (atk / def) * poder + 2.0);// * random;
            //double dano1 = dano + 5;
            double dano2 = dano + 1; //8
            double dano5 = dano - 3; //4
            int dano3 = Convert.ToInt32(dano);
            int dano4 = Convert.ToInt32(dano2);
            int dano6 = Convert.ToInt32(dano5);
            double danos = rand.Next(dano6, dano4); //4 a 8
            return Math.Round(danos);
        }

        public static int Critico()
        {
            Random chance = new Random();
            int crit = chance.Next(1, 30);
            if (crit <= 30 && crit >=25)
            {
                return 2;
            }
            else
            {
                return 1;
            }

        }

        /*public static (bool, int) Critico1()
        {
            Random chance = new Random();
            int crit = chance.Next(1, 30);
            int critico1;
            if (crit == 30)
            {
                critico1 = 2;
                return (true, critico1);
            }
            else
            {
                critico1 = 1;
                return (false, critico1);
            }
        }*/


        public static bool Crit_Confirm()
        {
            int confirm = Critico();
            if (confirm == 2)
            {
                return true;
            }
            else return false;
        }

        
        //Aqui funciona quando o usuario escolhe a defesa, e faz o calculo para quanto de dano ele vai tomar
        //Diogo depois da uma olhada para ver se estar certo, vou colocar para o inimigo dar um dano menor, tipo 2
        public static double Defesa_Prota(double lv, double atk, double def, double poder)
        {

            Random rand = new Random();
            double min = 0.85;
            double max = 1;
            double random = min + (rand.NextDouble() * (max - min));
            double dano = (((2 * lv + 10) / 250.0) * (atk / def) * poder + 2.0);// * random;
            //double dano1 = dano + 5;
            double dano2 = dano - 2;
            //double dano5 = dano2 - 2;
            int dano3 = Convert.ToInt32(dano);
            int dano4 = Convert.ToInt32(dano2);
            //int dano6 = Convert.ToInt32(dano5);
            double danos = rand.Next(dano4, dano3);
            return Math.Round(danos);
        }
    }
}

