using System.IO;


Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(32, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(32, '='));
Console.ResetColor();


Random random = new Random();
int qtdDezena;
int qtdDezenaInformada;
int qtdJogo;
int qtdJogoInformada;
float valorPremio;
bool repetir = false;


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
                Console.WriteLine("Quantidade dezena menor que 6 ou maior que 15! Tente novamente: ");
                repetir = true;
            }
            else
            {
                repetir = false;
                for (qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        Console.Write($"{random.Next(1, 61):D2} ");
                    }
                    Console.Write("\n");
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
        }
    }
    while (repetir == true);
}
else
{
    Console.WriteLine("Número inválido!");
    return;
}


Console.Write("Informe o valor do prêmio: ");
while(!float.TryParse(Console.ReadLine(), out valorPremio))
{
    Console.Write("Número inválido! Tente novamente: ");
}

Console.Write($"O prêmio será divido da seguinte forma:\nTodos acertos (75%): {valorPremio * 0.75}\n1 erro (15%): {valorPremio * 0.15}\n2 erros (10%): {valorPremio * 0.1}");