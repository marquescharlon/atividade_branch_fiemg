using System.IO;
using System.Security.Cryptography;

Console.Clear();

int largura = 32; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(largura, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(largura, '='));
Console.ResetColor();

Random random = new Random();

int qtdDezena,
    qtdDezenaInformada,
    qtdJogo,
    qtdJogoInformada,
    numRandom;

decimal valorPremio;

bool repetir = true;

Console.Write("Deseja realizar quantos jogos?: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    do
    {
        Console.Write("Informar a quantidade de dezenas: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                repetir = true;
            else
                repetir = false;

            if (!repetir)
            {
                Console.WriteLine();
                for (qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        numRandom = random.Next(1, 61);
                        if (qtdDezena != qtdDezenaInformada)
                            Console.Write($"{numRandom}-");
                        else
                            Console.WriteLine(numRandom);
                    }
                }
                // Console.WriteLine();
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                // Console.ResetColor();
            }
            else
            {
                Console.WriteLine("A quantidade de dezenas não pode ser menor que 6 ou maior que 15. Tente novamente.");
                repetir = true;
            }
        }
        else
        {
            Console.WriteLine("Número inválido!");
            repetir = true;
        }
    }
    while (repetir);
}
else
    Console.WriteLine("Número inválido!");

// Solicitar o valor do prêmio

// Console.Write("Informe o valor do prêmio: ");
// if (decimal.TryParse(Console.ReadLine(), out valorPremio))
// {