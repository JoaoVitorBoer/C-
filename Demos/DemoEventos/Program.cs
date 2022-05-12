static void OuvirExplosao(object? sender, EventArgs e)
{
    Console.WriteLine("A bomba fez BUMMMM!");
}


Bomba b = new Bomba(3);
b.FezBum += OuvirExplosao;  //Registra no evento o método que ele vai executar
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic();  //Explodiu!
Console.WriteLine("tic");
