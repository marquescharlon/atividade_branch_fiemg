using System.IO;

Console.Clear();
//int largura = 50; // Ajuste a largura do cabeçalho conforme necessário
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();
Random random = new Random();

        int qtdDezena, qtdDezenaInformada = 0, qtdJogo, qtdJogoInformada = 0;
        decimal valorPremio;
        bool repetir = true;

        // Solicitar a quantidade de jogos
        Console.Write("Deseja realizar quantos jogos: ");
        if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
        {
            do
            {
                // Solicitar a quantidade de dezenas
                Console.Write("Informar a quantidade de dezenas: ");
                if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
                {
                    if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    {
                        Console.WriteLine("Quantidade de dezenas inválida.");
                    }
                    else
                    {
                        repetir = false;
                        Console.WriteLine();
                        for (qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                        {
                            for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                            {
                                int numero = random.Next(1, 61); // Números de 1 a 60
                                Console.Write(numero + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                }
            } while (repetir == true);

            // Solicitar o valor do prêmio
            Console.Write("Informe o valor do prêmio: ");
            if (decimal.TryParse(Console.ReadLine(), out valorPremio))
            {
                Console.WriteLine($"Valor do prêmio informado: {valorPremio:F2}");
            }
            else
            {
                Console.WriteLine("Valor do prêmio inválido.");
            }
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    


