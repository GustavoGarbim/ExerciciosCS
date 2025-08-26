public enum TipoConta
{
    Corrente,
    Poupanca
}

class ContaBancaria
{
    // Campos (Atributos) Privados
    private static int s_proximoNumeroConta = 1001; // "s_" é uma convenção para campos estáticos

    // Propriedades (Acesso controlado aos dados)
    public int NumeroConta { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }
    public TipoConta Tipo { get; private set; }

    // Construtor
    public ContaBancaria(string titular, TipoConta tipo, double saldoInicial = 0)
    {
        // Atribui um número de conta único e o incrementa para a próxima conta
        NumeroConta = s_proximoNumeroConta;
        s_proximoNumeroConta++;

        Titular = titular;
        Tipo = tipo;
        Saldo = saldoInicial; // O saldo inicial é depositado aqui
    }

    // Métodos
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    // Este método agora retorna 'true' ou 'false' para indicar o sucesso da operação.
    // Isso é crucial para a lógica de transferência!
    public bool Sacar(double valor)
    {
        // Adicionamos uma taxa de R$5.00 para saques de conta corrente
        double taxaSaque = (this.Tipo == TipoConta.Corrente) ? 5.00 : 0;

        if (valor <= 0)
        {
            Console.WriteLine("O valor do saque deve ser positivo.");
            return false;
        }

        if ((Saldo - valor - taxaSaque) < 0)
        {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }

        Saldo -= (valor + taxaSaque);
        Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso (Taxa: R${taxaSaque:F2}).");
        return true;
    }

    // Sobrescrevendo ToString para uma exibição clara dos dados da conta
    public override string ToString()
    {
        return $"Conta: {NumeroConta} | Tipo: {Tipo} | Titular: {Titular} | Saldo: R${Saldo:F2}";
    }
}