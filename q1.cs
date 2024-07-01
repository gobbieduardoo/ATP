using System;

class q1
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        
        int count = 0;
        foreach (char c in frase)
        {
            if (c == ' ')
                count++;
        }
        
        Console.WriteLine("Número de espaços em branco: " + count);
    }
}
