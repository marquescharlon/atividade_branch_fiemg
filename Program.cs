using System.IO;

using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
{
    Console.Clear();

    int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=".PadLeft(32, '='));
    Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
    Console.WriteLine("=".PadLeft(32, '='));
    Console.ResetColor();

    Random randNum = new Random();
    int nums = randNum.Next(1, 60);

    int qtdDezena,
        qtdDezenaInformada,
        qtdJogoInformada;

    decimal valorPremio;

    bool repetir = true;

    do
    {
        Console.Write("Deseja realizar quantos jogos: ");
        if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
        {
            Console.Write("Informar a quantidade de dezena: ");
            if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
            {
                if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    repetir = true;
                else
                    repetir = false;

                if (repetir == false)
                {
                    Console.WriteLine();
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                        {
                            nums = randNum.Next(1, 60);
                            Console.Write($" - {nums}");
                            escrever.Write($" - {nums}\n");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                    Console.ResetColor();

                    Console.Write("Informe o valor do prêmio: ");
                    if (decimal.TryParse(Console.ReadLine(), out valorPremio))
                    {
                        repetir = false;
                        decimal premioS = valorPremio * 0.75m;
                        decimal premioC = valorPremio * 0.15m;
                        decimal premioQ = valorPremio * 0.10m;

                        Console.WriteLine($"\nQuem acertar 6 dezenas ganhará: R${Math.Round(premioS, 2)}");
                        Console.WriteLine($"Quem acertar 5 dezenas ganhará: R${Math.Round(premioC, 2)}");
                        Console.WriteLine($"Quem acertar 4 dezenas ganhará: R${Math.Round(premioQ, 2)}");
                    }
                    else
                    {
                        repetir = true;
                        Console.WriteLine("Número inválido!");
                    }
                }
                else
                {
                    Console.WriteLine("O número de dezenas não pode ser inferior a 6 e nem superior a 15.");
                    repetir = true;
                }
            }
            else
            {
                repetir = true;
                Console.WriteLine("Número inválido!");
            }
        }
        else
        {
            repetir = true;
            Console.WriteLine("Número inválido!");
        }
    }
    while (repetir == true);
}