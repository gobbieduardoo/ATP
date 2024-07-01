using System;

class q4
{
    static void Main()
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        
        string result = string.Empty;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result += (char)(((c + 3 - offset) % 26) + offset);
            }
            else
            {
                result += c;
            }
        }
        
        Console.WriteLine("String codificada: " + result);
    }
}
