using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Clear();

        int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=".PadLeft(37, '='));
        Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
        Console.WriteLine("=".PadLeft(37, '='));
        Console.ResetColor();

        Random random = new Random();

        int qtdJogoInformada;
        int qtdDezenaInformada;
        decimal valorPremio;
        decimal resultado = 0;

        Console.Write("Informe o valor do prêmio: ");
        while (!decimal.TryParse(Console.ReadLine(), out valorPremio))
        {
            Console.WriteLine("Número inválido! Por favor, informe um valor válido.");
            Console.Write("Informe o valor do prêmio: ");
        }

        Console.Write("Deseja realizar quantos jogos: ");
        while (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada <= 0)
        {
            Console.WriteLine("Número inválido! Por favor, informe um valor válido.");
            Console.Write("Deseja realizar quantos jogos: ");
        }

        do
        {
            Console.Write("Informar a quantidade de dezenas (6 a 15): ");
            if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
            {
                if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                {
                    Console.WriteLine("Quantidade de dezenas deve estar entre 6 e 15.");
                }
                else
                {
                    // Aqui você pode gerar os jogos e salvar em um arquivo
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        // Gerar números aleatórios para o jogo
                        Console.Write($"Jogo {qtdJogo}: ");
                        for (int qtdDezena = 0; qtdDezena < qtdDezenaInformada; qtdDezena++)
                        {
                            Console.Write(random.Next(1, 61) + " "); // Números de 1 a 60
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Jogos gerados com sucesso!\n");
                    
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Número inválido! Por favor, informe um valor válido.");
            }
        } while (qtdDezenaInformada < 6 || qtdDezenaInformada > 15);

    // Solicitar o valor do prêmio
        if (qtdDezenaInformada == 6)
        {
            resultado = valorPremio * 0.75m;
        }
        else if (qtdDezenaInformada == 5)
        {
            resultado = valorPremio * 0.15m;
        }
        else if (qtdDezenaInformada == 4)
        {
            resultado = valorPremio * 0.10m;
        }

        Console.WriteLine($"O valor do prêmio será de: {Math.Round(resultado, 2)} reais.");
    }
}