using System;
using System.Text.RegularExpressions;

class Tarefa3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine() ?? ""; // Lê a frase digitada pelo usuário e atribui à variável "frase". Caso seja nulo, atribui uma string vazia.

        string[] palavras = frase?.Split(' ') ?? new string[0];
        // Divide a frase em palavras utilizando o espaço como separador e atribui o resultado ao array "palavras". Caso a frase seja nula, atribui um array vazio.

        Console.WriteLine("Número de vogais por palavra:");
        foreach (string palavra in palavras)
        {
            int numVogais = Regex.Matches(palavra, "[aeiouAEIOU]").Count;
            // Utiliza uma expressão regular para encontrar todas as ocorrências de vogais na palavra e conta o número de ocorrências.

            Console.WriteLine($"Palavra: {palavra}, Vogais: {numVogais}");
            // Exibe a palavra e o número de vogais encontradas.
        }
    }
}
