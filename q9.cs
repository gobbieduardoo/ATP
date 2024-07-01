using System;
using System.IO;

class q9
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Inserir dados de alunos");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");
            int opcao = int.Parse(Console.ReadLine());
            
            if (opcao == 1)
            {
                using (StreamWriter sw = new StreamWriter("alunos.txt", true))
                {
                    Console.WriteLine("Digite a matrícula do aluno:");
                    string matricula = Console.ReadLine();
                    
                    Console.WriteLine("Digite o telefone do aluno:");
                    string telefone = Console.ReadLine();
                    
                    sw.WriteLine(matricula + " " + telefone);
                }
            }
            else if (opcao == 2)
            {
                string[] linhas = File.ReadAllLines("alunos.txt");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            else if (opcao == 3)
            {
                break;
            }
        }
    }
}
