using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezenaInformada, qtdJogoInformada;
decimal valorPremio;

bool repetir = true;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    while (repetir)
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
                repetir = false; // Condição para sair do loop

                // Gerar jogos
                using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
                {
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        // Gerar as dezenas para o jogo
                        var dezenas = new HashSet<int>();
                        while (dezenas.Count < qtdDezenaInformada)
                        {
                            dezenas.Add(random.Next(1, 61)); // Números de 1 a 60
                        }

                        // Escrever no arquivo
                        escrever.WriteLine($"Jogo {qtdJogo}: {string.Join(", ", dezenas)}");
                    }
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
        }
    }
}
else
{
    Console.WriteLine("Número inválido!");
}

// Solicitar o valor do prêmio
Console.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    // Aqui você pode adicionar a lógica relacionada ao valor do prêmio, se necessário
    Console.WriteLine($"Valor do prêmio informado: {valorPremio:C}");
}
else
{
    Console.WriteLine("Número inválido!");
}
