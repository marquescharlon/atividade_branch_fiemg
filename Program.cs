main
﻿using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Random random = new Random();

        
        Console.WriteLine("=".PadLeft(37, '='));
        Console.WriteLine("Jogo da Mega-Sena");
        Console.WriteLine("=".PadLeft(37, '='));
        
       
        Console.WriteLine("\nDigite o valor do prêmio:");
        if (decimal.TryParse(Console.ReadLine(), out decimal valorPremio) && valorPremio > 0)
        {
            Console.WriteLine("Escolha a quantidade de Bolões.");
            
            if (int.TryParse(Console.ReadLine(), out int numeroDeBolao) && numeroDeBolao > 0)
            {
                Console.WriteLine("Escolha a quantidade de dezenas.");
                
                if (int.TryParse(Console.ReadLine(), out int quantidadeDezenas) && quantidadeDezenas > 0 && quantidadeDezenas >= 6 && quantidadeDezenas <= 15)
                {
                    string filePath = "resultado_boloes.txt";
                    
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                       
                        writer.WriteLine("=".PadLeft(37, '='));
                        writer.WriteLine("Atividade 13 - Jogo da Mega-Sena");
                        writer.WriteLine("=".PadLeft(37, '='));
                        writer.WriteLine($"Data: {DateTime.Now}");
                        writer.WriteLine($"Valor do Prêmio: R$ {valorPremio:F2}");
                        writer.WriteLine("=========================\n");

                       
                        for (int bolao = 0; bolao < numeroDeBolao; bolao++)
                        {
                            writer.WriteLine($"Bolão {bolao + 1}:");
                            Console.WriteLine($"\nBolão {bolao + 1}:");
                            
                            for (int dezena = 0; dezena < quantidadeDezenas; dezena++)
                            {
                                int num = random.Next(1, 61);
                                Console.Write($"{num} ");
                                writer.Write($"{num} ");
                            }
                            Console.WriteLine();
                            writer.WriteLine();
                        }
                    }
                    
                    Console.WriteLine($"\nResultado salvo no arquivo: {filePath}");
                }
                else
                {
                    Console.WriteLine("\nNúmero de dezenas inválido!");
                }
            }
            else
            {
                Console.WriteLine("Número de bolões inválido!");
            }
        }
        else
        {
            Console.WriteLine("Valor do prêmio inválido!");
        }
    }
}


