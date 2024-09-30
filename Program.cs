using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao gerador de jogos de Mega-Sena!");

        // Fase 2: Solicitar a quantidade de jogos
        Console.Write("Informe a quantidade de jogos que deseja fazer: ");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Fase 3: Solicitar a quantidade de dezenas
        int quantidadeDezenas;
        do
        {
            Console.Write("Informe a quantidade de dezenas (6 a 15): ");
            quantidadeDezenas = int.Parse(Console.ReadLine());
        } while (quantidadeDezenas < 6 || quantidadeDezenas > 15);

        // Gerar os jogos
        List<string> jogos = new List<string>();
        Random random = new Random();
        
        for (int i = 0; i < quantidadeJogos; i++)
        {
            HashSet<int> dezenas = new HashSet<int>();
            while (dezenas.Count < quantidadeDezenas)
            {
                dezenas.Add(random.Next(1, 61)); // Números entre 1 e 60
            }
            List<int> dezenasOrdenadas = new List<int>(dezenas);
            dezenasOrdenadas.Sort();
            jogos.Add(string.Join("-", dezenasOrdenadas));
        }

        // Exibir os jogos
        Console.WriteLine("\nJogos gerados:");
        foreach (var jogo in jogos)
        {
            Console.WriteLine(jogo);
        }

        // Fase 5: Salvar o jogo em um arquivo .TXT
        using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
        {
            foreach (var jogo in jogos)
            {
                escrever.WriteLine(jogo);
            }
        }

        Console.WriteLine("\nJogos salvos em 'jogos-mega-sena.txt'.");

        // Fase 6: Solicitar o valor do prêmio
        Console.Write("Informe o valor do prêmio: ");
        decimal premio = decimal.Parse(Console.ReadLine());

        // Fase 7: Calcular a distribuição do prêmio
        decimal premioSeisDezenas = premio * 0.75m;
        decimal premioCincoDezenas = premio * 0.15m;
        decimal premioQuatroDezenas = premio * 0.10m;

        Console.WriteLine($"\nDistribuição do prêmio:");
        Console.WriteLine($"75% para quem acertar 6 dezenas: {premioSeisDezenas:C}");
        Console.WriteLine($"15% para quem acertar 5 dezenas: {premioCincoDezenas:C}");
        Console.WriteLine($"10% para quem acertar 4 dezenas: {premioQuatroDezenas:C}");
    }
}
