Circulo circ1 = new Circulo(); 
Console.WriteLine(circ1); 

Circulo circ2 = new Circulo(2.4, 5, 3); 
Console.WriteLine(circ2); 

CirculoColorido circ3 = new CirculoColorido(); 
Console.WriteLine(circ3); 

CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho"); 
Console.WriteLine(circ4);

CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(1.5, 3.1, 1, "vermelho", "amarelo"); 
Console.WriteLine(circ5);

List<Circulo> lista = new List<Circulo>();
lista.Add(circ1);
lista.Add(circ2);
lista.Add(circ3);
lista.Add(circ4);
lista.Add(circ5);

Console.WriteLine("\nAgora printando no array: \n");
foreach(var circ in lista)
{
    Console.WriteLine(circ);
    Console.WriteLine(" ");
}