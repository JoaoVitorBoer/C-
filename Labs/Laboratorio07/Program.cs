    IEstadoBinario[] lista = new IEstadoBinario[2];
    lista[0] = new Lampada(110, 60);
    lista[0].Ligar();
    lista[1] = new TermometroEletrico();
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(lista[i].Estado);
    }

IEstadoBinarioZ[] lista2 = new IEstadoBinarioZ[3];
lista2[0] = new Gun(110);
lista2[0].Atirar();
lista2[1] = new Gun(50);
lista2[1].Recarregar();
lista2[2] = new Gun(10);
lista2[2].Recarregar();

for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(lista2[i].Estado);
    }

