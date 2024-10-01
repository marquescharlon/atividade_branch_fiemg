using System.IO;
internal class Program
{
    private static void Main()
    {
Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int  qtdDezenaInformada,  qtdJogoInformada;

decimal valorPremio;

bool repetir;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    do
    {
        repetir = false;
        Console.Write("Informar a quantidade de dezena (entre 6 e 15): ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
            {
                    Console.WriteLine("Quantidade de dezenas inválida!");
                        repetir = true;
            }
            else
            {
                using(StreamWriter escrever = new StreamWriter ("jogos-mega-sena.txt"))
                {
                for(int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    Console.Write($"Jogo {qtdJogo}: ");
                    for(int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
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
                        Console.Write($"{dezena:D2}-");
                    }
                    }
                    escrever.WriteLine();
                    Console.WriteLine();
                }
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                  Console.ResetColor();
                }
            }
                }
                else
                {
                    Console.WriteLine("Numero invalido!");
                    repetir = true;
                }
    }
    while (repetir);
}
              Console.Write("Informe o valor do premio: ");
              if (decimal.TryParse(Console.ReadLine(), out valorPremio ))
              {
                Console.WriteLine($"Valor do premio: {valorPremio:C}");
              }
              else 
              {
                Console.WriteLine("Numero invalido!");
              }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=".PadLeft(50, '='));
                Console.WriteLine("Distribuiçao do premio");
                Console.WriteLine("=".PadLeft(50, '='));
                Console.ResetColor();
                Console.WriteLine("Acertou as 6 dezenas: 75%\nAcertou 5 dezenas: 15%\nAcertou 4 dezenas: 10%");
    }
    }