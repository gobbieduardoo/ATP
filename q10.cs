using System;
using System.IO;
using System.Linq;

class q10
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminho = Console.ReadLine();
        
        double[] valores = File.ReadAllLines(caminho).Select(double.Parse).ToArray();
        
        double max = valores.Max();
        double min = valores.Min();
        double media = valores.Average();
        
        Console.WriteLine("Valor máximo: " + max);
        Console.WriteLine("Valor mínimo: " + min);
        Console.WriteLine("Média: " + media);
    }
}
