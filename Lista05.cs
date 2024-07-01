using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Menor elemento e sua posição no vetor");
            Console.WriteLine("2 - Notas dos alunos");
            Console.WriteLine("3 - Copiar valores negativos de um vetor");
            Console.WriteLine("4 - Intercalar dois vetores");
            Console.WriteLine("5 - Sorteio de números");
            Console.WriteLine("6 - Temperaturas de outubro");
            Console.WriteLine("7 - Operações em matriz 5x5");
            Console.WriteLine("8 - Soma abaixo da diagonal principal");
            Console.WriteLine("9 - Operações em matrizes 4x6");
            Console.WriteLine("10 - Troca de linhas e colunas em matriz 10x10");
            Console.WriteLine("11 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MenorElementoVetor();
                    break;
                case 2:
                    NotasAlunos();
                    break;
                case 3:
                    CopiarValoresNegativos();
                    break;
                case 4:
                    IntercalarVetores();
                    break;
                case 5:
                    SorteioNumeros();
                    break;
                case 6:
                    TemperaturasOutubro();
                    break;
                case 7:
                    OperacoesMatriz5x5();
                    break;
                case 8:
                    SomaAbaixoDiagonalPrincipal();
                    break;
                case 9:
                    OperacoesMatrizes4x6();
                    break;
                case 10:
                    TrocasMatriz10x10();
                    break;
                case 11:
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 11);
    }

    // Questão 1
    static void MenorElementoVetor()
    {
        int[] N = new int[20];
        Console.WriteLine("Digite 20 elementos para o vetor N:");
        for (int i = 0; i < 20; i++)
        {
            N[i] = int.Parse(Console.ReadLine());
        }

        int menor = N.Min();
        int posicao = Array.IndexOf(N, menor);

        Console.WriteLine($"O menor elemento de N é {menor} e sua posição dentro do vetor é {posicao}");
    }

    // Questão 2
    static void NotasAlunos()
    {
        double[] notas = new double[10];
        PreencherNotas(notas);
        CalcularMediaEContarAcimaMedia(notas);
    }

    static void PreencherNotas(double[] notas)
    {
        Console.WriteLine("Digite as notas dos 10 alunos:");
        for (int i = 0; i < 10; i++)
        {
            notas[i] = double.Parse(Console.ReadLine());
        }
    }

    static void CalcularMediaEContarAcimaMedia(double[] notas)
    {
        double media = notas.Average();
        int acimaMedia = notas.Count(nota => nota > media);

        Console.WriteLine($"A média da turma é {media}");
        Console.WriteLine($"Número de alunos com nota acima da média: {acimaMedia}");
    }

    // Questão 3
    static void CopiarValoresNegativos()
    {
        int[] X = new int[10];
        PreencherVetor(X);

        int[] negativos = CopiarNegativos(X);
        ExibirVetor(negativos);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite 10 elementos para o vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int[] CopiarNegativos(int[] vetor)
    {
        return vetor.Where(x => x < 0).ToArray();
    }

    static void ExibirVetor(int[] vetor)
    {
        Console.WriteLine("Conteúdo do vetor:");
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Questão 4
    static void IntercalarVetores()
    {
        int[] X = new int[10];
        int[] Y = new int[10];

        Console.WriteLine("Digite os elementos do vetor X:");
        PreencherVetor(X);

        Console.WriteLine("Digite os elementos do vetor Y:");
        PreencherVetor(Y);

        int[] Z = Intercalar(X, Y);
        ExibirVetor(Z);
    }

    static int[] Intercalar(int[] X, int[] Y)
    {
        int[] Z = new int[20];
        for (int i = 0; i < 10; i++)
        {
            Z[2 * i] = X[i];
            Z[2 * i + 1] = Y[i];
        }
        return Z;
    }

    // Questão 5
    static void SorteioNumeros()
    {
        Random random = new Random();
        int[] sorteados = new int[3];
        for (int i = 0; i < 3; i++)
        {
            sorteados[i] = random.Next(10, 51);
        }

        int tentativa;
        do
        {
            Console.WriteLine("Tente acertar um dos números sorteados (entre 10 e 50):");
            tentativa = int.Parse(Console.ReadLine());
        } while (!sorteados.Contains(tentativa));

        Console.WriteLine($"Parabéns! Você acertou um dos números sorteados: {tentativa}");
    }

    // Questão 6
    static void TemperaturasOutubro()
    {
        double[] temperaturas = new double[31];

        Console.WriteLine("Digite as temperaturas de outubro:");
        for (int i = 0; i < 31; i++)
        {
            temperaturas[i] = double.Parse(Console.ReadLine());
        }

        double menor = temperaturas.Min();
        double maior = temperaturas.Max();
        double media = temperaturas.Average();
        int diasAbaixoMedia = temperaturas.Count(temp => temp < media);

        Console.WriteLine($"Menor temperatura: {menor}");
        Console.WriteLine($"Maior temperatura: {maior}");
        Console.WriteLine($"Temperatura média: {media}");
        Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoMedia}");
    }

    // Questão 7
    static void OperacoesMatriz5x5()
    {
        int[,] M = new int[5, 5];
        PreencherMatriz5x5(M);
        ExibirMatriz(M);

        int somaLinha4 = SomaLinha(M, 4);
        int somaColuna2 = SomaColuna(M, 2);
        int somaDiagonalPrincipal = SomaDiagonalPrincipal(M);
        int somaDiagonalSecundaria = SomaDiagonalSecundaria(M);
        int somaTotal = SomaTotal(M);

        Console.WriteLine($"Soma da linha 4: {somaLinha4}");
        Console.WriteLine($"Soma da coluna 2: {somaColuna2}");
        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
        Console.WriteLine($"Soma total: {somaTotal}");
    }

    static void PreencherMatriz5x5(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;
        for (int j = 0; j < 5; j++)
        {
            soma += matriz[linha, j];
        }
        return soma;
    }

    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, coluna];
        }
        return soma;
    }

    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 4 - i];
        }
        return soma;
    }

    static int SomaTotal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        Console.WriteLine("Conteúdo da matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Questão 8
    static void SomaAbaixoDiagonalPrincipal()
    {
        int[,] matriz = new int[4, 4];
        PreencherMatriz4x4(matriz);
        ExibirMatriz(matriz);

        int somaAbaixoDiagonal = 0;
        Console.WriteLine("Elementos da diagonal principal:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                else if (i > j)
                {
                    somaAbaixoDiagonal += matriz[i, j];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Soma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");
    }

    static void PreencherMatriz4x4(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Questão 9
    static void OperacoesMatrizes4x6()
    {
        int[,] A = new int[4, 6];
        int[,] B = new int[4, 6];

        Console.WriteLine("Digite os elementos da matriz A:");
        PreencherMatriz4x6(A);

        Console.WriteLine("Digite os elementos da matriz B:");
        PreencherMatriz4x6(B);

        int[,] S = SomaMatrizes(A, B);
        int[,] D = DiferencaMatrizes(A, B);

        Console.WriteLine("Matriz Soma:");
        ExibirMatriz(S);

        Console.WriteLine("Matriz Diferença:");
        ExibirMatriz(D);
    }

    static void PreencherMatriz4x6(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] SomaMatrizes(int[,] A, int[,] B)
    {
        int[,] S = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                S[i, j] = A[i, j] + B[i, j];
            }
        }
        return S;
    }

    static int[,] DiferencaMatrizes(int[,] A, int[,] B)
    {
        int[,] D = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                D[i, j] = A[i, j] - B[i, j];
            }
        }
        return D;
    }

    // Questão 10
    static void TrocasMatriz10x10()
    {
        int[,] M = new int[10, 10];
        PreencherMatriz10x10(M);
        ExibirMatriz(M);

        TrocarLinhas(M, 1, 7); // Trocar linha 2 com linha 8 (índices 1 e 7)
        TrocarColunas(M, 3, 9); // Trocar coluna 4 com coluna 10 (índices 3 e 9)
        TrocarDiagonais(M);
        TrocarLinhaComColuna(M, 4, 9); // Trocar linha 5 com coluna 10 (índices 4 e 9)
    }

    static void PreencherMatriz10x10(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < 10; j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }

        Console.WriteLine("Matriz após troca de linhas:");
        ExibirMatriz(matriz);
    }

    static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }

        Console.WriteLine("Matriz após troca de colunas:");
        ExibirMatriz(matriz);
    }

    static void TrocarDiagonais(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, 9 - i];
            matriz[i, 9 - i] = temp;
        }

        Console.WriteLine("Matriz após troca das diagonais:");
        ExibirMatriz(matriz);
    }

    static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna];
            matriz[i, coluna] = temp;
        }

        Console.WriteLine("Matriz após troca da linha com a coluna:");
        ExibirMatriz(matriz);
    }
}
