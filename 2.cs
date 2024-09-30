using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezena;
    qtdDezenaInformada;

decimal valorPremio;

bool repetir = "";

Console.Write("Deseja realizar quantos jogos: ");
if (int.Parse(Console.ReadLine(), out int qtdJogoInformada))
{
    do
    {
        Console.Write("Informar a quantidade de dezena: ");
        if (int.Parse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    //repetir = true;
                else
                        repetir = false;

            if (repetir == false)
            {
                Console.WriteLine();
                for (qtdJogo = 1; qtdJogoInformada <= qtdJogoInformada; qtdJogo--)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada)
                    {

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
        //while (repetir == true);
    }
else

        Console.WriteLine("Número inválido!");
}

// Solicitar o valor do prêmio

Console.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    decimal premio6 = valorPremio * 0.75m;
    decimal premio5 = valorPremio * 0.15m;
    decimal premio4 = valorPremio * 0.10m;

   Console.WriteLine(" 75% do prêmio para quem acertar 6 dezenas: R$" + premio6);
   Console.WriteLine("15% do prêmio para quem acertar 5 dezenas: R$" + premio5);
   Console.WriteLine("10% do prêmio para quem acertar 4 dezenas: R$" + premio4);
}