using System;
using System.IO;

class MegaSena
{
    static void Main()
    {
        Console.Clear();

        string titulo = "Atividade 13 - Jogo da Mega-Sena";
        int largura = titulo.Length;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=".PadLeft(largura, '='));
        Console.WriteLine(titulo);
        Console.WriteLine("=".PadLeft(largura, '='));
        Console.ResetColor();

        Random random = new Random();

        int qtdJogoInformada;
        do
        {
            Console.Write("Deseja realizar quantos jogos?: ");
        } while (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada < 1);

        int qtdDezenaInformada;
        do
        {
            Console.Write("Informe a quantidade de dezenas (entre 6 e 15): ");
        } while (!int.TryParse(Console.ReadLine(), out qtdDezenaInformada) || qtdDezenaInformada < 6 || qtdDezenaInformada > 15);

        // Generate and save the games to a file
        using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
        {
            for (int i = 0; i < qtdJogoInformada; i++)
            {
                HashSet<int> numeros = new HashSet<int>();
                while (numeros.Count < qtdDezenaInformada)
                {
                    int numRandom = random.Next(1, 61);
                    numeros.Add(numRandom);
                }

                var sortedNumbers = numeros.OrderBy(n => n).ToList();
                Console.WriteLine(string.Join("-", sortedNumbers.Select(n => $"{n:D2}")));
                escrever.WriteLine(string.Join("-", sortedNumbers.Select(n => $"{n:D2}")));
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Jogo(s) gerado(s) e salvo(s) no arquivo 'jogos-mega-sena.txt'.");
        Console.ResetColor();

        decimal valorPremio;
        do
        {
            Console.Write("Informe o valor do prêmio: ");
        } while (!decimal.TryParse(Console.ReadLine(), out valorPremio) || valorPremio <= 0);

        decimal valorPremio6Dzn = valorPremio * 0.75m;
        decimal valorPremio5Dzn = valorPremio * 0.15m;
        decimal valorPremio4Dzn = valorPremio * 0.10m;

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Distribuição do prêmio:");
        Console.ResetColor();
        Console.WriteLine($"- {valorPremio6Dzn:C} distribuídos entre quem acertar 6 dezenas;");
        Console.WriteLine($"- {valorPremio5Dzn:C} distribuídos entre quem acertar 5 dezenas;");
        Console.WriteLine($"- {valorPremio4Dzn:C} distribuídos entre quem acertar 4 dezenas.");
    }
}
