using System.IO;
        Console.Clear();

        string titulo = "Atividade 13 - Jogo da Mega-Sena";
        int largura = titulo.Length;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=".PadLeft(largura, '='));
        Console.WriteLine(titulo);
        Console.WriteLine("=".PadLeft(largura, '='));
        Console.ResetColor();


        Random random = new Random();

        int qtdDezena,
            qtdDezenaInformada
    qtdJogoInformada,
            qtdJogo;

        decimal valorPremio,
        valorPremio6,
        valorPremio5,
        valorPremio4;

        bool repetir = false;

        do
        {
            Console.Write("Quantos jogos deseja realizar?: ");
            if (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("VALOR INVÁLIDO! Tente novamente.");
                Console.ResetColor();
            }
        } while (qtdJogoInformada < 1);

        {
            do
            {
                Console.Write("Informe uma quantidade de dezena entre 6 e 15: ");
                if (TryParse(Console.ReadLine(), out qtdDezenaInformada))
                {
                    if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("APENAS DEZENAS ENTRE 6 E 15! Tente novamente.");
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
                        Console.WriteLine("Jogo gerado(s) e salvo(s) no arquivo 'jogos-mega-sena.txt'.");
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
            Console.WriteLine("VALORES DOS PRÊMIOS");
            Console.ResetColor();
            Console.WriteLine($"- Se acertou 6 dezenas: {valorPremio6Dzn:C}");
            Console.WriteLine($"- Se acertou 5 dezenas: {valorPremio5Dzn:C}");
            Console.WriteLine($"- Se acertou 4 dezenas: {valorPremio4Dzn:C}");

            // Solicitar o valor do prêmio
            Console.Write("Informe o valor do prêmio: ");
            if (decimal.TryParse(Console.ReadLine(), out valorPremio))
    }
