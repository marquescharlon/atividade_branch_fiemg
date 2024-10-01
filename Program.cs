using System.IO;

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









