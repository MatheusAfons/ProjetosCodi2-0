using System;

// Classe abstrata Funcionário
public abstract class Funcionario
{
    // Propriedades comuns a todos os tipos de funcionário
    public string Nome { get; set; }
    public int Identificacao { get; set; }
    public string Cargo { get; set; }

    // Construtor da classe Funcionário
    public Funcionario(string nome, int identificacao, string cargo)
    {
        Nome = nome;
        Identificacao = identificacao;
        Cargo = cargo;
    }

    // Método abstrato para calcular o salário (será implementado nas classes filhas)
    public abstract double CalculaSalario();
}

// Classe Funcionário Assalariado
public class FuncionarioAssalariado : Funcionario
{
    public double SalarioFixo { get; set; }

    // Construtor da classe Funcionário Assalariado
    public FuncionarioAssalariado(string nome, int identificacao, string cargo, double salarioFixo)
        : base(nome, identificacao, cargo)
    {
        SalarioFixo = salarioFixo;
    }

    // Implementação do método CalculaSalario para funcionário assalariado
    public override double CalculaSalario()
    {
        // Retorna o salário fixo do funcionário assalariado
        return SalarioFixo;
    }
}

// Classe Funcionário por Hora
public class FuncionarioPorHora : Funcionario
{
    public int HorasTrabalhadas { get; set; }
    public double ValorPorHora { get; set; }

    // Construtor da classe Funcionário por Hora
    public FuncionarioPorHora(string nome, int identificacao, string cargo, int horasTrabalhadas, double valorPorHora)
        : base(nome, identificacao, cargo)
    {
        HorasTrabalhadas = horasTrabalhadas;
        ValorPorHora = valorPorHora;
    }

    // Implementação do método CalculaSalario para funcionário por hora
    public override double CalculaSalario()
    {
        // Calcula o salário multiplicando as horas trabalhadas pelo valor por hora
        return HorasTrabalhadas * ValorPorHora;
    }
}

// Classe Funcionário Comissionado
public class FuncionarioComissionado : FuncionarioAssalariado
{
    public double PorcentagemComissao { get; set; }
    public double ValorTotalVendas { get; set; }

    // Construtor da classe Funcionário Comissionado
    public FuncionarioComissionado(string nome, int identificacao, string cargo, double salarioFixo, double porcentagemComissao, double valorTotalVendas)
        : base(nome, identificacao, cargo, salarioFixo)
    {
        PorcentagemComissao = porcentagemComissao;
        ValorTotalVendas = valorTotalVendas;
    }

    // Implementação do método CalculaSalario para funcionário comissionado
    public override double CalculaSalario()
    {
        // Calcula o salário somando o salário fixo ao valor da comissão sobre as vendas
        double comissao = ValorTotalVendas * (PorcentagemComissao / 100);
        return SalarioFixo + comissao;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[5];

        // Loop para fazer a leitura das informações dos funcionários
        for (int i = 0; i < funcionarios.Length; i++)
        {
            Console.WriteLine($"Funcionário {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Identificação: ");
            int identificacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Tipo de Funcionário (1-Assalariado, 2-Por Hora, 3-Comissionado): ");
            int tipoFuncionario = Convert.ToInt32(Console.ReadLine());

            switch (tipoFuncionario)
            {
                case 1:
                    Console.Write("Salário Fixo: ");
                    double salarioFixoAssalariado = Convert.ToDouble(Console.ReadLine());
                    funcionarios[i] = new FuncionarioAssalariado(nome, identificacao, cargo, salarioFixoAssalariado);
                    break;
                case 2:
                    Console.Write("Horas Trabalhadas: ");
                    int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Valor por Hora: ");
                    double valorPorHora = Convert.ToDouble(Console.ReadLine());
                    funcionarios[i] = new FuncionarioPorHora(nome, identificacao, cargo, horasTrabalhadas, valorPorHora);
                    break;
                case 3:
                    Console.Write("Salário Fixo: ");
                    double salarioFixoComissionado = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Porcentagem de Comissão: ");
                    double porcentagemComissao = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Valor Total das Vendas: ");
                    double valorTotalVendas = Convert.ToDouble(Console.ReadLine());
                    funcionarios[i] = new FuncionarioComissionado(nome, identificacao, cargo, salarioFixoComissionado, porcentagemComissao, valorTotalVendas);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    i--; // Reduz o contador para repetir a iteração atual
                    break;
            }

            Console.WriteLine();
        }

        // Loop para calcular e exibir o salário de cada funcionário
        Console.WriteLine("Salários dos funcionários:");
        for (int i = 0; i < funcionarios.Length; i++)
        {
            Funcionario funcionario = funcionarios[i];
            double salario = funcionario.CalculaSalario();
            Console.WriteLine($"Funcionário {i + 1}:");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Salário: R${salario}");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}