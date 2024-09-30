using System;
using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();

Random random = new Random();

int qtdDezenaInformada;
int qtdJogoInformada;
decimal valorPremio;

bool repetir = true;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    do
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
