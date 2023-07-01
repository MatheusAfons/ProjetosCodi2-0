using System;

class Funcionario
{
    // Atributos da classe Funcionario
    private string nome;                // Nome do funcionário
    private int codigo;                 // Código de identificação do funcionário
    private double totalVendas;         // Valor total das vendas realizadas pelo funcionário
    private double comissao;            // Valor da comissão do funcionário

    // Propriedades para acesso aos atributos privados
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    // Função que retorna o valor total de vendas do funcionário
    public double GetTotalVendas()
    {
        return totalVendas;
    }

    // Função que adiciona o valor da venda realizada ao total de vendas do funcionário
    public void AdicionaVenda(double valorVenda)
    {
        totalVendas += valorVenda;
    }

    // Função que retorna a comissão atual do vendedor
    public double GetComissao()
    {
        return comissao;
    }

    // Função que adiciona o valor da comissão referente à venda realizada à comissão total
    public void AdicionaComissao(double valorComissao)
    {
        comissao += valorComissao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação do vetor de funcionários com tamanho 3
        Funcionario[] funcionarios = new Funcionario[3];

        // Preenchimento dos dois primeiros atributos de cada funcionário
        for (int i = 0; i < 2; i++)
        {
            funcionarios[i] = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário:");
            funcionarios[i].Nome = Console.ReadLine();

            Console.WriteLine("Digite o código do funcionário:");
            funcionarios[i].Codigo = int.Parse(Console.ReadLine());
        }

        // Variável para controlar a ação desejada pelo usuário
        int acao = 0;

        // Loop principal do programa
        while (acao != 2)
        {
            Console.WriteLine("Digite a ação desejada:");
            Console.WriteLine("1 - Contabilizar venda");
            Console.WriteLine("2 - Sair");
            acao = int.Parse(Console.ReadLine());

            if (acao == 1)
            {
                Console.WriteLine("Digite o código de identificação do funcionário:");
                int codigoVendedor = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço da peça vendida:");
                double precoPeca = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade vendida:");
                int quantidade = int.Parse(Console.ReadLine());

                // Chamada da função para contabilizar a venda e pagar a comissão
                RealizarVenda(codigoVendedor, precoPeca, quantidade, funcionarios);
            }
        }
    }

    // Função para contabilizar a venda e pagar a comissão do funcionário
    static void RealizarVenda(int codigoVendedor, double precoPeca, int quantidade, Funcionario[] funcionarios)
    {
        Funcionario vendedor = null;

        // Procura o vendedor com o código fornecido no vetor de funcionários
        foreach (Funcionario funcionario in funcionarios)
        {
            if (funcionario.Codigo == codigoVendedor)
            {
                vendedor = funcionario;
                break;
            }
        }

        // Verifica se o vendedor foi encontrado
        if (vendedor != null)
        {
            double valorVenda = precoPeca * quantidade;          // Calcula o valor total da venda
            double valorComissao = valorVenda * 0.05;            // Calcula o valor da comissão (5% do valor da venda)

            vendedor.AdicionaVenda(valorVenda);                  // Adiciona o valor da venda ao total de vendas do vendedor
            vendedor.AdicionaComissao(valorComissao);            // Adiciona o valor da comissão ao total de comissões do vendedor

            Console.WriteLine("Venda contabilizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Vendedor não encontrado!");
        }
    }
}