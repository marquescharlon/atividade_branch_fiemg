using System.IO;

using System;
using System.IO;

using System;
using System.IO;

class Program
{
    static void Main()
    {
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

        Console.Write("Deseja realizar quantos jogos: ");
        if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
        {
            for (int i = 0; i < qtdJogoInformada; i++)
            {
                bool repetir;
                do
                {
                    Console.Write("Informar a quantidade de dezenas (6 a 15): ");
                    if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
                    {
                        if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                        {
                            Console.WriteLine("Quantidade de dezenas deve ser entre 6 e 15. Tente novamente.");
                            repetir = true;
                        }
                        else
                        {
                            repetir = false;
                            Console.WriteLine($"Jogo {i + 1}:");
                            for (int j = 0; j < qtdDezenaInformada; j++)
                            {
                                // Gerar um número aleatório de 1 a 60, por exemplo
                                int dezena = random.Next(1, 61);
                                Console.Write($"{dezena} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido! Tente novamente.");
                        repetir = true;
                    }
                } while (repetir);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jogos gerados com sucesso.\n");
            Console.ResetColor();
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
            Console.WriteLine("Valor inválido!");
        }
    }
}
