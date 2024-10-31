using System;

class ExemploArray
{
    static void Main(string[] args)
    {
        // Declaração e inicialização de um array de inteiros com 5 elementos
        int[] numeros = new int[5];

        // Preenchendo o array com valores
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Exibindo os valores do array
        Console.WriteLine("Valores no array:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Elemento {i}: {numeros[i]}");
        }

        // Calculando a soma dos valores no array
        int soma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        Console.WriteLine($"\nA soma dos valores no array é: {soma}");

        // Exemplo de uso do foreach para percorrer o array
        Console.WriteLine("\nValores do array usando foreach:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        // Encontrar o maior número no array
        int maiorNumero = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maiorNumero)
            {
                maiorNumero = numeros[i];
            }
        }

        Console.WriteLine($"\nO maior numero no array é: {maiorNumero}");
    }
}
