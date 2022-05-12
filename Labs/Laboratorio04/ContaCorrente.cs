class ContaCorrente{
    private decimal saldo;
    private decimal cont;
    private decimal somaSaldo;
    public DateTime DataCriacao {get; private set;}
    private string nomeTitular;

    public event EventHandler SaldoNegativo;

      public ContaCorrente(decimal val, string nome){
        saldo = val;
        nomeTitular = nome;
        GerarData();

        somaSaldo = saldo;
    }

    private void GerarData(){
       DataCriacao = DateTime.Now;
    }

    public void SaldoMedio(){
        var saldoMedio = somaSaldo / cont;  
        Console.WriteLine($"O saldo médio atual da conta é de R$ {saldoMedio}");

    }

    public string Nome {
        get => nomeTitular;
    }

    public void Depositar(decimal val)
    {
        saldo += val;
        somaSaldo += val;
        cont++;

    }
    public void Sacar(decimal val){
        saldo -= val;
        somaSaldo -= val;
        cont++;

        if(saldo < 0){
            if(SaldoNegativo != null){
                SaldoNegativo(this,EventArgs.Empty);
            }
        }

    }
    
    public decimal Saldo {
        get => saldo;
    }

  


}