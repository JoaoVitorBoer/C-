public class CirculoColorido : Circulo
{
    private string minhaCor;
    public string Cor
    {
        get => minhaCor;
        set => minhaCor = value;
    }

    public CirculoColorido()
    {
        minhaCor = "preto";
    }
    public CirculoColorido(double x, double y, double r, string cor) : base(x, y, r) 
    {
        minhaCor = cor;
    }

    public override string ToString()
    {
        return base.ToString() + " cor " + Cor;
    }

}

