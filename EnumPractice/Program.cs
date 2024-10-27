using System;

class Program
{
    // Declaração do enum
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
        Console.WriteLine("Digite um número de 0 a 6 para escolher um dia da semana:");
        
        // Leitura e validação da entrada do usuário
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0 && numero <= 6)
        {
            // Convertendo o número para o enum correspondente
            DiasDaSemana diaEscolhido = (DiasDaSemana)numero;
            
            // Exibindo o dia da semana correspondente
            Console.WriteLine($"O dia escolhido é: {diaEscolhido}"); // Exemplo: "O dia escolhido é: Quarta"

            // Mensagem personalizada para meio da semana
            if (diaEscolhido == DiasDaSemana.Quarta)
            {
                Console.WriteLine("Estamos no meio da semana!");
            }
        }
        else
        {
            Console.WriteLine("Número inválido. Por favor, insira um número entre 0 e 6.");
        }
    }
}
