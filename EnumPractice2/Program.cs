using System;

class Program
{
    enum Meses
    {
        Janeiro = 1,
        Fevereiro = 2,
        Marco = 3,
        Abril = 4,
        Maio = 5,
        Junho = 6,
        Julho = 7,
        Agosto = 8,
        Setembro = 9,
        Outubro = 10,
        Novembro = 11,
        Dezembro = 12
    }

    static void Main(string[] args)
    {
        // Utilizando o enum
        Meses mesAtual = Meses.Outubro;

        // Exibe o nome e o valor do mês
        Console.WriteLine($"Estamos no mês de: {mesAtual}");  // Saída: Estamos no mês de: Outubro
        Console.WriteLine($"Número do mês: {(int)mesAtual}"); // Saída: Número do mês: 10
    }
}
