public class ContaPoupanca : Conta
{
    private decimal taxaJuros;
    private DateTime dataAniversario;

    public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
    {
        taxaJuros = j;
        dataAniversario = d;
    }

    public decimal Juros{
        get => taxaJuros;
        set => taxaJuros = value;
    }
    public DateTime DataAniversario{
        get => dataAniversario;
        
    }

    public void AdicionarRendimento()
    {
        DateTime hoje = DateTime.Now;
        if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
        {
        decimal rendimento = this.Saldo * taxaJuros;
        this.Depositar(rendimento);
        }
    }

    public override string Id
    {
        get => this.Titular + "(CP)";
    }

    
}