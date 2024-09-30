using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();


int qtdDezena, // adicionado a virgula
    qtdJogoInformada, // declarando a variavel
    qtdDezenaInformada,//declarando a variavel
    qtdJogo,//declarando a variavel
    dezenas;//declarando a variavel

decimal valorPremio;

bool repetir = false; //corrigindo de string para bool e adicionando o false
 returntwo:
Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))//corrigindo e adicionando TryParse
{
    do
    {
        Console.Write("Informar a quantidade de dezena: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))//corrigindo e adicionando TryParse
        {
            if (qtdDezenaInformada < 6 && qtdDezenaInformada > 15)//troca de sinais e do e/ou
            {
                repetir = true;//adicionando as chaves
            }
            else
            {
                repetir = false;//adicionando as chaves
            }

            if (repetir == false)
            {
                Console.WriteLine();
                //salvar o jogo/bolão em arquivo .TXT
                using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
                {
                    for (qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                    {
                        for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                        {
                            dezenas = random.Next(1, 61);
                            if (qtdDezena == qtdDezenaInformada)//impressão das dezenas com -
                            {
                                Console.Write($"{dezenas:D2}\n");
                                escrever.Write($"{dezenas:D2}\n");
                            }
                            else
                            {
                                Console.Write($"{dezenas:D2}-");
                                escrever.Write($"{dezenas:D2}-");
                            }
                        }
                    }
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
        } //adicionando as chaves   
        else
        {
            repetir = true;
            Console.WriteLine("Número inválido!");
        }
    }
    while (repetir == true);//descomentando while
}
else
{
    Console.WriteLine("Número inválido!");
    goto returntwo;//adicionando loop de validação
}

// Solicitar o valor do prêmio

    returnone:
Console.Write("Informe o valor do prêmio: ");
if (decimal.TryParse(Console.ReadLine(), out valorPremio))
{
    decimal valpremio6dez = valorPremio * 0.75m;
    decimal valpremio5dez = valorPremio * 0.15m;
    decimal valpremio4dez = valorPremio * 0.10m;
    Console.WriteLine($"{valpremio6dez}-valor para quem acertar 6 dezenas ");
    Console.WriteLine($"{valpremio5dez}-valor para quem acertar 5 dezenas ");
    Console.WriteLine($"{valpremio4dez}-valor para quem acertar 4 dezenas ");
}    
else
{   
    Console.WriteLine("numero invalido!");
    goto returnone;//adicionando loop de validação
}

