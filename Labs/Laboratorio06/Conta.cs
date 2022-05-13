public abstract class Conta
{
    private decimal saldo; 
    private string titular;

    public Conta(string t){
        titular = t;
    }

    public decimal Saldo
    {
        get => saldo;
    }
    public string Titular
    {
        get => titular;
    }

    public abstract string Id{
        get;
    }

    public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    }
    public virtual void Sacar(decimal valor)
    {
        saldo -= valor;
    }

}