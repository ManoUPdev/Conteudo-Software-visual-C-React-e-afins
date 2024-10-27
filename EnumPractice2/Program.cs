using System;

class Program
{
    // Declaração do enum Meses
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
       Console.WriteLine("Digite um numero de 1 a 12 para escolher um mes do ano:");

       // Leitura e validacao da entrada do usuario
       if(int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 12)
       {

        // Convertendo o numero para o enum correspondente
        Meses mesEscolhido = (Meses)numero;


        // Exibindo o mes correspondente
         Console.WriteLine($"O mes escolhido e: {mesEscolhido}");
         Console.WriteLine($"Numero do mes: {(int)mesEscolhido}");
       }
       else
       {
         Console.WriteLine("Numero invalido. Por favor, insira um numero entre 1 e 12.");
       }
    }
}
        