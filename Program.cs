
using System;
using System.IO;

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

int qtdDezenaInformada;
int qtdJogoInformada;
decimal valorPremio;

bool repetir = true;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))

int qtdDezena,
    qtdDezenaInformada,
    qtdJogo,
    qtdJogoInformada,
    numRandom;

decimal valorPremio,
        valorPremio6Dzn,
        valorPremio5Dzn,
        valorPremio4Dzn;

bool repetir = true;

do

{
    Console.Write("Deseja realizar quantos jogos?: ");
    if (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada < 1)
    {
        Console.Write("Informar a quantidade de dezena: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
            {
                Console.WriteLine("Quantidade de dezenas deve ser entre 6 e 15.");
                repetir = true;
            }
            else
            {
                repetir = false;

                Console.WriteLine();
                for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    Console.Write($"Jogo {qtdJogo}: ");
                    for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        // Gera uma dezena aleatória (aqui apenas um exemplo)
                        int dezena = random.Next(1, 61); // Considerando números de 1 a 60
                        Console.Write($"{dezena} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("Número inválido!");
            repetir = true;
        }
    } while (repetir);
}
else
{
    Console.WriteLine("Número inválido!");
}

// Solicitar o valor do prêmio
Console.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    Console.WriteLine($"Valor do prêmio informado: {valorPremio:C}");
}
else
{
    Console.WriteLine("Número inválido!");
}

        Console.WriteLine("Valor inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (qtdJogoInformada < 1);

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
            Console.WriteLine();
            repetir = false;
            using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
            {
                for (qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        numRandom = random.Next(1, 61);
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jogo(s) gerado(s) e salvo(s) no arquivo 'jogos-mega-sena.txt'.");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (repetir);

do
{
    Console.Write("Informe o valor do prêmio: ");
    if (!decimal.TryParse(Console.ReadLine(), out valorPremio) || valorPremio <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (valorPremio <= 0);

valorPremio6Dzn = valorPremio * 0.75m;
valorPremio5Dzn = valorPremio * 0.15m;
valorPremio4Dzn = valorPremio * 0.10m;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Distribuição do prêmio:");
Console.ResetColor();
Console.WriteLine($"- {valorPremio6Dzn:C} distribuídos entre quem acertar 6 dezenas;");
Console.WriteLine($"- {valorPremio5Dzn:C} distribuídos entre quem acertar 5 dezenas;");
Console.WriteLine($"- {valorPremio4Dzn:C} distribuídos entre quem acertar 4 dezenas.");