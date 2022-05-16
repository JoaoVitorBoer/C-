public class TermometroLimite : Termometro
{
    private double limiteSuperior;
    private bool disparadoEventoLimiteSuperior;
    public TermometroLimite(double ls)
    {
        limiteSuperior = ls;
        disparadoEventoLimiteSuperior = false;
    }
    public double LimiteSuperior
    {
        get { return limiteSuperior; }
        set { limiteSuperior = value; }
    }
    public delegate void MeuDelegate(string msg);
    public event MeuDelegate LimiteSuperiorEvent;

    private void OnLimiteSuperiorEvent()
    {
        if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
            if (LimiteSuperiorEvent != null)
            {
                LimiteSuperiorEvent("Atenção: temperatura acima do limite!!! Temperatura atual é de " + this.Temperatura);
                disparadoEventoLimiteSuperior = true;
            }
    }
    public event MeuDelegate TemperaturaNormal;

    private void NormalTempEvent()
    {
            if ((this.Temperatura < limiteSuperior) && (!disparadoEventoLimiteSuperior)){
                if( TemperaturaNormal != null)
                {
                    TemperaturaNormal("Atenção: temperatura está normal novamente!!! Temperatura atual é de " + this.Temperatura);
                }
            }
    }
    
    public override void Aumentar()
    {
        base.Aumentar();
        OnLimiteSuperiorEvent();
    }
    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        OnLimiteSuperiorEvent();
    }

    public override void Diminuir()
    {
        base.Diminuir();
        if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            disparadoEventoLimiteSuperior = false;
            NormalTempEvent();
        }
    }
    public override void Diminuir(double quantia)
    {
        base.Diminuir(quantia);
        if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            disparadoEventoLimiteSuperior = false;
            NormalTempEvent();
        }
    }
}
