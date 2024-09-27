using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezena
    qtdDezenaInformada;

decimal valorPremio;

bool repetir = false;

Console.Write("Informe o valor do prêmio: "); // Solicitar o valor do prêmio
if (!decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    Console.WriteLine("número inválido!");
}
else
{
Console.Write("Deseja realizar quantos jogos: ");
if (int.Parse(Console.ReadLine(), out qtdJogoInformada))
{
    do
    {
        Console.Write("Informar a quantidade de dezena: ");
        if (int.Parse(Console.ReadLine(), out qtdDezenaInformada))
        {
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
                for (qtdJogo = 1; qtdJogoInformada <= qtdJogoInformada; qtdJogo++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        int numero = random.Next(1, 61);
                        Console.Write(numero.ToString("D2") + " ");
                        escrever.Write(numero.ToString("D2") + " ");
                    }
                    escrever.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
            }
            else
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
    } while (repetir == true);
    else
    {
        Console.WriteLine("Número inválido!");
    }
}
}



