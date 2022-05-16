public enum EstadoBinarioZ { Recarregar, Atirar };

interface IEstadoBinarioZ
{
    void Recarregar();
    void Atirar();
    EstadoBinarioZ Estado { get; }
}

public class Gun : IEstadoBinarioZ
{
    private int muni;
    private bool recarregar;

    public void Atirar() { recarregar = false; } 
    public void Recarregar() { recarregar = true; }

    public Gun(int munic)
    {
        muni = munic;
        recarregar = false;
    }

    public EstadoBinarioZ Estado { 
         get {
              if (recarregar) return EstadoBinarioZ.Recarregar; 
              else return EstadoBinarioZ.Atirar; }
               } 
}