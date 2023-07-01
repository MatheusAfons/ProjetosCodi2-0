using System;

// Classe abstrata Animal
abstract class Animal
{
    public abstract void EmitirSom(); // Método abstrato para emitir som
}

// Classe Cachorro que herda de Animal
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late"); // Implementação do método EmitirSom para Cachorro
    }
}

// Classe Gato que herda de Animal
class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia"); // Implementação do método EmitirSom para Gato
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animais = new Animal[4]; // Criação de um array de animais

        animais[0] = new Cachorro(); // Instanciação de um objeto Cachorro e atribuição ao array
        animais[1] = new Gato(); // Instanciação de um objeto Gato e atribuição ao array
        animais[2] = new Cachorro(); // Instanciação de outro objeto Cachorro e atribuição ao array
        animais[3] = new Gato(); // Instanciação de outro objeto Gato e atribuição ao array

        foreach (Animal animal in animais) // Loop para percorrer o array de animais
        {
            animal.EmitirSom(); // Chama o método EmitirSom para cada animal (polimorfismo)
        }
    }
}
