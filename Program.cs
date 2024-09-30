using System.IO;
using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt", true))
{
Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(largura, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena\n");
escrever.WriteLine("Atividade 13 - Jogo da Mega-Sena\n");
Console.WriteLine("=".PadLeft(largura, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezena, qtdJogoInformada, qtdJogo;

decimal valorPremio;

bool repetir = true;

Console.Write("\nInforme o valor do prêmio: "); // Solicitar o valor do prêmio
escrever.Write("\nInforme o valor do prêmio: ");
if (!decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    Console.WriteLine("número inválido!");
    escrever.WriteLine("número inválido!");
}
else
{
Console.Write(valorPremio);
escrever.Write(valorPremio);
Console.Write("\nDeseja realizar quantos jogos: ");
escrever.Write("\nDeseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    Console.Write(qtdJogoInformada);
    escrever.Write(qtdJogoInformada);
    do
    {
        int qtdDezenaInformada;
        Console.Write("\nInformar a quantidade de dezena: ");
        escrever.Write("\nInformar a quantidade de dezena: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            Console.Write(qtdDezenaInformada);
            escrever.Write(qtdDezenaInformada);
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
            {
                repetir = true;
            }
                else
                {
                    repetir = false;
                }

            if (repetir == false)
            {
                Console.WriteLine();
                for (qtdJogo = 0; qtdJogo < qtdJogoInformada; qtdJogo++)
                {
                    Console.WriteLine($"\n\njogo {qtdJogo + 1}");
                    escrever.WriteLine($"\n\njogo {qtdJogo + 1}");
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        int numero = random.Next(1, 61);
                        if (qtdDezena == qtdDezenaInformada)
                        {
                            Console.Write($"{numero:D2}");
                            escrever.Write($"{numero:D2}");
                        }
                        else
                        {
                           Console.Write($"{numero:D2}-");
                           escrever.Write($"{numero:D2}-"); 
                        }
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nJogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                escrever.WriteLine("\n\nJogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
                decimal resultado1 = valorPremio * 0.75m;
				decimal resultado2 = valorPremio * 0.15m;
				decimal resultado3 = valorPremio * 0.1m;
                Console.WriteLine($"\n\nSe alguém acertou um total de 6 dezenas, receberá um valor de: {resultado1}.\n");
                escrever.WriteLine($"\n\nSe alguém acertou um total de 6 dezenas, receberá um valor de: {resultado1}.\n");
				Console.WriteLine($"\nSe alguém acertou um total de 5 dezenas, receberá um valor de: {resultado2}.\n");
                escrever.WriteLine($"\n\nSe alguém acertou um total de 6 dezenas, receberá um valor de: {resultado2}.\n");
				Console.WriteLine($"\nSe alguém acertou um total de 4 dezenas, receberá um valor de: {resultado3}.\n");
                escrever.WriteLine($"\n\nSe alguém acertou um total de 6 dezenas, receberá um valor de: {resultado3}.\n");
            }
            else
            {
                Console.WriteLine("Quantidade dezena menor que 6");
                escrever.WriteLine("Quantidade dezena menor que 6");

                repetir = true;
            }
        }
            else
            {
                repetir = true;
                Console.WriteLine("Número inválido!");
                escrever.WriteLine("Número inválido!");
            }
    
    }while (repetir == true);
}
    else
    {
        Console.WriteLine("Número inválido!");
        escrever.WriteLine("Número inválido!");
    }
}
}