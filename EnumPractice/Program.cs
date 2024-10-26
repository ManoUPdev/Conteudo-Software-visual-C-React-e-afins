using System;

class Program
{

    // Declaracao do enum
    enum DiasDaSemana
    {
        Domingo,      // 0
        Segunda,      // 1
        Terca,        // 2
        Quarta,       // 3
        Quinta,       // 4
        Sexta,        // 5
        Sabado        // 6
    }

    static void Main(string[] args)
    {
        // Utilizando o enum
        DiasDaSemana hoje = DiasDaSemana.Quarta;

        Console.WriteLine($"Hoje e: {hoje}");  // Saida: Hoje e: Quarta

        // Convertendo o enum para numero inteiro
        int valorNumerico = (int)hoje;
        Console.WriteLine($"O valor numerico de {hoje} e: {valorNumerico}"); // Saida: O valor numerico de Quarta e: 3

        // Condicional com enum
        if(hoje == DiasDaSemana.Quarta)
        {
            Console.WriteLine("Estamos no meio da semana!");
        }
    }
}