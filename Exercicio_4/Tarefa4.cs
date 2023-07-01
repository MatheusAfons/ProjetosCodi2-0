using System;

class Program
{
    static float[] InverteVetor(float[] vetor)
    {
        Array.Reverse(vetor); // Inverte o vetor utilizando o método Reverse da classe Array
        return vetor; // Retorna o vetor invertido
    }

    static void SomaValores(float[] vetor)
    {
        float soma = 0;

        foreach (float valor in vetor)
        {
            soma += valor; // Soma os valores do vetor
        }

        Console.WriteLine("Soma dos valores: " + soma);
        Console.WriteLine(soma % 3 == 0 ? "A soma é divisível por 3." : "A soma não é divisível por 3.");
        // Verifica se a soma é divisível por 3 e exibe uma mensagem correspondente
    }

    static bool Crescente(float[] vetor)
    {
        float[] vetorOrdenado = new float[vetor.Length];
        Array.Copy(vetor, vetorOrdenado, vetor.Length); // Copia o vetor original para outro vetor

        Array.Sort(vetorOrdenado); // Ordena o vetor copiado utilizando o método Sort da classe Array

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != vetorOrdenado[i])
            {
                return false; // Retorna false se encontrar algum elemento diferente entre os vetores
            }
        }

        return true; // Retorna true se todos os elementos forem iguais entre os vetores
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do vetor:");
        int tamanho = int.Parse(Console.ReadLine()); // Lê o tamanho do vetor digitado pelo usuário

        float[] vetor = new float[tamanho]; // Cria um vetor com o tamanho especificado

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Valor #{i + 1}: ");
            vetor[i] = float.Parse(Console.ReadLine()); // Lê os valores do vetor digitados pelo usuário
        }

        float[] vetorInvertido = InverteVetor(vetor); // Chama a função para inverter o vetor
        Console.WriteLine("Vetor invertido:");
        Console.WriteLine(string.Join(", ", vetorInvertido)); // Exibe o vetor invertido separado por vírgulas

        SomaValores(vetor); // Chama a função para calcular a soma dos valores do vetor

        bool ordenado = Crescente(vetor); // Chama a função para verificar se o vetor está ordenado em ordem crescente
        Console.WriteLine($"Vetor está ordenado em ordem crescente: {ordenado}");
    }
}
