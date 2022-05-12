public class Produto 
{
    public string Id{get;set;}
    public string Descricao {get;set;}
    public decimal  ValorUnitario {get;set;}

    public Produto(string umID, string umaDescricao, decimal umValorUnitario)
    {
        Id = umID;
        Descricao = umaDescricao;
        ValorUnitario = umValorUnitario;
    }        
}