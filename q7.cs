using System;
using System.IO;

class q7
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de letras (N):");
        int N = int.Parse(Console.ReadLine());
        
        using (StreamWriter sw = new StreamWriter("letras.txt"))
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite uma letra:");
                char letra = Console.ReadLine()[0];
                sw.Write(letra);
            }
        }

        int vogaisCount = 0;
        string conteudo = File.ReadAllText("letras.txt");
        foreach (char c in conteudo)
        {
            if ("aeiouAEIOU".Contains(c))
                vogaisCount++;
        }
        
        Console.WriteLine("Número de vogais: " + vogaisCount);
    }
}
