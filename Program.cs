
main
using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
{
    Console.Clear();

    int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=".PadLeft(37, '='));
    Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
    Console.WriteLine("=".PadLeft(37, '='));
    Console.ResetColor();


    Random random = new Random();

    int qtdDezenaInformada;
    bool repetir = true;
    //asfubafafafaf

    Console.Write("Deseja realizar quantos jogos: ");
    if (int.TryParse(Console.ReadLine(), out int qtdJogoInformada))
    {
        do
        {
            repetir = false;
            Console.Write("Informar a quantidade de dezenas (entre 6 e 15): ");
            if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
            {
                if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    repetir = true;
                else
                    repetir = false;

                if (!repetir)
                {
                    Console.WriteLine();
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        
                            Console.WriteLine($"Jogo {qtdJogo} ");
                            escrever.WriteLine($"Jogo {qtdJogo} ");

                            HashSet<int> numerosSorteados = new HashSet<int>();

                            while (numerosSorteados.Count < qtdDezenaInformada)
                            {
                                int num = random.Next(1, 61);
                                if (numerosSorteados.Add(num))
                                {
                                    Console.Write($"-{num} ");
                                    escrever.Write($"-{num} ");
                                }
                            }
                            Console.WriteLine();
                            escrever.WriteLine();
                    
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                    Console.ResetColor();
                }
                }
                else
                {
                    repetir = true;
                    Console.WriteLine("Quantidade dezena menor que 6");
                }
            } while (repetir);
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    }

    Console.Write("Informe o valor do prêmio: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal valorPremio))
    {
        decimal premio6dezenas = valorPremio *0.75M;
        decimal premio5dezenas = valorPremio *0.15M;
        decimal premio4dezenas = valorPremio *0.10M;

        Console.WriteLine("\nDistribuição do Prêmio");
        Console.WriteLine($"- 75% para quem acertar 6 dezenas: {premio6dezenas:C}");
        Console.WriteLine($"- 15% para quem acertar 6 dezenas: {premio5dezenas:C}");
        Console.WriteLine($"- 10% para quem acertar 6 dezenas: {premio4dezenas:C}");
        Console.WriteLine($"Valor do prêmio informado: {valorPremio:C}");
    }
    else
    {
        Console.WriteLine("Valor do prêmio inválido!");
    }









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
        Console.ForegroundColor = ConsoleColor.Red;
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
develop

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