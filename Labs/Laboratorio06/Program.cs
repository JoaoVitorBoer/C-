ContaPoupanca c1 = new ContaPoupanca( 10M, new DateTime(2013, 6, 1, 12, 32, 30),"Joao");
c1.Depositar(50000);
ContaPoupanca c2 = new ContaPoupanca( 5M, new DateTime(2013, 6, 1, 12, 32, 30),"Paulo");
ContaPoupanca c3 = new ContaPoupanca( 7M, new DateTime(2013, 6, 1, 12, 32, 30),"Pedro");
ContaPoupanca c4 = new ContaPoupanca( 9M, new DateTime(2013, 6, 1, 12, 32, 30),"Julio");
ContaPoupanca c5 = new ContaPoupanca( 11M, new DateTime(2013, 6, 1, 12, 32, 30),"Jacinto");
ContaPoupanca c6 = new ContaPoupanca( 23M, new DateTime(2013, 6, 1, 12, 32, 30),"Jamelao");
ContaPoupanca c7 = new ContaPoupanca( 110M, new DateTime(2013, 6, 1, 12, 32, 30),"Juca");

List<ContaPoupanca> contas = new List<ContaPoupanca>();

contas.Add(c1);
contas.Add(c2);
contas.Add(c3);
contas.Add(c4);
contas.Add(c5);
contas.Add(c6);
contas.Add(c7);

foreach(var conta in contas)
{
    Console.WriteLine(conta.Titular);
    Console.WriteLine(conta.Juros);
    Console.WriteLine(conta.Saldo);
}