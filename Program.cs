using System;
using System.IO;

Console.Clear();

string titulo = "Atividade 13 - Jogo da Mega-Sena";
int largura = titulo.Length;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(largura, '='));
Console.WriteLine(titulo);
Console.WriteLine("=".PadLeft(largura, '='));
Console.ResetColor();

Random random = new Random();

int qtdDezenaInformada, qtdJogoInformada;

do
{
    Console.Write("Deseja realizar quantos jogos?: ");
} while (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada < 1);

int qtdDezena;
do
{
    Console.Write("Informe a quantidade de dezenas (entre 6 e 15): ");
    if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
    {
        if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A quantidade de dezenas não pode ser menor que 6 ou maior que 15. Tente novamente.");
            Console.ResetColor();
        }
        else
        {
            using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
            {
                for (int i = 0; i < qtdJogoInformada; i++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        int numRandom = random.Next(1, 61);
                        if (qtdDezena != qtdDezenaInformada)
                        {
                            Console.Write($"{numRandom:D2}-");
                            escrever.Write($"{numRandom:D2}-");
                        }
                        else
                        {
                            Console.WriteLine($"{numRandom:D2}");
                            escrever.WriteLine($"{numRandom:D2}");
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jogo(s) gerado(s) e salvo(s) no arquivo 'jogos-mega-sena.txt'.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (qtdDezenaInformada < 6 || qtdDezenaInformada > 15);


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
