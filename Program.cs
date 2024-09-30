using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=".PadLeft(50, '='));
        Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
        Console.WriteLine("=".PadLeft(50, '='));
        Console.ResetColor();


        Random random = new Random();

        int qtdDezenaInformada, qtdJogoInformada;
        decimal valorPremio;
        bool repetir;

        Console.Write("Deseja realizar quantos jogos: ");
        if (int.TryParse(Console.ReadLine(), out qtdJogoInformada) && qtdJogoInformada > 0)
        {
            do
            {
                repetir = false;
                Console.Write("Informar a quantidade de dezena (entre 6 e 15): ");
                if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
                {
                    if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    {
                        Console.WriteLine("Quantidade de dezenas inválida");
                        repetir = true;
                    }
                    else
                    {
                        using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
                        {
                            for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                            {
                                Console.Write($"Jogo {qtdJogo}: ");
                                for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                                {
                                    int dezena = random.Next(1, 61);
                                    if (qtdDezena == qtdDezenaInformada)
                                    {
                                        Console.Write($"{dezena:D2}");
                                        escrever.Write($"{dezena:D2}");
                                    }
                                    else
                                    {
                                        Console.Write($"{dezena:D2}-");
                                        escrever.Write($"{dezena:D2}-");
                                    }
                                }
                                escrever.WriteLine();
                                Console.WriteLine();
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                    repetir = true;
                }

            } while (repetir);
        }

        // Solicitar o valor do prêmio

        Console.Write("Informe o valor do prêmio: ");
        if (decimal.TryParse(Console.ReadLine(), out valorPremio))
        {
            Console.WriteLine($"Valor do prêmio: {valorPremio:C}");
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=".PadLeft(50, '='));
        Console.WriteLine("Distribuição do prêmio");
        Console.WriteLine("=".PadLeft(50, '='));
        Console.ResetColor();

        Console.WriteLine("Acertou as 6 dezenas: 75%\nAcertou 5 dezenas: 15%\nAcertou 4 dezenas: 10%");
    }
}