using System;
using System.IO;

class q6
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());
        
        int soma = 0;
        Console.WriteLine("Divisores:");
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                soma += i;
            }
        }
        
        File.WriteAllText("soma_divisores.txt", "Soma dos divisores: " + soma);
        Console.WriteLine("Soma dos divisores salva em 'soma_divisores.txt'");
    }
}
