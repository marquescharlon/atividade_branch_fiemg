using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdJogoInformada;
int qtdDezenaInformada;

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
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15){
                    Console.WriteLine("A quantidade de dezenas deve ser pelo menos 6 e no máximo 15!");
                    repetir = true;
            }
            else{
                for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        if(qtdDezena == qtdDezenaInformada)
                            Console.Write(random.Next(1, 61));
                        else
                            Console.Write(random.Next(1, 61) + " - ");
                    }
                    Console.WriteLine();

                    
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
                repetir = false;
            }
        }
        else
            {
                repetir = true;
                Console.WriteLine("Número inválido!");
            }
    }while (repetir == true);

}
else
        Console.WriteLine("Número inválido!");


// Solicitar o valor do prêmio

/*IConsole.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{*/

