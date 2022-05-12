static void Alerta(object? sender, EventArgs e)
{
    Console.WriteLine("Atenção saldo negativo");
}


ContaCorrente minhaConta = new ContaCorrente(500, "Joao");

minhaConta.SaldoNegativo += Alerta;
minhaConta.Depositar(500);
minhaConta.Sacar(10000);


Console.WriteLine(minhaConta.DataCriacao);
Console.WriteLine(minhaConta.Nome);
Console.WriteLine(minhaConta.Saldo);

//minhaConta.SaldoMedio();


