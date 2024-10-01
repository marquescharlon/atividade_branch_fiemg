
﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Remover ou comentar a linha abaixo para evitar o erro de "Identificador inválido"
        // Console.Clear();

        // Cabeçalho do programa
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(new string('=', 37)); // Linha de '='
        Console.WriteLine("Atividade 13 - Jogo da Mega-Sena".PadLeft(28));
        Console.WriteLine(new string('=', 37));
        Console.ResetColor();

        Random random = new Random();
        int qtdJogoInformada, qtdDezenaInformada;
        decimal valorPremio;
        bool repetir;

        // Solicitar quantidade de jogos
        Console.Write("Deseja realizar quantos jogos? ");
        if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
        {
            do
            {
                repetir = false; // Resetar flag de repetição
                Console.Write("Informe a quantidade de dezenas (entre 6 e 15): ");
                
                if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
                {
                    if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    {
                        Console.WriteLine("Quantidade de dezenas deve ser entre 6 e 15.");
                        repetir = true; // Voltar para a solicitação se o valor for inválido
                    }
                    else
                    {
                        // Gerar os jogos e salvar no arquivo .txt
                        using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
                        {
                            Console.WriteLine();
                            for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                            {
                                HashSet<int> dezenas = new HashSet<int>(); // Usar HashSet para evitar repetição de números

                                Console.Write($"Jogo {qtdJogo}: ");
                                escrever.Write($"Jogo {qtdJogo}: ");
                                
                                while (dezenas.Count < qtdDezenaInformada)
                                {
                                    int dezena = random.Next(1, 61); // Gera número entre 1 e 60
                                    if (dezenas.Add(dezena)) // Adiciona ao HashSet se ainda não tiver sido sorteado
                                    {
                                        Console.Write(dezena + " ");
                                        escrever.Write(dezena + " ");
                                    }
                                }
                                Console.WriteLine();
                                escrever.WriteLine();
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                    repetir = true;
                }
            } while (repetir); // Repete enquanto necessário

            // Solicitar o valor do prêmio
            Console.Write("Informe o valor do prêmio: ");
            if (decimal.TryParse(Console.ReadLine(), out valorPremio))
            {
                // Calcular a premiação
                decimal premio6 = valorPremio * 0.75m; // 75% para 6 dezenas
                decimal premio5 = valorPremio * 0.15m; // 15% para 5 dezenas
                decimal premio4 = valorPremio * 0.10m; // 10% para 4 dezenas

                // Exibir os valores
                Console.WriteLine($"\nValor do prêmio total: {valorPremio:C}");
                Console.WriteLine($"Premiação para quem acertar 6 dezenas: {premio6:C}");
                Console.WriteLine($"Premiação para quem acertar 5 dezenas: {premio5:C}");
                Console.WriteLine($"Premiação para quem acertar 4 dezenas: {premio4:C}");
            }
            else
            {
                Console.WriteLine("Valor do prêmio inválido! Programa encerrado.");
            }
        }
        else
        {
            Console.WriteLine("Número de jogos inválido! Programa encerrado.");
        }
    }
}
