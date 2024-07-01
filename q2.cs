using System;

class q2
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        
        string resultado = string.Empty;
        foreach (char c in frase)
        {
            if (!"aeiouAEIOU".Contains(c))
                resultado += c;
        }
        
        Console.WriteLine("Frase sem vogais: " + resultado);
    }
}
