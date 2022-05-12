public class Bomba
{
    public bool Explodiu {get; private set;}
    private int tics;
    public int TempoLimite {get;init;}

    //Evento
    public event EventHandler FezBum;

    public Bomba(int tempoLimite)
    {
        TempoLimite = tempoLimite;
    }

    public void Tic()
    {
        tics++;
        if (tics > TempoLimite && !Explodiu)
        {
            Explodiu = true;
            //Disparar envento
            if (FezBum != null) //Verifica se alguem esta interessado em receber o evento
            {                      // Nesse caso seria o OuvirExplosao
                FezBum(this,EventArgs.Empty);       //this, referencia para mim mesmo.
            }
        }
    }
}