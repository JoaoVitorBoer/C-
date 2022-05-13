Retangulo r1 = new Retangulo(2,5,10,23,"r1");
Retangulo r2 = new Retangulo(2,5,10,23,"r2");

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(r1.Equals(r2)); //São diferentes fois estão em uma posição de memória diferente.
Console.WriteLine(r1.Area);

Quadrado q1 = new Quadrado(1,1,5,"q1");
Console.WriteLine(q1);
Console.WriteLine(q1.Area);



FiguraGeometrica f1 = r1;


List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();
figuras.Add(new Retangulo(0,0,2,3,"ret1"));
figuras.Add(new Retangulo(1,1,1,1,"ret2"));
figuras.Add(new Quadrado(0,1,2,"qua1"));

figuras.Sort();
Console.WriteLine("Lista Ordenada:");
foreach(var figura in figuras)
{
    Console.WriteLine(figura);
}
figuras.Sort(new FiguraGeometrica.ComparadorPorPontoCartesioano());
Console.WriteLine("Lista Ordenada:");
foreach(var figura in figuras)
{
    Console.WriteLine(figura);
}
Console.WriteLine("Lista Ordenada:");
figuras.Sort((fig1,fig2) => {
    if(fig1 == null)
    {
        if(fig2 = null)
        {
            return 0;
        }
        return -1;
    }
    else
    {
        if(fig2 == null)
        {
            return 1;
        }
        return fig1.Id.CompareTo(fig2.Id);
    }
});

Console.WriteLine("Lista Ordenada:");
foreach(var figura in figuras)
{
    Console.WriteLine(figura);
}





