//prota = new Personagem(Contas.Vida_Prota(nivel), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel); ~~Diogo
//Linha 270 - Pensei em colocar o msm dano do prota pelo motivo q comentei lá ~~ Diogo
/*Uma ideia pra defesa que ao invés de dividir o Atk por 2.5 na conta, dividir o resultado da conta por 2,
pq assim a gente pode aumentar um pouco o dano dos inimigos (principalmente os bosses) e fzr o jogador usar mais a defesa ~~Diogo*/


using System.ComponentModel;
using TrabalhoLP2;


Console.Title = "The Eternal Curse: The Return of Skambor";

List<string> prologo = new List<string>();
List<string> creditos = new List<string>();
List<string> FinalBoss = new List<string>();

/*Prota inimigos = new Prota();*/
Personagem goblin = new Personagem(Contas.Vida_Inimigo(1), "", Contas.Ataque(1), Contas.Defesa(1), 100);
Personagem Lorde_goblin = new Personagem(Contas.Vida_Inimigo(2), "", Contas.Ataque(2), Contas.Defesa(2), 100);
Personagem Kent = new Personagem(Contas.Vida_Inimigo(6), "", Contas.Ataque(6), Contas.Defesa(6), 100);
Personagem mago = new Personagem(Contas.Vida_Inimigo(3), "", Contas.Ataque(3), Contas.Defesa(3), 100);
Personagem dragao = new Personagem(Contas.Vida_Inimigo(7), "", Contas.Ataque(7), Contas.Defesa(7), 100);
Personagem Skambor = new Personagem(Contas.Vida_Inimigo(10), "", Contas.Ataque(10), Contas.Defesa(10), 100);
/*Prota boss = new Prota();*/

prologo.Add("Em tempos antigos, um mau terrível chamado Skambor reinava sobre a região de Mécapole. ");
prologo.Add("Até que Zyruz, um homem que perdeu sua família para Skambor, jurou acabar com ele de vez. ");
prologo.Add("Após uma longa jornada derrotando monstros, ele sela Skambor em uma rocha indestrutível tornando-se o herói conhecido como \"O Salvador\" em Mécapole. ");
prologo.Add("Agora, séculos depois, um jovem mago chamado Kent, descobriu essa antiga história e libertou Skambor de seu selo. ");
prologo.Add("Agora, você, o descendente de Zyruz, deve enfrentar Skambor e Kent para salvar Mécapole mais uma vez. \nBoa sorte, jovem aventureiro!");
creditos.Add("Diogo gameplays\n");
creditos.Add("Gabriel gameplays\n");
creditos.Add("Leonardo Duarte gameplays\n");
creditos.Add("Dennis Rodman gameplay");
FinalBoss.Add("O Terrível Dragão Skambor");

bool amuleto_hp = false;
bool cond_special = false;
int critico;
int critico1;

while (true)
{
    Console.Clear();
    Console.Write(">>>>>>>>>> |");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(" Seja bem vindo(a) ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("| <<<<<<<<<<");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n\nDeseja iniciar(1)\n");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Deseja sair(2)\n");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Deseja créditos(3)");
    Console.ForegroundColor = ConsoleColor.White;
    int opc = Convert.ToInt32(Console.ReadLine());
    if (opc == 2)
    {
        break;
    }
    switch (opc)
    {
        case 1:
            {
                Console.Clear();
                for (int i = 0; i < prologo.Count; i++)
                {
                    for (int j = 0; j < prologo[i].Length; j++)
                    {
                        Console.Write($"{prologo[i][j]}");
                        Thread.Sleep(60);
                    }
                }
                Console.WriteLine("\nPressione enter para continuar");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("Aqui começa a sua jornada, não será facíl, mas seja forte. Boa sorte\n");
                Console.Clear();
                Console.WriteLine("Digite o nome do seu personagem: \n");
                string nome = Console.ReadLine();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Selecione a sua classe: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Mago(1)");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guerreiro(2)");
                    Console.ForegroundColor = ConsoleColor.White;
                    int classe = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (classe != 1 && classe != 2)
                    {
                        Console.WriteLine("Você não escolheu nenhuma das opções");
                    }
                    else
                    {
                        if (classe == 1)
                        {
                            Console.WriteLine("Parabéns pela sua escolha \n");
                            Console.WriteLine("Agora como mago você recebe uma capa e um cajado");

                            Console.WriteLine("Seus atributos são: \n");
                            double nivel = 1;
                            double vidap = Contas.Vida_Prota(nivel, amuleto_hp);
                            double atk = Contas.Ataque(nivel);
                            double def = Contas.Defesa(nivel);
                            double dano_arma = 100;
                            double dano = Contas.Dano(nivel, atk, def, dano_arma);
                            int y = 0;
                            Personagem prota = new Personagem(vidap, nome, atk, def, nivel);
                            Console.WriteLine($"Nível {nivel}: \nVida: {vidap} \nAtaque: {atk} \nDefesa: {def} \nApartir do momento que você subir de nivel seus atributos irão aumentar também");
                            List<string> GoblinLore = new List<string>();
                            GoblinLore.Add($"Agora você está indo em direção ao Reino de Nizfera, onde Kent está, em busca do selo que mantinha Skambor aprisionado. ");
                            GoblinLore.Add($"Ao sair do Reino de Mécapole, você é atacado por goblins selvagens que estão atrás do seu ouro. ");
                            GoblinLore.Add($"Seu objetivo é derrotar todos esses goblins para progredir em sua jornada!");
                            Console.Clear();
                            for (int i = 0; i < GoblinLore.Count; i++)
                            {
                                for (int j = 0; j < GoblinLore[i].Length; j++)
                                {
                                    Console.Write($"{GoblinLore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Sua batalha vai começar");   //Sistema de batalha do inimigo básico
                            for (int x = 3; x > 0; x--)
                            {
                                Console.Write($"{x} ");
                                Thread.Sleep(1000);
                            }
                            //Sistema de batalha do inimigo básico<x
                            Console.Clear();
                            int contMorte = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        Console.WriteLine("Serão três goblins, e o primeiro está vindo em sua direção");
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tGoblin - Hp:{goblin.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                            goblin.Hp -= damage;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            goblin.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (goblin.Hp <= 0)
                                        {
                                            Console.WriteLine($"Hp Goblin: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Goblin {goblin.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (goblin.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o globin\nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            if (y == 4)
                                            {
                                                Console.Clear();
                                                nivel++;
                                                prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                                Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                                Console.ReadLine();
                                            }
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(1, Contas.Ataque(1), Contas.Defesa(1), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tGoblin - Hp:{goblin.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }
                            Console.Clear();
                            List<string> LoreBossG = new List<string>();
                            LoreBossG.Add($"Lorde Goblin viu que seu ataque foi inútil. ");
                            LoreBossG.Add($"Então ele mesmo resolve avançar para destruí-lo.");

                            for (int i = 0; i < LoreBossG.Count; i++)
                            {
                                for (int j = 0; j < LoreBossG[i].Length; j++)
                                {
                                    Console.Write($"{LoreBossG[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            /*while(true){} ---> Fazer o sistema de batalha do boss goblin aqui*/

                            prota.Hp = prota.HpReset;  //Deixar fora do While pq se não a vida de ninguém diminui ~~Diogo 
                            while (true)
                            {
                                Console.WriteLine("\nInimigo: Lorde Goblin \nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tLorde Goblin - Hp:{Lorde_goblin.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Lorde_goblin.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} no inimigo");
                                        Lorde_goblin.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    if (Lorde_goblin.Hp <= 0)
                                    {
                                        Console.WriteLine("hp inimigo: 0");
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"hp inimigo: {Lorde_goblin.Hp}");
                                        Thread.Sleep(1000);
                                    }
                                    if (Lorde_goblin.Hp <= 0)
                                    {
                                        Console.WriteLine($"Você derrotou o Lorde Goblin.\nAperte Enter para continuar...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        nivel++;
                                        prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                        Console.WriteLine($"Parabéns! Você subiu de nível \n{prota.Descrever()}");
                                        Console.ReadLine();
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Lorde_goblin.Hp = Lorde_goblin.HpReset;
                                        Console.ReadLine();
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tLorde Goblin - Hp:{Lorde_goblin.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Lorde_goblin.Hp = Lorde_goblin.HpReset;
                                        Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                                /*
            ⣀⣤⣶⣶⣶⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠛⠉⡠⣔⢲⡪⣻⣦⢀⣠⣾⠿⣷⣤⣀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠁⠀⠀⠀⠁⢡⡡⣕⣰⣿⣿⣯⣭⣳⡎⠉⠛⣿⡄⠀
⠀⠀⠀⠀⠀⠀⠀⣴⡟⠀⠀⠀⠀⢀⣧⠿⠛⠋⠁⢀⣤⣤⣶⣾⣿⣀⣀⢸⡇⠀
⠀⠀⠀⠀⠀⠀⣼⡟⠀⠀⠀⣠⠞⠉⠀⢀⣠⠴⢋⣝⣿⠿⠛⠉⠀⠀⣠⣿⠃⠀
⠀⠀⠀⠀⣠⣶⢿⠁⠀⣠⣾⣁⣤⠴⠒⣿⡆⠀⠘⣿⠾⠷⠶⣶⣅⣸⣿⠃⠀⠀
⠀⠀⠀⢼⡿⠁⢀⣀⣰⡟⠘⣆⡀⠀⠀⠸⡟⠀⠐⠁⠀⠀⠀⠈⣿⡟⠃⠀⠀⠀
⠀⠀⠀⠘⣿⣶⠋⢅⡈⠻⣄⣨⡿⠀⣾⢶⣄⣀⡀⠀⠀⠀⠀⣠⣿⠁⠀⠀⠀⠀
⠀⠀⠀⠀⢸⣯⠀⠀⠛⡆⠉⠛⠁⠀⢻⣦⡀⠉⠉⠓⠶⠖⣾⡟⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠘⢿⣦⣌⣉⣠⣤⡀⠀⠀⠀⢸⠷⡶⣧⣴⡶⣾⠏⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣉⣽⣿⠿⠿⠿⣦⣀⡀⠘⢦⣾⣿⣯⡾⠃⠀⠀⢀⣀⠀⠀⠀⠀
⠀⠀⠀⣴⡶⠾⢯⣅⠀⢀⣠⠾⠋⢹⠉⠙⢯⣉⣻⡟⣧⣤⣴⡿⠛⠛⢿⣦⣀⠀
⠀⣠⡾⢛⠁⠀⠀⢈⣻⡟⠀⠀⠀⣼⢠⡾⠛⢻⡀⠀⣧⠹⣿⠁⠀⠀⠀⡿⣿⡆
⢠⣿⠁⡾⢠⡆⠀⠀⢹⡿⠶⠶⠞⠁⠸⣇⢀⣠⠇⠀⠙⢷⡿⠀⠀⠀⢠⢃⣿⠃
⠘⣿⡀⠀⠈⠁⢠⣆⣸⣇⡀⠀⠀⠀⠀⠉⠉⠁⠀⠀⠀⣾⠂⠀⠀⢀⣶⣿⠋⠀
⠀⠙⢿⣦⣄⣀⣨⠟⠁⢉⡿⣶⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣦⣀⣤⣶⣿⠇⠀⠀
⠀⠀⠀⠀⣿⢯⠁⠀⠀⢸⠀⣼⣷⣦⣤⣤⣴⠶⠟⠋⠁⠀⠉⠉⠉⠛⠉⠀⠀⠀
⠀⠀⠀⢸⡟⢸⠀⠀⠀⠈⢠⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢸⣷⣿⠀⠀⠀⢀⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠙⠻⢷⣶⣶⡾⠏⠀⠀⠀⠀⠀⠀⠀GABRIEL CORRÊA⠀⠀⠀*/
                            }
                            Console.Clear();
                            List<string> MagoSubordinados = new List<string>();
                            MagoSubordinados.Add($"Após derrotar o Lorde Goblin, nosso guerreiro atravessa a floresta e chega até o Reino de Nizfera");
                            MagoSubordinados.Add($"o Rei após descobrir que você está atrás de derrotar Skambor, ele manda os seus 3 melhores magos para o derrotar.\n");
                            MagoSubordinados.Add($"Derrote todos os poderosos magos para poder prosseguir com sua missão.\n");

                            for (int i = 0; i < MagoSubordinados.Count; i++)
                            {
                                for (int j = 0; j < MagoSubordinados[i].Length; j++)
                                {
                                    Console.Write($"{MagoSubordinados[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("Pressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            y = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        Console.WriteLine("Serão três magos, e o primeiro está vindo em sua direção");
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tMago - Hp:{mago.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                            mago.Hp -= damage;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            mago.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (mago.Hp < 0)
                                        {
                                            Console.WriteLine($"Hp Mago: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Mago {mago.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (mago.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o mago\nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            Console.Clear();
                                            nivel++;
                                            prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                            Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                            Console.ReadLine();
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tMago - Hp:{mago.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            prota.Hp = 0;
                                            Console.WriteLine($"Seu HP: {prota.Hp}");
                                            Console.WriteLine("You Died");
                                            Console.WriteLine("Pressione enter para tentar novamente");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }

                            Console.Clear();
                            List<string> Kent_lore = new List<string>();
                            Kent_lore.Add($"Depois de frustrar os planos do Rei, ele ordena que seu melhor mago, Kent ascendente do antigo mago Belchior, derrote-o.\n");

                            for (int i = 0; i < Kent_lore.Count; i++)
                            {
                                for (int j = 0; j < Kent_lore[i].Length; j++)
                                {
                                    Console.Write($"{Kent_lore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            /* while(true){} ---> Fazer a batalha contra o Mago Supremo aqui! */
                            prota.Hp = prota.HpReset;  //Deixar fora do While pq se não a vida de ninguém diminui ~~Diogo
                            while (true)
                            {
                                Console.WriteLine("\nInimigo: Kent O Mago \nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tKent - Hp:{Kent.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Kent.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} no inimigo");
                                        Kent.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    if (Kent.Hp <= 0)
                                    {
                                        Console.WriteLine("hp inimigo: 0");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"hp inimigo: {Kent.Hp}");
                                        Thread.Sleep(1000);
                                    }
                                    if (Kent.Hp <= 0)
                                    {
                                        Console.WriteLine($"Você derrotou o Kent.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"Após derrota-lo você coleta o Selo de Aprisionamento e também um Amuleto de Vida.\nAperte Enter para continuar...");
                                        Console.ReadKey();
                                        nivel++;
                                        prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                        Console.WriteLine($"Parabéns! Você subiu de nível \n{prota.Descrever()}");
                                        Console.Clear();
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ReadLine();
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Kent.Hp = Kent.HpReset;
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tKent - Hp:{Kent.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ReadLine();
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Kent.Hp = Kent.HpReset;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                            }
                            Console.Clear();
                            List<string> Dragões = new List<string>();
                            Dragões.Add("Após uma árdua jornada, o nosso herói retorna a Mécapole e chega ao seu centro, afim de derrotar o terrível Skambor, ");
                            Dragões.Add("porém antes que nosso herói possa atacar, Skambor manda seus discípulos para lhe impedir.\n");

                            for (int i = 0; i < Dragões.Count; i++)
                            {
                                for (int j = 0; j < Dragões[i].Length; j++)
                                {
                                    Console.Write($"{Dragões[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Sua batalha vai começar");   //Sistema de batalha do inimig
                            for (int x = 3; x > 0; x--)
                            {
                                Console.Write($"{x} ");
                                Thread.Sleep(1000);
                            }
                            Console.Clear();
                            y = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                dragao.Hp = Contas.Vida_Inimigo(nivel);

                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        dragao.Hp = dragao.HpReset;
                                        Console.WriteLine("Serão três dragões, e o primeiro está vindo em sua direção");
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        dragao.Hp = dragao.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        dragao.Hp = dragao.HpReset;

                                        /*░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄
                                        ░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█
                                        ░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█
                                        ░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█
                                        █▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█
                                        █▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
                                        ░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█
                                        ░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█
                                        ░░░█░░██░░▀█▄▄▄█▄▄█▄████░█
                                        ░░░░█░░░▀▀▄░█░░░█░███████░█
                                        ░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█
                                        ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█
                                        ░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█
                                        ░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█    Dennis :p*/

                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tDragão - Hp:{dragao.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                            dragao.Hp -= damage;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            dragao.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (dragao.Hp < 0)
                                        {
                                            Console.WriteLine($"Hp Dragão: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Dragão {dragao.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (dragao.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o dragão.\nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            Console.Clear();
                                            nivel++;
                                            prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                            Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                            Console.ReadKey();
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            prota.Hp = prota.HpReset;
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tDragão - Hp:{dragao.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            prota.Hp = prota.HpReset;
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Após você derrotar os três dragões, você fundi suas escamas em sua arma, assim ficando muito mais forte.");
                            Console.ReadKey();
                            Console.Clear();
                            List<string> SkamborLore = new List<string>();
                            SkamborLore.Add($"Depois de derrotar todo o império de Skambor, você está confiante que derrotará Skambor e trará a paz a Mécapole");
                            SkamborLore.Add($"e Skambor está ansioso com a chance de matar um descendente de Zyruz.");


                            for (int i = 0; i < SkamborLore.Count; i++)
                            {
                                for (int j = 0; j < SkamborLore[i].Length; j++)
                                {
                                    Console.Write($"{SkamborLore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }

                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            /* while(true){} ---> Fazer a batalha contra o Skambur aqui! */
                            Skambor.Hp = 1000;

                            for (int i = 0; i < FinalBoss.Count; i++)
                            {
                                for (int j = 0; j < FinalBoss[i].Length; j++)
                                {
                                    Console.Write($"{FinalBoss[i][j]}");
                                    Thread.Sleep(350);
                                }
                            }

                            while (true)
                            {
                                Console.WriteLine("\nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tSkambor - Hp:{Skambor.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, (2 * Contas.Ataque(nivel)), (2 * Contas.Defesa(nivel)), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Skambor.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} de dano");
                                        Skambor.Hp -= damage;
                                        Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                    }
                                    Console.WriteLine($"hp inimigo: {Skambor.Hp}");
                                    Thread.Sleep(1000);
                                    if (Skambor.Hp <= 600)
                                    {
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ReadLine();
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Skambor.Hp = Skambor.HpReset;
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tSkambor - Hp:{Skambor.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ReadLine();
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Skambor.Hp = Skambor.HpReset;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                            }
                            Console.Clear();
                            /*parte final, após a derrota do ultimo boss*/

                            List<string> Epilogo = new List<string>();
                            Epilogo.Add("Skambor: Estou fraco demais, como você conseguiu tanto poder? ");
                            Epilogo.Add("Você ignora a pergunta de Skambor e começa o ritual de selamento. ");
                            Epilogo.Add("Então depois de uma longa luta, nosso herói consegue selar mais uma vez o Dragão, fortalecendo mais o seu selo, para que o Dragão nunca mais fosse liberto. ");
                            Epilogo.Add("Porém não se esqueça, até que a linhagem de Zyruz não acabe, ");
                            Epilogo.Add("sempre virá um novo mal para assombrar o reino de Mécapole.");
                            double cont = 3;
                            for (int i = 0; i < Epilogo.Count; i++)
                            {
                                Thread.Sleep(2);
                                for (int j = 0; j < Epilogo[i].Length; j++)
                                {
                                    Console.Write($"{Epilogo[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            if (cont == 3)
                            {
                                {
                                    Console.WriteLine("Obrigado por terminar The Eternal Curse: The Return of Skambor\n Um jogo feito com muito carinho e dedicação, muitas noites mal dormidas");
                                    Console.WriteLine("\n mas é com orgulho que afirmo que a parte 2 virá, fique de olho");
                                    Console.WriteLine("Esse jogo foi feito pelos incríveis programadores: \n");
                                    Thread.Sleep(1000);
                                    for (int i = 0; i < creditos.Count; i++)
                                    {
                                        for (int j = 0; j < creditos[i].Length; j++)
                                        {
                                            if (i == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 3)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                        }
                                    }
                                    Thread.Sleep(3000);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                        }
                        if (classe == 2)
                        {
                            Console.WriteLine("Parabéns pela sua escolha \n");
                            Console.WriteLine("Agora como mago você recebe uma capa e um cajado");

                            Console.WriteLine("Seus atributos são: \n");
                            double nivel = 1;
                            double vidap = Contas.Vida_Prota(nivel, amuleto_hp);
                            double atk = Contas.Ataque(nivel);
                            double def = Contas.Defesa(nivel);
                            double dano_arma = 100;
                            double dano = Contas.Dano(nivel, atk, def, dano_arma);
                            int y = 0;
                            Personagem prota = new Personagem(vidap, nome, atk, def, nivel);
                            Console.WriteLine($"Nível {nivel}: \nVida: {vidap} \nAtaque: {atk} \nDefesa: {def} \nApartir do momento que você subir de nivel seus atributos irão aumentar também");
                            List<string> GoblinLore = new List<string>();
                            GoblinLore.Add($" Agora você está indo em direção ao Reino de Nizfera, onde Kent está, em busca do selo que mantinha Skambor aprisionado.");
                            GoblinLore.Add($"Ao sair do Reino de Mécapole, você é atacado por goblins selvagens que estão atrás do seu ouro.");
                            GoblinLore.Add($"Seu objetivo é derrotar todos esses goblins para progredir em sua jornada!");
                            Console.Clear();
                            for (int i = 0; i < GoblinLore.Count; i++)
                            {
                                for (int j = 0; j < GoblinLore[i].Length; j++)
                                {
                                    Console.Write($"{GoblinLore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Sua batalha vai começar");   //Sistema de batalha do inimigo básico
                            for (int x = 3; x > 0; x--)
                            {
                                Console.Write($"{x} ");
                                Thread.Sleep(1000);
                            }
                            //Sistema de batalha do inimigo básico<x
                            Console.Clear();
                            int contMorte = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.WriteLine("Serão três goblins, e o primeiro está vindo em sua direção");
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        goblin.Hp = goblin.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tGoblin - Hp:{goblin.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                            goblin.Hp -= damage;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            goblin.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (goblin.Hp < 0)
                                        {
                                            Console.WriteLine($"Hp Goblin: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Goblin {goblin.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (goblin.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o globin. \nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            if (y == 4)
                                            {
                                                Console.Clear();
                                                nivel++;
                                                prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                                Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                                Console.ReadLine();
                                            }
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(1, Contas.Ataque(1), Contas.Defesa(1), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tGoblin - Hp:{goblin.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }
                            Console.Clear();
                            List<string> LoreBossG = new List<string>();
                            LoreBossG.Add($"Lorde Goblin viu que seu ataque foi inútil. ");
                            LoreBossG.Add($"Então ele mesmo resolve avançar para destruí-lo.");

                            for (int i = 0; i < LoreBossG.Count; i++)
                            {
                                for (int j = 0; j < LoreBossG[i].Length; j++)
                                {
                                    Console.Write($"{LoreBossG[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            /*while(true){} ---> Fazer o sistema de batalha do boss goblin aqui*/

                            prota.Hp = prota.HpReset;  //Deixar fora do While pq se não a vida de ninguém diminui ~~Diogo 
                            while (true)
                            {
                                Console.WriteLine("\nInimigo: Lorde Goblin \nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tLorde Goblin - Hp:{Lorde_goblin.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Lorde_goblin.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} no inimigo");
                                        Lorde_goblin.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    if (Lorde_goblin.Hp <= 0)
                                    {
                                        Console.WriteLine("hp inimigo: 0");
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"hp inimigo: {Lorde_goblin.Hp}");
                                        Thread.Sleep(1000);
                                    }
                                    if (Lorde_goblin.Hp <= 0)
                                    {
                                        Console.WriteLine($"Você derrotou o Lorde Goblin.\nAperte Enter para continuar...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        nivel++;
                                        prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                        Console.WriteLine($"Parabéns! Você subiu de nível \n{prota.Descrever()}");
                                        Console.ReadLine();
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        prota.Hp = prota.HpReset;
                                        Lorde_goblin.Hp = Lorde_goblin.HpReset;
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tLorde Goblin - Hp:{Lorde_goblin.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        prota.Hp = prota.HpReset;
                                        Lorde_goblin.Hp = Lorde_goblin.HpReset;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                                /*
            ⣀⣤⣶⣶⣶⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠛⠉⡠⣔⢲⡪⣻⣦⢀⣠⣾⠿⣷⣤⣀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠁⠀⠀⠀⠁⢡⡡⣕⣰⣿⣿⣯⣭⣳⡎⠉⠛⣿⡄⠀
⠀⠀⠀⠀⠀⠀⠀⣴⡟⠀⠀⠀⠀⢀⣧⠿⠛⠋⠁⢀⣤⣤⣶⣾⣿⣀⣀⢸⡇⠀
⠀⠀⠀⠀⠀⠀⣼⡟⠀⠀⠀⣠⠞⠉⠀⢀⣠⠴⢋⣝⣿⠿⠛⠉⠀⠀⣠⣿⠃⠀
⠀⠀⠀⠀⣠⣶⢿⠁⠀⣠⣾⣁⣤⠴⠒⣿⡆⠀⠘⣿⠾⠷⠶⣶⣅⣸⣿⠃⠀⠀
⠀⠀⠀⢼⡿⠁⢀⣀⣰⡟⠘⣆⡀⠀⠀⠸⡟⠀⠐⠁⠀⠀⠀⠈⣿⡟⠃⠀⠀⠀
⠀⠀⠀⠘⣿⣶⠋⢅⡈⠻⣄⣨⡿⠀⣾⢶⣄⣀⡀⠀⠀⠀⠀⣠⣿⠁⠀⠀⠀⠀
⠀⠀⠀⠀⢸⣯⠀⠀⠛⡆⠉⠛⠁⠀⢻⣦⡀⠉⠉⠓⠶⠖⣾⡟⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠘⢿⣦⣌⣉⣠⣤⡀⠀⠀⠀⢸⠷⡶⣧⣴⡶⣾⠏⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣉⣽⣿⠿⠿⠿⣦⣀⡀⠘⢦⣾⣿⣯⡾⠃⠀⠀⢀⣀⠀⠀⠀⠀
⠀⠀⠀⣴⡶⠾⢯⣅⠀⢀⣠⠾⠋⢹⠉⠙⢯⣉⣻⡟⣧⣤⣴⡿⠛⠛⢿⣦⣀⠀
⠀⣠⡾⢛⠁⠀⠀⢈⣻⡟⠀⠀⠀⣼⢠⡾⠛⢻⡀⠀⣧⠹⣿⠁⠀⠀⠀⡿⣿⡆
⢠⣿⠁⡾⢠⡆⠀⠀⢹⡿⠶⠶⠞⠁⠸⣇⢀⣠⠇⠀⠙⢷⡿⠀⠀⠀⢠⢃⣿⠃
⠘⣿⡀⠀⠈⠁⢠⣆⣸⣇⡀⠀⠀⠀⠀⠉⠉⠁⠀⠀⠀⣾⠂⠀⠀⢀⣶⣿⠋⠀
⠀⠙⢿⣦⣄⣀⣨⠟⠁⢉⡿⣶⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣦⣀⣤⣶⣿⠇⠀⠀
⠀⠀⠀⠀⣿⢯⠁⠀⠀⢸⠀⣼⣷⣦⣤⣤⣴⠶⠟⠋⠁⠀⠉⠉⠉⠛⠉⠀⠀⠀
⠀⠀⠀⢸⡟⢸⠀⠀⠀⠈⢠⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢸⣷⣿⠀⠀⠀⢀⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠙⠻⢷⣶⣶⡾⠏⠀⠀⠀⠀⠀⠀⠀GABRIEL CORRÊA⠀⠀⠀*/
                            }
                            Console.Clear();
                            List<string> MagoSubordinados = new List<string>();
                            MagoSubordinados.Add($"Após derrotar o Lorde Goblin, nosso guerreiro atravessa a floresta e chega até o Reino de Nizfera");
                            MagoSubordinados.Add($"o Rei após descobrir que você está atrás de derrotar Skambor, ele manda os seus 3 melhores magos para o derrotar.\n");
                            MagoSubordinados.Add($"Derrote todos os poderosos magos para poder prosseguir com sua missão.\n");

                            for (int i = 0; i < MagoSubordinados.Count; i++)
                            {
                                for (int j = 0; j < MagoSubordinados[i].Length; j++)
                                {
                                    Console.Write($"{MagoSubordinados[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("Pressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            y = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        Console.WriteLine("Serão três magos, e o primeiro está vindo em sua direção");
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        mago.Hp = mago.HpReset;
                                        prota.Hp = prota.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tMago - Hp:{mago.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            mago.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (mago.Hp < 0)
                                        {
                                            Console.WriteLine($"Hp Mago: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Mago {mago.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (mago.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o mago\nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            Console.Clear();
                                            nivel++;
                                            prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                            Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                            Console.ReadLine();
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tMago - Hp:{mago.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            prota.Hp = 0;
                                            Console.WriteLine($"Seu HP: {prota.Hp}");
                                            Console.WriteLine("You Died");
                                            Console.WriteLine("Pressione enter para tentar novamente");
                                            Console.ReadLine();
                                            Console.ResetColor();
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }

                            Console.Clear();
                            List<string> Kent_lore = new List<string>();
                            Kent_lore.Add($"Depois de frustrar os planos do Rei, ele ordena que seu melhor mago, Kent ascendente do antigo mago Belchior, derrote-o.\n");

                            for (int i = 0; i < Kent_lore.Count; i++)
                            {
                                for (int j = 0; j < Kent_lore[i].Length; j++)
                                {
                                    Console.Write($"{Kent_lore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            /* while(true){} ---> Fazer a batalha contra o Mago Supremo aqui! */
                            prota.Hp = prota.HpReset;  //Deixar fora do While pq se não a vida de ninguém diminui ~~Diogo
                            while (true)
                            {
                                Console.WriteLine("\nInimigo: Kent O Mago \nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tKent - Hp:{Kent.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Kent.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} no inimigo");
                                        Kent.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    if (Kent.Hp <= 0)
                                    {
                                        Console.WriteLine("hp inimigo: 0");
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"hp inimigo: {Kent.Hp}");
                                        Thread.Sleep(1000);
                                    }
                                    if (Kent.Hp <= 0)
                                    {
                                        Console.WriteLine($"Você derrotou o Kent.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"Após derrota-lo você coleta o Selo de Aprisionamento e também um Amuleto de Vida.\nAperte Enter para continuar...");
                                        Console.ReadKey();
                                        nivel++;
                                        prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                        Console.WriteLine($"Parabéns! Você subiu de nível \n{prota.Descrever()}");
                                        Console.Clear();
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        prota.Hp = prota.HpReset;
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tKent - Hp:{Kent.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        prota.Hp = prota.HpReset;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                            }
                            Console.Clear();
                            List<string> Dragões = new List<string>();
                            Dragões.Add("Após uma árdua jornada, o nosso herói retorna a Mécapole e chega ao seu centro, afim de derrotar o terrível Skambor, ");
                            Dragões.Add("porém antes que nosso herói possa atacar, Skambor manda seus discípulos para lhe impedir.\n");

                            for (int i = 0; i < Dragões.Count; i++)
                            {
                                for (int j = 0; j < Dragões[i].Length; j++)
                                {
                                    Console.Write($"{Dragões[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Sua batalha vai começar");   //Sistema de batalha do inimig
                            for (int x = 3; x > 0; x--)
                            {
                                Console.Write($"{x} ");
                                Thread.Sleep(1000);
                            }
                            Console.Clear();
                            y = 0;
                            for (int x = 0; x <= 2; x++)
                            {
                                dragao.Hp = Contas.Vida_Inimigo(nivel);

                                while (true)
                                {
                                    if (y == 0)
                                    {
                                        dragao.Hp = dragao.HpReset;
                                        Console.WriteLine("Serão três dragões, e o primeiro está vindo em sua direção");
                                        y++;
                                    }
                                    else if (y == 2)
                                    {
                                        dragao.Hp = dragao.HpReset;
                                        Console.Clear();
                                        Console.WriteLine("Você derrotou o primeiro, agora o segundo está vindo");
                                        y++;
                                    }
                                    else if (y == 4)
                                    {
                                        dragao.Hp = dragao.HpReset;

                                        /*░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄
                                        ░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█
                                        ░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█
                                        ░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█
                                        █▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█
                                        █▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
                                        ░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█
                                        ░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█
                                        ░░░█░░██░░▀█▄▄▄█▄▄█▄████░█
                                        ░░░░█░░░▀▀▄░█░░░█░███████░█
                                        ░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█
                                        ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█
                                        ░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█
                                        ░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█    Dennis :p*/

                                        Console.Clear();
                                        Console.WriteLine("Menos dois, mas não baixe a guarda o terceiro está vindo");
                                        y++;
                                    }
                                    Console.WriteLine("\nAtacar(1) Defender(2)");
                                    int opc1 = Convert.ToInt32(Console.ReadLine());
                                    if (opc1 == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tDragão - Hp:{dragao.Hp}");
                                        critico = Contas.Critico();
                                        double damage = Contas.Dano(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico;
                                        if (critico == 2)
                                        {
                                            Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                            dragao.Hp -= damage;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Você deu {damage} de dano");
                                            dragao.Hp -= damage;
                                            Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                        }
                                        if (dragao.Hp < 0)
                                        {
                                            Console.WriteLine($"Hp Dragão: 0");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Hp Dragão {dragao.Hp}");
                                            Thread.Sleep(1000);
                                        }
                                        if (dragao.Hp <= 0)
                                        {
                                            Console.WriteLine($"Você derrotou o dragão.\nAperte Enter para continuar...");
                                            Console.ReadKey();
                                            y++;
                                            Console.Clear();
                                            nivel++;
                                            prota = new Personagem(Contas.Vida_Prota(nivel, amuleto_hp), prota.Nome, Contas.Ataque(nivel), Contas.Defesa(nivel), nivel);
                                            Console.WriteLine($"Parabéns! Você subiu de nível. \n{prota.Descrever()}");
                                            Console.ReadKey();
                                            break;
                                        }
                                        critico1 = Contas.Critico();
                                        double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                        if (critico1 == 2)
                                        {
                                            Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                            prota.Hp -= damage1;
                                            Thread.Sleep(1000);
                                        }
                                        Console.WriteLine($"Seu hp: {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            prota.Hp = prota.HpReset;
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else if (opc1 == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tDragão - Hp:{dragao.Hp}");
                                        Thread.Sleep(1000);
                                        double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                        Console.WriteLine($"Você recebeu {damage2} de dano");
                                        Thread.Sleep(1000);
                                        prota.Hp -= damage2;
                                        Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                        if (prota.Hp <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("You Died");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            prota.Hp = prota.HpReset;
                                            y--;
                                            Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                    }
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Após você derrotar os três dragões, você fundi suas escamas em sua arma, assim ficando muito mais forte.");
                            Console.ReadKey();
                            Console.Clear();
                            List<string> SkamburLore = new List<string>();
                            SkamburLore.Add($"Depois de derrotar todo o império de Skambor, você está confiante que derrotará Skambor e trará a paz a Mécapole");
                            SkamburLore.Add($"e Skambor está ansioso com a chance de matar um descendente de Zyruz.");


                            for (int i = 0; i < SkamburLore.Count; i++)
                            {
                                for (int j = 0; j < SkamburLore[i].Length; j++)
                                {
                                    Console.Write($"{SkamburLore[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }

                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            /* while(true){} ---> Fazer a batalha contra o Skambur aqui! */
                            Skambor.Hp = 1000;

                            for (int i = 0; i < FinalBoss.Count; i++)
                            {
                                for (int j = 0; j < FinalBoss[i].Length; j++)
                                {
                                    Console.Write($"{FinalBoss[i][j]}");
                                    Thread.Sleep(350);
                                }
                            }

                            while (true)
                            {
                                Console.WriteLine("\nAtacar(1) Defender(2)");
                                int opc1 = Convert.ToInt32(Console.ReadLine());
                                if (opc1 == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tSkambor - Hp:{Skambor.Hp}");
                                    critico = Contas.Critico();
                                    double damage = Contas.Dano(nivel, (2 * Contas.Ataque(nivel)), (2 * Contas.Defesa(nivel)), dano_arma) * critico;
                                    if (critico == 2)
                                    {
                                        Console.WriteLine($"Você acertou um crítico. Você deu {damage} de dano");
                                        Skambor.Hp -= damage;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você deu {damage} de dano");
                                        Skambor.Hp -= damage;
                                        Thread.Sleep(1000); // Quando estiver tudo pronto, aumenta o tempo de todos para o jogador ler a informação com calma ~~Diogo
                                    }
                                    Console.WriteLine($"hp inimigo: {Skambor.Hp}");
                                    Thread.Sleep(1000);
                                    if (Skambor.Hp <= 600)
                                    {
                                        break;
                                    }
                                    critico1 = Contas.Critico();
                                    double damage1 = Contas.Dano_Inimigo(nivel, Contas.Ataque(nivel), Contas.Defesa(nivel), dano_arma) * critico1;
                                    if (critico1 == 2)
                                    {
                                        Console.WriteLine($"O inimigo acertou um crítico. Ele deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Agora é a vez dele.\nEle deu {damage1} de dano");
                                        prota.Hp -= damage1;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Seu hp: {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        prota.Hp = prota.HpReset;
                                        Skambor.Hp = Skambor.HpReset;
                                    }
                                }
                                else if (opc1 == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{prota.Nome} - Hp:{prota.Hp}\t\t\tSkambor - Hp:{Skambor.Hp}");
                                    Thread.Sleep(1000);
                                    double damage2 = (Contas.Defesa_Prota(nivel, atk, def, dano_arma) / 2.0) * Contas.Critico();
                                    Console.WriteLine($"Você recebeu {damage2} de dano");
                                    Thread.Sleep(1000);
                                    prota.Hp -= damage2;
                                    Console.WriteLine($"Agora sua vida é {prota.Hp}");
                                    if (prota.Hp <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You Died");
                                        Console.ReadLine();
                                        Console.ResetColor();
                                        prota.Hp = prota.HpReset;
                                        Skambor.Hp = Skambor.HpReset;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nVocê não escolheu nenhuma das opções\nEscolha novamente");
                                }
                            }
                            Console.Clear();
                            /*parte final, após a derrota do ultimo boss*/

                            List<string> Epilogo = new List<string>();
                            Epilogo.Add("Skambor: Estou fraco demais, como você conseguiu tanto poder?\n");
                            Epilogo.Add("Você ignora a pergunta de Skambor e começa o ritual de selamento. ");
                            Epilogo.Add("Então depois de uma longa luta, nosso herói consegue selar mais uma vez o Dragão, fortalecendo mais o seu selo, para que o Dragão nunca mais fosse liberto. ");
                            Epilogo.Add("Porém não se esqueça, até que a linhagem de Zyruz não acabe, ");
                            Epilogo.Add("sempre virá um novo mal para assombrar o reino de Mécapole.");
                            double cont = 3;
                            for (int i = 0; i < Epilogo.Count; i++)
                            {
                                for (int j = 0; j < Epilogo[i].Length; j++)
                                {
                                    Console.Write($"{Epilogo[i][j]}");
                                    Thread.Sleep(60);
                                }
                            }
                            Console.WriteLine("\nPressione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            if (cont == 3)
                            {
                                {
                                    Console.WriteLine("Obrigado por terminar The Eternal Curse: The Return of Skambor.\n Um jogo feito com muito carinho e dedicação, muitas noites mal dormidas, ");
                                    Console.Write("mas é com orgulho que afirmo que a parte 2 virá, fique de olho");
                                    Console.WriteLine("Esse jogo foi feito pelos incríveis programadores: \n");
                                    Thread.Sleep(1000);
                                    for (int i = 0; i < creditos.Count; i++)
                                    {
                                        for (int j = 0; j < creditos[i].Length; j++)
                                        {
                                            if (i == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                            if (i == 3)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write($"{creditos[i][j]}");
                                                Thread.Sleep(60);
                                            }
                                        }
                                    }
                                    Thread.Sleep(3000);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                        }


                    }
                    break;
                }
                break;
            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("Esse jogo foi feito pelos incríveis programadores: \n");
                Thread.Sleep(1000);
                for (int i = 0; i < creditos.Count; i++)
                {
                    for (int j = 0; j < creditos[i].Length; j++)
                    {
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write($"{creditos[i][j]}");
                            Thread.Sleep(100);
                        }
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{creditos[i][j]}");
                            Thread.Sleep(100);
                        }
                        if (i == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{creditos[i][j]}");
                            Thread.Sleep(100);
                        }
                        if (i == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{creditos[i][j]}");
                            Thread.Sleep(100);
                        }
                    }
                }
                Thread.Sleep(1000);
                Console.ReadKey();
                break;
            }
    }
    if (opc != 1 && opc != 2 && opc != 3)
    {
        Console.WriteLine("\nVocê não escolheu nenhuma das opções");
        Console.ReadLine();
    }
}



/*░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄
░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█
░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█
░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█
█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█
█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█
░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█
░░░█░░██░░▀█▄▄▄█▄▄█▄████░█
░░░░█░░░▀▀▄░█░░░█░███████░█
░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█
░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█
░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█
░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█ DENNIS*/




/*안녕하세요 방탄 손 연단, 저는 1입니다 방탄 소년단의 황금 막내 오 전 정국입니다*/

/*
 ⠀⠀⣀⡤⢤⣄⠀⣠⡤⣤⡀⠀⠀⠀
⠀⠀⢀⣴⢫⠞⠛⠾⠺⠟⠛⢦⢻⣆⠀⠀
⠀⠀⣼⢇⣻⡀⠀⠀⠀⠀⠀⠀⢸⡇⢿⣆⠀
⠀⢸⣯⢦⣽⣷⣄⡀⠀⢀⣴⣿⣳⣬⣿⠀
⢠⡞⢩⣿⠋⠙⠳⣽⢾⣯⠛⠙⢹⣯⠘⣷
⠀⠈⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠋⠁⠀⠀
 LEONARDO DUARTE*/

/*
    ⠀⣠⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⡄⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀
⠀⣠⣴⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀
⠠⣿⣿⣿⣿⣿⠿⠛⠉⠀⠀⠀⠀⠈⠙⣿⣿⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀
⠀⢻⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀
⠀⢠⡟⡠⠔⡦⠘⣫⣤⣄⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⢟⠭⢽⡀⠀⠀
⠀⠈⢇⣴⡿⢧⡌⠙⠛⠻⠿⠿⢷⣦⠄⠀⠀⢸⣿⡿⠋⢂⠀⢀⠇⠀⠀
⠀⢠⣾⡿⠡⢄⡄⢠⠀⡴⠶⠶⠲⠷⠀⠀⠀⠈⠙⠁⠀⡆⠈⢸⡇⠀⠀
⠀⠀⢏⣴⠞⢛⣷⠀⠀⠑⠒⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠔⠉⡇⠀⠀
⠀⠀⠀⠟⠈⠜⡇⠀⠀⡀⡠⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢠⡌⠀⠀⠀
⠀⠀⢸⠀⡈⢰⡀⢀⠤⠤⠆⠀⠑⢄⠀⢠⠀⠀⠀⠀⠀⠀⢸⠃⠀⠀⠀
⠀⠀⠘⡀⠑⠈⢁⡠⢤⣀⣶⣶⢦⣄⣤⠘⡄⠀⠀⠀⠀⢘⣿⠀⠀⠀⠀
⠀⠀⠀⠐⡜⢄⣿⣞⣉⣡⣷⣿⣾⡟⢛⠸⠀⠀⠀⠀⠀⢈⡇⠀⠀⠀⠀
⠀⠀⠀⠀⠈⢂⢻⢝⠿⠍⢓⡉⠔⠁⣸⠇⠀⠀⠀⠀⠀⡜⠇⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠡⣧⠀⠀⠀⠀⠀⠔⠝⠀⠀⠀⠀⢀⠊⠀⠰⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⡰⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⠄⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⣢⢄⠠⠔⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡌⠢⡀
⠀⠀⠀⠀⠀⠀⠀⡐⠀⢆⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⠀
      G.O.N*/