using System;
using System.IO;

class q5
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminho = Console.ReadLine();

        int count = 0;
        foreach (char c in File.ReadAllText(caminho))
        {
            if (c == 'a' || c == 'A')
                count++;
        }

        Console.WriteLine("Número de caracteres 'a': " + count);
    }
}
