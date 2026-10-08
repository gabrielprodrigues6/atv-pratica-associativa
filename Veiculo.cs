public class Veiculo
{
    private string _modelo;
    private string _placa;

    public string Modelo
    {
        get
        {
            return _modelo;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O modelo do veículo não pode ficar vazio."
                );
            }

            _modelo = value.Trim();
        }
    }

    public string Placa
    {
        get
        {
            return _placa;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa do veículo não pode ficar vazia."
                );
            }

            _placa = value.Trim();
        }
    }

    public Veiculo (string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Placa: {Placa}");
    }
}