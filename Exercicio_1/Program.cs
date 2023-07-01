using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> vetor = new List<int>(); // Cria uma lista vazia para armazenar os valores do vetor

        int opcao = 0;
        while (opcao != 7)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Ler valores do vetor");
            Console.WriteLine("2 - Listar Vetor (exibir os valores armazenados)");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("8 - CalcularValoresDentroForaIntervalo");

            opcao = int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário

            switch (opcao)
            {
                case 1:
                    LerValoresVetor(vetor); // Chama o método para preencher os valores do vetor
                    break;
                case 2:
                    ListarVetor(vetor); // Chama o método para exibir os valores armazenados no vetor
                    break;
                case 3:
                    ExibirNumerosPares(vetor); // Chama o método para exibir apenas os números pares do vetor
                    break;
                case 4:
                    ExibirNumerosImpares(vetor); // Chama o método para exibir apenas os números ímpares do vetor
                    break;
                case 5:
                    ExibirQuantidadeParesPosicoesImpares(vetor); // Chama o método para exibir a quantidade de números pares nas posições ímpares do vetor
                    break;
                case 6:
                    ExibirQuantidadeImparesPosicoesPares(vetor); // Chama o método para exibir a quantidade de números ímpares nas posições pares do vetor
                    break;
                case 7:
                    Console.WriteLine("Saindo do programa...");
                    break;
                case 8:
                    CalcularValoresDentroForaIntervalo(); // Chama o método para calcular os valores dentro e fora de um intervalo
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void LerValoresVetor(List<int> vetor)
    {
        vetor.Clear(); // Limpa a lista para preencher com novos valores

        for (int i = 1; i <= 20; i++)
        {
            vetor.Add(i); // Adiciona os números de 1 a 20 na lista
        }

        Console.WriteLine("Valores do vetor preenchidos automaticamente com os números de 1 a 20.");
    }

    static void ListarVetor(List<int> vetor)
    {
        Console.WriteLine("Elementos do vetor:");
        for (int i = 0; i < vetor.Count; i++)
        {
            Console.WriteLine(vetor[i]); // Exibe cada elemento do vetor
        }
    }

    static void ExibirNumerosPares(List<int> vetor)
    {
        Console.WriteLine("Números pares do vetor:");
        for (int i = 0; i < vetor.Count; i++)
        {
            if (vetor[i] % 2 == 0) // Verifica se o número é par
            {
                Console.WriteLine(vetor[i]); // Exibe o número par
            }
        }
    }

    static void ExibirNumerosImpares(List<int> vetor)
    {
        Console.WriteLine("Números ímpares do vetor:");
        for (int i = 0; i < vetor.Count; i++)
        {
            if (vetor[i] % 2 != 0) // Verifica se o número é ímpar
            {
                Console.WriteLine(vetor[i]); // Exibe o número ímpar
            }
        }
    }

    static void ExibirQuantidadeParesPosicoesImpares(List<int> vetor)
    {
        int quantidade = 0;
        for (int i = 1; i < vetor.Count; i += 2)
        {
            if (vetor[i] % 2 == 0) // Verifica se o número é par
            {
                quantidade++; // Incrementa a quantidade de números pares nas posições ímpares
            }
        }

        Console.WriteLine($"Quantidade de números pares nas posições ímpares do vetor: {quantidade}");
    }

    static void ExibirQuantidadeImparesPosicoesPares(List<int> vetor)
    {
        int quantidade = 0;
        for (int i = 0; i < vetor.Count; i += 2)
        {
            if (vetor[i] % 2 != 0) // Verifica se o número é ímpar
            {
                quantidade++; // Incrementa a quantidade de números ímpares nas posições pares
            }
        }

        Console.WriteLine($"Quantidade de números ímpares nas posições pares do vetor: {quantidade}");
    }

    static void CalcularValoresDentroForaIntervalo()
    {
        Console.WriteLine("Digite o valor de N:");
        int N = int.Parse(Console.ReadLine()); // Lê o valor de N

        int quantidadeDentro = 0;
        int quantidadeFora = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o valor #{i + 1}:");
            float X = float.Parse(Console.ReadLine()); // Lê os valores digitados pelo usuário

            if (X >= 10 && X <= 20) // Verifica se o valor está dentro do intervalo
            {
                quantidadeDentro++; // Incrementa a quantidade de valores dentro do intervalo
            }
            else
            {
                quantidadeFora++; // Incrementa a quantidade de valores fora do intervalo
            }
        }

        Console.WriteLine($"Valores dentro do intervalo: {quantidadeDentro}");
        Console.WriteLine($"Valores fora do intervalo: {quantidadeFora}");
    }
}
