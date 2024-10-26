using System;

class ExemploCondicional
{
    static void Main(string[] args)
    {
        int idade = 20;

        if (idade >= 18)
        {
            Console.WriteLine("Voce e maior de idade.");
        }
        else if (idade >= 16 && idade < 18)
        {
            Console.WriteLine("Voce pode votar, mas ainda nao e maior de idade.");
        }
        else
        {
            Console.WriteLine("Voce e menor de idade.");
        }
    }
}