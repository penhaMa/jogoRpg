using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo RPG!");

            Console.Write("Digite o nome do seu personagem: ");
            string nomePersonagem = Console.ReadLine();

            Console.WriteLine($"Bem-vindo, {nomePersonagem}!");

            int pontosVida = 0;
            int pontosAtaque = 0;
            int pontosDefesa = 0;

            int pontosExperiencia = 0;
            int nivel = 1;
            int experienciaNecessaria = 100;

            bool escolhaClasse = true;

            while (escolhaClasse)
            {
                Console.WriteLine();
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Mago");
                Console.WriteLine("2 - Arqueiro");
                Console.WriteLine("3 - Guerreiro");
                Console.WriteLine("4 - Jogar");
                Console.WriteLine("5 - Sair do jogo");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                Console.WriteLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine($"Status do personagem - {nomePersonagem}:");
                        Console.WriteLine($"Nível: {nivel}");
                        Console.WriteLine($"Experiência: {pontosExperiencia}/{experienciaNecessaria}");
                        Console.WriteLine($"Pontos de Vida: {pontosVida = 120}");
                        Console.WriteLine($"Pontos de Ataque: {pontosAtaque = 5}");
                        Console.WriteLine($"Pontos de Defesa: {pontosDefesa = 7}");
                        break;

                    case "2":
                        Console.WriteLine($"Status do personagem - {nomePersonagem}:");
                        Console.WriteLine($"Nível: {nivel}");
                        Console.WriteLine($"Experiência: {pontosExperiencia}/{experienciaNecessaria}");
                        Console.WriteLine($"Pontos de Vida: {pontosVida = 110}");
                        Console.WriteLine($"Pontos de Ataque: {pontosAtaque = 10}");
                        Console.WriteLine($"Pontos de Defesa: {pontosDefesa = 10}");
                        break;

                    case "3":
                        Console.WriteLine($"Status do personagem - {nomePersonagem}:");
                        Console.WriteLine($"Nível: {nivel}");
                        Console.WriteLine($"Experiência: {pontosExperiencia}/{experienciaNecessaria}");
                        Console.WriteLine($"Pontos de Vida: {pontosVida = 100}");
                        Console.WriteLine($"Pontos de Ataque: {pontosAtaque = 15}");
                        Console.WriteLine($"Pontos de Defesa: {pontosDefesa = 15}");
                        break;
                    case "4":
                        Console.Clear();
                        Continuar();
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por jogar!");
                        escolhaClasse = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha novamente.");
                        break;
                }
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

            void Continuar()
            {
                bool jogadorVivo = true;

                while (jogadorVivo)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opções:");
                    Console.WriteLine("1 - Explorar Masmorra");
                    Console.WriteLine("2 - Ver status do personagem");
                    Console.WriteLine("3 - Voltar");
                    Console.Write("Escolha uma opção: ");

                    string escolha = Console.ReadLine();

                    Console.WriteLine();

                    switch (escolha)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Você está explorando a Masmorra...");
                            Combate(ref pontosVida, ref pontosExperiencia, ref nivel, ref pontosAtaque, ref pontosDefesa);
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine($"Status do personagem - {nomePersonagem}:");
                            Console.WriteLine($"Nível: {nivel}");
                            Console.WriteLine($"Experiência: {pontosExperiencia}/{experienciaNecessaria}");
                            Console.WriteLine($"Pontos de Vida: {pontosVida}");
                            Console.WriteLine($"Pontos de Ataque: {pontosAtaque}");
                            Console.WriteLine($"Pontos de Defesa: {pontosDefesa}");
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Obrigado por jogar!");
                            jogadorVivo = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Escolha novamente.");
                            break;
                    }
                }
            }
        }

        static void Combate(ref int pontosVida, ref int pontosExperiencia, ref int nivel, ref int pontosAtaque, ref int pontosDefesa)
        {
            List<string> nomes = new List<string>()
        {
            "Diablo",
            "The Lich King",
            "Zeus ",
            "Ridley ",
            "Dr. Robotnik",
            "Lavos",
            "The Illusive Man",
            "Vergil",
            "Ornstein and Smough",
            "Vaas Montenegro",
            "The Butcher",
            "Nemesis",
            "Ardyn Izunia",
            "General Raam",
            "Medusa",
            "The Nameless King",
            "King K. Rool",
            "Gruntilda",
            "Kefka",
            "Andrew Ryan",
            "Gwyn, Lord of Cinder",
            "The Master Chief",
            "The Boss",
            "M. Bison",
            "King Dedede",
            "Mother Brain",
            "Psycho Mantis",
            "Zeus",
            "Lord Gwyn",
            "Ganondorf",
            "Bowser Jr.",
            "Artorias the Abysswalker",
            "Liquid Snake",
            "The Reaper",
            "The Witch King",
            "Ultimecia",
            "Mysterio",
            "Sin",
            "Albert Wesker",
            "Shang Tsung",
            "The White Witch",
            "General Shepherd",
            "Saren Arterius",
            "The Sorrow",
            "El Gigante",
            "The Overlord",
            "Malthael",
            "Shadow Queen",
            "Dark Samus",
            "Alduin"
        };
            Random random = new Random();
            // Escolhe um nome aleatório da lista
            string nomeAleatorio = nomes[random.Next(nomes.Count)];
            int inimigoVida = random.Next(90, 101);
            int inimigoAtaque = random.Next(5, 17);
            int inimigoDefesa = random.Next(2, 13);

            Console.WriteLine($"{nomeAleatorio} apareceu!");
            Console.WriteLine($"Vida do inimigo: {inimigoVida}");
            Console.WriteLine($"Ataque: {inimigoAtaque}");
            Console.WriteLine($"Defesa: {inimigoDefesa}");

                bool combateAtivo = true;

            while (combateAtivo)
            {
                Console.WriteLine();
                Console.WriteLine("Opções de combate:");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Fugir");
                Console.Write("Escolha uma opção: ");

                string escolhaCombate = Console.ReadLine();

                Console.WriteLine();

                switch (escolhaCombate)
                {
                    case "1":
                        // Calcula dano ao inimigo
                        int danoInimigo = pontosAtaque - inimigoDefesa;
                        danoInimigo = Math.Max(danoInimigo, 0); // Não pode causar dano negativo
                        inimigoVida -= danoInimigo;
                        Console.WriteLine($"Você causou {danoInimigo} de dano em {nomeAleatorio}");

                        if (inimigoVida <= 0)
                        {
                            Console.WriteLine($"Você derrotou {nomeAleatorio}!");
                            combateAtivo = false;

                            pontosVida = 100; // Recupera todos os pontos de vida após derrotar um inimigo

                            // Ganha experiência
                            int experienciaGanha = random.Next(20, 41);
                            pontosExperiencia += experienciaGanha;
                            Console.WriteLine($"Você ganhou {experienciaGanha} pontos de experiência!");

                            int experienciaNecessaria = 100;
                            // Verifica se subiu de nível
                            if (pontosExperiencia >= experienciaNecessaria)
                            {
                                nivel++;
                                pontosExperiencia = 0; // Reinicia a experiência para o próximo nível
                                experienciaNecessaria *= 2; // Dobra a experiência necessária a cada nível
                                pontosVida += 10; // Aumenta os pontos de vida ao subir de nível

                                Console.WriteLine($"Parabéns! Você subiu para o nível {nivel}!");
                                Console.WriteLine($"Experiência necessária para o próximo nível: {experienciaNecessaria}");
                                Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}, seus pontos de defesa aumentaram para {pontosDefesa} e seus pontos de vida aumentaram para {pontosVida}.");

                                Console.WriteLine("Escolha como deseja evoluir:");
                                Console.WriteLine("1 - Aumentar Ataque");
                                Console.WriteLine("2 - Aumentar Defesa");
                                Console.WriteLine("3 - Aumentar Defesa e Ataque");
                                Console.Write("Escolha uma opção: ");

                                string escolhaEvolucao = Console.ReadLine();

                                switch (escolhaEvolucao)
                                {
                                    case "1":
                                        pontosAtaque += 10;
                                        Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}.");
                                        break;

                                    case "2":
                                        pontosDefesa += 7; 
                                        Console.WriteLine($"Seus pontos de defesa aumentaram para {pontosDefesa}.");
                                        break;
                                    case "3":
                                        pontosAtaque += 4; 
                                        Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}.");

                                        pontosDefesa += 3;
                                        Console.WriteLine($"Seus pontos de defesa aumentaram para {pontosDefesa}.");
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida! Os pontos de evolução foram distribuídos de forma aleatória.");
                                        int escolhaAleatoria = random.Next(1, 3);
                                        if (escolhaAleatoria == 1)
                                        {
                                            pontosAtaque += 10;
                                            Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}.");
                                        }
                                        else
                                        {
                                            pontosDefesa += 7;
                                            Console.WriteLine($"Seus pontos de defesa aumentaram para {pontosDefesa}.");
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            // Calcula dano recebido do inimigo
                            int danoRecebido = inimigoAtaque - pontosDefesa;
                            danoRecebido = Math.Max(danoRecebido, 0); // Não pode receber dano negativo

                            pontosVida -= danoRecebido;
                            Console.WriteLine($"Você recebeu {danoRecebido} de dano do inimigo!");

                            if (pontosVida <= 0)
                            {
                                Console.WriteLine("Você foi derrotado!");
                                combateAtivo = false;
                                break;
                            }

                            Console.WriteLine($"Vida do inimigo: {inimigoVida}");
                            Console.WriteLine($"Sua vida: {pontosVida}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Você fugiu do combate!");
                        combateAtivo = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha novamente.");
                        break;
                }
            }
        }
    }
}





