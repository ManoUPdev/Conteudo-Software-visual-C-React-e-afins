﻿using System;
using System.Collections.Generic;

class ExemploRepeticao
{
    static void Main(string[] args)
    {
        // Solicita ao usuário um número para a contagem com 'for'
        Console.WriteLine("Digite um numero para contar de 1 ate esse numero com 'for':");
        
        if (int.TryParse(Console.ReadLine(), out int limiteFor) && limiteFor > 0)
        {
            Console.WriteLine("\nContagem usando 'for':");
            for (int i = 1; i <= limiteFor; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida para o 'for'. Digite um numero inteiro positivo.");
        }

        // Solicita ao usuário um número para a contagem com 'while'
        Console.WriteLine("\nDigite um numero para contar de 1 ate esse numero com 'while':");
        
        if (int.TryParse(Console.ReadLine(), out int limiteWhile) && limiteWhile > 0)
        {
            Console.WriteLine("\nContagem usando 'while':");
            int contador = 1;
            while (contador <= limiteWhile)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida para o 'while'. Digite um numero inteiro positivo.");
        }

        // Usa 'foreach' para percorrer uma lista
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine("\nContagem usando 'foreach' em uma lista de numeros predefinidos:");
        
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
