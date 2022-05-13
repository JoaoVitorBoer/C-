using System;
public class Retangulo : FiguraGeometrica
{
    
    public int Altura {get;set;}
    public int Largura {get;set;}


    public Retangulo(int x, int y, int altura, int largura, string id) : base(x,y,id)
    {
        
        if(altura <= 0)
        {
            //gerar uma exceção
            throw new Exception("Altura não pode ser <= 0");
        }
        if(largura <= 0)
        {
            throw new Exception("Altura não pode ser <= 0");

        }
        Altura = altura;
        Largura = largura;
    }

    public override string ToString()
    {
        return base.ToString() + $"[X={X}, Y={Y}, Altura={Altura}, Largura={Largura}]";
    }

    //public virtual int Area => Altura*Largura;
    public override int Area =>  Altura*Largura;
}