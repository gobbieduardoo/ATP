using System;
using System.IO;

class program   
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminho = Console.ReadLine();
        
        string[] linhas = File.ReadAllLines(caminho);
        int count = 0;
        
        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
            count++;
        }
        
        Console.WriteLine("Número de linhas: " + count);
    }
}
