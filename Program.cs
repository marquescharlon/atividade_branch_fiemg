using System;
using System.IO;

class Program
{
static void Main()
{
Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(new string('=', largura));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine(new string('=', largura));
Console.ResetColor();


Random random = new Random();

int qtdDezenaInformada;

decimal valorPremio;

bool repetir;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))
{
    do
    {
        repetir = false;
        Console.Write("Informar a quantidade de dezenas: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                {
                    Console.WriteLine("Quantidade de dezenas inválida. Deve ser entre 6 e 15. ");
                    repetir = true;
                }
                else
                {
                Console.WriteLine();
                for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    Console.Write($"jOGO {qtdJogo}: ");
                    for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                     int numeroSorteado = random.Next(1, 61);
                     Console.Write($"{numeroSorteado} ");
                    }
                    Console.WriteLine():
                    }
                    using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
                    {
                     for(int qtdJogo = 1; qtdJogo <= qtdJogoInformada;qtdJogo++)
                     {
                     escrever.Write($"Jogo {qtdJogo}: ");
                     for(int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                     {
                        int numeroSorteado = random.Next(1, 61);
                        escrever.Write($"{numeroSorteado} ");
                     }
                     escreve.WriteLine();
                     }
                    }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Número inválido! ");
                repetir = true;
            }
             while(repetir);
           
// Solicitar o valor do prêmio
Console.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    Console.WriteLine($"O valor do prêmio informado é: {valorPremio:C} ");

//Cálculo Valor do Prêmio
decimal premio6 = valorPremio * 0.75m;
decimal premio5 = valorPremio * 0.15m;
decimal premio4 = valorPremio * 0.10m;
Console.Write("75% do prêmio para quem acertar 6 dezenas: R$" + premio6.ToSting("C"));
Console.Write("15% do prêmio para quem acertar 6 dezenas: R$" + premio5.ToSting("C"));
Console.Write("10% do prêmio para quem acertar 6 dezenas: R$" + premio4.ToSting("C"));
}
else
{
    Console.Write("Valor do Prêmio inválido! ");