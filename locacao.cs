public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiario;

    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um cliente."
                );
            }

            _cliente = value;
        }
    }

    public Veiculo Veiculo
    {
        get
        {
            return _veiculo;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um veículo."
                );
            }

            _veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get
        {
            return _dataRetirada;
        }

        private set
        {
            _dataRetirada = value;
        }
    }

    public int QuantidadeDias
    {
        get
        {
            return _quantidadeDias;
        }

         set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "A quantidade de dias não pode ser menor que zero."
                );
            }

            _quantidadeDias = value;
        }
    }

    public decimal ValorDiario
    {
        get
        {
            return _valorDiario;
        }

        set
        {
            _valorDiario = value;
        }
    }

    public Locacao(
        Cliente cliente,
        Veiculo veiculo,
        DateOnly dataRetirada,
        int quantidadeDias,
        decimal valorDiario
    )
    {
        Cliente = cliente; // aqui caracteriza a associaçção
        Veiculo = veiculo; // aqui caracteriza a associaçção
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiario = valorDiario;
    }

public decimal CalcularValorBruto()
{
   return QuantidadeDias * ValorDiario;
}

public decimal CalcularDesconto()
{
    if (QuantidadeDias >= 7)
    {
        return CalcularValorBruto() * 0.10m; 
    }
    
    else
    {
        return 0;
    }
}

public decimal CalcularValorFinal()
{
    return CalcularValorBruto() - CalcularDesconto();
}

public void ExibirResumo()
{
    Console.WriteLine("===== LOCAÇÃO =====");

    Console.WriteLine($"Cliente: {Cliente.Nome}");
    Console.WriteLine($"CPF: {Cliente.Cpf}");

    Console.WriteLine($"Veículo: {Veiculo.Modelo}");
    Console.WriteLine($"Placa: {Veiculo.Placa}");

    Console.WriteLine(
        $"Data da locação: {DataRetirada:dd/MM/yyyy}"
    );

    Console.WriteLine(
        $"Dias de locação: {QuantidadeDias}"
    );

    Console.WriteLine(
        $"Diária: R$ {ValorDiario:F2}"
    );

    Console.WriteLine(
        $"Valor Total: R$ {CalcularValorBruto():F2}"
    );

    Console.WriteLine(
        $"Desconto: R$ {CalcularDesconto():F2}"
    );

    Console.WriteLine(
        $"Valor final: R$ {CalcularValorFinal():F2}"
    );
}
}