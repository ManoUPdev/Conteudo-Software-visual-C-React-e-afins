﻿using System;

class ExemploCondicional
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua idade:");

        // Leitura e validação da entrada do usuário
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            // Condicional para verificar a faixa etária
            if (idade < 0)
            {
                Console.WriteLine("Idade nao pode ser negativa. Por favor, insira uma idade valida.");
            }
            else if (idade > 120)
            {
                Console.WriteLine("Idade parece irreal. Por favor, insira uma idade valida.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Você e maior de idade.");
            }
            else if (idade >= 16)
            {
                Console.WriteLine("Voce pode votar, mas ainda nao e maior de idade.");
            }
            else
            {
                Console.WriteLine("Voce e menor de idade e tambem nao pode votar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida. Por favor, insira um numero inteiro para a idade.");
        }
    }
}

