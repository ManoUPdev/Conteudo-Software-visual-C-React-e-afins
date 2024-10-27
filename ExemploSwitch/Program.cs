using System;

class ExemploSwitch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número de 1 a 7 para escolher um dia da semana:");

        // Leitura e validação da entrada do usuário
        if (int.TryParse(Console.ReadLine(), out int diaSemana) && diaSemana >= 1 && diaSemana <= 7)
        {
            // Estrutura switch para determinar o dia da semana
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Número inválido. Por favor, insira um número entre 1 e 7.");
        }
    }
}
