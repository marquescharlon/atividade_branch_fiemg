using System;
using System.Collections.Generic;
using System.IO;

Console.Clear();

using (StreamWriter escrever = new StreamWriter("Jogos-mega.txt"))
{
    int largura = 32; // Ajuste a largura do cabeçalho conforme necessário

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=".PadLeft(largura, '='));
    Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
    Console.WriteLine("=".PadLeft(largura, '='));
    Console.ResetColor();


    Random random = new Random();

    int qtdDezena;
    int qtdDezenaInformada;
    float valorPremio;

    bool repetir = true;

    Console.Write("Deseja realizar quantos jogos: ");
    if (int.TryParse(Console.ReadLine(), out int qtdJogoInformada))
    {
        do
        {
            Console.Write("Informar a quantidade de dezena: ");
            if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
            {
                if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                        //repetir = true;
                        repetir = true;
                    else
                            repetir = false;

                if (repetir == false)
                {
                    Console.WriteLine();
                    for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        Console.Write("\x0A" + qtdJogo + "º jogo: ");
                        HashSet<int> un = new HashSet<int>();
                        string num = "";
                        for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                        {
                            int rn;
                            do
                            {
                                rn = new Random().Next(1, 61);
                            } while (!un.Add(rn));

                            if (qtdDezena > 1)
                            {
                                num += "-";
                            }
                            num += rn.ToString("D2");
                        }
                        Console.WriteLine(num);
                        escrever.WriteLine(num);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                    Console.ResetColor();
                }
                else if(qtdDezenaInformada < 6)
                {
                    Console.WriteLine("Quantidade dezena menor que 6");
                    repetir = true;

                }
                else
                {
                    repetir = true;
                    Console.WriteLine("Número inválido!");
                }
            }
            //while (repetir == true);
        }while(repetir == true);
    }
    else
    {
    Console.WriteLine("Número inválido!");
    }

        // Solicitar o valor do prêmio
    Console.Write("Informe o valor do prêmio: ");
    if(!float.TryParse(Console.ReadLine(), out valorPremio))
    {
        Console.WriteLine("Valor inválido");
    }
    Console.Write($"\x0A 75% do prêmio será dividido aos que acertarem às 6 dezenas, equivalente a : {valorPremio * 0.75:F2} \x0A 15% Para quem acertar 5 dezenas, equivalente a : {valorPremio * 0.15:F2} \x0A 10% Para quem acertar 4 dezenas, equivalente a : {valorPremio * 0.10:F2}");
}
