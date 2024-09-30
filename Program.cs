using System;
using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabecalho conforme necessario

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(largura / 2, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(largura / 2, '='));
Console.ResetColor();

 Random random = new Random();

int qtdDezenaInformada,
    qtdJogoInformada;
decimal valorPremio;

bool repetir;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    do
    {
        Console.Write("Informar a quantidade de dezenas (6 a 15): ");
          repetir = false; // Reseta a variavel de repeticao

        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
            {
                 Console.WriteLine("Quantidade de dezenas deve ser entre 6 e 15.");
                    repetir = true;
            }
            else
            {
                Console.WriteLine();
                using (StreamWriter writer = new StreamWriter("jogos-mega-sena.txt"))
                {
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                         Console.Write($"Jogo {qtdJogo}: ");
                                int[] dezenas = new int[qtdDezenaInformada];

                                for (int i = 0; i < qtdDezenaInformada; i++)
                                {
                                    int dezena;
                                    do
                                    {
                                        dezena = random.Next(1, 61); // Gera um numero entre 1 e 60
                                    } while (Array.Exists(dezenas, d => d == dezena)); // Verifica se a dezena ja foi escolhida

                                    dezenas[i] = dezena;

                                }

                                Array.Sort(dezenas);
                                Console.WriteLine(string.Join(",", dezenas));
                                writer.WriteLine(string.Join(",", dezenas));
                                }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("Numero invalido!");
            repetir = true;
        }
    } while (repetir);
}
else
{
    Console.WriteLine("Numero invalido!");
}

// Solicitar o valor do premio
Console.Write("Informe o valor do premio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    decimal premioPorJogo = valorPremio / qtdJogoInformada;
    Console.WriteLine($"Valor do premio infrmado: {valorPremio:C}");
    Console.WriteLine($"Cada jogo recebera: {premioPorJogo:C}");
}
else
{
    Console.WriteLine("Valor do premio invalido!");
}


