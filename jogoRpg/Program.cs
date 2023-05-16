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

            int pontosVida = 100;
            int pontosAtaque = 10;
            int pontosDefesa = 5;

            int pontosExperiencia = 0;
            int nivel = 1;
            int experienciaNecessaria = 100;

            bool jogadorVivo = true;

            while (jogadorVivo)
            {
                Console.WriteLine();
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Explorar a masmorra");
                Console.WriteLine("2 - Ver status do personagem");
                Console.WriteLine("3 - Sair do jogo");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                Console.WriteLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Você está explorando a masmorra...");
                        Combate(ref pontosVida, ref pontosExperiencia, ref nivel, ref pontosAtaque, ref pontosDefesa);
                        break;

                    case "2":
                        Console.WriteLine($"Status do personagem - {nomePersonagem}:");
                        Console.WriteLine($"Nível: {nivel}");
                        Console.WriteLine($"Experiência: {pontosExperiencia}/{experienciaNecessaria}");
                        Console.WriteLine($"Pontos de Vida: {pontosVida}");
                        Console.WriteLine($"Pontos de Ataque: {pontosAtaque}");
                        Console.WriteLine($"Pontos de Defesa: {pontosDefesa}");
                        break;

                    case "3":
                        Console.WriteLine("Obrigado por jogar!");
                        jogadorVivo = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha novamente.");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void Combate(ref int pontosVida, ref int pontosExperiencia, ref int nivel, ref int pontosAtaque, ref int pontosDefesa)
        {
            List<string> nomes = new List<string>()
        {
            "João",
            "Maria",
            "Pedro",
            "Ana",
            "Lucas",
            "Mariana",
            "Roberto",
            "Gobilim",
            "Rogerio",
            "Roma",
            "Jesus",
            "Deus",
            "Demonio",
            "Satan"
        };

            Random random = new Random();
            // Escolhe um nome aleatório da lista
            string nomeAleatorio = nomes[random.Next(nomes.Count)];
            int inimigoVida = random.Next(50, 101);
            int inimigoAtaque = random.Next(5, 11);
            int inimigoDefesa = random.Next(2, 6);

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
                                        Console.WriteLine("\nDigite o quanto de dano você deseja dar: ");
                                        pontosAtaque = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}.");
                                        break;

                                    case "2":
                                        Console.WriteLine("\nDigite o quanto de defesa você deseja ter: ");
                                        pontosDefesa = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Seus pontos de defesa aumentaram para {pontosDefesa}.");
                                        break;
                                    case "3":
                                        Console.WriteLine("\nDigite o quanto de dano você deseja dar: ");
                                        pontosAtaque = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Seus pontos de ataque aumentaram para {pontosAtaque}.");
                                        Console.WriteLine("\nDigite o quanto de defesa você deseja ter: ");
                                        pontosDefesa = Convert.ToInt32(Console.ReadLine());
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





