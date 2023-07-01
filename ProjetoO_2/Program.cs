using System;
using System.Collections.Generic;

// Classe base Veiculo que contém as propriedades comuns a todos os veículos
class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public decimal Preco { get; set; }

    // Método virtual que exibe as informações do veículo
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano de Fabricação: " + AnoFabricacao);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("----------------------------------------");
    }
}

// Classe Carro que herda da classe Veiculo
class Carro : Veiculo
{
    public int QuantidadePortas { get; set; }

    // Sobrescreve o método ExibirInformacoes() para incluir as informações específicas do carro
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes(); // Chama o método ExibirInformacoes() da classe base
        Console.WriteLine("Quantidade de Portas: " + QuantidadePortas);
        Console.WriteLine("----------------------------------------");
    }
}

// Classe Moto que herda da classe Veiculo
class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    // Sobrescreve o método ExibirInformacoes() para incluir as informações específicas da moto
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes(); // Chama o método ExibirInformacoes() da classe base
        Console.WriteLine("Cilindradas: " + Cilindradas);
        Console.WriteLine("----------------------------------------");
    }
}

// Classe Caminhao que herda da classe Veiculo
class Caminhao : Veiculo
{
    public decimal CapacidadeCarga { get; set; }

    // Sobrescreve o método ExibirInformacoes() para incluir as informações específicas do caminhão
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes(); // Chama o método ExibirInformacoes() da classe base
        Console.WriteLine("Capacidade de Carga: " + CapacidadeCarga);
        Console.WriteLine("----------------------------------------");
    }
}

// Classe responsável por armazenar e gerenciar uma lista de veículos
class CadastroVeiculos
{
    private List<Veiculo> veiculos;

    public CadastroVeiculos()
    {
        veiculos = new List<Veiculo>();
    }

    // Adiciona um veículo à lista de veículos
    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    // Exibe todos os veículos cadastrados, chamando o método ExibirInformacoes() de cada veículo
    public void ExibirVeiculos()
    {
        foreach (Veiculo veiculo in veiculos)
        {
            veiculo.ExibirInformacoes();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CadastroVeiculos cadastro = new CadastroVeiculos();

        // Criação de alguns veículos (carro, moto e caminhão)
        Carro carro1 = new Carro
        {
            Marca = "Ford",
            Modelo = "Fiesta",
            AnoFabricacao = 2021,
            Preco = 50000,
            QuantidadePortas = 4
        };

        Moto moto1 = new Moto
        {
            Marca = "Honda",
            Modelo = "CBR500R",
            AnoFabricacao = 2022,
            Preco = 30000,
            Cilindradas = 500
        };

        Caminhao caminhao1 = new Caminhao
        {
            Marca = "Scania",
            Modelo = "R450",
            AnoFabricacao = 2019,
            Preco = 250000,
            CapacidadeCarga = 20000
        };

        // Adiciona os veículos ao cadastro
        cadastro.AdicionarVeiculo(carro1);
        cadastro.AdicionarVeiculo(moto1);
        cadastro.AdicionarVeiculo(caminhao1);

        // Exibe todos os veículos cadastrados
        cadastro.ExibirVeiculos();

        Console.ReadKey();
    }
}