 using System.IO;
 Console.Clear();

 int largura = 50;

 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.WriteLine("=".PadLeft(37, '='));
 Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
 Console.WriteLine("=".PadLeft(37, '='));
 Console.ResetColor();

  Random random = new Random();
  Console.Write("Insira a quantidade de jogos que você deseja fazer: ");
  int quantidadeJogos = int.Parse(Console.ReadLine());
  int quantidadeDeDezenas;

  Console.Write("Informe o valor do prêmio: ");
  decimal valordopremio = decimal.Parse(Console.ReadLine());

  do
  {
    Console.Write("Informe a quantidade de dezenas (entre 6 e 15): ");
    quantidadeDeDezenas = int.Parse(Console.ReadLine());

    if (quantidadeDeDezenas < 6 || quantidadeDeDezenas > 15)
    {
        Console.Write("Quantidade inválida! A quantidade de dezenas deve ser maior que 6 ou menor que 15. ");
    }
 }
 while (quantidadeDeDezenas < 6 || quantidadeDeDezenas > 15);
 Console.WriteLine(quantidadeJogos + "Jogos de" + quantidadeDeDezenas + "dezenas: ");
 for (int j = 0; j < quantidadeJogos; j++)
 {
    string dezenasSorteadas = "";
    for (int i = 0; i < quantidadeDeDezenas; i++)
    {
        int numero;
        do
        {
            numero = random.Next(1, 61);
        }
        while (dezenasSorteadas.Contains(numero.ToString("00")));
        dezenasSorteadas += numero.ToString("00");
        if(i < quantidadeDeDezenas - 1)
        {
            dezenasSorteadas += "-";
        }
    }
    Console.WriteLine("Jogo " + (j + 1) + ": " + dezenasSorteadas);
 }

   decimal premio6 = valordopremio * 0.75m;
   decimal premio5 = valordopremio * 0.15m;
   decimal premio4 = valordopremio * 0.10m;

   Console.WriteLine("75% do prêmio para quem acertar 6 dezenas: R$" + premio6);
   Console.WriteLine("15% do prêmio para quem acertar 5 dezenas: R$" + premio5);
   Console.WriteLine("10% do prêmio para quem acertar 4 dezenas: R$" + premio4);
