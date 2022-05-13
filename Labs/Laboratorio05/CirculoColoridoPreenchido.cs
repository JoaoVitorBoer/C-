public class CirculoColoridoPreenchido : CirculoColorido
{
    private string corPreenchimento;

    public CirculoColoridoPreenchido(double x, double y, double r, string cor, string corPreenchida) : base(x,y,r,cor)
    {
        corPreenchimento = corPreenchida;
    }

    public string CorPreenchimento{
        get => corPreenchimento;
    }

    public override string ToString()
    {
        return base.ToString() + " Preenchida " + CorPreenchimento;
    }
}