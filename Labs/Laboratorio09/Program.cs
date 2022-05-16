static void TrataLimiteSuperior(string msg) 
{ 
    Console.WriteLine(msg); 
    }
static void TrataNormal(string msg)
{
    Console.WriteLine(msg);
}    

TermometroLimite term = new TermometroLimite(5); 
Console.WriteLine(term.ToString());

term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
term.TemperaturaNormal += new TermometroLimite.MeuDelegate(TrataNormal);

Console.WriteLine(term.ToString());
term.Aumentar(6); 

term.Diminuir(3);
Console.WriteLine(term.ToString());